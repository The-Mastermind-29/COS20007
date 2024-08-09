using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1P_Clock_Class
{
    public class Clock
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Clock()
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;
        }

        public void Tick()
        {
            if (_seconds == 59)
            {
                _seconds = 0;
                if (_minutes == 59)
                {
                    _minutes = 0;
                    _hours++;
                }
                else
                {
                    _minutes++;
                }
            }
            else
            {
                _seconds++;
            }
        }

        public void Reset()
        {
            _hours = 0;
            _minutes = 0;
            _seconds = 0;
        }

        public string Time
        {
            get
            {
                return _hours.ToString("00") + ":" + _minutes.ToString("00") + ":" + _seconds.ToString("00");
            }
        }
    }
}
