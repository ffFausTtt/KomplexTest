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
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int s { get; set; }
        int fon = 0;
        public Start()
        {
            InitializeComponent();
                s = 24;
                PropertyChanged(this, new PropertyChangedEventArgs("s"));
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

        private void newbg_Click(object sender, RoutedEventArgs e)
        {
            fon = 1;
            new Start2(fon,s).Show();
            this.Close();
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            fon = 2;
            new Start2(fon,s).Show();
            this.Close();
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
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            fon = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
