﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_BLL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<SerializableConnectionString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <ConnectionString>Data Source=DESKTOP-EKGAA51;Initial Catalog=QUANLYRAPCHIEUPHIM;Persist Security Info=True;User ID=sa;Password=123</ConnectionString>
  <ProviderName>System.Data.SqlClient</ProviderName>
</SerializableConnectionString>")]
        public string QUANLYRAPCHIEUPHIMConnectionString {
            get {
                return ((string)(this["QUANLYRAPCHIEUPHIMConnectionString"]));
            }
            set {
                this["QUANLYRAPCHIEUPHIMConnectionString"] = value;
            }
        }
    }
}
