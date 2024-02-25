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
using test.windowsRez;

namespace test.pages
{
    /// <summary>
    /// Логика взаимодействия для Var3.xaml
    /// </summary>
    public partial class Var3 : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string bg { get; set; }
        public string bb { get; set; }
        public string fg { get; set; }
        public string img { get; set; }

        public int s { get; set; }

        int fon = 0;

        public Var3()
        {
            _timer = new DispatcherTimer();
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
            s = 24;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            img = "/img/голос.png";
            PropertyChanged(this, new PropertyChangedEventArgs("img"));
        }
        private MediaPlayer player = new MediaPlayer();
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path = @".\voice";
            string s = System.IO.Path.GetFullPath(path) + @"\вариант 3.mp3";
            s = s.Replace(@"\bin\Debug", "");
            player.Open(new Uri(s, UriKind.Relative));
            player.Play();
        }
        public string[] otv = new string[26];
        private void Chack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            int prov = 0;
            try
            {
                if (z1v3.IsChecked == true)
                {
                    otv[0] = z1v3.Content.ToString();
                }
                if (z1v2.IsChecked == true)
                {
                    otv[1] = z1v2.Content.ToString();
                }
                if (z1v4.IsChecked == true)
                {
                    otv[2] = z1v4.Content.ToString();
                }
                if (z1v5.IsChecked == true)
                {
                    otv[3] = z1v5.Content.ToString();
                }
                if (z1v6.IsChecked == true)
                {
                    otv[4] = z1v6.Content.ToString();
                }
                if (z1v7.IsChecked == true)
                {
                    otv[5] = z1v7.Content.ToString();
                }
                if (z1v8.IsChecked == true)
                {
                    otv[6] = z1v8.Content.ToString();
                }
                if (z1v1.IsChecked == true)
                {
                    otv[7] = z1v1.Content.ToString();
                }


                if (z2v1.IsChecked == true)
                {
                    otv[8] = z2v1.Content.ToString();
                }
                else if (z2v2.IsChecked == true)
                {
                    otv[8] = z2v2.Content.ToString();
                }

                if (z3v1.IsChecked == true)
                {
                    otv[9] = z3v1.Content.ToString();
                }
                else if (z3v2.IsChecked == true)
                {
                    otv[9] = z3v2.Content.ToString();
                }

                if (z4v2.IsChecked == true)
                {
                    otv[10] = z4v2.Content.ToString();
                }
                else if (z4v1.IsChecked == true)
                {
                    otv[10] = z4v1.Content.ToString();
                }

                if (z5v1.IsChecked == true)
                {
                    otv[11] = z5v1.Content.ToString();
                }
                else if (z5v2.IsChecked == true)
                {
                    otv[11] = z5v2.Content.ToString();
                }

                if (z6v1.IsChecked == true)
                {
                    otv[12] = z6v1.Content.ToString();
                }
                else if (z6v2.IsChecked == true)
                {
                    otv[12] = z6v2.Content.ToString();
                }

                if (z7v1.IsChecked == true)
                {
                    otv[13] = z7v1.Content.ToString();
                }
                else if (z7v2.IsChecked == true)
                {
                    otv[13] = z7v2.Content.ToString();
                }
                else if(z7v3.IsChecked == true)
                {
                    otv[13] = z7v3.Content.ToString();
                }
                else if (z7v4.IsChecked == true)
                {
                    otv[13] = z7v4.Content.ToString();
                }

                if (z8v1.IsChecked == true)
                {
                    otv[14] = z8v1.Content.ToString();
                }
                else if (z8v2.IsChecked == true)
                {
                    otv[14] = z8v2.Content.ToString();
                }
                else if (z8v3.IsChecked == true)
                {
                    otv[14] = z8v3.Content.ToString();
                }
                else if (z8v4.IsChecked == true)
                {
                    otv[14] = z8v4.Content.ToString();
                }

                if (z9v1.IsChecked == true)
                {
                    otv[15] = z9v1.Content.ToString();
                }
                else if (z9v2.IsChecked == true)
                {
                    otv[15] = z9v2.Content.ToString();
                }
                else if (z9v3.IsChecked == true)
                {
                    otv[15] = z9v3.Content.ToString();
                }
                else if (z9v4.IsChecked == true)
                {
                    otv[15] = z9v4.Content.ToString();
                }

                if (z10v1.IsChecked == true)
                {
                    otv[16] = z10v1.Content.ToString();
                }
                else if (z10v2.IsChecked == true)
                {
                    otv[16] = z10v2.Content.ToString();
                }
                else if (z10v3.IsChecked == true)
                {
                    otv[16] = z10v3.Content.ToString();
                }
                else if (z10v4.IsChecked == true)
                {
                    otv[16] = z10v4.Content.ToString();
                }

                if (z11v1.IsChecked == true)
                {
                    otv[15] = z11v1.Content.ToString();
                }
                else if (z11v2.IsChecked == true)
                {
                    otv[15] = z11v2.Content.ToString();
                }
                else if (z11v3.IsChecked == true)
                {
                    otv[15] = z11v3.Content.ToString();
                }
                else if (z11v4.IsChecked == true)
                {
                    otv[15] = z11v4.Content.ToString();
                }
                if (Regex.IsMatch(z12v1.Text, @"^[a-zA-Z]+$") || z12v1.Text == "")
                {
                    otv[18] = z12v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 12.");
                }
                if (Regex.IsMatch(z13v1.Text, @"^[a-zA-Z]+$") || z13v1.Text == "")
                {
                    otv[19] = z13v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 13.");
                }
                if (Regex.IsMatch(z14v1.Text, @"^[a-zA-Z]+$") || z14v1.Text == "")
                {
                    otv[20] = z14v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 14.");
                }
                if (Regex.IsMatch(z15v1.Text, @"^[a-zA-Z]+$") || z15v1.Text == "")
                {
                    otv[21] = z15v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 15.");
                }
                if (Regex.IsMatch(z16v1.Text, @"^[a-zA-Z]+$") || z16v1.Text == "")
                {
                    otv[22] = z16v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 16.");
                }
                if (Regex.IsMatch(z17v1.Text, @"^[a-zA-Z]+$") || z17v1.Text == "")
                {
                    otv[23] = z17v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 17.");
                }
                if (Regex.IsMatch(z18v1.Text, @"^[a-zA-Z]+$") || z18v1.Text == "")
                {
                    otv[24] = z18v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 18.");
                }
                if (Regex.IsMatch(z19v1.Text, @"^[a-zA-Z]+$") || z19v1.Text == "")
                {
                    otv[25] = z19v1.Text;
                }
                else
                {
                    throw new Exception("Неверный формат данных в задании 19.");
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
                new RezultVar3(otv, fon, s).ShowDialog();
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

        private void var_Click(object sender, RoutedEventArgs e)
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
