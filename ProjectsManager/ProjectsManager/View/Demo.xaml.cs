﻿using System;
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

namespace ProjectsManager
{
    /// <summary>
    /// Interaction logic for Demo.xaml
    /// </summary>
    public partial class Demo : Window
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdvisorMainMeeting stMain = new AdvisorMainMeeting();
            stMain.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdvisorMain amMain = new AdvisorMain();
            amMain.Show();
        }
    }
}
