﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bucavent.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ControlText")]
        public global::System.Drawing.Color colorLetra {
            get {
                return ((global::System.Drawing.Color)(this["colorLetra"]));
            }
            set {
                this["colorLetra"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LemonChiffon")]
        public global::System.Drawing.Color colorFondo {
            get {
                return ((global::System.Drawing.Color)(this["colorFondo"]));
            }
            set {
                this["colorFondo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lucida Calligraphy, 9.75pt")]
        public global::System.Drawing.Font tipoLetra {
            get {
                return ((global::System.Drawing.Font)(this["tipoLetra"]));
            }
            set {
                this["tipoLetra"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("nadie")]
        public string identificacion {
            get {
                return ((string)(this["identificacion"]));
            }
            set {
                this["identificacion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool actualizarLetra {
            get {
                return ((bool)(this["actualizarLetra"]));
            }
            set {
                this["actualizarLetra"] = value;
            }
        }
    }
}
