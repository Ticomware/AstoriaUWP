﻿#pragma checksum "D:\Documents\Visual Studio 2015\Projects\DalvikUWPCSharp\DalvikUWPCSharp\EmuPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A846B5DA88D231875149FB2CEA15AF7F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DalvikUWPCSharp
{
    partial class EmuPage : 
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
                    this.RenderTargetGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.PreSplashGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.NavBarBackgroundGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.NavBarGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 128 "..\..\..\EmuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.GoHome;
                    #line default
                }
                break;
            case 6:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 131 "..\..\..\EmuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.GoBack;
                    #line default
                }
                break;
            case 7:
                {
                    this.button2_Copy = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 134 "..\..\..\EmuPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2_Copy).Click += this.GoHome;
                    #line default
                }
                break;
            case 8:
                {
                    this.appImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9:
                {
                    this.statusTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.progRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
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
