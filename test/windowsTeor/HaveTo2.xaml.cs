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
    /// Логика взаимодействия для HaveTo2.xaml
    /// </summary>
    public partial class HaveTo2 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string vs1 { get; set; }
        public string vs2 { get; set; }
        public string vs3 { get; set; }
        public string vs4 { get; set; }
        public string bg { get; set; }
        public string fg { get; set; }
        public string bb { get; set; }
        public int s { get; set; }
        int fon;
        public HaveTo2(int f, int sz)
        {
            InitializeComponent();
            fon = f;
            s = sz;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            vib.SelectedIndex = 0;
            if (fon == 1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                bb = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            }
            else if (fon == 2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                bb = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
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
            bb = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fon = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
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
            new SravPrev(fon, s).Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new HaveToTask(fon, s).Show();
            this.Close();
        }

        private void vib_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (vib.SelectedIndex)
            {
                case 0:
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs4 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs4"));
                    break;
                case 1:
                    vs1 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs4 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs4"));
                    break;
                case 2:
                    vs2 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs4 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs4"));
                    break;
                case 3:
                    vs3 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs4 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs4"));
                    break;
                case 4:
                    vs4 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs4"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    break;
            }
        }
    }
}
