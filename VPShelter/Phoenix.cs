using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Phoenix : VirtualPet
    {
        //// REQUIREMENTS
        //// 1 Type Property
        //// 1 Diet Property

        Phoenix userPhoenix = new Phoenix();


        //// fields
        private string petName;
        private string petType;

        private bool isHungry = true;
        private bool isThirsty = true;

        private string foodTypePhoenix;


        // Properties
        public string PetName { get; }
        public string PetType { get; }

        public bool IsHungry { get; set; }
        public bool IsThirsty { get; set; }

        public string FoodTypePhoenix { get; }


        // Constructors

        public Phoenix()
        {
            this.petName = "Emmalani";
            this.petType = "Phoenix";
            this.foodTypePhoenix = "chicken long rice";
        }

        public Phoenix(bool isHungry, bool isThirsty)
        {
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
        }

        public Phoenix(string foodTypePhoenix)
        {
            this.foodTypePhoenix = foodTypePhoenix;
        }

        
        // Methods
        
        //// To Water
        public void PhoenixWateringTime()
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
        public void PhoenixFeedingTime()
        {
            if (IsHungry == false)
            {
                IsHungry = true;
                Console.WriteLine("Thank you but I am not hungry.");
            }
            else if (isHungry == true)
            {
                IsHungry = false;
                Console.WriteLine("Please feed " + foodTypePhoenix + ".");
            }
            else
            {
                Console.WriteLine("");
            }



        }
    }
}
