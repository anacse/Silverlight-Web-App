﻿#pragma checksum "C:\Users\André\Documents\Visual Studio 2013\Projects\Bubbles Projeto\Bubbles Projeto\Views\Quiz.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D181CC1027968DCCE084CD7BFCB0E485"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Bubbles_Projeto.Views {
    
    
    public partial class Quiz : System.Windows.Controls.Page {
        
        internal System.Windows.Media.Animation.Storyboard RespostaErrada;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta1to2;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta2to3;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta3to4;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta4to5;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta5to6;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta6to7;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta7to8;
        
        internal System.Windows.Media.Animation.Storyboard RespostaCerta8to9;
        
        internal System.Windows.Media.Animation.Storyboard RespostasCerta9toReplay;
        
        internal System.Windows.Media.Animation.Storyboard Replay1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid Pergunta_1;
        
        internal System.Windows.Controls.Button button;
        
        internal System.Windows.Controls.Image Image1;
        
        internal System.Windows.Controls.Grid Pergunta_2;
        
        internal System.Windows.Controls.Image Image;
        
        internal System.Windows.Controls.Grid Pergunta_3;
        
        internal System.Windows.Controls.Image Image2;
        
        internal System.Windows.Controls.Grid Pergunta_4;
        
        internal System.Windows.Controls.Image Image3;
        
        internal System.Windows.Controls.Grid Pergunta_5;
        
        internal System.Windows.Controls.Image Image4;
        
        internal System.Windows.Controls.Grid Pergunta_6;
        
        internal System.Windows.Controls.Image Image5;
        
        internal System.Windows.Controls.Grid Pergunta_7;
        
        internal System.Windows.Controls.Image Image6;
        
        internal System.Windows.Controls.Grid Pergunta_8;
        
        internal System.Windows.Controls.Image Image7;
        
        internal System.Windows.Controls.Grid Pergunta_9;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.Image Image8;
        
        internal System.Windows.Controls.Image ImagemErro;
        
        internal System.Windows.Controls.Image ImagemCorrecto;
        
        internal System.Windows.Controls.Button Replay;
        
        internal System.Windows.Controls.TextBlock Congrats;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Bubbles%20Projeto;component/Views/Quiz.xaml", System.UriKind.Relative));
            this.RespostaErrada = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaErrada")));
            this.RespostaCerta1to2 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta1to2")));
            this.RespostaCerta2to3 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta2to3")));
            this.RespostaCerta3to4 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta3to4")));
            this.RespostaCerta4to5 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta4to5")));
            this.RespostaCerta5to6 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta5to6")));
            this.RespostaCerta6to7 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta6to7")));
            this.RespostaCerta7to8 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta7to8")));
            this.RespostaCerta8to9 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostaCerta8to9")));
            this.RespostasCerta9toReplay = ((System.Windows.Media.Animation.Storyboard)(this.FindName("RespostasCerta9toReplay")));
            this.Replay1 = ((System.Windows.Media.Animation.Storyboard)(this.FindName("Replay1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Pergunta_1 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_1")));
            this.button = ((System.Windows.Controls.Button)(this.FindName("button")));
            this.Image1 = ((System.Windows.Controls.Image)(this.FindName("Image1")));
            this.Pergunta_2 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_2")));
            this.Image = ((System.Windows.Controls.Image)(this.FindName("Image")));
            this.Pergunta_3 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_3")));
            this.Image2 = ((System.Windows.Controls.Image)(this.FindName("Image2")));
            this.Pergunta_4 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_4")));
            this.Image3 = ((System.Windows.Controls.Image)(this.FindName("Image3")));
            this.Pergunta_5 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_5")));
            this.Image4 = ((System.Windows.Controls.Image)(this.FindName("Image4")));
            this.Pergunta_6 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_6")));
            this.Image5 = ((System.Windows.Controls.Image)(this.FindName("Image5")));
            this.Pergunta_7 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_7")));
            this.Image6 = ((System.Windows.Controls.Image)(this.FindName("Image6")));
            this.Pergunta_8 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_8")));
            this.Image7 = ((System.Windows.Controls.Image)(this.FindName("Image7")));
            this.Pergunta_9 = ((System.Windows.Controls.Grid)(this.FindName("Pergunta_9")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.Image8 = ((System.Windows.Controls.Image)(this.FindName("Image8")));
            this.ImagemErro = ((System.Windows.Controls.Image)(this.FindName("ImagemErro")));
            this.ImagemCorrecto = ((System.Windows.Controls.Image)(this.FindName("ImagemCorrecto")));
            this.Replay = ((System.Windows.Controls.Button)(this.FindName("Replay")));
            this.Congrats = ((System.Windows.Controls.TextBlock)(this.FindName("Congrats")));
        }
    }
}

