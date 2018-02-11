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
        public string petName;
        public string petDescription;


        //// Properties
        public string PetName { get; set; }
        public string PetDescription { get; set; }


        //// Constructors
        public VirtualPet()
        {
            // default Constructors
        }

        public VirtualPet(string petName, string petDescription)
        {
            this.petName = petName;
            this.petDescription = petDescription;
        }



        //// Methods
        
    }
}

