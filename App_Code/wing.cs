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
                //check for bad words
                if (!validation.badWords(value))
                {
                    wingName = value; //if the value does not contain bad words, store it
                }
                else
                {
                    feedback += "\n ERROR: Wing name contains an inappropiate word.";
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
                //check for bad words
                if (!validation.badWords(value))
                {
                    wingFlavor = value; //if the value does not contain bad words, store it
                }
                else
                {
                    feedback += "\n ERROR: Wing flavor contains an inappropiate word.";
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
                //check for bad words
                if (!validation.badWords(value))
                {
                    wingDesc = value; //if the value does not contain bad words, store it
                }
                else
                {
                    feedback += "\n ERROR: Wing description contains an inappropiate word.";
                }
            }

        }


        public string Feedback
        {
            get
            {
                return feedback; //Allows for outside code to see feedback 
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