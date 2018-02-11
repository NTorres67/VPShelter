using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        
        //// fields

        private string volunteerName;
        protected string volunteerID;

        private int hungerLevelPhoenix = 0;
        private int thirstLevelPhoenix = 0;
        private int energyLevelPhoenix = 0;

        private int hungerLevelSphinx = 0;
        private int thirstLevelSphinx = 0;
        private int energyLevelSphinx = 0;



        //// Properties

        public string VolunteerName { get; }
        public string VolunteerID { get; }

        public int HungerLevelPhoenix { get; set; }
        public int ThirstLevelPhoenix { get; set; }
        public int EnergyLevelPhoenix { get; set; }

        public int HungerLevelSphinx { get; set; }
        public int ThirstLevelSphinx { get; set; }
        public int EnergyLevelSphinx { get; set; }



        //// Constructors
        public Volunteer()
        {
            this.volunteerName = "Mars";
            this.volunteerID = "V1";
            this.hungerLevelPhoenix = 50;
            this.thirstLevelPhoenix = 50;
            this.energyLevelPhoenix = 50;

            this.hungerLevelSphinx = 50;
            this.thirstLevelSphinx = 50;
            this.energyLevelSphinx = 50;

        }


        public Volunteer(int hungerLevelPhoenix, int thirstLevelPhoenix, int energyLevelPhoenix, int hungerLevelSphinx, int thirstLevelSphinx, int energyLevelSphinx)
        {
            this.hungerLevelPhoenix = hungerLevelPhoenix;
            this.thirstLevelPhoenix = thirstLevelPhoenix;
            this.energyLevelPhoenix = energyLevelPhoenix;

            this.hungerLevelSphinx = hungerLevelSphinx;
            this.thirstLevelSphinx = thirstLevelSphinx;
            this.energyLevelSphinx = energyLevelSphinx;
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


        //// To Feed
        int feedAmountPhoenix = 0;
        int toFeedPhoenix = 0;
        int feedWho;

        int feedAmountSphinx = 0;
        int toFeedSphinx = 0;

        public void FeedingTime()
        {
            Console.WriteLine("Type 1 to feed the Phoenix.");
            Console.WriteLine("Type 2 to feed the Sphinx");
            feedWho = int.Parse(Console.ReadLine());

            switch (feedWho)
            {
                case 1:
                    // feed Phoenix
                    Console.WriteLine("Do you want to increase or decrease your Phoenix's hunger level?");
                    Console.WriteLine("Type 1 to increase");
                    Console.WriteLine("Type 2 to decrease");
                    toFeedPhoenix = int.Parse(Console.ReadLine());

                    if (toFeedPhoenix == 1)
                    {
                        Console.WriteLine("Enter amount to increase hunger level.");
                        feedAmountPhoenix = int.Parse(Console.ReadLine());
                        this.hungerLevelPhoenix = hungerLevelPhoenix + feedAmountPhoenix;
                        this.energyLevelPhoenix = energyLevelPhoenix + 10;
                    }
                    else if (toFeedPhoenix == 2)
                    {
                        Console.WriteLine("Amount to decrease hunger level.");
                        feedAmountPhoenix = int.Parse(Console.ReadLine());
                        this.hungerLevelPhoenix = hungerLevelPhoenix - feedAmountPhoenix;
                        this.energyLevelPhoenix = energyLevelPhoenix - 5;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    if (hungerLevelPhoenix >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No longer hungry thanks.");
                    }
                    else if (hungerLevelPhoenix <= 99 && hungerLevelPhoenix > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("May I have something to eat?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Starving here!");
                    }
                    break;

                case 2:
                    {
                        // feed Sphinx
                        Console.WriteLine("Do you want to increase or decrease your Sphinx's hunger level?");
                        Console.WriteLine("Type 1 to increase");
                        Console.WriteLine("Type 2 to decrease");
                        toFeedSphinx = int.Parse(Console.ReadLine());

                        if (toFeedSphinx == 1)
                        {
                            Console.WriteLine("Enter amount to increase hunger level.");
                            feedAmountSphinx = int.Parse(Console.ReadLine());
                            this.hungerLevelSphinx = hungerLevelSphinx + feedAmountSphinx;
                            this.energyLevelSphinx = energyLevelSphinx + 10;
                        }
                        else if (toFeedSphinx == 2)
                        {
                            Console.WriteLine("Amount to decrease hunger level.");
                            feedAmountSphinx = int.Parse(Console.ReadLine());
                            this.hungerLevelSphinx = hungerLevelSphinx - feedAmountSphinx;
                            this.energyLevelSphinx = energyLevelSphinx - 5;
                        }
                        else
                        {
                            Console.WriteLine("");
                        }

                        if (hungerLevelSphinx >= 100)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No longer hungry thanks.");
                        }
                        else if (hungerLevelSphinx <= 99 && hungerLevelSphinx > 50)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("May I have something to eat?");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Starving here!");
                        }
                        break;
                    }
            }    



            
        }


        //// To Water
        int waterAmountPhoenix = 0;
        int toWaterPhoenix = 0;
        int waterWho = 0;
        int waterAmountSphinx = 0;
        int toWaterSphinx = 0;


        public void WateringTime()
        {
            Console.WriteLine("Type 1 to water the Phoenix.");
            Console.WriteLine("Type 2 to water the Sphinx");
            waterWho = int.Parse(Console.ReadLine());

            switch (waterWho)
            {
                case 1:
                    // water Phoenix
                    Console.WriteLine("Do you want to increase or decrease your Phoenix's thirst level?");
                    Console.WriteLine("Type 1 to increase");
                    Console.WriteLine("Type 2 to decrease");
                    toWaterPhoenix = int.Parse(Console.ReadLine());

                    if (toWaterPhoenix == 1)
                    {
                        Console.WriteLine("Enter amount to increase thirst level.");
                        waterAmountPhoenix = int.Parse(Console.ReadLine());
                        this.thirstLevelPhoenix = thirstLevelPhoenix + waterAmountPhoenix;
                        this.energyLevelPhoenix = energyLevelPhoenix - 2;
                    }
                    else if (toWaterPhoenix == 2)
                    {
                        Console.WriteLine("Amount to decrease thirst level.");
                        waterAmountPhoenix = int.Parse(Console.ReadLine());
                        this.thirstLevelPhoenix = thirstLevelPhoenix - waterAmountPhoenix;
                        this.energyLevelPhoenix = energyLevelPhoenix + 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    if (thirstLevelPhoenix >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No longer thirsty thanks.");
                    }
                    else if (thirstLevelPhoenix <= 99 && thirstLevelPhoenix > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("May I have something to drink?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Dehydrated here!");
                    }
                    break;

                case 2:
                    // water Sphinx
                    Console.WriteLine("Do you want to increase or decrease your Sphinx's thirst level?");
                    Console.WriteLine("Type 1 to increase");
                    Console.WriteLine("Type 2 to decrease");
                    toWaterSphinx = int.Parse(Console.ReadLine());

                    if (toWaterSphinx == 1)
                    {
                        Console.WriteLine("Enter amount to increase thirst level.");
                        waterAmountSphinx = int.Parse(Console.ReadLine());
                        this.thirstLevelSphinx = thirstLevelSphinx + waterAmountSphinx;
                        this.energyLevelSphinx = energyLevelSphinx - 2;
                    }
                    else if (toWaterSphinx == 2)
                    {
                        Console.WriteLine("Amount to decrease thirst level.");
                        waterAmountSphinx = int.Parse(Console.ReadLine());
                        this.thirstLevelSphinx = thirstLevelSphinx - waterAmountSphinx;
                        this.energyLevelSphinx = energyLevelSphinx + 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    if (thirstLevelSphinx >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No longer thirsty thanks.");
                    }
                    else if (thirstLevelSphinx <= 99 && thirstLevelSphinx > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("May I have something to drink?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Dehydrated here!");
                    }
                    break;

                case 3:
                    {

                    }
                    break;

            }  
        }


        //// To Play
        int playAmountPhoenix = 0;
        int playWho = 0;

        int playAmountSphinx = 0;

        public void PlayTime()
        {
            Console.WriteLine("Type 1 to play with the Phoenix.");
            Console.WriteLine("Type 2 to play with the Sphinx.");
            playWho = int.Parse(Console.ReadLine());

            switch (playWho)
            {
                case 1:
                    // play with Phoenix
                    Console.WriteLine("Amount you want to play with the Phoenix?");
                    playAmountPhoenix = int.Parse(Console.ReadLine());
                    this.energyLevelPhoenix = energyLevelPhoenix + playAmountPhoenix;
                    this.hungerLevelPhoenix = hungerLevelPhoenix - 50;
                    this.thirstLevelPhoenix = thirstLevelPhoenix - 40;

                    if (energyLevelPhoenix >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Play with me now!");
                    }
                    else if (energyLevelPhoenix <= 99 && energyLevelPhoenix > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Will you please play with me more?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I don't want to play anymore.");
                    }
                    break;
                    
                case 2:
                    // play with Sphinx
                    Console.WriteLine("Amount you want to play with the Sphinx?");
                    playAmountSphinx = int.Parse(Console.ReadLine());
                    this.energyLevelSphinx = energyLevelSphinx + playAmountSphinx;
                    this.hungerLevelSphinx = hungerLevelSphinx - 50;
                    this.thirstLevelSphinx = thirstLevelSphinx - 40;

                    if (energyLevelSphinx >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Play with me now!");
                    }
                    else if (energyLevelSphinx <= 99 && energyLevelSphinx > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Will you please play with me more?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I don't want to play anymore.");
                    }
                    break;
            }



        }


        //// To Rest
        int restWho = 0;

        public void NapTime()
        {
            Console.WriteLine("Type 1 to rest the Phoenix.");
            Console.WriteLine("Type 2 to rest the Sphinx.");
            restWho = int.Parse(Console.ReadLine());

            switch (restWho)
            {
                case 1:
                    // rest Phoenix
                    Console.WriteLine("Amount you want the Phoenix to nap?");
                    playAmountPhoenix = int.Parse(Console.ReadLine());
                    this.energyLevelPhoenix = energyLevelPhoenix - playAmountPhoenix;
                    this.hungerLevelPhoenix = hungerLevelPhoenix - 15;
                    this.thirstLevelPhoenix = thirstLevelPhoenix - 14;

                    if (energyLevelPhoenix >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Play with me now!");
                    }
                    else if (energyLevelPhoenix <= 99 && energyLevelPhoenix > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Will you please play with me more?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I need a nap.");
                    }
                    break;

                case 2:
                    // rest Sphinx
                    Console.WriteLine("Amount you want the Sphinx to nap?");
                    playAmountSphinx = int.Parse(Console.ReadLine());
                    this.energyLevelSphinx = energyLevelSphinx - playAmountSphinx;
                    this.hungerLevelSphinx = hungerLevelSphinx - 15;
                    this.thirstLevelSphinx = thirstLevelSphinx - 14;

                    if (energyLevelSphinx >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Play with me now!");
                    }
                    else if (energyLevelSphinx <= 99 && energyLevelSphinx > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Will you please play with me more?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I need a nap.");
                    }
                    break;

            }


            
        }


        //// Pet Status
        public void PetStatus()
        {
            Console.WriteLine("");
            Console.WriteLine("Status of our pets:");
            Console.WriteLine("Pet         Hunger      Thirst      Play");
            Console.WriteLine("Phoenix     " + hungerLevelPhoenix + "           " + thirstLevelPhoenix + "          " + energyLevelPhoenix);
            Console.WriteLine("Sphinx      " + hungerLevelSphinx + "           " + thirstLevelSphinx + "          " + energyLevelSphinx);
            Console.WriteLine("");
        }





    }
}
