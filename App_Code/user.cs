using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.App_Code;

namespace Capstone.App_Code
{
    public class user
    {
        private string userFname;
        private string userLname;
        private string userName;
        private string userPassword;
        private string userEmail;
        protected string feedback;

        public string UserFname
        { get
            { return userFname; }
            set
            {
                
                    userFname = value;
                
            }
        }

        public string UserLname
        {
            get
            { return userLname; }
            set
            {
                
                    userLname = value;
                
            }
        }

        public string UserName
        {
            get
            { return userName; }
            set
            {
              
                    userName = value;
                
            }
        }

        public string UserPassword
        {
            get
            { return userPassword; }
            set
            {
                
                    userPassword = value;
                
            }
        }

        public string UserEmail
        {
            get
            { return userEmail; }
            set
            {
                
                    userEmail = value;
                
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }
            set
            {
                feedback = value;
            }
        }

        public user()
        {
            userFname = "";
            userLname = "";
            userName = "";
            userPassword = "";
            userEmail = "";
        }


    }
}