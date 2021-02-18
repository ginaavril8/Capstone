using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Capstone.App_Code;


namespace Capstone.App_Code
{
    public class contactUs
    {
        private string contactName;
        private string contactEmail;
        private string contactMessage;
        protected string feedback; //Shared between parent and child files only; intended to track error messages

        public string ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                //Check for empty spaces
#pragma warning disable CS0436 // Type conflicts with imported type
                if (validation.dataEntered(value))
#pragma warning restore CS0436 // Type conflicts with imported type
                {
                    contactName = value; //if the value does not contain bad words, store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Please enter a valid name.";
                }
            }

        }

        public string ContactEmail
        {
            get
            {
                return contactEmail;
            }
            set
            {
                //Check for empty spaces
#pragma warning disable CS0436 // Type conflicts with imported type
                if (validation.validateEmail(value))
#pragma warning restore CS0436 // Type conflicts with imported type
                {
                    contactEmail = value; //if the email is formatted correctly, store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Please enter a valid email.";
                }
            }

        }

        public string ContactMessage
        {
            get
            {
                return contactMessage;
            }
            set
            {
                //Check for empty spaces
#pragma warning disable CS0436 // Type conflicts with imported type
                if (validation.dataEntered(value))
#pragma warning restore CS0436 // Type conflicts with imported type
                {
                    contactMessage = value; //if the value isn't null, store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Let us know what's on your mind!";
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



        public contactUs()
        {
            contactName = "";
            contactEmail = "";
            contactMessage = "";
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

            string strSQL = "INSERT INTO contactUs (contactName, contactEmail, contactMessage) VALUES (@contactName, @contactEmail, @contactMessage)";


            //Bark out command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL; //Commander knows what to say
            comm.Connection = Conn; //Where is the phone? Right here.


            //Fill in all perameters in the same order
            comm.Parameters.AddWithValue("@contactName", contactName);
            comm.Parameters.AddWithValue("@contactEmail", contactEmail);
            comm.Parameters.AddWithValue("@contactMessage", contactMessage); 



            //Attempt connection to the server

            try
            {
                Conn.Open();
                //Phone or "dial" the DB
                int intRecs = comm.ExecuteNonQuery();
                //strResult = $"SUCCESS: Inserted {intRecs} records."; //Report that DB accepted record 
                strResult = $"<br> Sent!"; //Report that DB accepted record 
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