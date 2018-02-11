using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Emmalani : VirtualPet
    {

        //// fields
        private string petType;
        private string emmalaniDiet;


        //// Properties
        public string PetType { get; set; }
        public string EmmalaniDiet { get; set; }

        //// Constructors

        public void EmmalaniDietList()
        {
            List<string> EmmaDietList = new List<string>();
            EmmaDietList.Add("chicken long rice");
            EmmaDietList.Add("miso chilean sea bass");
            EmmaDietList.Add("honey ginger tofu");

            foreach (string emma in EmmaDietList)
            {
                Console.WriteLine(emma);
            }
        }



    }
}
