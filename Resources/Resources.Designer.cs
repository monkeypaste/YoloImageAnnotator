﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YoloImageAnnotator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("YoloImageAnnotator.Resources.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image Annotations.
        /// </summary>
        public static string AnnLabel {
            get {
                return ResourceManager.GetString("AnnLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} objects detected.
        /// </summary>
        public static string BodyText {
            get {
                return ResourceManager.GetString("BodyText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value between 0 and 1 to filter detected accuracy.
        /// </summary>
        public static string ConfDescription {
            get {
                return ResourceManager.GetString("ConfDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confidence.
        /// </summary>
        public static string ConfLabel {
            get {
                return ResourceManager.GetString("ConfLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A totally free, local and lightweight object detector trained on 80 different types of objects..
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error. Please make sure your OS is up to date. For Windows users you may also need to install &lt;a href=&quot;{0}&quot;&gt;this&lt;/a&gt; (Visual C++ Redistributable Package). 
        ///
        ///See the &lt;a href=&quot;{1}&quot;&gt;ImageAnnotator github repo&lt;/a&gt; for more info or to report the issue.
        ///
        ///Error:
        ///{2}.
        /// </summary>
        public static string ExText {
            get {
                return ResourceManager.GetString("ExText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image Detection, Annotation, Image, AI, Text.
        /// </summary>
        public static string Tags {
            get {
                return ResourceManager.GetString("Tags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yolo Image Annotator.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}