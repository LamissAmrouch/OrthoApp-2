﻿#pragma checksum "..\..\Window8.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2DCEED2EEA59F207E3ECA59C0AF81E5A22C8F1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using App2;
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


namespace App2 {
    
    
    /// <summary>
    /// Window8
    /// </summary>
    public partial class Window8 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 163 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button decouvrir;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exerser;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeBtn;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Images_home2_png;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\Window8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Images_milieu_jpg;
        
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
            System.Uri resourceLocater = new System.Uri("/App2;component/window8.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window8.xaml"
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
            
            #line 140 "..\..\Window8.xaml"
            ((System.Windows.Controls.Grid)(target)).ContextMenuClosing += new System.Windows.Controls.ContextMenuEventHandler(this.HomeBtnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\Window8.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.decouvrir = ((System.Windows.Controls.Button)(target));
            
            #line 165 "..\..\Window8.xaml"
            this.decouvrir.Click += new System.Windows.RoutedEventHandler(this.decouvrirClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.exerser = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\Window8.xaml"
            this.exerser.Click += new System.Windows.RoutedEventHandler(this.exerserClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HomeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 167 "..\..\Window8.xaml"
            this.HomeBtn.Click += new System.Windows.RoutedEventHandler(this.HomeBtnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Images_home2_png = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.Images_milieu_jpg = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

