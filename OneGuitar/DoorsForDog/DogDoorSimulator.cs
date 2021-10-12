using System;
using System.Threading;

namespace DoorsForDog
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            //Console.WriteLine("Фидо лает, чтобы выйти на улицу...");
            Console.WriteLine();
            remote.pressButton();
            Console.WriteLine("\nФидо ушел на улицу...");
            Console.WriteLine("\nФидо всё готово...");
            //remote.pressButton();
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e){}
            Console.WriteLine("...но он застрял снаружи!");
            Console.WriteLine("\nФидо начинает лаять...");
            Console.WriteLine("... Джина хватает пульт дистанционного управления.");
            Console.WriteLine("\nФидо вернулся в дом...");
            remote.pressButton();
            //remote.pressButton();

            Console.WriteLine("Нажмите ENTER, для окончании программы..");
            Console.ReadLine();
        }
    }
}
