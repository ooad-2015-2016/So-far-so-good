﻿#pragma checksum "C:\Users\HP\Desktop\GIT\NovaMapa\ProjekatJobRadar\JobRadar\JobRadarBaza\Views\PocetnaRegistracija.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3E42F0D09F48AB0F070B9F65DC1649F8"
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
    partial class PocetnaRegistracija : 
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
                    this.image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.btnRegistracijaKorisnika = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\..\JobRadarBaza\Views\PocetnaRegistracija.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRegistracijaKorisnika).Click += this.btnRegistracijaKorisnika_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnRegistracijaKompanije = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\..\JobRadarBaza\Views\PocetnaRegistracija.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRegistracijaKompanije).Click += this.btnRegistracijaKompanije_Click;
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

