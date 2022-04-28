using System;
using System.Collections.Generic;
using System.Text;
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

namespace CLOCKCONTYL
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        int hour = 0;
        int minute = 0;
        int second = 0;
        double hAngle = 0;
        int mAngle = 0;
        int sAngle = 0;
        RotateTransform mTransform = new RotateTransform(0);
        RotateTransform hTransform = new RotateTransform(0);
        RotateTransform sTransform = new RotateTransform(0);
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public Clock()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            InitializeComponent();
            setTime();
        }
        void setTime()
        {
            setHour();
            setMin();
            setSec();
        }
        void setHour()
        {
            hour = DateTime.Now.Hour;
            hAngle = (hour * 30) + minute / 2;
            hTransform = new RotateTransform(hAngle);
            hourStick.RenderTransform = hTransform;
        }
        void setMin()
        {
            minute = DateTime.Now.Minute;
            mAngle = minute * 6;
            mTransform = new RotateTransform(mAngle);
            minuteStick.RenderTransform = mTransform;
        }
        
        void setSec()
        {
            second = DateTime.Now.Second;
            sAngle = second * 6;
            sTransform = new RotateTransform(sAngle);
            secondStick.RenderTransform = sTransform;
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            setTime();
            CommandManager.InvalidateRequerySuggested();
        }
        //public int Hours
        //{
        //    get { return hour; }
        //    set
        //    {
        //        if (value < 24 && value >= 0)
        //        {
        //            hour = value;
        //            setHour();
        //        }
        //    }
        //}
        //public int Minutes
        //{
        //    get { return minute; }
        //    set
        //    {
        //        if (value < 60 && value >= 0)
        //        {
        //            minute = value;
        //            setTime();
        //        }
        //    }
        //}
    }
}
