using System;

namespace ARKTribalFeatures
{
    class Dinosaur
    {
        //Getters for Dinosaur Name and Level
        private String name;

        public string getName
        {
            get { return name; }
        }

        private int level;

        public int getLevel
        {
            get { return level; }
        }

        //Constructor to initilize the Dinosaur. Used to set Dinosaur Name and level. 
        public Dinosaur(String Name, int Level)
        {
            this.name = Name;
            this.level = Level;
        }
    }
}