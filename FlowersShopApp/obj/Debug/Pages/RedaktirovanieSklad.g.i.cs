﻿#pragma checksum "..\..\..\Pages\RedaktirovanieSklad.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0B6B8A12D94204EB9889FEB8468AECEDC3AE360ABB10BB0E5CB36EC1DC547CB"
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
    /// RedaktirovanieSklad
    /// </summary>
    public partial class RedaktirovanieSklad : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\RedaktirovanieSklad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\RedaktirovanieSklad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\RedaktirovanieSklad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbAdres;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\RedaktirovanieSklad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbZvety;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\RedaktirovanieSklad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbKolichestvo;
        
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
            System.Uri resourceLocater = new System.Uri("/FlowersShopApp;component/pages/redaktirovaniesklad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\RedaktirovanieSklad.xaml"
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
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\RedaktirovanieSklad.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\RedaktirovanieSklad.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbAdres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbZvety = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbKolichestvo = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

