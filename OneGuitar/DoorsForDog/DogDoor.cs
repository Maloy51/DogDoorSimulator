using System;

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
    }
}