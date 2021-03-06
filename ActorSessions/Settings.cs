﻿using System;

using System.Configuration;
using System.Diagnostics;

namespace Sessions
{

    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute ()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute ("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized (new Settings ())));

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute ()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute ()]
        [global::System.Configuration.DefaultSettingValueAttribute ("127.0.0.1")]
        public string ServerAddress {
            get {
                return ((string)(this ["ServerAddress"]));
            }
        }
       
        [global::System.Configuration.ApplicationScopedSettingAttribute ()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute ()]
        [global::System.Configuration.DefaultSettingValueAttribute ("50")]
        public string Sessions {
            get {
                return ((string)(this ["Sessions"]));
            }
        }
       
    }
}

