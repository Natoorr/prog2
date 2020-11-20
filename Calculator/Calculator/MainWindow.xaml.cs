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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelfButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                CalcField.Text += button.Content;
            }
        }

        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            CalcField.Text += "*";
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            CalcField.Text += "/";
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            CalcField.Text = CalcField.Text.Substring(0, CalcField.Text.Length - 1);
        }
    }
}
