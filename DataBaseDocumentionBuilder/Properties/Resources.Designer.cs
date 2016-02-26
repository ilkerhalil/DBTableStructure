﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseDocumentionBuilder.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DataBaseDocumentionBuilder.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SELECT							T.name														AS [TableName],
        ///	                            C.name														AS [ColumnName],
        ///	                            TYPE_NAME(C.system_type_id)									AS [ColumnType],
        ///	                            C.max_length												AS [ColumnLength],
        ///	                            C.is_nullable												AS [IsNullable], 
        ///	                            C.is_identity												AS [IsIdentity], 
        ///	                            C.is_computed												AS [IsComputed], 
        ///	                    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetTableQuery {
            get {
                return ResourceManager.GetString("GetTableQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select t.name as TableName from sys.tables t order by t.name.
        /// </summary>
        internal static string TableListQuery {
            get {
                return ResourceManager.GetString("TableListQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;xsl:stylesheet version=&quot;2.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        ///                xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;&gt;
        ///    &lt;xsl:template match=&quot;DocumentElement&quot;&gt;
        ///        &lt;html xmlns:mshelp=&quot;http://msdn.microsoft.com/mshelp&quot;&gt;
        ///        &lt;head&gt;     
        ///            &lt;title&gt;Database&lt;/title&gt;
        ///              &lt;link rel=&quot;stylesheet&quot; href=&quot;Content/bootstrap.min.css&quot;&gt;&lt;/link&gt;
        ///  &lt;script src=&quot;Scripts/jquery-1.9.1.min.js&quot;&gt;&lt;/scrip [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string template {
            get {
                return ResourceManager.GetString("template", resourceCulture);
            }
        }
    }
}
