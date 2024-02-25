using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PrintDialog = System.Windows.Controls.PrintDialog;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для NewTest.xaml
    /// </summary>
    public partial class NewTest : Window
    {
        public NewTest()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            //var doc = new Document();
            //RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(1240, 1754, 0, 0, PixelFormats.Pbgra32);
            //renderTargetBitmap.Render(Griddd);
            //PngBitmapEncoder pngImage = new PngBitmapEncoder();
            //pngImage.Frames.Add(BitmapFrame.Create(renderTargetBitmap));
            //System.Windows.Forms.FolderBrowserDialog saveFileDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            //if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            //    return;
            //// получаем выбранный файл
            //string filename = saveFileDialog1.SelectedPath;
            //// сохраняем текст в файл
            //System.Windows.MessageBox.Show(filename);
            //byte[] myBytes;
            //using (var memoryStream = new System.IO.MemoryStream())
            //{
            //    pngImage.Save(memoryStream);
            //    myBytes = memoryStream.ToArray();
            //}
            //try
            //{
            //    if(doc==null)
            //    {
            //        System.Windows.MessageBox.Show("опа");
            //    }
            //        PdfWriter.GetInstance(doc, new FileStream(filename + @"\Document.pdf", System.IO.FileMode.Create));

            //                    doc.Open();
            //                    iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(myBytes);
            //                    jpg.Alignment = Element.ALIGN_CENTER;
            //                    doc.Add(jpg);
            //                    doc.Close();
            //}
            //catch
            //{
            //    System.Windows.MessageBox.Show("впереди копы");
            //}

                System.Windows.Controls.PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(Griddd, "Diplom");
                }

        }

        private void del1_Click(object sender, RoutedEventArgs e)
        {
            Cht.Visibility = Visibility.Collapsed;
            Cht1.Visibility = Visibility.Collapsed;
        }

        private void del2_Click(object sender, RoutedEventArgs e)
        {
            LexGram.Visibility = Visibility.Collapsed;
            LexGram1.Visibility = Visibility.Collapsed;
        }

        private void del3_Click(object sender, RoutedEventArgs e)
        {
            Pism.Visibility = Visibility.Collapsed;
            Pism1.Visibility = Visibility.Collapsed;
        }

        private void del4_Click(object sender, RoutedEventArgs e)
        {
            Govor.Visibility = Visibility.Collapsed;
            Govor1.Visibility = Visibility.Collapsed;
        }

        private void del0_Click(object sender, RoutedEventArgs e)
        {
            List.Visibility = Visibility.Collapsed;
            List1.Visibility = Visibility.Collapsed;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
                new Start().Show();
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }
    }
}
