﻿#pragma checksum "C:\Users\SENAD\Desktop\Final\ProjekatJobRadar\JobRadar\JobRadarBaza\Views\RegistracijaForma3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "24318B86738679B8C2119284B1C14885"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobRadar
{
    partial class Registracija3Forma : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnCamera = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 2:
                {
                    this.btnFinish = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 55 "..\..\..\..\JobRadarBaza\Views\RegistracijaForma3.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnFinish).Click += this.btnFinish_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

