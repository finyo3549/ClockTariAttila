using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Hozz létre egy Clock példányt a következő paraméterekkel:

            Aktuális óra: 12
            Aktuális perc: 30
            Aktuális másodperc: 45
            Időzóna: "UTC+2"
            Időformátum: 24 órás*/
            Clock ora = new Clock(12, 30, 45, "UTC+2", true);

            /*
             * Hozz létre egy List<Alarm> listát az ébresztések tárolásához. Adj hozzá legalább két ébresztést a listához a következő paraméterekkel:

            Ébresztés 1: óra: 6, perc: 0
            Ébresztés 2: óra: 8, perc: 0*/
            List<Alarm> alarms = new List<Alarm>();
            Alarm alarm1 = new Alarm(1, 6, true);
            Alarm alarm2 = new Alarm(2, 8, true);
            alarms.Add(alarm1);
            alarms.Add(alarm2);

            /* Hozz létre egy Timer példányt a következő paraméterekkel:

            Időzítő időtartama: 10 másodperc*/
            
            Timer idozito = new Timer(10);
            
            //Kiírja az aktuális időt a konzolra a myClock.DisplayTime() metódussal.

            ora.DisplayTime();
            /*
             * Ellenőrizze az ébresztéseket a következőképpen:

            Menjen végig a alarms listán lévő ébresztéseken.
            Használja a IsAlarmTime metódust, hogy ellenőrizze, hogy elérkezett-e az ébresztési idő a jelenlegi óra és perc alapján.
            Ha egy ébresztés ideje elérkezett, írja ki a konzolra "Az ébresztő megszólalt!" üzenettel.*/

            foreach (Alarm alarm in alarms)
            {
                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                if (alarm.IsAlarmTime(hour,minute))
                {
                    Console.WriteLine($"{alarm.AlarmHour}:{alarm.AlarmMinute}: az ébresztés megszólalt!");
                }
            }
            //Indítsa el az időzítőt a myTimer.StartTimer() metódussal. Az időzítő visszaszámlál a beállított időig, és közben kiírja az eltelt időt a konzolra.
            idozito.StartTimer();


            Console.ReadLine();
        }
    }
}
