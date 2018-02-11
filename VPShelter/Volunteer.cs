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

        private int hungerLevelEmmalani = 0;
        private int thirstLevelEmmalani = 0;
        private int energyLevelEmmalani = 0;

        private int hungerLevelMana = 0;
        private int thirstLevelMana = 0;
        private int energyLevelMana = 0;

        
        //// Properties

        public string VolunteerName { get; }
        public string VolunteerID { get; }

        public int HungerLevelEmmalani { get; set; }
        public int ThirstLevelEmmalani { get; set; }
        public int EnergyLevelEmmalani { get; set; }

        public int HungerLevelMana { get; set; }
        public int ThirstLevelMana { get; set; }
        public int EnergyLevelMana { get; set; }

        
        //// Constructors
        public Volunteer()
        {
            this.volunteerName = "Mars";
            this.volunteerID = "V1";
            this.hungerLevelEmmalani = 50;
            this.thirstLevelEmmalani = 50;
            this.energyLevelEmmalani = 50;

            this.hungerLevelMana = 50;
            this.thirstLevelMana = 50;
            this.energyLevelMana = 50;
        }


        public Volunteer(int hungerLevelEmmalani, int thirstLevelEmmalani, int energyLevelEmmalani, int hungerLevelSphinx, int thirstLevelSphinx, int energyLevelSphinx)
        {
            this.hungerLevelEmmalani = hungerLevelEmmalani;
            this.thirstLevelEmmalani = thirstLevelEmmalani;
            this.energyLevelEmmalani = energyLevelEmmalani;

            this.hungerLevelMana = hungerLevelSphinx;
            this.thirstLevelMana = thirstLevelSphinx;
            this.energyLevelMana = energyLevelSphinx;
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
        int feedAmountEmmalani = 0;
        int toFeedEmmalani = 0;
        int feedWho;

        int feedAmountMana = 0;
        int toFeedMana = 0;

        public void FeedingTime()
        {
            Console.WriteLine("Type 1 to feed Emmalani.");
            Console.WriteLine("Type 2 to feed Mana.");
            feedWho = int.Parse(Console.ReadLine());

            switch (feedWho)
            {
                case 1:
                    // feed Emmalani
                    Console.WriteLine("Do you want to increase or decrease Emmalani's hunger level?");
                    Console.WriteLine("Type 1 to increase");
                    Console.WriteLine("Type 2 to decrease");
                    toFeedEmmalani = int.Parse(Console.ReadLine());

                    if (toFeedEmmalani == 1)
                    {
                        Console.WriteLine("Enter amount to increase hunger level.");
                        feedAmountEmmalani = int.Parse(Console.ReadLine());
                        this.hungerLevelEmmalani = hungerLevelEmmalani + feedAmountEmmalani;
                        this.energyLevelEmmalani = energyLevelEmmalani + 10;
                    }
                    else if (toFeedEmmalani == 2)
                    {
                        Console.WriteLine("Enter amount to decrease hunger level.");
                        feedAmountEmmalani = int.Parse(Console.ReadLine());
                        this.hungerLevelEmmalani = hungerLevelEmmalani - feedAmountEmmalani;
                        this.energyLevelEmmalani = energyLevelEmmalani - 5;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    if (hungerLevelEmmalani >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No longer hungry thanks.");
                    }
                    else if (hungerLevelEmmalani <= 99 && hungerLevelEmmalani > 50)
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
                        // feed Mana
                        Console.WriteLine("Do you want to increase or decrease Mana's hunger level?");
                        Console.WriteLine("Type 1 to increase");
                        Console.WriteLine("Type 2 to decrease");
                        toFeedMana = int.Parse(Console.ReadLine());

                        if (toFeedMana == 1)
                        {
                            Console.WriteLine("Enter amount to increase hunger level.");
                            feedAmountMana = int.Parse(Console.ReadLine());
                            this.hungerLevelMana = hungerLevelMana + feedAmountMana;
                            this.energyLevelMana = energyLevelMana + 10;
                        }
                        else if (toFeedMana == 2)
                        {
                            Console.WriteLine("Enter amount to decrease hunger level.");
                            feedAmountMana = int.Parse(Console.ReadLine());
                            this.hungerLevelMana = hungerLevelMana - feedAmountMana;
                            this.energyLevelMana = energyLevelMana - 5;
                        }
                        else
                        {
                            Console.WriteLine("");
                        }

                        if (hungerLevelMana >= 100)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No longer hungry thanks.");
                        }
                        else if (hungerLevelMana <= 99 && hungerLevelMana > 50)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("May I have something to eat?");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Food! Give me food!");
                        }
                        break;
                    }
            }    
        }


        //// To Water
        int waterAmountEmmalani = 0;
        int toWaterEmmalani = 0;
        int waterWho = 0;
        int waterAmountMana = 0;
        int toWaterMana = 0;


        public void WateringTime()
        {
            Console.WriteLine("Type 1 to water Emmalani");
            Console.WriteLine("Type 2 to water Mana");
            waterWho = int.Parse(Console.ReadLine());

            switch (waterWho)
            {
                case 1:
                    // water Emmalani
                    Console.WriteLine("Do you want to increase or decrease Emmalani's thirst level?");
                    Console.WriteLine("Type 1 to increase");
                    Console.WriteLine("Type 2 to decrease");
                    toWaterEmmalani = int.Parse(Console.ReadLine());

                    if (toWaterEmmalani == 1)
                    {
                        Console.WriteLine("Enter amount to increase thirst level.");
                        waterAmountEmmalani = int.Parse(Console.ReadLine());
                        this.thirstLevelEmmalani = thirstLevelEmmalani + waterAmountEmmalani;
                        this.energyLevelEmmalani = energyLevelEmmalani - 2;
                    }
                    else if (toWaterEmmalani == 2)
                    {
                        Console.WriteLine("Amount to decrease thirst level.");
                        waterAmountEmmalani = int.Parse(Console.ReadLine());
                        this.thirstLevelEmmalani = thirstLevelEmmalani - waterAmountEmmalani;
                        this.energyLevelEmmalani = energyLevelEmmalani + 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    if (thirstLevelEmmalani >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No longer thirsty thanks.");
                    }
                    else if (thirstLevelEmmalani <= 99 && thirstLevelEmmalani > 50)
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
                    // water Mana
                    Console.WriteLine("Do you want to increase or decrease Mana's thirst level?");
                    Console.WriteLine("Type 1 to increase");
                    Console.WriteLine("Type 2 to decrease");
                    toWaterMana = int.Parse(Console.ReadLine());

                    if (toWaterMana == 1)
                    {
                        Console.WriteLine("Enter amount to increase thirst level.");
                        waterAmountMana = int.Parse(Console.ReadLine());
                        this.thirstLevelMana = thirstLevelMana + waterAmountMana;
                        this.energyLevelMana = energyLevelMana - 2;
                    }
                    else if (toWaterMana == 2)
                    {
                        Console.WriteLine("Amount to decrease thirst level.");
                        waterAmountMana = int.Parse(Console.ReadLine());
                        this.thirstLevelMana = thirstLevelMana - waterAmountMana;
                        this.energyLevelMana = energyLevelMana + 1;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                    if (thirstLevelMana >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No longer thirsty thanks.");
                    }
                    else if (thirstLevelMana <= 99 && thirstLevelMana > 50)
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
            }  
        }


        //// To Play
        int playAmountEmmalani = 0;
        int playWho = 0;

        int playAmountMana = 0;

        public void PlayTime()
        {
            Console.WriteLine("Type 1 to play with Emmalani");
            Console.WriteLine("Type 2 to play with Mana");
            playWho = int.Parse(Console.ReadLine());

            switch (playWho)
            {
                case 1:
                    // play with Emmalani
                    Console.WriteLine("Enter amount you want to play with Emmalani.");
                    playAmountEmmalani = int.Parse(Console.ReadLine());
                    this.energyLevelEmmalani = energyLevelEmmalani + playAmountEmmalani;
                    this.hungerLevelEmmalani = hungerLevelEmmalani - 50;
                    this.thirstLevelEmmalani = thirstLevelEmmalani - 40;

                    if (energyLevelEmmalani >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Play with me now!");
                    }
                    else if (energyLevelEmmalani <= 99 && energyLevelEmmalani > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Will you please play with me 10 more minutes?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("I don't want to play anymore.");
                    }
                    break;
                    
                case 2:
                    // play with Mana
                    Console.WriteLine("Enter amount you want to play with Mana.");
                    playAmountMana = int.Parse(Console.ReadLine());
                    this.energyLevelMana = energyLevelMana + playAmountMana;
                    this.hungerLevelMana = hungerLevelMana - 50;
                    this.thirstLevelMana = thirstLevelMana - 40;

                    if (energyLevelMana >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Play with me now!");
                    }
                    else if (energyLevelMana <= 99 && energyLevelMana > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Will you please play with me more?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Go away.");
                    }
                    break;
            }
        }


        //// To Rest
        int restWho = 0;

        public void NapTime()
        {
            Console.WriteLine("Type 1 to rest Emmalani");
            Console.WriteLine("Type 2 to rest Mana");
            restWho = int.Parse(Console.ReadLine());

            switch (restWho)
            {
                case 1:
                    // rest Emmalani
                    Console.WriteLine("Enter amount you want Emmalani to nap.");
                    playAmountEmmalani = int.Parse(Console.ReadLine());
                    this.energyLevelEmmalani = energyLevelEmmalani - playAmountEmmalani;
                    this.hungerLevelEmmalani = hungerLevelEmmalani - 15;
                    this.thirstLevelEmmalani = thirstLevelEmmalani - 14;

                    if (energyLevelEmmalani >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("But I don't want to nap!");
                    }
                    else if (energyLevelEmmalani <= 99 && energyLevelEmmalani > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("May I please nap later?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Have you seen my bed?");
                    }
                    break;

                case 2:
                    // rest Mana
                    Console.WriteLine("Enter amount you want Mana to nap.");
                    playAmountMana = int.Parse(Console.ReadLine());
                    this.energyLevelMana = energyLevelMana - playAmountMana;
                    this.hungerLevelMana = hungerLevelMana - 15;
                    this.thirstLevelMana = thirstLevelMana - 14;

                    if (energyLevelMana >= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Nope! Not napping!");
                    }
                    else if (energyLevelMana <= 99 && energyLevelMana > 50)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Do I really have to take a nap?");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Where's my bed?");
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
            Console.WriteLine("Emmalani     " + hungerLevelEmmalani + "           " + thirstLevelEmmalani + "          " + energyLevelEmmalani);
            Console.WriteLine("Mana         " + hungerLevelMana + "           " + thirstLevelMana + "          " + energyLevelMana);
            Console.WriteLine("");
        }





    }
}
