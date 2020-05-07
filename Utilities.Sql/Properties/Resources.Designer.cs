﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Utilities.Sql.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Utilities.Sql.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The SqlConnection parameter &apos;{0}&apos; is not open..
        /// </summary>
        internal static string Assert_IsOpen {
            get {
                return ResourceManager.GetString("Assert_IsOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database &apos;{0}&apos; not found..
        /// </summary>
        internal static string DatabaseNotFound {
            get {
                return ResourceManager.GetString("DatabaseNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IdentifierHelper.Init() method must be called before this method is called for the first time..
        /// </summary>
        internal static string IdentiferHelperInitNotCalled {
            get {
                return ResourceManager.GetString("IdentiferHelperInitNotCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;name&apos; parameter has an invalid form (&apos;{0}&apos;).  Only one-part ([object name]) or two-part ([schema name].[object name]) T-SQL identifiers are allowed as a stored procedure name..
        /// </summary>
        internal static string InvalidStoredProcedureName {
            get {
                return ResourceManager.GetString("InvalidStoredProcedureName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;name&apos; is a multipart name (&apos;{0}&apos;).  Only one-part stored procedure names are allowed when adding a stored procedure to a schema..
        /// </summary>
        internal static string InvalidStoredProcedureNameForSchema {
            get {
                return ResourceManager.GetString("InvalidStoredProcedureNameForSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; not found in list..
        /// </summary>
        internal static string ItemNotFound {
            get {
                return ResourceManager.GetString("ItemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created new item for &apos;{0}&apos;..
        /// </summary>
        internal static string Make_CreatedNewItem {
            get {
                return ResourceManager.GetString("Make_CreatedNewItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executed &apos;{0}&apos;..
        /// </summary>
        internal static string Make_Executed {
            get {
                return ResourceManager.GetString("Make_Executed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No items exist yet for pathname &apos;{0}&apos;.  Empty item data structure created in memory..
        /// </summary>
        internal static string Make_ItemsDoNotExist {
            get {
                return ResourceManager.GetString("Make_ItemsDoNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Items loaded from &apos;{0}&apos;..
        /// </summary>
        internal static string Make_ItemsLoaded {
            get {
                return ResourceManager.GetString("Make_ItemsLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Items saved to &apos;{0}&apos;..
        /// </summary>
        internal static string Make_ItemsSaved {
            get {
                return ResourceManager.GetString("Make_ItemsSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pathname &apos;{0}&apos; not found in items..
        /// </summary>
        internal static string Make_PathnameNotFound {
            get {
                return ResourceManager.GetString("Make_PathnameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source file does not exist for database object [{0}].[{1}] (object type &apos;{2}&apos;)..
        /// </summary>
        internal static string Make_SourceFileDoesNotExist {
            get {
                return ResourceManager.GetString("Make_SourceFileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully compiled &apos;{0}&apos;..
        /// </summary>
        internal static string Make_SuccessfullyCompiled {
            get {
                return ResourceManager.GetString("Make_SuccessfullyCompiled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a one-, or two-part T-SQL identifier..
        /// </summary>
        internal static string Make_UnknownFilenameFormat {
            get {
                return ResourceManager.GetString("Make_UnknownFilenameFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown type: &apos;{0}&apos;..
        /// </summary>
        internal static string Make_UnknownType {
            get {
                return ResourceManager.GetString("Make_UnknownType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Does not need to be compiled: &apos;{0}&apos;.
        /// </summary>
        internal static string Make_UpdatedExistingItem_DoesNotNeedToBeCompiled {
            get {
                return ResourceManager.GetString("Make_UpdatedExistingItem_DoesNotNeedToBeCompiled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Needs to be compiled: &apos;{0}&apos;.
        /// </summary>
        internal static string Make_UpdatedExistingItem_NeedsToBeCompiled {
            get {
                return ResourceManager.GetString("Make_UpdatedExistingItem_NeedsToBeCompiled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updated item for file &apos;{0}&apos;..
        /// </summary>
        internal static string Make_UpdatedItemForFile {
            get {
                return ResourceManager.GetString("Make_UpdatedItemForFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot cast DBNull.Value to type &apos;{0}&apos;. Please use a nullable type.  Column name = &apos;{1}&apos;, column index = {2}..
        /// </summary>
        internal static string NonNullableCast {
            get {
                return ResourceManager.GetString("NonNullableCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no stored procedure name in &apos;{0}&apos;..
        /// </summary>
        internal static string NoStoredProcedureName {
            get {
                return ResourceManager.GetString("NoStoredProcedureName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; schema does not exist..
        /// </summary>
        internal static string SchemaNameNotFound {
            get {
                return ResourceManager.GetString("SchemaNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stored procedure &apos;{0}&apos;, version {1} already exists.  If you have a stored procedure that has multiple versions, make sure the version numbers don&apos;t conflict..
        /// </summary>
        internal static string StoredProcedureAlreadyExists {
            get {
                return ResourceManager.GetString("StoredProcedureAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t know how to handle the enumerated value TargetLanguage.{0}..
        /// </summary>
        internal static string UnknownTargetLanguageValue {
            get {
                return ResourceManager.GetString("UnknownTargetLanguageValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t know how to handle XmlSystem.{0}..
        /// </summary>
        internal static string UnknownXmlSystemValue {
            get {
                return ResourceManager.GetString("UnknownXmlSystemValue", resourceCulture);
            }
        }
    }
}