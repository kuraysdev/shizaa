﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace shizaa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Thread(async () => {
                ulong da = 0;
                while (true)
                {
                    
                    da++;
                    
                    Dispatcher.Invoke(() =>
                    {
                        pisya.Text = $"{da}";
                    });
                    await Task.Delay(100);
                }
            }).Start();
        }
    }
}
