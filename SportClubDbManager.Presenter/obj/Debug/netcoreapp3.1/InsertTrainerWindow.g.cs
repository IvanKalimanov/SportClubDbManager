﻿#pragma checksum "..\..\..\InsertTrainerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7FE4319769B0F40792A9677517ED3C8AEB19E3B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SportClubDbManager.Presenter;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SportClubDbManager.Presenter {
    
    
    /// <summary>
    /// InsertTrainerWindow
    /// </summary>
    public partial class InsertTrainerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\InsertTrainerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrainerIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\InsertTrainerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\InsertTrainerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrainerFIOTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\InsertTrainerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrainerLevelTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\InsertTrainerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TrainerRatingTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\InsertTrainerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TrainerSportComboBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SportClubDbManager.Presenter;component/inserttrainerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\InsertTrainerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TrainerIdTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\InsertTrainerWindow.xaml"
            this.TrainerIdTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.DecimalTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\InsertTrainerWindow.xaml"
            this.TrainerIdTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.IntegerTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.insertButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\InsertTrainerWindow.xaml"
            this.insertButton.Click += new System.Windows.RoutedEventHandler(this.insertButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TrainerFIOTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TrainerLevelTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\InsertTrainerWindow.xaml"
            this.TrainerLevelTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TrainerRatingTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\InsertTrainerWindow.xaml"
            this.TrainerRatingTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.DecimalTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\InsertTrainerWindow.xaml"
            this.TrainerRatingTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.DecimalTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\InsertTrainerWindow.xaml"
            this.TrainerRatingTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TrainerSportComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

