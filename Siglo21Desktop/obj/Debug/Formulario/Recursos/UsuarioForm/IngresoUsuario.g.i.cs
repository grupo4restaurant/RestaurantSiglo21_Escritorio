﻿#pragma checksum "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "338BF04DC32FBA2D691EFDB619DE3EE8BF4FED31F51815E5565D5DBB39D5A711"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Siglo21Desktop.Formulario.Recursos.UsuarioForm;
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


namespace Siglo21Desktop.Formulario.Recursos.UsuarioForm {
    
    
    /// <summary>
    /// IngresoUsuario
    /// </summary>
    public partial class IngresoUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPaterno;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaterno;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PerfilCB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFono;
        
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
            System.Uri resourceLocater = new System.Uri("/Siglo21Desktop;component/formulario/recursos/usuarioform/ingresousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
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
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtPaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtMaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PerfilCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txtFono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 57 "..\..\..\..\..\Formulario\Recursos\UsuarioForm\IngresoUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
