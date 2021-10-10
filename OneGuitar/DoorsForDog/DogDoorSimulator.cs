using System;

namespace DoorsForDog
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Фидо лает, чтобы выйти на улицу...");
            remote.pressButton();
            Console.WriteLine("\nФидо ушел на улицу...");
            remote.pressButton();
            Console.WriteLine("\nФидо все готово...");
            remote.pressButton();
            Console.WriteLine("\nФидо вернулся в дом...");
            remote.pressButton();
        }
    }
}
