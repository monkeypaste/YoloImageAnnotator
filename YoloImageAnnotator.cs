﻿using Compunet.YoloSharp;
using MonkeyPaste.Common.Plugin;
using SixLabors.ImageSharp;
using System.Runtime.InteropServices;

namespace YoloImageAnnotator {
    public class YoloImageAnnotator : MpIAnalyzeComponentAsync {

        private YoloPredictor _scorer = null;

        const string PARAM_ID_CONFIDENCE = "conf";
        const string PARAM_ID_CONTENT = "img64";

        public async Task<MpAnalyzerPluginResponseFormat> AnalyzeAsync(MpAnalyzerPluginRequestFormat req) {
            Resources.Culture = new System.Globalization.CultureInfo(req.culture);

            double confidence = req.GetParamValue<double>(PARAM_ID_CONFIDENCE);
            string imgBase64 = req.GetParamValue<string>(PARAM_ID_CONTENT);

            try {
                if(_scorer == null) {
                    _scorer = new YoloPredictor(Path.Combine(Path.GetDirectoryName(typeof(YoloImageAnnotator).Assembly.Location), "yolov8n.onnx"));
                }

                var bytes = Convert.FromBase64String(imgBase64);
                using(var ms = new MemoryStream(bytes)) {
                    using(var img = await Image.LoadAsync(ms)) {
                        var result = await _scorer.DetectAsync(img);
                        // filter and convert predictions to annotations
                        var rootNode = new MpAnnotationNodeFormat() {
                            label = Resources.AnnLabel,
                            children = result
                                .Where(x => x.Confidence >= confidence)
                                .Select(x => new MpImageAnnotationNodeFormat() {
                                    score = x.Confidence,
                                    type = "Object",
                                    label = x.Name.Name,
                                    left = x.Bounds.X,
                                    top = x.Bounds.Y,
                                    right = x.Bounds.X + x.Bounds.Width,
                                    bottom = x.Bounds.Y + x.Bounds.Height
                                }).Cast<MpAnnotationNodeFormat>().ToList()
                        };
                        rootNode.body = string.Format(Resources.BodyText, rootNode.children.Count);

                        return new MpAnalyzerPluginResponseFormat() {
                            dataObjectLookup = new Dictionary<string, object> {
                                { MpPortableDataFormats.INTERNAL_CONTENT_ANNOTATION_FORMAT, rootNode.SerializeObject(true) }
                            }
                        };
                    }

                }
            }
            catch(Exception ex) {
                return new MpAnalyzerPluginResponseFormat() {
                    errorMessage = string.Format(
                        Resources.ExText,
                        RuntimeInformation.ProcessArchitecture == Architecture.Arm ?
                            "https://aka.ms/vs/17/release/vc_redist.arm64.exe" :
                            Environment.Is64BitProcess ?
                                "https://aka.ms/vs/17/release/vc_redist.x64.exe" :
                                "https://aka.ms/vs/17/release/vc_redist.x86.exe",
                        "https://www.github.com/monkeypaste/ImageAnnotator",
                        ex.Message)
                };
            }
        }
    }
}
