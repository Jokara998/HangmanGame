﻿#pragma checksum "..\..\Game.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62F798D61FA443588D734785B90D8E15A2996584FF1CDEBEF8A2FF41B259EBBE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HangManGame;
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


namespace HangManGame {
    
    
    /// <summary>
    /// Game
    /// </summary>
    public partial class Game : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hangman;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox word;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Game.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu menu;
        
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
            System.Uri resourceLocater = new System.Uri("/HangManGame;component/game.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Game.xaml"
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
            this.hangman = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.Exit2 = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Game.xaml"
            this.Exit2.Click += new System.Windows.RoutedEventHandler(this.Exit2_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.word = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\Game.xaml"
            this.word.KeyDown += new System.Windows.Input.KeyEventHandler(this.word_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Submit = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Game.xaml"
            this.Submit.Click += new System.Windows.RoutedEventHandler(this.FinalGuess);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 17 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 18 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 19 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 20 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 21 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 22 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 23 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 24 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 25 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 26 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 27 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 28 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 29 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 30 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 31 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 32 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 33 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 34 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 35 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 36 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 37 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 38 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 39 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 40 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 41 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 42 "..\..\Game.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.WordGuess);
            
            #line default
            #line hidden
            return;
            case 31:
            this.menu = ((System.Windows.Controls.Menu)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

