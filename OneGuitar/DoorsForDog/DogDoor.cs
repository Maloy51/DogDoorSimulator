using System;
using System.Threading;

namespace DoorsForDog
{
    public class DogDoor
    {
        private bool _open;

        public DogDoor()
        {
            this._open = false;
        }

        public void open()
        {
            Console.WriteLine("Дверь для собаки открывается.");
            _open = true;

            Timer timer = new Timer(new TimerCallback(run), null , 5000, -1);
        }
        public void close()
        {
            Console.WriteLine("Дверь для собаки закрывается.");
            _open = false;
        }
        public bool isOpen()
        {
            return _open;
        }
        private void run(object obj)
        {
            close();
            Console.WriteLine("Задержка закрытия двери на 5 сек.");
        }
    }
}