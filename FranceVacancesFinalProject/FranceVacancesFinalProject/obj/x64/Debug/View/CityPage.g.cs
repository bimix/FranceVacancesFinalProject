﻿#pragma checksum "C:\Git\Repos\FranceVacancesFinalProject\FranceVacancesFinalProject\FranceVacancesFinalProject\View\CityPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D02A90E5815B1F716A74255C5BBE99CF"
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
                    this.image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.bookButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 62 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.bookButton).Click += this.bookButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5:
                {
                    this.listView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 74 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.listView).SelectionChanged += this.listView_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.textBlock4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.textBlock5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.textBlock7 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.image2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10:
                {
                    this.homeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.homeButton).Click += this.homeButton_Click_1;
                    #line default
                }
                break;
            case 11:
                {
                    this.loginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\View\CityPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.loginButton).Click += this.loginButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 52 "..\..\..\View\CityPage.xaml"
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

