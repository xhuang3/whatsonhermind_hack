﻿#pragma checksum "C:\Users\xinhu\documents\visual studio 2013\Projects\WhatsOnHerMind\WhatsOnHerMind\MainAppPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D5F74B3C7F8F4EF9993BFA8924EC4633"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AmCharts.Windows.QuickCharts;
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


namespace WhatsOnHerMind {
    
    
    public partial class MainAppPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid PivotRoot;
        
        internal System.Windows.Controls.TextBox NameBox;
        
        internal System.Windows.Controls.TextBox AgeBox;
        
        internal AmCharts.Windows.QuickCharts.SerialChart chart1;
        
        internal System.Windows.Controls.ListBox DateListBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WhatsOnHerMind;component/MainAppPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PivotRoot = ((System.Windows.Controls.Grid)(this.FindName("PivotRoot")));
            this.NameBox = ((System.Windows.Controls.TextBox)(this.FindName("NameBox")));
            this.AgeBox = ((System.Windows.Controls.TextBox)(this.FindName("AgeBox")));
            this.chart1 = ((AmCharts.Windows.QuickCharts.SerialChart)(this.FindName("chart1")));
            this.DateListBox = ((System.Windows.Controls.ListBox)(this.FindName("DateListBox")));
        }
    }
}

