﻿#pragma checksum "..\..\ChangePass.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6674471D716D34D74433678B9FB416F113A1C2BDB66C984334359EC5642C155"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Maps.MapControl.WPF;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// ChangePass
    /// </summary>
    public partial class ChangePass : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox oldPassTB;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPassTB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPassTB2;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ApplyChangesBT;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse closeButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\ChangePass.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse minButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/changepass.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChangePass.xaml"
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
            this.oldPassTB = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.newPassTB = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.newPassTB2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.ApplyChangesBT = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\ChangePass.xaml"
            this.ApplyChangesBT.Click += new System.Windows.RoutedEventHandler(this.ApplyChangesBT_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.closeButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 64 "..\..\ChangePass.xaml"
            this.closeButton.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.closeButton_PreviewMouseUp_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.minButton = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 71 "..\..\ChangePass.xaml"
            this.minButton.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.minButton_PreviewMouseUp_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

