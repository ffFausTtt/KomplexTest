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
    /// Логика взаимодействия для PredlogTask.xaml
    /// </summary>
    public partial class PredlogTask : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f;
        public PredlogTask(int fon, int sz)
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
                new Predlog(f, s).Show();
                this.Close();
            }
            else
            {
                new Predlog2(f, s).Show();
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((Regex.IsMatch(z1v1.Text, @"^[a-zA-Z. ]+$") || z1v1.Text == "") && (Regex.IsMatch(z1v2.Text, @"^[a-zA-Z. ]+$") || z1v2.Text == "") && (Regex.IsMatch(z1v3.Text, @"^[a-zA-Z. ]+$") || z1v3.Text == "") && (Regex.IsMatch(z1v4.Text, @"^[a-zA-Z. ]+$") || z1v4.Text == "") && (Regex.IsMatch(z1v5.Text, @"^[a-zA-Z. ]+$") || z1v5.Text == "") && (Regex.IsMatch(z1v6.Text, @"^[a-zA-Z. ]+$") || z1v6.Text == ""))
                {
                    if (z1v1.Text != "in" || z1v2.Text != "in front of" || z1v3.Text != "opposite" || z1v4.Text != "on" || z1v5.Text != "behind" || z1v6.Text != "under")
                    {
                        new PredMest(1, f, s).ShowDialog();
                    }
                    else
                    {
                        new Right(f, s).ShowDialog();
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
                if (z2v1.IsChecked == false || z2v3.IsChecked == false || z2v5.IsChecked == false || z2v8.IsChecked == false || z2v9.IsChecked == false || z2v11.IsChecked == false || z2v13.IsChecked == false || z2v16.IsChecked == false || z2v18.IsChecked == false)
                {
                    new PredMest(1,f,s).ShowDialog();
                }
                else
                {
                    new Right(f, s).ShowDialog();
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
                if (z3v2.IsChecked == false || z3v3.IsChecked == false || z3v5.IsChecked == false || z3v8.IsChecked == false || z3v9.IsChecked == false)
                {
                    new PredMest(1,f,s).ShowDialog();
                }
                else
                {
                    new Right(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (z4v2.IsChecked == false || z4v4.IsChecked == false || z4v5.IsChecked == false || z4v7.IsChecked == false || z4v10.IsChecked == false || z4v12.IsChecked == false)
                {
                    new PredMest(1,f,s).ShowDialog();
                }
                else
                {
                    new Right(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vib1.SelectedIndex != 3 || vib2.SelectedIndex != 4 || vib3.SelectedIndex != 1 || vib4.SelectedIndex != 0|| vib5.SelectedIndex !=2)
                {
                    new PredMest(1,f,s).ShowDialog();
                }
                else
                {
                    new Right(f, s).ShowDialog();
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
                if (vib21.SelectedIndex != 0 || vib22.SelectedIndex != 2 || vib222.SelectedIndex != 0 || vib23.SelectedIndex != 2 || (vib24.SelectedIndex != 2 && vib24.SelectedIndex != 1) || vib25.SelectedIndex != 1 || vib26.SelectedIndex != 0 || vib27.SelectedIndex != 0 || vib28.SelectedIndex != 1)
                {
                    new PredMest(2,f,s).ShowDialog();
                }
                else
                {
                    new Right(f, s).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
