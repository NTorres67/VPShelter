using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Sphinx : VirtualPet
    {

        Sphinx userSphinx = new Sphinx();

        //// fieldss
        private string petName;
        private string petType;

        private bool isHungry = true;
        private bool isThirsty = true;

        private string foodTypeSphinx;

        // Properties
        public string PetName { get; }
        public string PetType { get; }

        public bool IsHungry { get; set; }
        public bool IsThirsty { get; set; }

        public string FoodTypeSphinx { get; }

        // Constructors

        public Sphinx()
        {
            this.petName = "Mana";
            this.petType = "Sphinx";
            this.foodTypeSphinx = "spam musubi";
        }

        public Sphinx(bool isHungry, bool isThirsty)
        {
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
        }

        public Sphinx (string foodTypeSphinx)
        {
            this.foodTypeSphinx = foodTypeSphinx;
        }

        

        // Methods

        //// To Water
        public void SphinxWateringTime()
        {
            if (isThirsty == false)
            {
                isThirsty = true;
                Console.WriteLine("Not thirsty thanks.");
            }
            else if (isThirsty == true)
            {
                isThirsty = false;
                Console.WriteLine("May I have something to drink.");
            }
            else
            {
                Console.WriteLine("");
            }


        }


        //// To Feed
        public void SphinxFeedingTime()
        {
            if (IsHungry == false)
            {
                IsHungry = true;
                Console.WriteLine("Thank you but I am not hungry.");
            }
            else if (isHungry == true)
            {
                IsHungry = false;
                Console.WriteLine("Please feed me " + foodTypeSphinx + ".");
            }
            else
            {
                Console.WriteLine("");
            }






        }
    }
}
