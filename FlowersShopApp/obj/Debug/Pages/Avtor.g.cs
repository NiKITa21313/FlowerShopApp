﻿#pragma checksum "..\..\..\Pages\Avtor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F46A749E86554EF44CB8E48E5A0D642A3EB37318F67EFFFDD35E44B272E721C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FlowersShopApp.Pages;
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


namespace FlowersShopApp.Pages {
    
    
    /// <summary>
    /// Avtor
    /// </summary>
    public partial class Avtor : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\Avtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtLogin;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\Avtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbLogin;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Avtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtPassword;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\Avtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pswbPassword;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Avtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnterPokupatel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\Avtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnter;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowersShopApp;component/pages/avtor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Avtor.xaml"
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
            this.txtLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtbLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.pswbPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btnEnterPokupatel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\Avtor.xaml"
            this.btnEnterPokupatel.Click += new System.Windows.RoutedEventHandler(this.btnEnterPokupatel_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEnter = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\Avtor.xaml"
            this.btnEnter.Click += new System.Windows.RoutedEventHandler(this.btnEnter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
