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
using Toolsbox.ShuntingYard;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShuntingYardSimpleMath SY = new ShuntingYardSimpleMath();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelfButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                CalcField.Text += button.Content + " ";
            }
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                Double hey;
                if (CalcField.Text.Length > 1 && Double.TryParse(CalcField.Text[CalcField.Text.Length - 2] + "", out hey))
                {
                    CalcField.Text = CalcField.Text.Substring(0, CalcField.Text.Length - 1);
                    CalcField.Text += button.Content + " ";

                } else
                {
                    CalcField.Text += button.Content + " ";
                }
                
            }
        }

        private void MultiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            CalcField.Text += "* ";
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            CalcField.Text += "/ ";
        }

        private void Off_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (CalcField.Text.Length > 0)
            {
                CalcField.Text = CalcField.Text.Substring(0, CalcField.Text.Length - 2);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (CalcField.Text.Length > 0)
            {
                CalcField.Text = CalcField.Text.Substring(0, CalcField.Text.Length - CalcField.Text.Length);
            }
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            var text = CalcField.Text.Trim();
            
            List<String> ss = text.Split(' ').ToList();
            Double res = SY.Execute(ss, null);
            CalcField.Text = res + " ";


        }
    }
}

    /*
 * Copyright 2012 Søren Gullach
 * 
 * This code is written by Søren Gullach
 * mail code@toolsbox.dk
 * Web www.toolsbox.dk
 * 
 * Ver. 1.1
 * */

