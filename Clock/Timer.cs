using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clock
{
    internal class Timer
    {
        public int remainingSeconds {  get; set; }
        public Timer(int seconds)
        {
            remainingSeconds = seconds;
        }
        public void SetTime(int seconds)
        {
            remainingSeconds = seconds;
        }
        public void StartTimer()
        {
            Console.WriteLine("Az időzítő elindult.");
            for (int i = remainingSeconds; i > 0; i--)
            {
                Console.WriteLine($"Hátralévő idő: {i} másodperc");
                Thread.Sleep(1000); // Várunk 1 másodpercet
            }
            Console.WriteLine("Az idő lejárt.");
        }
    }
}

