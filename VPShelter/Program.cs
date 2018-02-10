using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display actions
            // Takes user input
            // Triggers the actions based on user choices

            int userInput = 0;
            string animalType = " ";
            string task = " ";

            Volunteer userVolunteer = new Volunteer();


            Console.WriteLine("Welcome to the Mythical Beast Pet Shelter. ");
            Console.WriteLine("Please select your employee type");

            do
            {
                Console.WriteLine("Select 1 for Volunteer.");
                Console.WriteLine("Select 2 for Manager");
                Console.WriteLine("Select 0 to quit");

                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        // select Volunteer Class
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for volunteering at our shelter.");
                        Console.WriteLine("Please select what task would you like to do?");

                        do
                        {

                            Console.WriteLine("Type \"a\" to learn your name.");
                            Console.WriteLine("Type \"b\" to learn your employee ID number.");
                            Console.WriteLine("Type \"d\" to Feed.");
                            Console.WriteLine("Type \"e\" to Water.");
                            Console.WriteLine("Type \"z\" to stop working as a volunteer.");
                            Console.WriteLine("");

                            task = Console.ReadLine();
                            task = task.ToLower();

                            switch (task)
                            {
                                case "a":
                                    // to get volunteer name
                                    userVolunteer.EmployeeName();
                                    break;

                                case "b":
                                    // to get volunteer ID number
                                    userVolunteer.EmployeeIDNumber();
                                    break;

                                case "c":
                                    // to Feed
                                    userVolunteer.FeedPet();
                                    break;

                                case "d":
                                    // To Water
                                    //userVolunteer.WateringTime();
                                    break;
                            }
                        } while (task != "z");
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for volunteering!");

                        break;








                }


            } while (userInput != 0);
            Console.WriteLine("");
            Console.WriteLine("Thank you for spendig time at the Mythical Beast Pet Shelter");
            Console.WriteLine("Please visit us again soon!");



        }
    }
}
