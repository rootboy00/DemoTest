﻿#pragma checksum "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC9C2717A91B2E668CF58FC09FDD4D9612303F9E2E790CCC6EA1E1CDAF1C3A59"
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
using WpfApp1.Pages.Dlg;


namespace WpfApp1.Pages.Dlg {
    
    
    /// <summary>
    /// CommentsDlgPage
    /// </summary>
    public partial class CommentsDlgPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NamePageLabel;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NewsComboBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CommentsTextBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePostDatePicker;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateChangeDatePicker;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsersComboBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/dlg/commentsdlgpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
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
            this.NamePageLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.NewsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.CommentsTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DatePostDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.DateChangeDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.UsersComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.OkButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
            this.OkButton.Click += new System.Windows.RoutedEventHandler(this.OkButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Pages\Dlg\CommentsDlgPage.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

