﻿#pragma checksum "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0AA1D4A1D02B7E96BA879F6464BE9168"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ES.UI;
using ExtendedGrid.ExtendedColumn;
using ExtendedGrid.ExtendedGridControl;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace ES.UI.Setups {
    
    
    /// <summary>
    /// ucClassFee
    /// </summary>
    public partial class ucClassFee : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucClassFee CustomUserControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ShellHeader;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewClassMarks;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveFeeDetail;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid grid;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/finance/fee/ucclassfee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
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
            this.CustomUserControl = ((ES.UI.Setups.ucClassFee)(target));
            return;
            case 2:
            this.ShellHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 34 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 61 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnViewClassMarks = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
            this.btnViewClassMarks.Click += new System.Windows.RoutedEventHandler(this.btnViewClassMarks_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSaveFeeDetail = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
            this.btnSaveFeeDetail.Click += new System.Windows.RoutedEventHandler(this.btnSaveFeeDetail_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grid = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            
            #line 101 "..\..\..\..\..\..\Setups\Finance\Fee\ucClassFee.xaml"
            this.grid.RowEditEnding += new System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>(this.grid_RowEditEnding);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

