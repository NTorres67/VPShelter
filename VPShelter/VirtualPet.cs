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
        public float petWeight;


        //// Properties
        public string PetName { get; set; }
        public float PetWeight { get; set; }


        //// Constructors
        public VirtualPet()
        {
            // default Constructors
        }

        public VirtualPet(string petName, float petWeightd)
        {
            this.petName = petName;
            this.petWeight = petWeight;
        }



        //// Methods
        
    }
}

