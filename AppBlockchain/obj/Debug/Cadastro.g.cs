﻿#pragma checksum "..\..\Cadastro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D0FFC50E6CE6975E4341E31703856645"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using AppBlockchain;
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


namespace AppBlockchain {
    
    
    /// <summary>
    /// Cadastro
    /// </summary>
    public partial class Cadastro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFundo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCriarConta;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cnvCampos;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuario;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwbSenha;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwbConfirmSenha;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labSenha;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labConfirmSenha;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Cadastro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogotipo;
        
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
            System.Uri resourceLocater = new System.Uri("/AppBlockchain;component/cadastro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Cadastro.xaml"
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
            this.imgFundo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnCriarConta = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Cadastro.xaml"
            this.btnCriarConta.Click += new System.Windows.RoutedEventHandler(this.btnCriarConta_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cnvCampos = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\Cadastro.xaml"
            this.txtNome.GotFocus += new System.Windows.RoutedEventHandler(this.txtNome_GotFocus);
            
            #line default
            #line hidden
            
            #line 15 "..\..\Cadastro.xaml"
            this.txtNome.LostFocus += new System.Windows.RoutedEventHandler(this.txtNome_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtUsuario = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\Cadastro.xaml"
            this.txtUsuario.GotFocus += new System.Windows.RoutedEventHandler(this.txtUsuario_GotFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\Cadastro.xaml"
            this.txtUsuario.LostFocus += new System.Windows.RoutedEventHandler(this.txtUsuario_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\Cadastro.xaml"
            this.txtEmail.GotFocus += new System.Windows.RoutedEventHandler(this.txtEmail_GotFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\Cadastro.xaml"
            this.txtEmail.LostFocus += new System.Windows.RoutedEventHandler(this.txtEmail_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pwbSenha = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 18 "..\..\Cadastro.xaml"
            this.pwbSenha.LostFocus += new System.Windows.RoutedEventHandler(this.pwbSenha_LostFocus);
            
            #line default
            #line hidden
            
            #line 18 "..\..\Cadastro.xaml"
            this.pwbSenha.GotFocus += new System.Windows.RoutedEventHandler(this.pwbSenha_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.pwbConfirmSenha = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 19 "..\..\Cadastro.xaml"
            this.pwbConfirmSenha.GotFocus += new System.Windows.RoutedEventHandler(this.pwbConfirmSenha_GotFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\Cadastro.xaml"
            this.pwbConfirmSenha.LostFocus += new System.Windows.RoutedEventHandler(this.pwbConfirmSenha_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.labSenha = ((System.Windows.Controls.Label)(target));
            
            #line 20 "..\..\Cadastro.xaml"
            this.labSenha.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.labSenha_MouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.labConfirmSenha = ((System.Windows.Controls.Label)(target));
            
            #line 21 "..\..\Cadastro.xaml"
            this.labConfirmSenha.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.labConfirmSenha_MouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.imgLogotipo = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

