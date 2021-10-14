using System;

namespace DoorsForDog
{
    public class BarkRecognizer
    {
        private DogDoor door;

        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }
        public void recognize(string bark)
        {
            Console.WriteLine("   Распознователь лая: Слышит '" + bark + "'");
            door.open();
        }
    }
}