﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLQueryStress.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SQLQueryStress.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SqlQueryStress.
        /// </summary>
        internal static string AppTitle {
            get {
                return ResourceManager.GetString("AppTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQLQueryStress Configuration Files|*.json.
        /// </summary>
        internal static string ConfigFiles {
            get {
                return ResourceManager.GetString("ConfigFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Failed.
        /// </summary>
        internal static string ConnFail {
            get {
                return ResourceManager.GetString("ConnFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Succeeded.
        /// </summary>
        internal static string ConnSucc {
            get {
                return ResourceManager.GetString("ConnSucc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Csv Files (*.csv)|*.csv.
        /// </summary>
        internal static string CsvFiles {
            get {
                return ResourceManager.GetString("CsvFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press Enter to continue.
        /// </summary>
        internal static string EnterToContinue {
            get {
                return ResourceManager.GetString("EnterToContinue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error loading settings..
        /// </summary>
        internal static string ErrLoadingSettings {
            get {
                return ResourceManager.GetString("ErrLoadingSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error saving settings..
        /// </summary>
        internal static string ErrorSavingSettings {
            get {
                return ResourceManager.GetString("ErrorSavingSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exceptions.
        /// </summary>
        internal static string Exceptions {
            get {
                return ResourceManager.GetString("Exceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must set valid database connection information. Click the Database button to configure the settings..
        /// </summary>
        internal static string MustSetValidDatabaseConn {
            get {
                return ResourceManager.GetString("MustSetValidDatabaseConn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must set valid database connection information. Click the Database button to configure the settings..
        /// </summary>
        internal static string MustSetValidDbConnInfo {
            get {
                return ResourceManager.GetString("MustSetValidDbConnInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No variables were identified in the main query. Variables must be used there before parameter substitution can be used..
        /// </summary>
        internal static string NoVarsWereIdentified {
            get {
                return ResourceManager.GetString("NoVarsWereIdentified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon QueryStressIcon {
            get {
                object obj = ResourceManager.GetObject("QueryStressIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text Files (*.txt)|*.txt.
        /// </summary>
        internal static string TextFiles {
            get {
                return ResourceManager.GetString("TextFiles", resourceCulture);
            }
        }
    }
}
