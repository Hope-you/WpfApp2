using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp2
{
    public class Command1ViewModel
    {
        public MyCommad1Commad ShowCommand { get; set; }

        public Command1ViewModel()
        {
            ShowCommand = new MyCommad1Commad(Show);
        }
        public void Show()
        {
            MessageBox.Show("点击了按钮");
        }
    }

    /// <summary>
    /// 通过ICommand给界面添加事件
    /// </summary>
    public class MyCommad1Commad : ICommand
    {
        Action executeAction;
        public MyCommad1Commad(Action action)
        {
            executeAction = action;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeAction();
        }
    }
}
