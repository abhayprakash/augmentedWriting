﻿#pragma checksum "C:\Users\Prakhar\documents\visual studio 2012\Projects\PhoneApp3\PhoneApp3\Cameraget.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EEE7B2F31AF2CD58DB40E7458E1F126F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace PhoneApp3 {
    
    
    public partial class Cameraget : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas viewfinderCanvas;
        
        internal System.Windows.Media.VideoBrush viewfinderBrush;
        
        internal System.Windows.Controls.TextBlock focusBrackets;
        
        internal System.Windows.Controls.Canvas drawCanvas;
        
        internal System.Windows.Controls.Button Save;
        
        internal System.Windows.Controls.Button New;
        
        internal System.Windows.Controls.Button Refresh_Location;
        
        internal System.Windows.Controls.Button ShutterButton;
        
        internal System.Windows.Controls.Button FlashButton;
        
        internal System.Windows.Controls.Button AFButton;
        
        internal System.Windows.Controls.Button ResButton;
        
        internal System.Windows.Controls.TextBlock statusTextBlock;
        
        internal System.Windows.Controls.TextBlock txtDebug;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp3;component/Cameraget.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.viewfinderCanvas = ((System.Windows.Controls.Canvas)(this.FindName("viewfinderCanvas")));
            this.viewfinderBrush = ((System.Windows.Media.VideoBrush)(this.FindName("viewfinderBrush")));
            this.focusBrackets = ((System.Windows.Controls.TextBlock)(this.FindName("focusBrackets")));
            this.drawCanvas = ((System.Windows.Controls.Canvas)(this.FindName("drawCanvas")));
            this.Save = ((System.Windows.Controls.Button)(this.FindName("Save")));
            this.New = ((System.Windows.Controls.Button)(this.FindName("New")));
            this.Refresh_Location = ((System.Windows.Controls.Button)(this.FindName("Refresh_Location")));
            this.ShutterButton = ((System.Windows.Controls.Button)(this.FindName("ShutterButton")));
            this.FlashButton = ((System.Windows.Controls.Button)(this.FindName("FlashButton")));
            this.AFButton = ((System.Windows.Controls.Button)(this.FindName("AFButton")));
            this.ResButton = ((System.Windows.Controls.Button)(this.FindName("ResButton")));
            this.statusTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("statusTextBlock")));
            this.txtDebug = ((System.Windows.Controls.TextBlock)(this.FindName("txtDebug")));
        }
    }
}
