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

namespace WpfApp2
{
    /// <summary>
    /// Commad1.xaml 的交互逻辑
    /// </summary>
    public partial class Command1 : Window
    {
        public Command1()
        {
            InitializeComponent();
            this.DataContext = new Command1ViewModel();
        }
    }
}
