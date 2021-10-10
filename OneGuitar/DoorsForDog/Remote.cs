using System;

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
        }
    }
}