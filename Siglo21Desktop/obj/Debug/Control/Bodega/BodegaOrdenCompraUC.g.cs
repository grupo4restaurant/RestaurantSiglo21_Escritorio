﻿#pragma checksum "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDB9688C90FF0866CE5B06630C920A53BA1F553A991B1DF36494C3383641EA75"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Siglo21Desktop.Control.Bodega;
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


namespace Siglo21Desktop.Control.Bodega {
    
    
    /// <summary>
    /// BodegaOrdenCompraUC
    /// </summary>
    public partial class BodegaOrdenCompraUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 21 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNuevo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRefresh;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg;
        
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
            System.Uri resourceLocater = new System.Uri("/Siglo21Desktop;component/control/bodega/bodegaordencomprauc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
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
            this.btnNuevo = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            this.btnNuevo.Click += new System.Windows.RoutedEventHandler(this.btnNuevo_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRefresh = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            this.btnRefresh.Click += new System.Windows.RoutedEventHandler(this.btnRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            this.dg.Sorting += new System.Windows.Controls.DataGridSortingEventHandler(this.DataGrid_Sorting);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            this.dg.TargetUpdated += new System.EventHandler<System.Windows.Data.DataTransferEventArgs>(this.DataGrid_TargetUpdated);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            this.dg.Loaded += new System.Windows.RoutedEventHandler(this.DataGrid_Loaded);
            
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
            case 4:
            
            #line 47 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 63 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 79 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 95 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 111 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 127 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 143 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtName_TextChanged);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 153 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Click);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 154 "..\..\..\..\Control\Bodega\BodegaOrdenCompraUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

