﻿#pragma checksum "..\..\AuthenticateWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C0250F754DD2CE24E318DEF6B5B73467"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfContacts;


namespace WpfContacts {
    
    
    /// <summary>
    /// AuthenticateWindow
    /// </summary>
    public partial class AuthenticateWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_verificationRequired;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_phoneNumber;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_submitPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_codeSent;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_code;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_submitCode;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AuthenticateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_smsError;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfContacts;component/authenticatewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthenticateWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\AuthenticateWindow.xaml"
            ((WpfContacts.AuthenticateWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBlock_verificationRequired = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.textBox_phoneNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\AuthenticateWindow.xaml"
            this.textBox_phoneNumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_phoneNumber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_submitPhoneNumber = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\AuthenticateWindow.xaml"
            this.button_submitPhoneNumber.Click += new System.Windows.RoutedEventHandler(this.button_submitPhoneNumber_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBlock_codeSent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.textBox_code = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.button_submitCode = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\AuthenticateWindow.xaml"
            this.button_submitCode.Click += new System.Windows.RoutedEventHandler(this.button_submitCode_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBlock_smsError = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
