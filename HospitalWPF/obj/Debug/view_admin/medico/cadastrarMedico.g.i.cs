#pragma checksum "..\..\..\..\view_admin\medico\cadastrarMedico.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1C0489B200811348EB23218745132243"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using HospitalWPF.view_admin.medico;
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


namespace HospitalWPF.view_admin.medico
{


    /// <summary>
    /// cadastrarMedico
    /// </summary>
    public partial class cadastrarMedico : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvar;

#line default
#line hidden


#line 11 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;

#line default
#line hidden


#line 20 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;

#line default
#line hidden


#line 23 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTurno;

#line default
#line hidden


#line 29 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateNasc;

#line default
#line hidden


#line 30 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBanco;

#line default
#line hidden


#line 31 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbArea;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HospitalWPF;component/view_admin/medico/cadastrarmedico.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.btnSalvar = ((System.Windows.Controls.Button)(target));

#line 10 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
                    this.btnSalvar.Click += new System.Windows.RoutedEventHandler(this.btnSalvar_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.btnCancelar = ((System.Windows.Controls.Button)(target));

#line 11 "..\..\..\..\view_admin\medico\cadastrarMedico.xaml"
                    this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.txtNome = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.txtCrm = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.txtCpf = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.cbTurno = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 7:
                    this.txtTelefone = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.dateNasc = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 9:
                    this.cbBanco = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 10:
                    this.cbArea = ((System.Windows.Controls.ComboBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal Xceed.Wpf.Toolkit.MaskedTextBox txtCpf;
        internal Xceed.Wpf.Toolkit.MaskedTextBox txtTelefone;
        internal Xceed.Wpf.Toolkit.MaskedTextBox txtCrm;
    }
}

