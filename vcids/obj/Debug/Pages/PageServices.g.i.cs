﻿#pragma checksum "..\..\..\Pages\PageServices.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3E5AEE9EEF0A8351FA5A15C1ED438AC688502884962E066F3C7E4C2BFAE42A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using vcids.Pages;


namespace vcids.Pages {
    
    
    /// <summary>
    /// PageServices
    /// </summary>
    public partial class PageServices : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 28 "..\..\..\Pages\PageServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Header;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\PageServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\PageServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBoxServices;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\PageServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridServices;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pages\PageServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddService;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\PageServices.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtndelService;
        
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
            System.Uri resourceLocater = new System.Uri("/vcids;component/pages/pageservices.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageServices.xaml"
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
            this.Header = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\Pages\PageServices.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CBoxServices = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\Pages\PageServices.xaml"
            this.CBoxServices.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBoxServices_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DGridServices = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.BtnAddService = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\Pages\PageServices.xaml"
            this.BtnAddService.Click += new System.Windows.RoutedEventHandler(this.BtnAddService_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtndelService = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\Pages\PageServices.xaml"
            this.BtndelService.Click += new System.Windows.RoutedEventHandler(this.BtndelService_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 70 "..\..\..\Pages\PageServices.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditService_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

