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
using test.windowsTeor;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Start2.xaml
    /// </summary>
    public partial class Start2 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public int s { get; set; }
        int fon = 0;
        public Start2(int f, int sz)
        {
            InitializeComponent();
            fon = f;
            s = sz;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            if (f==1)
            {
                bg = "#000000";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                bb = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
                fg = "#ffff00";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            }
            else if(f==2)
            {
                bg = "#99ccff";
                PropertyChanged(this, new PropertyChangedEventArgs("bg"));
                bb = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("bb"));
                fg = "#0f6cbf";
                PropertyChanged(this, new PropertyChangedEventArgs("fg"));
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
            fon = 1;
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
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
            new Start().Show();
            this.Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void tem1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Lecsica(fon, s).ShowDialog();
            //this.Close();
        }

        private void tem2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new Predlog2(fon, s).Show();
                this.Close();
            }
            else
            {
                new Predlog(fon, s).Show();
                this.Close();
            }
        }

        private void tem3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //new Times(fon, s).Show();
            //this.Close();
        }

        private void tem4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new Article2(fon, s).Show();
                this.Close();
            }
            else
            {
                new Article(fon, s).Show();
                this.Close();
            }
        }

        private void tem5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new SravPrev2(fon, s).Show();
                this.Close();
            }
            else
            {
                new SravPrev(fon, s).Show();
                this.Close();
            }
        }

        private void tem6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new MuchMany2(fon, s).Show();
                this.Close();
            }
            else
            {
                new MuchMany(fon, s).Show();
                this.Close();
            }
        }

        private void tem7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new Chisl2(fon, s).Show();
                this.Close();
            }
            else
            {
                new Chisl(fon, s).Show();
                this.Close();
            }
        }

        private void tem8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new Mnozh2(fon, s).Show();
                this.Close();
            }
            else
            {
                new Mnozh(fon, s).Show();
                this.Close();
            }
        }

        private void tem9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new SomeAny2(fon, s).Show();
                this.Close();
            }
            else
            {
                new SomeAny(fon, s).Show();
                this.Close();
            }
        }

        private void tem10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new ThisThat2(fon, s).Show();
                this.Close();
            }
            else
            {
                new ThisThat(fon, s).Show();
                this.Close();
            }
        }

        private void tem11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new ToBe2(fon, s).Show();
                this.Close();
            }
            else
            {
                new ToBe(fon, s).Show();
                this.Close();
            }
        }

        private void tem12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new PritMest2(fon, s).Show();
                this.Close();
            }
            else
            {
                new PritMest(fon, s).Show();
                this.Close();
            }
        }

        private void tem13_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new PritPadezh2(fon, s).Show();
                this.Close();
            }
            else
            {
                new PritPadezh(fon, s).Show();
                this.Close();
            }
        }

        private void tem14_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new HaveGot2(fon, s).Show();
                this.Close();
            }
            else
            {
                new HaveGot(fon, s).Show();
                this.Close();
            }
        }

        private void tem15_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new ThereIsThereAre2(fon, s).Show();
                this.Close();
            }
            else
            {
                new ThereIsThereAre(fon, s).Show();
                this.Close();
            }
        }

        private void tem16_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new HaveTo2(fon, s).Show();
                this.Close();
            }
            else
            {
                new HaveTo(fon, s).Show();
                this.Close();
            }
        }

        private void tem19_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fon != 0)
            {
                new Guestion2(fon, s).Show();
                this.Close();
            }
            else
            {
                new Guestion(fon, s).Show();
                this.Close();
            }
        }
    }
}
