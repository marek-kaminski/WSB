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

namespace wyszukiwarka
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void textbox2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            {
                if (textbox1.Text == "")
                {
                    label2.Content = "";
                }
                else
                {

                    if (textbox2.Text.Contains(textbox1.Text))
                    {
                        label2.Content = $"znaleziono {textbox1.Text}";
                    }

                    else
                    {
                        label2.Content = "nie znaleziono";
                    }
                }
            }
        }
    }
}
