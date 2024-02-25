using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private MediaPlayer player = new MediaPlayer();
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path = @".\voice";
            string s = System.IO.Path.GetFullPath(path) + @"\введение.mp3";
            s = s.Replace(@"\bin\Debug", "");
            player.Open(new Uri(s, UriKind.Relative));
            player.Play();
        }

        private void MyWipedText9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int ind = 1;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int ind = 2;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int ind = 3;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int ind = 4;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void MyWipedText13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int ind = 5;
            player.Stop();
            new Tests(ind).Show();
            this.Close();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        { 
            player.Stop();
            new Start().Show();
            this.Close();
        }

        private void new_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Teacher th = new Teacher();
            if (th.ShowDialog() == true)
            {
                if (th.Password == "12")
                {
                    new NewTest().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
    }
}
