using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        

        //// fields

        private string managerName;
        protected string managerID;

        
        //// Properties

        public string ManagerName { get; }
        public string ManagerID { get; }

        
        //// Constructors
        public Manager()
        {
            this.managerName = "Athena";
            this.managerID = "M1";
        }



        //// Methods

        //// get employee name
        public override void EmployeeName()
        {
            Console.WriteLine("Your name is " + managerName + ".");
            Console.WriteLine("");
        }


        //// get employee ID number
        public override void EmployeeIDNumber()
        {
            Console.WriteLine("Your employee ID number is " + managerID + ".");
            Console.WriteLine("");
        }

        //// play with a pet
        int playWho = 0;
        public void PlayTime()
        {
            Console.WriteLine("Which pet would you like to play with?");
            Console.WriteLine("Type 1 to play with Emmalani");
            Console.WriteLine("Type 2 to play with Mana");
            playWho = int.Parse(Console.ReadLine());

            switch (playWho)
            {
                case 1:
                    {
                        // play with Emmalani
                        Console.WriteLine("");
                        Console.WriteLine("Close the windows when playing with Emmalani.");
                        Console.WriteLine("");
                    }
                    break;

                case 2:
                    {
                        // play with Mana
                        Console.WriteLine("");
                        Console.WriteLine("Be careful of Mana's riddles.");
                        Console.WriteLine("");
                    }
                    break;
            }
        }


        //// arrange a pet adoption
       
        public void PetAdoption()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to adopt one of our mythical beasts?");
            Console.WriteLine("Would you prefer Emmalani or a Mana?");
            Console.WriteLine("");

            List<string> petDescriptionList = new List<string>();
            petDescriptionList.Add("ID  Name      Species   Color               Shoulder Ht(in)   Weight(lbs)");
            petDescriptionList.Add("P1  Emmalani  Phoenix   purple and silver   17                5");
            petDescriptionList.Add("P2  Mana      Sphinx    tan and brown       50                187");

            foreach (string description in petDescriptionList)
            {
                Console.WriteLine(description);
                Console.WriteLine("");
            }

        }
    }
}
