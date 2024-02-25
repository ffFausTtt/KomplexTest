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
    /// Логика взаимодействия для AAn.xaml
    /// </summary>
    public partial class AAn : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string vsmest { get; set; }
        public string bg { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int f;
        public AAn(int fon, int sz)
        {
            InitializeComponent();
            vsmest = "Collapsed";
            PropertyChanged(this, new PropertyChangedEventArgs("vsmest"));
            s = sz;
            f = fon;
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
            vsmest = "Visible";
            PropertyChanged(this, new PropertyChangedEventArgs("vsmest"));
        }
    }
}
