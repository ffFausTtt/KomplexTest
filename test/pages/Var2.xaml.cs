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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace test.pages
{
    /// <summary>
    /// Логика взаимодействия для Var2.xaml
    /// </summary>
    public partial class Var2 :Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public string img { get; set; }
        public int s { get; set; }

        int fon = 0;
        public Var2()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = _interval;
            _timer.Tick += delegate
            {
                var now = DateTime.Now;
                var elapsed = now.Subtract(_startCountdown);
                TimeToEnd = _startTimeSpan.Subtract(elapsed);
            };
            StopTimer();
            InitializeComponent();
            StartTimer(DateTime.Now);
            bb = "#FFFF8000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img = "/img/голос.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
        }
        private MediaPlayer player = new MediaPlayer();
        public string[] otv = new string[22];
        private void Chack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            int prov = 0;
            try
            {
                if (z1v1.Text == "A")
                {
                    otv[0] = "A";
                }
                else if (z1v1.Text == "B")
                {
                    otv[0] = "B";
                }
                else if (z1v1.Text == "C")
                {
                    otv[0] = "C";
                }
                else if (z1v1.Text == "D")
                {
                    otv[0] = "D";
                }
                else if (z1v1.Text == "")
                {
                    otv[0] = " ";
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 8.");
                }

                if (z1v2.Text == "A")
                {
                    otv[1] = "A";
                }
                else if (z1v2.Text == "B")
                {
                    otv[1] = "B";
                }
                else if (z1v2.Text == "C")
                {
                    otv[1] = "C";
                }
                else if (z1v2.Text == "D")
                {
                    otv[1] = "D";
                }
                else if (z1v2.Text == "")
                {
                    otv[1] = " ";
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 8.");
                }

                if (z1v3.Text == "A")
                {
                    otv[2] = "A";
                }
                else if (z1v3.Text == "B")
                {
                    otv[2] = "B";
                }
                else if (z1v3.Text == "C")
                {
                    otv[2] = "C";
                }
                else if (z1v3.Text == "D")
                {
                    otv[2] = "D";
                }
                else if (z1v3.Text == "")
                {
                    otv[2] = " ";
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 8.");
                }

                if (z1v4.Text == "A")
                {
                    otv[3] = "A";
                }
                else if (z1v4.Text == "B")
                {
                    otv[3] = "B";
                }
                else if (z1v4.Text == "C")
                {
                    otv[3] = "C";
                }
                else if (z1v4.Text == "D")
                {
                    otv[3] = "D";
                }
                else if (z1v4.Text == "")
                {
                    otv[3] = " ";
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 8.");
                }

               

                if (z2v1.IsChecked == true)
                {
                    otv[4] = z2v1.Content.ToString();
                }
                else if (z2v2.IsChecked == true)
                {
                    otv[4] = z2v2.Content.ToString();
                }

                if (z3v1.IsChecked == true)
                {
                    otv[5] = z3v1.Content.ToString();
                }
                else if (z3v2.IsChecked == true)
                {
                    otv[5] = z3v2.Content.ToString();
                }

                if (z4v1.IsChecked == true)
                {
                    otv[6] = z4v1.Content.ToString();
                }
                else if (z4v2.IsChecked == true)
                {
                    otv[6] = z4v2.Content.ToString();
                }

                if (z5v1.IsChecked == true)
                {
                    otv[7] = z5v1.Content.ToString();
                }
                else if (z5v2.IsChecked == true)
                {
                    otv[7] = z5v2.Content.ToString();
                }

                if (z6v1.IsChecked == true)
                {
                    otv[8] = z6v1.Content.ToString();
                }
                else if (z6v2.IsChecked == true)
                {
                    otv[8] = z6v2.Content.ToString();
                }

                if(Regex.IsMatch(z7v1.Text, @"^[a-zA-Z]+$") || z7v1.Text == "")
                {
                    otv[9] = z7v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 7.");
                }
                if (Regex.IsMatch(z7v2.Text, @"^[a-zA-Z]+$") || z7v2.Text == "")
                {
                    otv[10] = z7v2.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 7.");
                }
                if (Regex.IsMatch(z7v3.Text, @"^[a-zA-Z]+$") || z7v3.Text == "")
                {
                    otv[11] = z7v3.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 7.");
                }
                if (Regex.IsMatch(z7v4.Text, @"^[a-zA-Z]+$") || z7v4.Text == "")
                {
                    otv[12] = z7v4.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 7.");
                }
                if (Regex.IsMatch(z7v5.Text, @"^[a-zA-Z]+$") || z7v5.Text == "")
                {
                    otv[13] = z7v5.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 7.");
                }

                if (z8v1.IsChecked == true)
                {
                    otv[14] = z8v1.Content.ToString();
                }
                else if (z8v2.IsChecked == true)
                {
                    otv[14] = z8v2.Content.ToString();
                }
                if (z9v1.IsChecked == true)
                {
                    otv[15] = z9v1.Content.ToString();
                }
                else if (z9v2.IsChecked == true)
                {
                    otv[15] = z9v2.Content.ToString();
                }
                if (z10v1.IsChecked == true)
                {
                    otv[16] = z10v1.Content.ToString();
                }
                else if (z10v2.IsChecked == true)
                {
                    otv[16] = z10v2.Content.ToString();
                }
                if (z11v1.IsChecked == true)
                {
                    otv[17] = z11v1.Content.ToString();
                }
                else if (z11v2.IsChecked == true)
                {
                    otv[17] = z11v2.Content.ToString();
                }
                if (z12v1.IsChecked == true)
                {
                    otv[18] = z12v1.Content.ToString();
                }
                else if (z12v2.IsChecked == true)
                {
                    otv[18] = z12v2.Content.ToString();
                }

                if(Regex.IsMatch(z13v1.Text, @"^[a-zA-Z.]+$") || z13v1.Text == "")
                {
                    otv[19] = z13v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 13.");
                }
                if (Regex.IsMatch(z14v1.Text, @"^[a-zA-Z.]+$") || z14v1.Text=="")
                {
                    otv[20] = z14v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 14.");
                }
                if (Regex.IsMatch(z15v1.Text, @"^[a-zA-Z.]+$") || z15v1.Text == "")
                {
                    otv[21] = z15v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 15.");
                }
               
                prov = 1;
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
                prov = 0;
            }
            if (prov == 1)
            {
                new RezultVar2(otv, fon, s).ShowDialog();
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

            img = "/img/голос желтый.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img"));

            fon = 1;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path = @".\voice";
            string s = System.IO.Path.GetFullPath(path) + @"\вариант 2 задание 1.mp3";
            s = s.Replace(@"\bin\Debug", "");
            player.Open(new Uri(s, UriKind.Relative));
            player.Play();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string path = @".\voice";
            string s = System.IO.Path.GetFullPath(path) + @"\вариант 2 задание 2.mp3";
            s = s.Replace(@"\bin\Debug", "");
            player.Open(new Uri(s, UriKind.Relative));
            player.Play();
        }

        private void newbg2_Click(object sender, RoutedEventArgs e)
        {
            bg = "#99ccff";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));

            bb = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));

            fg = "#0f6cbf";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));

            img = "/img/голос синий.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img"));

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
            bg = "#FFFFFF";
            PropertyChanged(this, new PropertyChangedEventArgs("bg"));
            bb = "#FFFF8000";
            PropertyChanged(this, new PropertyChangedEventArgs("bb"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img = "/img/голос.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img"));
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            fon = 0;
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            if (fon == 0)
            {
                new Start().Show();
            }
            else
            {
                new Start2(fon, s).Show();
            }
            foreach (Window window in App.Current.Windows)
            {
                if (window.Title == "YourTask")
                    window.Close();
            }
        }
        private DateTime _startCountdown; // время запуска таймера
        private TimeSpan _startTimeSpan = TimeSpan.FromMinutes(20); // начальное время до окончания таймера
        private TimeSpan _timeToEnd; // время до окончания таймера. Меняется когда таймер запущен
        private TimeSpan _interval = TimeSpan.FromMilliseconds(15); // интервал таймера


        private DispatcherTimer _timer;


        public TimeSpan TimeToEnd
        {
            get
            {
                return _timeToEnd;
            }

            set
            {
                _timeToEnd = value;
                if (value.TotalMilliseconds <= 0)
                {
                    StopTimer();
                    new RezultVar1(otv, fon, s).ShowDialog();
                }

                OnPropertyChanged("StringCountdown");
            }
        }

        public string StringCountdown
        {
            get
            {
                var frmt = TimeToEnd.Minutes < 1 ? "ss\\.ff" : "mm\\:ss";
                return _timeToEnd.ToString(frmt);
            }
        }

        public bool TimerIsEnabled
        {
            get { return _timer.IsEnabled; }
        }

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void StopTimer()
        {
            if (TimerIsEnabled)
                _timer.Stop();
            TimeToEnd = _startTimeSpan;
        }

        private void StartTimer(DateTime sDate)
        {
            _startCountdown = sDate;
            _timer.Start();
        }
        private void var_Click_1(object sender, RoutedEventArgs e)
        {
            player.Stop();
            new MainWindow().Show();
            foreach (Window window in App.Current.Windows)
            {
                if (window.Title == "YourTask")
                    window.Close();
            }
        }
    }
}
