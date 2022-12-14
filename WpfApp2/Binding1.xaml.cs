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

namespace WpfApp2
{
    /// <summary>
    /// Binding1.xaml 的交互逻辑
    /// </summary>
    public partial class Binding1 : Window
    {
        public Binding1()
        {
            InitializeComponent();
            this.DataContext = new obj { Name = "张三", sliderValue = 5f };
        }

        private void slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {


            Console.WriteLine(((dynamic)DataContext).sliderValue);
        }
    }
    public class obj
    {
        public string Name { get; set; }
        public float sliderValue { get; set; }
    }
}
