﻿#pragma checksum "..\..\..\Download Data Async\DownloadWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D43046831B397AB9BB88C7A68067693EE175075B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainWindow.Download_Data_Async;
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


namespace MainWindow.Download_Data_Async {
    
    
    /// <summary>
    /// DownloadWindow
    /// </summary>
    public partial class DownloadWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Download Data Async\DownloadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadRSS;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Download Data Async\DownloadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CounterIncButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Download Data Async\DownloadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Counter;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Download Data Async\DownloadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Downloader;
        
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
            System.Uri resourceLocater = new System.Uri("/MainWindow;component/download%20data%20async/downloadwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Download Data Async\DownloadWindow.xaml"
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
            this.DownloadRSS = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Download Data Async\DownloadWindow.xaml"
            this.DownloadRSS.Click += new System.Windows.RoutedEventHandler(this.DownloadRSS_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CounterIncButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Download Data Async\DownloadWindow.xaml"
            this.CounterIncButton.Click += new System.Windows.RoutedEventHandler(this.CounterIncButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Counter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Downloader = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
