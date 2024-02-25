using iTextSharp.text;
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

namespace test
{
    /// <summary>
    /// Логика взаимодействия для RezultVar1.xaml
    /// </summary>
    public partial class RezultVar1 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Cl1 { get; set; }
        public string Cl2 { get; set; }
        public string Cl3 { get; set; }
        public string Cl4 { get; set; }
        public string Cl5 { get; set; }
        public string Cl6 { get; set; }
        public string Cl7 { get; set; }
        public string Cl8 { get; set; }
        public string Cl9 { get; set; }
        public string Cl10 { get; set; }
        public string Cl11 { get; set; }
        public string Cl12 { get; set; }
        public string Cl13 { get; set; }
        public string fg { get; set; }
        public string bg { get; set; }
        public int s { get; set; }
        public RezultVar1(string[] otv, int fon, int sz)
        {
            InitializeComponent();
            fg = "#000000";
            PropertyChanged(this, new PropertyChangedEventArgs("fg"));
            s = sz;
            PropertyChanged(this, new PropertyChangedEventArgs("s"));
            z1.Text = otv[0];
            z2.Text = otv[1];
            z3.Text = otv[2];
            z4.Text = otv[3];
            z5.Text = otv[4];
            z6.Text = otv[5];
            z7.Text = otv[6];
            z8.Text = otv[7] + ", " + otv[8] + ", " + otv[9] + ", " + otv[10] + ", " + otv[11];
            z9.Text = otv[12];
            z10.Text = otv[13];
            z11.Text = otv[14];
            z12.Text = otv[15];
            z13.Text = otv[16];

            if (fon == 0)
            {
                if (z1.Text != z1otv.Text)
                {
                    Cl1 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl1"));
                }
                else
                {
                    Cl1 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl1"));
                }

                if (z2.Text != z2otv.Text)
                {
                    Cl2 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl2"));
                }
                else
                {
                    Cl2 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl2"));
                }

                if (z3.Text != z3otv.Text)
                {
                    Cl3 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl3"));
                }
                else
                {
                    Cl3 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl3"));
                }

                if (z4.Text != z4otv.Text)
                {
                    Cl4 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl4"));
                }
                else
                {
                    Cl4 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl4"));
                }

                if (z5.Text != z5otv.Text)
                {
                    Cl5 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl5"));
                }
                else
                {
                    Cl5 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl5"));
                }

                if (z6.Text != z6otv.Text)
                {
                    Cl6 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl6"));
                }
                else
                {
                    Cl6 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl6"));
                }

                if (z7.Text != z7otv.Text)
                {
                    Cl7 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl7"));
                }
                else
                {
                    Cl7 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl7"));
                }

                if (z8.Text != z8otv.Text)
                {
                    Cl8 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl8"));
                }
                else
                {
                    Cl8 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl8"));
                }

                if (z9.Text != z9otv.Text)
                {
                    Cl9 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl9"));
                }
                else
                {
                    Cl9 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl9"));
                }

                if (z10.Text != z10otv.Text)
                {
                    Cl10 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl10"));
                }
                else
                {
                    Cl10 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl10"));
                }

                if (z11.Text != z11otv.Text)
                {
                    Cl11 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl11"));
                }
                else
                {
                    Cl11 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl11"));
                }

                if (z12.Text != z12otv.Text)
                {
                    Cl12 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl12"));
                }
                else
                {
                    Cl12 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl12"));
                }

                if (z13.Text != z13otv.Text)
                {
                    Cl13 = "#FFE06868";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl13"));
                }
                else
                {
                    Cl13 = "#FFB1E664";
                    PropertyChanged(this, new PropertyChangedEventArgs("Cl13"));
                }
            }
            else
            {
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
            int mark = calcBonusesVarOne(otv);
            marktxt.Text = mark.ToString();
        }
        public static int calcBonusesVarOne(string[] otv)
        {
            int mark = 0;
            if (otv[0] == "Pizza")
            {
                mark += 1;
            }
            if (otv[1] == "could read in English")
            {
                mark += 1;
            }
            if (otv[2] == "every week")
            {
                mark += 1;
            }
            if (otv[3] == "write a book")
            {
                mark += 1;
            }
            if (otv[4] == "True")
            {
                mark += 1;
            }
            if (otv[5] == "False")
            {
                mark += 1;
            }
            if (otv[6] == "True")
            {
                mark += 1;
            }
            if (otv[7] + ", " + otv[8] + ", " + otv[9] + ", " + otv[10] + ", " + otv[11] == "weather, Pizza, book, interesting, happy")
            {
                mark += 2;
            }
            if (otv[12] == "better")
            {
                mark += 1;
            }
            if (otv[13] == "-")
            {
                mark += 1;
            }
            if (otv[14] == "wrote")
            {
                mark += 1;
            }
            if (otv[15] == "was")
            {
                mark += 1;
            }
            if (otv[16] == "Does")
            {
                mark += 1;
            }
            return mark;
        }
    }
}
