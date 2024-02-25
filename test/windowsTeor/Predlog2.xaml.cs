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
    /// Логика взаимодействия для Predlog2.xaml
    /// </summary>
    public partial class Predlog2 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string vs1 { get; set; }
        public string vs2 { get; set; }
        public string vs3 { get; set; }
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string img4 { get; set; }
        public string img5 { get; set; }
        public string img6 { get; set; }
        public string img7 { get; set; }
        public string img8 { get; set; }
        public int s { get; set; }
        int fon;
        public Predlog2(int f, int sz)
        {
            InitializeComponent();
            fon = f;
            s = sz;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            vib.SelectedIndex = 0;
            if (f == 1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                bb = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                img1 = "/img/inЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img1"));
                img2 = "/img/onЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img2"));
                img3 = "/img/underЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img3"));
                img4 = "/img/next toЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img4"));
                img5 = "/img/in front ofЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img5"));
                img6 = "/img/behindЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img6"));
                img7 = "/img/oppositeЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img7"));
                img8 = "/img/betweenЖ.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            }
            else if (f == 2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                fg = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
                bb = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
                img1 = "/img/inС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img1"));
                img2 = "/img/onС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img2"));
                img3 = "/img/underС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img3"));
                img4 = "/img/next toС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img4"));
                img5 = "/img/in front ofС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img5"));
                img6 = "/img/behindС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img6"));
                img7 = "/img/oppositeС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img7"));
                img8 = "/img/betweenС.png";
                PropertyChanged(this, new PropertyChangedEventArgs("img8"));
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
            img1 = "/img/inЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img1"));
            img2 = "/img/onЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img2"));
            img3 = "/img/underЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img3"));
            img4 = "/img/next toЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img4"));
            img5 = "/img/in front ofЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img5"));
            img6 = "/img/behindЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img6"));
            img7 = "/img/oppositeЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img7"));
            img8 = "/img/betweenЖ.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img8"));
            bb = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fon = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img1 = "/img/inС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img1"));
            img2 = "/img/onС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img2"));
            img3 = "/img/underС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img3"));
            img4 = "/img/next toС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img4"));
            img5 = "/img/in front ofС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img5"));
            img6 = "/img/behindС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img6"));
            img7 = "/img/oppositeС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img7"));
            img8 = "/img/betweenС.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img8"));
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
            new Predlog(fon,s).Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new PredlogTask(fon, s).Show();
            this.Close();
        }

        private void vib_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (vib.SelectedIndex)
            {
                case 0:
                    vs3 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    break;
                case 1:
                    vs1 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    vs2 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    break;
                case 2:
                    vs3 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs3"));
                    vs2 = "Visible";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs2"));
                    vs1 = "Collapsed";
                    PropertyChanged(this, new PropertyChangedEventArgs("vs1"));
                    break;
            }
        }
    }
}
