﻿#pragma checksum "..\..\RegisInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7CAD5F7D3BB973382E24431E0EFD8935"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using AForge.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WpfApp10;


namespace WpfApp10 {
    
    
    /// <summary>
    /// RegisInfo
    /// </summary>
    public partial class RegisInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Age;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdNumber;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Birthday;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DepatementID;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Commit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AForge.Controls.VideoSourcePlayer sourcePlayer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Message;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Format;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Normal_User;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Administrator;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UsernameText;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PasswordText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Username;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\RegisInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Collect_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp10;component/regisinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegisInfo.xaml"
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
            this.Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Age = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.IdNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Birthday = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\RegisInfo.xaml"
            this.Birthday.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Birthday_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\RegisInfo.xaml"
            this.Birthday.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.Birthday_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DepatementID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Commit = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\RegisInfo.xaml"
            this.Commit.Click += new System.Windows.RoutedEventHandler(this.Commit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.sourcePlayer = ((AForge.Controls.VideoSourcePlayer)(target));
            return;
            case 8:
            this.Message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Format = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Combo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.Normal_User = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 31 "..\..\RegisInfo.xaml"
            this.Normal_User.Selected += new System.Windows.RoutedEventHandler(this.Normal_User_Selected);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Administrator = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 32 "..\..\RegisInfo.xaml"
            this.Administrator.Selected += new System.Windows.RoutedEventHandler(this.Administrator_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            this.UsernameText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.PasswordText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 17:
            this.Collect_Button = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\RegisInfo.xaml"
            this.Collect_Button.Click += new System.Windows.RoutedEventHandler(this.Collect_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

