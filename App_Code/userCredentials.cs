using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Capstone.App_Code;


namespace Capstone.App_Code
{

    public class userCredentials
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string userPassword;
        private string userEmail;
        private int wingTally;
        protected string feedback; //Shared between parent and child files only; intended to track error messages



        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                //Check for empty spaces
                if (validation.dataEntered(value) && !validation.badWords(value))
                {
                    firstName = value; //if the value isn't blank, store it
                }
                else
                {
                    //Otherwise, send an error message
                    feedback += "\n <br> ERROR: Please enter a valid name.";
                }
            }
             
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                //Check for empty spaces
                if (validation.dataEntered(value) && !validation.badWords(value))
                {
                    lastName = value; //if the value isn't blank, store it
                }
                else
                {
                    //Otherwise, send an error message
                    feedback += "\n <br> ERROR: Please enter a last name.";
                }
            }

        }



        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                //Check for empty spaces
                if (validation.dataEntered(value) && !validation.badWords(value))
                {
                    userName = value; //if the value isn't blank, store it
                }
                else
                {
                    //Otherwise, send an error message
                    feedback += "\n <br> ERROR: Please enter a username.";
                }
            }

        }

        public string UserEmail
        {
            get
            {
                return userEmail;
            }
            set
            {
                //Check for valid email
                if (validation.validateEmail(value))
                {
                    userEmail = value; //if the email is in correct format, store it
                }
                else
                {
                    //Otherwise, send an error message
                    feedback += "\n <br> ERROR: Please enter a valid email.";
                }
            }

        }


        public string UserPassword
        {
            get
            {
                return userPassword;
            }
            set
            {
                //Check for empty spaces
                if (validation.dataEntered(value)) 
                {
                    userPassword = value; //if the value isn't blank, store it
                }
                else
                {
                    //Otherwise, send an error message
                    feedback += "\n <br> ERROR: Please enter a valid password.";
                }
            }

        }


        public int WingTally
        {
            get
            {
                return wingTally;
            }
            set
            {

                {
                    wingTally = value;
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


        //Default Constructor
        public userCredentials()
        {
            //Initialize so that there are no null values

            firstName = "";
            lastName = "";
            userPassword = "";
            userEmail = "";
            wingTally = 5;
            feedback = "";

        }





        //Utility function -- controls all SQL Server login info
        private string GetConnected()
        {
            return @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE245_GMartin;User Id=SE245_GMartin;Password=008003563;";
        }



        //Add a record, but first connect to the database
        public string AddARecord()
        {
            //Int string variable
            string strResult = "";

            //Make connection to object 
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @GetConnected(); //Set who/what/where of DB

            string strSQL = "INSERT INTO userCredentials (firstName, lastName, userName, userPassword, userEmail, wingTally) VALUES (@firstName, @lastName, @userName, @userPassword, @userEmail, @wingTally)";


            //Bark out command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL; //Commander knows what to say
            comm.Connection = Conn; // = Phone


            //Fill in all perameters in the same order
            comm.Parameters.AddWithValue("@firstName", firstName);
            comm.Parameters.AddWithValue("@lastName", lastName);
            comm.Parameters.AddWithValue("@userName", userName);
            comm.Parameters.AddWithValue("@userPassword", userPassword);
            comm.Parameters.AddWithValue("@userEmail", userEmail);
            comm.Parameters.AddWithValue("@wingTally", wingTally);
       



            //Attempt connection to the server

            try
            {
                Conn.Open();
                //Phone or "dial" the DB
                int intRecs = comm.ExecuteNonQuery(); 
                strResult = $"<br> Welcome!"; //Report that DB accepted record 
                Conn.Close();
            }
            catch (Exception err)
            //Connect to DB
            {
                strResult = "ERROR: " + err.Message;
                // & error info
            }
            finally
            {

            }
            //Return resulting feedback string
            return strResult;
        }
    }
}
