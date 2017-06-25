using System;
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
using System.Windows.Threading;
namespace clock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public MainWindow()
        {
            InitializeComponent();
            year.Content = System.DateTime.Now.Year;
            month.Content = System.DateTime.Now.Month;
            day.Content = System.DateTime.Now.Day;
            hour.Content = System.DateTime.Now.Hour;
            minute.Content = System.DateTime.Now.Minute;
            second.Content = System.DateTime.Now.Second;
            weekday.Content = System.DateTime.Now.DayOfWeek;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //UI异步更新
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
            {
                year.Content = System.DateTime.Now.Year;
                month.Content = System.DateTime.Now.Month;
                day.Content = System.DateTime.Now.Day;
                hour.Content = System.DateTime.Now.Hour;
                minute.Content = System.DateTime.Now.Minute;
                second.Content = System.DateTime.Now.Second;
                weekday.Content = System.DateTime.Now.DayOfWeek;
              
            }));



        }
    }
}
        
    

