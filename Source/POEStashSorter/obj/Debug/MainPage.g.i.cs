﻿#pragma checksum "..\..\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E711A5EC0DDA57CD2C4E7D5479BAEFC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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


namespace POEStashSorter {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlLeague;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlSort;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSort;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOutput;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlSpeed;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ddlStash;
        
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
            System.Uri resourceLocater = new System.Uri("/POEStashSorter;component/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainPage.xaml"
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
            this.ddlLeague = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\MainPage.xaml"
            this.ddlLeague.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlLeague_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ddlSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\MainPage.xaml"
            this.ddlSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSort = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\MainPage.xaml"
            this.btnSort.Click += new System.Windows.RoutedEventHandler(this.btnSort_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtOutput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ddlSpeed = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\MainPage.xaml"
            this.ddlSpeed.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlSpeed_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ddlStash = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\MainPage.xaml"
            this.ddlStash.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ddlStash_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
