using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.App_Code;

namespace Capstone.App_Code
{
    public class wing
    {
        private string wingName; 
        private string wingFlavor;
        private string wingDesc;
        protected string feedback; //Shared between parent and child files only; intended to track error messages


        public string WingName
        {
            get
            {
                return wingName;
            }
            set
            {
                //Check for empty space and "bad words"
                if (validation.dataEntered(value) && !validation.badWords(value))
                {
                    wingName = value; //if everything is correct, store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Please enter an appropriate wing name.";
                }
            }

        }

        public string WingFlavor
        {
            get
            {
                return wingFlavor;
            }
            set
            {
                //Check for empty space and "bad words"
                if (validation.dataEntered(value) && !validation.badWords(value))
                {
                    wingFlavor = value; //if the value isn't blank and it doesn't hav any "bad words", store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Please enter an appropriate wing flavor.";
                }
            }

        }

        public string WingDesc
        {
            get
            {
                return wingDesc;
            }
            set
            {
                //Check for empty space and "bad words"
                if (validation.dataEntered(value) && !validation.badWords(value))
                {
                    wingDesc = value; //if the value does not contain bad words and it isn't blank, store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Please enter an appropriate wing description.";
                }
            }

        }


        public string Feedback
        {
            get
            {
                return feedback; //Allows for outside code to see feedback -- communicate with front end if data entered is valid or not
            }
            set
            {
                feedback = value;
            }
        }

        public wing()
        {
            //Initialize so that there are no null values

            wingName = "";
            wingFlavor = "";
            wingDesc = "";
            feedback = "";

        }

    }
}