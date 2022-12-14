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
    /// DataTemp.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemp : Window
    {
        public DataTemp()
        {
            InitializeComponent();
            List<Color> list = new List<Color>();
            list.Add(new Color { index = 0, code = "#cc434d" });
            list.Add(new Color { index = 1, code = "#006cbe" });
            list.Add(new Color { index = 2, code = "#a7691f" });
            list.Add(new Color { index = 3, code = "#ef7b15" });
            list.Add(new Color { index = 4, code = "#26bb5f" });
            grid.ItemsSource = lsDataTemp.ItemsSource = list;
        }
        public class Color
        {
            public int index { get; set; }
            public string code { get; set; }
        }
    }
}
