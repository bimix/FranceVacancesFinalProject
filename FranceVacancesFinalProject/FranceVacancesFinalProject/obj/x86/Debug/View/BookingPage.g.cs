﻿#pragma checksum "C:\Users\admin-nova\Desktop\DK SKóli\1st semester\France Vacances\FranceVacancesFinalProject\FranceVacancesFinalProject\View\BookingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4908C690F556A28051028FCE9F06AA3A"
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
    partial class BookingPage : 
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
                    this.startDatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 2:
                {
                    this.endDatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 3:
                {
                    this.checkAvailabilityButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 4:
                {
                    this.priceInfoTextblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.commentTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.payButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 58 "..\..\..\View\BookingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.payButton).Click += this.payButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.cancelPaymentButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 68 "..\..\..\View\BookingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cancelPaymentButton).Click += this.cancelPaymentButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.homeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\View\BookingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.homeButton).Click += this.homeButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.loginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\View\BookingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.loginButton).Click += this.loginButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.Logo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13:
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\View\BookingPage.xaml"
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

