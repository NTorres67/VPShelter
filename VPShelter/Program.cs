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
            string task = " ";

            Volunteer userVolunteer = new Volunteer();
            Manager userManager = new Manager();
            Emmalani userEmmalani = new Emmalani();
            Mana userMana = new Mana();



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
                        

                        userVolunteer.PetStatus();

                        do
                        {
                            Console.WriteLine("Please select what task would you like to do?");
                            Console.WriteLine("Type \"a\" to learn your name.");
                            Console.WriteLine("Type \"b\" to learn your employee ID number.");
                            Console.WriteLine("Type \"c\" to feed pet.");
                            Console.WriteLine("Type \"d\" to water pet.");
                            Console.WriteLine("Type \"e\" to play with pet.");
                            Console.WriteLine("Type \"f\" to rest pet");
                            Console.WriteLine("Type \"z\" to stop working as a volunteer.");
                            Console.WriteLine("");

                            task = Console.ReadLine();
                            task = task.ToLower();


                            switch (task)
                            {
                                case "a":
                                    // get volunteer name
                                    userVolunteer.EmployeeName();
                                    break;
                                    
                                case "b":
                                    // to get volunteer ID number
                                    userVolunteer.EmployeeIDNumber();
                                    break;
                                    
                                case "c":
                                    //// to feeding
                                    userVolunteer.FeedingTime();
                                    break;
                                    
                                case "d":
                                    //// to water
                                    userVolunteer.WateringTime();
                                    break;
                                    
                                case "e":
                                    //// to play
                                    userVolunteer.PlayTime();
                                    break;
                                    
                                case "f":
                                    //// to rest
                                    userVolunteer.NapTime();
                                    break;
                            }
                            
                            Console.WriteLine("");
                            userVolunteer.PetStatus();
                            
                        } while (task != "z");
                        Console.WriteLine("");
                        Console.WriteLine("Again thank you for volunteering!");
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for managing our shelter.");
                        Console.WriteLine("");

                        do
                        {
                            Console.WriteLine("What task would you like to do?");
                            Console.WriteLine("Type \"g\" to learn your name.");
                            Console.WriteLine("Type \"h\" to learn your employee ID number.");
                            Console.WriteLine("Type \"i\" to play with a pet.");
                            Console.WriteLine("Type \"j\" to arrange a pet adoption.");
                            Console.WriteLine("Type \"z\" to stop working as a manager.");
                            Console.WriteLine("");

                            task = Console.ReadLine();
                            task = task.ToLower();

                            switch (task)
                            {
                                case "g":
                                    // to get manager name
                                    userManager.EmployeeName();
                                    break;

                                case "h":
                                    // to get user ID number
                                    userManager.EmployeeIDNumber();
                                    break;
                                    

                                case "i":
                                    // to play with a pet
                                    userManager.PlayTime();
                                    break;

                                case "j":
                                    // adopt out a pet
                                    userManager.PetAdoption();
                                    break;
                            }
                           
                        } while (task != "z");
                        Console.WriteLine("");
                        Console.WriteLine("Again thank you for managing our shelter!");
                        Console.WriteLine("");
                        break;
                }

                userVolunteer.Tick();


            } while (userInput != 0);
            Console.WriteLine("");
            Console.WriteLine("Thank you for spendig time at the Mythical Beast Pet Shelter");
            Console.WriteLine("Please visit us again soon!");
            Console.WriteLine("");



        }
    }
}
