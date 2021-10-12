using System;
using System.Threading;

namespace DoorsForDog
{
    public class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void pressButton()
        {
            Console.WriteLine("Нажатие кнопки пульта дистанционного управления...");
            if(door.isOpen())
            {
                door.close();
            }
            else
            {
                door.open();
            }
            TimerCallback tm = new TimerCallback(doner);
            Timer timer = new Timer(tm, 0, 5000, Timeout.Infinite);
        }
        private void doner(object obj)
        {
            door.close();
            Console.WriteLine("Автоматика сработала через 5 секунд.");
        }
    }
}