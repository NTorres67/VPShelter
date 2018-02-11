using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {

        // fields
        // invisible

        // Properites

        public List<Employee> AllEmployeesList { get; set; }
        public List<VirtualPet> AllPets { get; set; }


        public void ShelterLists()
        {
            List<string> allEmployeesList = new List<string>();

            allEmployeesList.Add("Mars");
            allEmployeesList.Add("Athena");

            List<string> allPetsList = new List<string>();

            allPetsList.Add("Phoenix");
            allPetsList.Add("Sphinx");
        }
        
        

        

        

    }
}
