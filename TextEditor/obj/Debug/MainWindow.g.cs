﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6B3A3848C2EF80E135A38A05DB31D8C8090328335F220780EA3D5DE3827BD5FF"
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
using TextEditor;


namespace TextEditor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem newMenuItem;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem openMenuItem;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem saveMenuItem;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem exitMenuItem;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton speechBtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton boldBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton italBtn;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton underBtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox familyBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sizeBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBar statusBar;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusTextBlock;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox contentBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TextEditor;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.newMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.newMenuItem.Click += new System.Windows.RoutedEventHandler(this.newMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.openMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.openMenuItem.Click += new System.Windows.RoutedEventHandler(this.openMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.saveMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.saveMenuItem.Click += new System.Windows.RoutedEventHandler(this.saveMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.exitMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.exitMenuItem.Click += new System.Windows.RoutedEventHandler(this.exitMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.speechBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.speechBtn.Click += new System.Windows.RoutedEventHandler(this.speechBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.boldBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.boldBtn.Click += new System.Windows.RoutedEventHandler(this.boldBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.italBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.italBtn.Click += new System.Windows.RoutedEventHandler(this.italBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.underBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.underBtn.Click += new System.Windows.RoutedEventHandler(this.underBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.familyBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\MainWindow.xaml"
            this.familyBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.familyBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.sizeBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.sizeBox.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.sizeBox_TextChanged));
            
            #line default
            #line hidden
            return;
            case 11:
            this.statusBar = ((System.Windows.Controls.Primitives.StatusBar)(target));
            return;
            case 12:
            this.statusTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.contentBox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 77 "..\..\MainWindow.xaml"
            this.contentBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.contentBox_TextChanged);
            
            #line default
            #line hidden
            
            #line 78 "..\..\MainWindow.xaml"
            this.contentBox.SelectionChanged += new System.Windows.RoutedEventHandler(this.contentBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
