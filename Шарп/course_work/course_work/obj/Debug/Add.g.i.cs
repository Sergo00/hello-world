﻿#pragma checksum "..\..\Add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54F914BFDAEE334B854DA021AABDE80D2DA216D539A341CE711C0E60E3BE6668"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using course_work;


namespace course_work {
    
    
    /// <summary>
    /// Add
    /// </summary>
    public partial class Add : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fileName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindWay;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton funny;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sad;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton angry;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton cringe;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ok;
        
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
            System.Uri resourceLocater = new System.Uri("/course_work;component/add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Add.xaml"
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
            this.fn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.fileName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FindWay = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Add.xaml"
            this.FindWay.Click += new System.Windows.RoutedEventHandler(this.FindWay_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.funny = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.sad = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.angry = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.cringe = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.Ok = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Add.xaml"
            this.Ok.Click += new System.Windows.RoutedEventHandler(this.Ok_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

