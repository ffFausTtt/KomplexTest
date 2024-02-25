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
    /// Логика взаимодействия для MnozhTask.xaml
    /// </summary>
    public partial class MnozhTask : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f;
        public MnozhTask(int fon, int sz)
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
                new Mnozh(f, s).Show();
                this.Close();
            }
            else
            {
                new Mnozh2(f, s).Show();
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (z2v2.IsChecked == true && z2v3.IsChecked == true && z2v6.IsChecked == true && z2v8.IsChecked == true && z2v9.IsChecked == true && z2v12.IsChecked == true && z2v14.IsChecked == true && z2v15.IsChecked == true && z2v18.IsChecked == true && z2v20.IsChecked == true)
                {
                    new Right(f, s).ShowDialog();
                }
                else
                {
                    new MnCh(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((Regex.IsMatch(z3v1.Text, @"^[a-zA-Z. ]+$") || z3v1.Text == "") && (Regex.IsMatch(z3v2.Text, @"^[a-zA-Z. ]+$") || z3v2.Text == "") && (Regex.IsMatch(z3v3.Text, @"^[a-zA-Z. ]+$") || z3v3.Text == "") && (Regex.IsMatch(z3v4.Text, @"^[a-zA-Z. ]+$") || z3v4.Text == "") && (Regex.IsMatch(z3v5.Text, @"^[a-zA-Z. ]+$") || z3v5.Text == ""))
                {
                    if (z3v1.Text == "cats" && z3v2.Text == "boxes" && z3v3.Text == "boys" && z3v4.Text == "feet" && z3v5.Text == "glasses")
                    {
                        new Right(f, s).ShowDialog();
                    }
                    else
                    {
                        new MnCh(f, s).ShowDialog();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vib1.SelectedIndex == 0 && vib2.SelectedIndex == 0 && vib3.SelectedIndex == 0 && vib4.SelectedIndex == 0)
                {
                    new Right(f, s).ShowDialog();
                }
                else
                {
                    new MnCh(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}