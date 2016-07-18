using System;

namespace ARKTribalFeatures
{
    class Event_Taming
    {
        //Getter for the current Dinosaur that is taming
        public Dinosaur dino;

        //Constructor to initialize tame
        public Event_Taming(Dinosaur Dino)
        {
            dino = Dino;

        }

        public void print_taming_dino()
        {
            Console.WriteLine( "The {0} is level {1}", dino.getName, dino.getLevel );
        }
    }
}