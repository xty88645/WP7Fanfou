﻿#pragma checksum "D:\GitHub\WP7Fanfou\MetroFanfou\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4000835D5D7EA9D825AFFD251AFE805B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.269
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MetroFanfou.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace MetroFanfou {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid rootView;
        
        internal System.Windows.Controls.StackPanel TrayPanel;
        
        internal Microsoft.Phone.Controls.PerformanceProgressBar performanceBar;
        
        internal System.Windows.Controls.Image imgTweetCount;
        
        internal System.Windows.Controls.TextBlock tbTweetCount;
        
        internal System.Windows.Controls.Image imgCommentCount;
        
        internal System.Windows.Controls.TextBlock tbCommentCount;
        
        internal System.Windows.Controls.Image imgMessageCount;
        
        internal System.Windows.Controls.TextBlock tbMessageCount;
        
        internal System.Windows.Controls.Image imgFanxCount;
        
        internal System.Windows.Controls.TextBlock tbFanxCount;
        
        internal System.Windows.Controls.Image imgLogo;
        
        internal System.Windows.Controls.TextBlock tbAccountName;
        
        internal Microsoft.Phone.Controls.Pivot PivotMain;
        
        internal MetroFanfou.Controls.FanList homeItem;
        
        internal MetroFanfou.Controls.FanList replyItem;
        
        internal MetroFanfou.Controls.FanList publicItem;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem mSetting;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem mLogout;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem mAbout;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem mHelp;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem mExit;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnReload;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnAdd;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnProfile;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnSearch;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/MetroFanfou;component/MainPage.xaml", System.UriKind.Relative));
            this.rootView = ((System.Windows.Controls.Grid)(this.FindName("rootView")));
            this.TrayPanel = ((System.Windows.Controls.StackPanel)(this.FindName("TrayPanel")));
            this.performanceBar = ((Microsoft.Phone.Controls.PerformanceProgressBar)(this.FindName("performanceBar")));
            this.imgTweetCount = ((System.Windows.Controls.Image)(this.FindName("imgTweetCount")));
            this.tbTweetCount = ((System.Windows.Controls.TextBlock)(this.FindName("tbTweetCount")));
            this.imgCommentCount = ((System.Windows.Controls.Image)(this.FindName("imgCommentCount")));
            this.tbCommentCount = ((System.Windows.Controls.TextBlock)(this.FindName("tbCommentCount")));
            this.imgMessageCount = ((System.Windows.Controls.Image)(this.FindName("imgMessageCount")));
            this.tbMessageCount = ((System.Windows.Controls.TextBlock)(this.FindName("tbMessageCount")));
            this.imgFanxCount = ((System.Windows.Controls.Image)(this.FindName("imgFanxCount")));
            this.tbFanxCount = ((System.Windows.Controls.TextBlock)(this.FindName("tbFanxCount")));
            this.imgLogo = ((System.Windows.Controls.Image)(this.FindName("imgLogo")));
            this.tbAccountName = ((System.Windows.Controls.TextBlock)(this.FindName("tbAccountName")));
            this.PivotMain = ((Microsoft.Phone.Controls.Pivot)(this.FindName("PivotMain")));
            this.homeItem = ((MetroFanfou.Controls.FanList)(this.FindName("homeItem")));
            this.replyItem = ((MetroFanfou.Controls.FanList)(this.FindName("replyItem")));
            this.publicItem = ((MetroFanfou.Controls.FanList)(this.FindName("publicItem")));
            this.mSetting = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("mSetting")));
            this.mLogout = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("mLogout")));
            this.mAbout = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("mAbout")));
            this.mHelp = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("mHelp")));
            this.mExit = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("mExit")));
            this.btnReload = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnReload")));
            this.btnAdd = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnAdd")));
            this.btnProfile = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnProfile")));
            this.btnSearch = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnSearch")));
        }
    }
}

