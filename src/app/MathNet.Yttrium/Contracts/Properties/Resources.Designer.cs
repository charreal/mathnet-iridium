﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathNet.Symbolics.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MathNet.Symbolics.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation &apos;{0}&apos; does not support circular systems, that is systems with signals depending upon themselves..
        /// </summary>
        internal static string ex_CyclicSignalsNotSupportes {
            get {
                return ResourceManager.GetString("ex_CyclicSignalsNotSupportes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deserialize the entity {0}.{1}: entity is generic but no extension is attached..
        /// </summary>
        internal static string ex_Deserialize_Failed_GenericEntity {
            get {
                return ResourceManager.GetString("ex_Deserialize_Failed_GenericEntity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deserialize an item, due to an invalid data file or a usage error. Expected &apos;{0}&apos; but got &apos;{1}&apos; instead. Check the data file for errors and report to the developer..
        /// </summary>
        internal static string ex_Deserialize_Failed_UnexpectedPosition {
            get {
                return ResourceManager.GetString("ex_Deserialize_Failed_UnexpectedPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No proper category deserialization method found..
        /// </summary>
        internal static string ex_Deserialize_Failed_UnsupportedCategory {
            get {
                return ResourceManager.GetString("ex_Deserialize_Failed_UnsupportedCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No proper structure deserialization method found..
        /// </summary>
        internal static string ex_Deserialize_Failed_UnsupportedStructure {
            get {
                return ResourceManager.GetString("ex_Deserialize_Failed_UnsupportedStructure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation expected {0} but got {1} instead. Maybe an extension module is not loaded yet, there is a typo, or the module is faulty..
        /// </summary>
        internal static string ex_Entity_Unexpected_SignalCount {
            get {
                return ResourceManager.GetString("ex_Entity_Unexpected_SignalCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Math.NET Architecture matching the requirements (including supporting the entity &apos;{0}&apos;) was found. Maybe an extension module is not loaded yet, or the input signals are not qualified enough..
        /// </summary>
        internal static string ex_NotAvailable_Architecture {
            get {
                return ResourceManager.GetString("ex_NotAvailable_Architecture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The currently loaded context library does not list the demanded domain &apos;{0}&apos;. Maybe an extension module is not loaded yet, there is a typo, or the module is faulty..
        /// </summary>
        internal static string ex_NotAvailable_Domain {
            get {
                return ResourceManager.GetString("ex_NotAvailable_Domain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The currently loaded context library does not list the demanded entity &apos;{0}&apos;. Maybe an extension module is not loaded yet, there is a typo, or the module is faulty..
        /// </summary>
        internal static string ex_NotAvailable_Entity {
            get {
                return ResourceManager.GetString("ex_NotAvailable_Entity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search for a specific item has returned no result..
        /// </summary>
        internal static string ex_NotFound {
            get {
                return ResourceManager.GetString("ex_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A requested feature is not yet implemented..
        /// </summary>
        internal static string ex_NotImplementedYet {
            get {
                return ResourceManager.GetString("ex_NotImplementedYet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing failed. Token Mismatch. Expected &apos;{0}&apos; but got &apos;{1}&apos; around &apos;{2}&apos;..
        /// </summary>
        internal static string ex_Parsing_Failed_TokenMismatch {
            get {
                return ResourceManager.GetString("ex_Parsing_Failed_TokenMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing failed. Token Mismatch. Expected &apos;{0} [{3}]&apos; but got &apos;{1}&apos; around &apos;{2}&apos;..
        /// </summary>
        internal static string ex_Parsing_Failed_TokenMismatchEx {
            get {
                return ResourceManager.GetString("ex_Parsing_Failed_TokenMismatchEx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A theorem was used on a wrong item or a matching theorem was not found. This probably is a programming error, please report to the manufacturer..
        /// </summary>
        internal static string ex_Theorem_Mismatch {
            get {
                return ResourceManager.GetString("ex_Theorem_Mismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A mutual exclusive system traversing strategy is already in use and may not be executed again before the other finishes its operation..
        /// </summary>
        internal static string ex_Traversing_Failed_ReserveMutex {
            get {
                return ResourceManager.GetString("ex_Traversing_Failed_ReserveMutex", resourceCulture);
            }
        }
    }
}