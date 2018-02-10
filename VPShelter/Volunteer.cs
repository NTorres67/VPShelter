using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        // REQUJREMENTS
        // 1 Property
        // 1 Override Method
        // Feed Method
        // Water Mehtod

        int choosePet = 0;

        Phoenix userPhoenix = new Phoenix();
        Sphinx userSphinx = new Sphinx();

        //// fields

        private string volunteerName;
        protected string volunteerID;

        private bool isHungry = true;
        private bool isThirsty = true;
        private bool isBored = true;


        //// Properties

        public string VolunteerName { get; }
        public string VolunteerID { get; }

        public bool IsHungry { get; set; }
        public bool IsThirsty { get; set; }
        public bool IsBored { get; set; }




        //// Constructors
        public Volunteer()
        {
            this.volunteerName = "Mars";
            this.volunteerID = "V1";
        }

        public Volunteer(bool isHungry, bool isThirsty, bool isBored)
        {
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isBored = isBored;
        }



        //// Methods


        //// get employee name
        public override void EmployeeName()
        {
            Console.WriteLine("Your name is " + volunteerName + ".");
            Console.WriteLine("");
        }


        //// get employee ID number
        public override void EmployeeIDNumber()
        {
            Console.WriteLine("Your employee ID number is " + volunteerID + ".");
            Console.WriteLine("");
        }

        //// To Feed Phoenix
        public void FeedPet()
        {
            

            do
            {
                Console.WriteLine("Select which animal you would like to feed:");
                Console.WriteLine("Type 1 for Phoenix");
                Console.WriteLine("Type 2 for Sphinx");
                Console.WriteLine("Type 99 to stop feeding the pets");
                choosePet = int.Parse(Console.ReadLine());

                switch (choosePet)
                {
                    case 1:
                        userPhoenix.PhoenixFeedingTime();
                        break;

                    case 2:
                        userSphinx.SphinxFeedingTime();
                        break;

                }
            } while (choosePet != 99);
            Console.WriteLine("Thank you for feeding the pets.");
            Console.WriteLine("");
            


        }
         


        

    }
}
