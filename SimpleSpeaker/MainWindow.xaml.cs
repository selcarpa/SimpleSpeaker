﻿using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace SimpleSpeaker
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<FileInfo> audio_list = new List<FileInfo>();
            string path = Directory.GetCurrentDirectory();
            path = path + "\\音频库";
            DirectoryInfo the_folder = new DirectoryInfo(path);
            DirectoryInfo[] dirInfo = the_folder.GetDirectories();
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                FileInfo[] fileInfo = NextFolder.GetFiles("*.txt");
                foreach (FileInfo NextFile in fileInfo)
                {
                    audio_list.Add(NextFile);
                }
            }
            foreach(FileInfo f in audio_list)
            {
                Main_list.Items.Add(f.Name,f.DirectoryName);
            }
        }

        private void MenuItem0_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}