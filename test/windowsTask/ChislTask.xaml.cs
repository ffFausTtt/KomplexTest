using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using test.windowsCheck;
using test.windowsTeor;

namespace test.windowsTask
{
    /// <summary>
    /// Логика взаимодействия для ChislTask.xaml
    /// </summary>
    public partial class ChislTask : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f;
        public ChislTask(int fon, int sz)
        {
            InitializeComponent();
            s = sz;
            f = fon;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            if (fon == 0)
            {
                fg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#FFFF8000";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            }
            else if (fon == 1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            }
            else if (fon == 2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            }
        }

        private void Chack_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0)
            {
                new Start().Show();
                this.Close();
            }
            else
            {
                new Start2(f,s).Show();
                this.Close();
            }
        }

        private void newbg_Click(object sender, RoutedEventArgs e)
        {
            bg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            f = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            f = 2;
        }

        private void newsz_Click(object sender, RoutedEventArgs e)
        {
            s -= 2;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
        }

        private void newsz2_Click(object sender, RoutedEventArgs e)
        {
            s += 2;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
        }

        private void oldbg_Click(object sender, RoutedEventArgs e)
        {
            bg = "#FFFFFF";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#FFFF8000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            f = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            if (f == 0)
            {
                new Chisl(f, s).Show();
                this.Close();
            }
            else
            {
                new Chisl2(f, s).Show();
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((Regex.IsMatch(z1v1.Text, @"^[a-zA-Z]+$") || z1v1.Text == "") && (Regex.IsMatch(z1v2.Text, @"^[a-zA-Z]+$") || z1v2.Text == "") && (Regex.IsMatch(z1v3.Text, @"^[a-zA-Z]+$") || z1v3.Text == "") && (Regex.IsMatch(z1v4.Text, @"^[a-zA-Z]+$") || z1v4.Text == "") && (Regex.IsMatch(z1v5.Text, @"^[a-zA-Z]+$") || z1v5.Text == ""))
                {
                    if (z1v1.Text == "first" && z1v2.Text == "elevent" && z1v3.Text == "sixteenth" && z1v4.Text == "twentieth" && z1v5.Text == "thirty-first")
                    {
                        new Right(f, s).ShowDialog();
                    }
                    else
                    {
                        new CChisl(f, s).ShowDialog();
                    }
                }
                else
                {
                    throw new Exception("Неверный формат данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((Regex.IsMatch(z12v1.Text, @"^[a-zA-Z]+$") || z12v1.Text == "") && (Regex.IsMatch(z13v1.Text, @"^[a-zA-Z]+$") || z13v1.Text == "") && (Regex.IsMatch(z14v1.Text, @"^[a-zA-Z]+$") || z14v1.Text == "") && (Regex.IsMatch(z15v1.Text, @"^[a-zA-Z]+$") || z15v1.Text == "") && (Regex.IsMatch(z16v1.Text, @"^[a-zA-Z]+$") || z16v1.Text == ""))
                {
                    if (z12v1.Text == "second" && z13v1.Text == "fifth" && z14v1.Text == "sixth" && z15v1.Text == "third" && z16v1.Text == "fourth")
                    {
                        new Right(f, s).ShowDialog();
                    }
                    else
                    {
                        new CChisl(f, s).ShowDialog();
                    }
                }
                else
                {
                    throw new Exception("Неверный формат данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (z3v2.IsChecked == true && z3v3.IsChecked == true && z3v6.IsChecked == true && z3v7.IsChecked == true)
                {
                    new CChisl(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
