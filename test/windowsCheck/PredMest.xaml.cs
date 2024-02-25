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

namespace test.windowsCheck
{
    /// <summary>
    /// Логика взаимодействия для PredMest.xaml
    /// </summary>
    public partial class PredMest : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string vsmest { get; set; }
        public string vsvrem { get; set; }
        public string bg { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f, nom;
        public PredMest(int n, int fon, int sz)
        {
            InitializeComponent();
            vsmest = "Collapsed";
            PropertyChanged(this, new PropertyChangedEventArgs("vsmest"));
            vsvrem = "Collapsed";
            PropertyChanged(this, new PropertyChangedEventArgs("vsvrem"));
            s = sz;
            f = fon;
            nom = n;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            if (fon == 0)
            {
                fg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            }
            else if (fon == 1)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(nom == 1)
            {
                vsmest = "Visible";
                PropertyChanged(this, new PropertyChangedEventArgs("vsmest"));
                vsvrem = "Collapsed";
                PropertyChanged(this, new PropertyChangedEventArgs("vsvrem"));
            }
            else
            {
                vsvrem = "Visible";
                PropertyChanged(this, new PropertyChangedEventArgs("vsvrem"));
                vsmest = "Collapsed";
                PropertyChanged(this, new PropertyChangedEventArgs("vsmest"));
            }
        }
    }
}
