﻿#pragma checksum "..\..\Buttons.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CA0D1DF8E59C67BEEF87066D6A39DADD7C26B4D58922C9775158EC2B9C6E626"
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
using WpfEntreprise;


namespace WpfEntreprise {
    
    
    /// <summary>
    /// Buttons
    /// </summary>
    public partial class Buttons : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrdinaryButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.RepeatButton RepeatButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Buttons.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RadioButton2;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfEntreprise;component/buttons.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Buttons.xaml"
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
            this.OrdinaryButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Buttons.xaml"
            this.OrdinaryButton.Click += new System.Windows.RoutedEventHandler(this.OrdinaryButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RepeatButton = ((System.Windows.Controls.Primitives.RepeatButton)(target));
            
            #line 31 "..\..\Buttons.xaml"
            this.RepeatButton.Click += new System.Windows.RoutedEventHandler(this.RepeatButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\Buttons.xaml"
            ((System.Windows.Controls.Primitives.ToggleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ToggleButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 39 "..\..\Buttons.xaml"
            this.CheckBox.Checked += new System.Windows.RoutedEventHandler(this.ToggleButton_Checked);
            
            #line default
            #line hidden
            
            #line 39 "..\..\Buttons.xaml"
            this.CheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.ToggleButton_Unchecked);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Buttons.xaml"
            this.CheckBox.Indeterminate += new System.Windows.RoutedEventHandler(this.ToggleButton_Indeterminate);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RadioButton1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 44 "..\..\Buttons.xaml"
            this.RadioButton1.Checked += new System.Windows.RoutedEventHandler(this.ToggleButton_Checked);
            
            #line default
            #line hidden
            
            #line 44 "..\..\Buttons.xaml"
            this.RadioButton1.Unchecked += new System.Windows.RoutedEventHandler(this.ToggleButton_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RadioButton2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 46 "..\..\Buttons.xaml"
            this.RadioButton2.Checked += new System.Windows.RoutedEventHandler(this.ToggleButton_Checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\Buttons.xaml"
            this.RadioButton2.Unchecked += new System.Windows.RoutedEventHandler(this.ToggleButton_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

