using System;
using System.Threading;

namespace DoorsForDog
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);

            // Имитация лая для распознователя:
            Console.WriteLine("Фидо начинает лаять.");
            recognizer.recognize("Гав");
            Console.WriteLine("\nФидо ушел на улицу...");
            Console.WriteLine("\nФидо всё готово...");
            //remote.pressButton();
            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            {
                var q = e;
            }
            Console.WriteLine("...но он застрял снаружи!");
            
            // Имитация повторного лая:
            Console.WriteLine("\nФидо начинает лаять...");
            recognizer.recognize("Гав");
            Console.WriteLine("\nФидо вернулся в дом...");

            Console.WriteLine("\nНажмите ENTER, для окончании программы..");
            Console.ReadLine();
        }
    }
}
