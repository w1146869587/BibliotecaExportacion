﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExportLibrary {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
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
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExportLibrary.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
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
        ///   Busca una cadena traducida similar a The collection is empty.
        /// </summary>
        internal static string DataEmpty {
            get {
                return ResourceManager.GetString("DataEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Column.
        /// </summary>
        internal static string DefaultColumnName {
            get {
                return ResourceManager.GetString("DefaultColumnName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Sheet 1.
        /// </summary>
        internal static string DefaultSheetName {
            get {
                return ResourceManager.GetString("DefaultSheetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Object.
        /// </summary>
        internal static string DefaultTypeText {
            get {
                return ResourceManager.GetString("DefaultTypeText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Byte[].
        /// </summary>
        internal static byte[] DocumentFormat_OpenXml {
            get {
                object obj = ResourceManager.GetObject("DocumentFormat_OpenXml", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Impossible export, details: .
        /// </summary>
        internal static string ExceptionText {
            get {
                return ResourceManager.GetString("ExceptionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Byte[].
        /// </summary>
        internal static byte[] itextsharp {
            get {
                object obj = ResourceManager.GetObject("itextsharp", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a NULL.
        /// </summary>
        internal static string NullObject {
            get {
                return ResourceManager.GetString("NullObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Path is empty.
        /// </summary>
        internal static string PathEmpty {
            get {
                return ResourceManager.GetString("PathEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Byte[].
        /// </summary>
        internal static byte[] System_IO_Packaging {
            get {
                object obj = ResourceManager.GetObject("System_IO_Packaging", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Byte[].
        /// </summary>
        internal static byte[] WindowsBase {
            get {
                object obj = ResourceManager.GetObject("WindowsBase", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}