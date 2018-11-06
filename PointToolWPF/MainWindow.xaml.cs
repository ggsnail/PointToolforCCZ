using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointToolWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string bgPic;
        public MainWindow()
        {
            InitializeComponent();
            drawing();
        }
        
        private void MenuItem_Click_File(object sender, RoutedEventArgs e)
        {

        }

        private void Click_OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.jpg";
            ofd.Filter = "jpg图片(.jpg)|*.jpg";
            if(ofd.ShowDialog() == true)
            {
                bgPic = ofd.FileName;
                Uri uri = new Uri(bgPic);
                BitmapImage bitmap = new BitmapImage(uri);
                mmap.Source = bitmap;
                //drawing();
            }
        }

        private void Click_SavePoint(object sender, RoutedEventArgs e)
        {

        }
        private void Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void MenuItem_Click_Edit(object sender, RoutedEventArgs e)
        {

        }

        private void drawing()
        {
            for (int i = 0; i < 100; i++)
            {
                Line myLine = new Line();
                myLine.Stroke = System.Windows.Media.Brushes.Black;
                myLine.Fill = System.Windows.Media.Brushes.Black;
                myLine.X1 = 0 + 8 * i;
                myLine.Y1 = 400 + 4 * i;
                myLine.X2 = 800 + 8 * i;
                myLine.Y2 = 4 * i;
                mainGrid.Children.Add(myLine);
            }
            for (int i = 0; i < 100; i++)
            {
                Line myLine2 = new Line();
                myLine2.Stroke = System.Windows.Media.Brushes.Black;
                myLine2.Fill = System.Windows.Media.Brushes.Black;
                myLine2.X1 = 8 * i;
                myLine2.Y1 = 400 - 4 * i;
                myLine2.X2 = 800 + 8 * i;
                myLine2.Y2 = 800 - 4 * i;
                mainGrid.Children.Add(myLine2);
            }
            mainGrid.Visibility = Visibility.Hidden;
        }
        private void Click_Undo(object sender, RoutedEventArgs e)
        {

        }
        private void Click_Redo(object sender, RoutedEventArgs e)
        {

        }
        private void Click_Help(object sender, RoutedEventArgs e)
        {

        }
        private void Click_About(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click_Help(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_Grid(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Open_Grid(object sender, RoutedEventArgs e)
        {
            mainGrid.Visibility = Visibility.Visible;
        }

        private void Click_Close_Grid(object sender, RoutedEventArgs e)
        {
            mainGrid.Visibility = Visibility.Hidden;
        }
    }
}
