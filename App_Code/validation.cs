using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks; 
using System.Text.RegularExpressions; //activates regex

namespace Capstone.App_Code
{
    public class validation
    {

        //Validate words unwanted in database
        public static bool badWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "yuck", "lame", "disgusting", "gross", "ew"};

            foreach (string strBW in strBadWords)
                if (temp.Contains(strBW))
                {
                    result = true;
                }
            return result;

        }



        //Validate if something is left blank
        public static bool isFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }

        //Requires input 
        public static bool dataEntered(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }
            return result;
        }



        //Validate that the email is formatted correctly
        public static bool validateEmail(string temp)
        {

            bool blnResult = true;

            if (temp.Contains("@gmail") || temp.Contains(".com") || temp.Contains(".net") || temp.Contains("@aol") || temp.Contains("@edu") || temp.Contains("@yahoo"))
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }
            return blnResult;
        }

    }
}