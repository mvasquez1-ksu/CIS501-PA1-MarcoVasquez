using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CIS501_PA1_MarcoVasquez
{
    public class Alarm
    {
        private DateTime time { get; set; }

        private bool on { get; set; }

        private bool wentOff { get; set; }

        private System.Timers.Timer timer { get; set; }

        private EventHandler alarmEvent;

        public Alarm(DateTime time, bool on)
        {
            this.time = time;
            this.on = on;
            this.wentOff = false;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timerElapsed;
            timer.Start();
        }

        private void timerElapsed(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;
            if (on && now.Hour == time.Hour && now.Minute == time.Minute && now.Second == time.Second)
            {
                //on = false;
                if (alarmEvent != null)
                {
                    alarmEvent(this, EventArgs.Empty);
                }
                this.wentOff = true;
            }
        }

        public event EventHandler AlarmEvent
        {
            add
            {
                alarmEvent += value;
            }
            remove
            {
                alarmEvent -= value;
            }
        }

        public System.Timers.Timer Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
            }
        }

        public bool WentOff
        {
            get
            {
                return wentOff;
            }
        }

        public string Time
        {
            get
            {
                return time.ToString("hh:mm tt");
            }
        }

        public string LongTime
        {
            get
            {
                return time.ToString("hh:mm:ss tt");
            }
        }


        public bool On
        {
            get
            {
                return this.on;
            }
        }

        public string OnString
        {
            get
            {
                if (this.on)
                {
                    return "On";
                }
                else
                {
                    return "Off";
                }
            }
        }

        public string alarmString
        {
            get
            {
                return Time + " " + OnString;
            }
        }

        public string alarmStringLong
        {
            get
            {
                return LongTime + " " + OnString;
            }
        }

        public void setTime(DateTime t)
        {
            time = t;
        }

        public void setOnOff(bool o)
        {
            on = o;
            if (on)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        public void setWentOff(bool o)
        {
            wentOff = o;
        }

        public void snooze()
        {
            time = DateTime.Now;
            time.AddSeconds(3);
        }
    }
}
