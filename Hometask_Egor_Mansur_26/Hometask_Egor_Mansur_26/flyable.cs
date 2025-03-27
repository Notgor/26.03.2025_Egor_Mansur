using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Egor_Mansur_26
{
    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Утка летит.");
        }

        public void Swim()
        {
            Console.WriteLine("Утка плавает.");
        }
    }

    class Task12
    {
        public static void Execute()
        {
            IFlyable flyingDuck = new Duck();
            ISwimmable swimmingDuck = new Duck();

            flyingDuck.Fly();
            swimmingDuck.Swim();
        }
    }
}
