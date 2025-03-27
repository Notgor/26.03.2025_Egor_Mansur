using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    class Task6
    {
        public static void Execute()
        {
            TimerExample timer = new TimerExample(2000);
            timer.TimeElapsed += Timer_TimeElapsed;
            timer.Start();

            Console.WriteLine("Нажмите Enter для остановки таймера.");
            Console.ReadLine();
            timer.Stop();
        }

        private static void Timer_TimeElapsed(object sender, EventArgs e)
        {
            Console.WriteLine("Событие: Время истекло!");
        }
    }

    class TimerExample
    {
        private readonly int interval;
        private bool running;
        public event EventHandler TimeElapsed;

        public TimerExample(int interval)
        {
            this.interval = interval;
        }

        public void Start()
        {
            running = true;
            Thread thread = new Thread(Run);
            thread.Start();
        }

        public void Stop()
        {
            running = false;
        }

        private void Run()
        {
            while (running)
            {
                Thread.Sleep(interval);
                TimeElapsed?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

