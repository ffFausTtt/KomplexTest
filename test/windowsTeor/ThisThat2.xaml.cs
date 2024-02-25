using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using test.windowsTask;

namespace test.windowsTeor
{
    /// <summary>
    /// Логика взаимодействия для ThisThat2.xaml
    /// </summary>
    public partial class ThisThat2 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int fon;
        public ThisThat2(int f, int sz)
        {
            InitializeComponent();
            fon = f;
            s = sz;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            if (fon == 1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            }
            else if (fon == 2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            }
        }

        private void Chack_Click(object sender, RoutedEventArgs e)
        {
            new Start2(fon, s).Show();
            this.Close();
        }

        private void newbg_Click(object sender, RoutedEventArgs e)
        {
            bg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            fg = "#ffff00";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            fon = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            fon = 2;
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
            fon = 0;
            s = 24;
            new ThisThat(fon, s).Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new ThisThatTask(fon, s).Show();
            this.Close();
        }
    }
}
