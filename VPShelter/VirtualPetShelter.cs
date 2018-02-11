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


        public void EmployeeList()
        {
            List<string> allEmployeesList = new List<string>();
            allEmployeesList.Add("Mars");
            allEmployeesList.Add("Athena");

            foreach (string employee in allEmployeesList)
            {
                Console.WriteLine(employee);
            }
        }
    
        public void PetList()
        { 
            List<string> allPetsList = new List<string>();
            allPetsList.Add("Emmalani");
            allPetsList.Add("Mana");

            foreach (string pet in allPetsList)
            {
                Console.WriteLine(pet);
            }
        }
        
        

        

        

    }
}
