using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Mana : VirtualPet
    {
        //// fields
        private string petType;
        private string manaDiet;


        //// Properties
        public string PetType { get; set; }
        public string ManaDiet { get; set; }

        //// Constructors

        public void ManaDietList()
        {
            List<string> ManasDietList = new List<string>();
            ManasDietList.Add("shoyu chicken");
            ManasDietList.Add("smoked kahala");
            ManasDietList.Add("kalua pig");

            foreach (string mana in ManasDietList)
            {
                Console.WriteLine(mana);
            }
        }


    }
}
