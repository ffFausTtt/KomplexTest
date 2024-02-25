﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace test.windowsCheck
{
    /// <summary>
    /// Логика взаимодействия для Right.xaml
    /// </summary>
    public partial class Right : Window
    {
        public Right(int fon, int sz)
        {
            InitializeComponent();
        }
 private MediaPlayer player = new MediaPlayer();
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path = @".\voice";
            string s = System.IO.Path.GetFullPath(path) + @"\right.mp3";
            s = s.Replace(@"\bin\Debug", "");
            player.Open(new Uri(s, UriKind.Relative));
            player.Play();
        }
    }
}
