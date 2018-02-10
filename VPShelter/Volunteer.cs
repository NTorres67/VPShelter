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



        //// fields

        protected string volunteerName;
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
            this.volunteerID = "V1.Mars";
        }

        public Volunteer(bool isHungry, bool isThirsty, bool isBored)
        {
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isBored = isBored;
        }



        //// Methods


        //// get employee name
        public override string EmployeeName()
        {
            return volunteerName;
        }


        //// get employee ID number
        public override string EmployeeIDNumber()
        {
            return volunteerID;
        }


        //// To Water
        public string WateringTime()
        {
            if (isThirsty == false)
            {
                isThirsty = true;
                return "Not thirsty thanks.";
            }
            else if (isThirsty == true)
            {
                isThirsty = false;
                return "May I have something to drink.";
            }
            else
            {
                return "";
            }


        }


        //// To Feed
        public string FeedingTime()
        {
            if (IsHungry == false)
            {
                IsHungry = true;
                return "Thank you but I am not hungry.";
            }
            else if (isHungry == true)
            {
                IsHungry = false;
                return "Please feed me.";
            }
            else
            {
                return "";
            }











        }

    }
}
