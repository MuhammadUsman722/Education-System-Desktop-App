﻿#pragma checksum "..\..\..\UserControls\ColumnChooserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0CCBFEFEF0732EDABBE138789242A07D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace ExtendedGrid.UserControls {
    
    
    /// <summary>
    /// ColumnChooserControl
    /// </summary>
    public partial class ColumnChooserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 55 "..\..\..\UserControls\ColumnChooserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup popupDrag;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\UserControls\ColumnChooserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid;
        
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
            System.Uri resourceLocater = new System.Uri("/ExtendedGrid;component/usercontrols/columnchoosercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ColumnChooserControl.xaml"
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
            
            #line 4 "..\..\..\UserControls\ColumnChooserControl.xaml"
            ((ExtendedGrid.UserControls.ColumnChooserControl)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.UserControlSizeChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.popupDrag = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 5:
            this.grid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 76 "..\..\..\UserControls\ColumnChooserControl.xaml"
            this.grid.Loaded += new System.Windows.RoutedEventHandler(this.DataGridLoaded);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\UserControls\ColumnChooserControl.xaml"
            this.grid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.GridSizeChanged);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\UserControls\ColumnChooserControl.xaml"
            this.grid.MouseMove += new System.Windows.Input.MouseEventHandler(this.GridMouseMove);
            
            #line default
            #line hidden
            
            #line 76 "..\..\..\UserControls\ColumnChooserControl.xaml"
            this.grid.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.GridPreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.ToggleButton.CheckedEvent;
            
            #line 44 "..\..\..\UserControls\ColumnChooserControl.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.CheckBoxChecked);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Primitives.ToggleButton.UncheckedEvent;
            
            #line 45 "..\..\..\UserControls\ColumnChooserControl.xaml"
            eventSetter.Handler = new System.Windows.RoutedEventHandler(this.CheckBoxChecked);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 46 "..\..\..\UserControls\ColumnChooserControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 3:
            
            #line 50 "..\..\..\UserControls\ColumnChooserControl.xaml"
            ((System.Windows.Controls.TextBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.TextBoxLoaded);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\UserControls\ColumnChooserControl.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.TextBoxMouseLeave);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\UserControls\ColumnChooserControl.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TextBoxMouseDown);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\UserControls\ColumnChooserControl.xaml"
            ((System.Windows.Controls.TextBox)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TextBoxMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\UserControls\ColumnChooserControl.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxTextChanged);
            
            #line default
            #line hidden
            break;
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 80 "..\..\..\UserControls\ColumnChooserControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.PreviewDataCellMouseLeftButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 81 "..\..\..\UserControls\ColumnChooserControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.CellMouseEnter);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 82 "..\..\..\UserControls\ColumnChooserControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

