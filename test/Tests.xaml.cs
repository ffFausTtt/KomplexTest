using System;
using System.Collections.Generic;
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
using test.pages;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для Tests.xaml
    /// </summary>
    public partial class Tests : Window
    {
        public Tests(int ind)
        {
            InitializeComponent();
            if(ind == 1)
            {
                MainFraim.Navigate(new Var1());
                ChangePages.ChangedPages = MainFraim;
            }
            else if (ind == 2)
            {
                MainFraim.Navigate(new Var2());
                ChangePages.ChangedPages = MainFraim;
            }
            else if (ind == 3)
            {
                MainFraim.Navigate(new Var3());
                ChangePages.ChangedPages = MainFraim;
            }
            else if (ind == 4)
            {
                MainFraim.Navigate(new Var4());
                ChangePages.ChangedPages = MainFraim;
            }
            else
            {
                MainFraim.Navigate(new Var5());
                ChangePages.ChangedPages = MainFraim;
            }
        }
    }
}
