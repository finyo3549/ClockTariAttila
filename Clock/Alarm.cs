using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Alarm
    {
        public int AlarmHour {  get; set; }
        public int AlarmMinute { get; set; }
        public bool IsAlarmOn { get; set; }

        public Alarm(int alarmHour, int alarmMinute, bool isAlarmOn)
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            IsAlarmOn = isAlarmOn;
        }
        public void SetAlarm(int hour, int minute)
        {
            AlarmHour = hour;
            AlarmMinute = minute;
        }

        public void TurnOnAlarm()
        {
            IsAlarmOn = true;
        }
        public void TurnOffAlarm() { IsAlarmOn = false; }
        public bool IsAlarmTime(int hour, int minute)
        {
            if (AlarmHour < hour)
            {
                return true;
            }
            if  (AlarmHour == hour) {

                if (AlarmMinute <= minute)
                {
                    return true;
                }
            }
             return false; 
  
            }
        }
    }


