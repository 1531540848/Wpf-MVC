﻿#pragma checksum "..\..\..\StudentUpdate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62919A1D459D95F9830AB089C1100611230E7588"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPFUI;


namespace WPFUI {
    
    
    /// <summary>
    /// StudentUpdate
    /// </summary>
    public partial class StudentUpdate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StuName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox StuGender;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StuBirthday;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StuAddress;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StuPatriarchTel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateNewStu;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\StudentUpdate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Updateout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFUI;component/studentupdate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StudentUpdate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.StuName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.StuGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.StuBirthday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.StuAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.StuPatriarchTel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.UpdateNewStu = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\StudentUpdate.xaml"
            this.UpdateNewStu.Click += new System.Windows.RoutedEventHandler(this.UpdateNewStu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Updateout = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\StudentUpdate.xaml"
            this.Updateout.Click += new System.Windows.RoutedEventHandler(this.Updateout_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

