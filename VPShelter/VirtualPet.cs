using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //// REQUIREMENTS ================
        //// Name Property
        ////Description Property
        //// 2 Constructors



        //// fields
        // invisible
        private string petName;
        private string petDescription;

        private int hungerLevelEmmalani = 0;
        private int thirstLevelEmmalani = 0;
        private int energyLevelEmmalani = 0;

        private int hungerLevelMana = 0;
        private int thirstLevelMana = 0;
        private int energyLevelMana = 0;


        //// Properties
        public List <VirtualPet> PetName { get; set; }
        public List <VirtualPet> PetDescription { get; set; }

        public int HungerLevelEmmalani { get; set; }
        public int ThirstLevelEmmalani { get; set; }
        public int EnergyLevelEmmalani { get; set; }

        public int HungerLevelMana { get; set; }
        public int ThirstLevelMana { get; set; }
        public int EnergyLevelMana { get; set; }

        //// Constructors
        public VirtualPet()
        {
            // default constructor
            this.petName = petName;
            this.petDescription = petDescription;
            this.hungerLevelEmmalani = 50;
            this.thirstLevelEmmalani = 50;
            this.energyLevelEmmalani = 50;

            this.hungerLevelMana = 50;
            this.thirstLevelMana = 50;
            this.energyLevelMana = 50;
        }

        public VirtualPet(string petName, string petDescription )
        {
            this.petName = petName;
            this.petDescription = petDescription;
        }

        

        public void PetDescriptions()
        {
            List<string> petDescriptionList = new List<string>();
            petDescriptionList.Add("ID number   Name         Species    Color                 Shoulder Height(in)    Weight(lbs)");
            petDescriptionList.Add("P1          Emmalani     Phoenix    purple and silver     17                     5");
            petDescriptionList.Add("P2          Mana         Sphinx     tan and brown         50                     187");

            foreach (string description in petDescriptionList)
            {
                Console.WriteLine(description);
            }
        }


    }       
}

