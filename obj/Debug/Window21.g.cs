﻿#pragma checksum "..\..\Window21.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F6FAD348EA48217FD392E54BFFC5BED0A2EB6224"
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
    /// Window21
    /// </summary>
    public partial class Window21 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 441 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 442 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock1;
        
        #line default
        #line hidden
        
        
        #line 443 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeBtn;
        
        #line default
        #line hidden
        
        
        #line 444 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Images_home2_png;
        
        #line default
        #line hidden
        
        
        #line 446 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mesactions;
        
        #line default
        #line hidden
        
        
        #line 447 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button messens;
        
        #line default
        #line hidden
        
        
        #line 448 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button moncorps;
        
        #line default
        #line hidden
        
        
        #line 450 "..\..\Window21.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/App2;component/window21.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window21.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.HomeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 443 "..\..\Window21.xaml"
            this.HomeBtn.Click += new System.Windows.RoutedEventHandler(this.HomeBtnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Images_home2_png = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.mesactions = ((System.Windows.Controls.Button)(target));
            
            #line 446 "..\..\Window21.xaml"
            this.mesactions.Click += new System.Windows.RoutedEventHandler(this.mesactionsClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.messens = ((System.Windows.Controls.Button)(target));
            
            #line 447 "..\..\Window21.xaml"
            this.messens.Click += new System.Windows.RoutedEventHandler(this.SensClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.moncorps = ((System.Windows.Controls.Button)(target));
            
            #line 448 "..\..\Window21.xaml"
            this.moncorps.Click += new System.Windows.RoutedEventHandler(this.moncorpsClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 450 "..\..\Window21.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.ExitClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

