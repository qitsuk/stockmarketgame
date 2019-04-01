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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StockMarketGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameWindow gw;
        HowTo ht;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewGame_button_Click(object sender, RoutedEventArgs e)
        {
            gw = new GameWindow(new Engine());
            gw.Show();
            Close();
        }

        private void HowToPlay_button_Click(object sender, RoutedEventArgs e)
        {
            ht = new HowTo();
            ht.Show();
        }
    }
}
