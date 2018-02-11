using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        // REQUIREMENTS
        // 1 Property
        // 1 Override Method
        // Adoption Mehod

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
            Console.WriteLine("Type 1 to play with the Phoenix.");
            Console.WriteLine("Type 2 to play with the Sphinx.");
            playWho = int.Parse(Console.ReadLine());

            switch (playWho)
            {
                case 1:
                    {
                        // play with Phoenix
                        Console.WriteLine("");
                        Console.WriteLine("Close the windows when playing with the Phoenix");
                        Console.WriteLine("");
                    }
                    break;

                case 2:
                    {
                        // play with the Sphinx
                        Console.WriteLine("");
                        Console.WriteLine("Be careful of the Sphinx's riddles.");
                        Console.WriteLine("");
                    }
                    break;
            }
        }
        

        //// adopt a pet
        public void PetAdoption()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to adopt one of our mythical beasts?");
            Console.WriteLine("Would you prefer a Phoenix or a Sphinx?");
            Console.WriteLine("");
        }


    }
}
