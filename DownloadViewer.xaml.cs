﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Download_Manager
{
    /// <summary>
    /// Interaction logic for DownloadViewer.xaml
    /// </summary>
    public partial class DownloadViewer : Page
    {

        private DriveInfo dInfo = new DriveInfo("C:\\Users\\eturn\\Downloads");
        
        public DownloadViewer()
        {
            InitializeComponent();
        }

        public DriveName(string dName)
        {

        }
    }
}
