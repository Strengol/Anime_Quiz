﻿#pragma checksum "C:\Users\strengol\Documents\Visual Studio 2015\Projects\Animu\Animu\View\DeviceFamily-Desktop\EndGame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "52D79FE3DE8DCAB90995B51CA34AE849"
#pragma checksum "C:\Users\strengol\Documents\Visual Studio 2015\Projects\Animu\Animu\View\DeviceFamily-Mobile\EndGame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "40D6CE1A98DBF8E8C6AA6A0C89536ADB"
#pragma checksum "C:\Users\strengol\Documents\Visual Studio 2015\Projects\Animu\Animu\View\EndGame.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12F0786C4A92F619252886AB8FF22094"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Animu.View
{
    partial class EndGame : 
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
                    this.VisualState500 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 2:
                {
                    this.VisualState0 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.TranslateX = (global::Windows.UI.Xaml.Media.CompositeTransform)(target);
                }
                break;
            case 4:
                {
                    this.Burgerek = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 5:
                {
                    this.wynik = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.zagrajPonownie = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 87 "..\..\..\..\View\DeviceFamily-Desktop\EndGame.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.zagrajPonownie).Click += this.zagrajPonownie_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.show = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 50 "..\..\..\..\View\DeviceFamily-Desktop\EndGame.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.show).Click += this.showpanel;
                    #line default
                }
                break;
            case 8:
                {
                    this.Ranking = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
                {
                    this.Glowna = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 10:
                {
                    this.wynik = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.zagrajPonownie = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\..\View\DeviceFamily-Mobile\EndGame.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.zagrajPonownie).Click += this.zagrajPonownie_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.wynik = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.zagrajPonownie = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\View\EndGame.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.zagrajPonownie).Click += this.zagrajPonownie_Click;
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

