﻿#pragma checksum "C:\Git\Repos\FranceVacancesFinalProject\FranceVacancesFinalProject\FranceVacancesFinalProject\View\CityPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DBC1E566F3023932656B916FE0B2819D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FranceVacancesFinalProject.View
{
    partial class CityPage : 
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
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 2:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.bookButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 65 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bookButton).Click += this.bookButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.homeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.homeButton).Click += this.homeButton_Click_1;
                    #line default
                }
                break;
            case 8:
                {
                    this.loginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.loginButton).Click += this.loginButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.Logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 11:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.backButton_Click;
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

