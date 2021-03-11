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
        private string contactStatus;
        protected string feedback; //Shared between parent and child files only; intended to track error messages
        private int contactID;

        public Int32 ContactID
        {
            get
            {
                return contactID;
            }
            set
            {
                if (value >= 0)
                {
                    contactID = value;
                }
                else
                {
                    //Error message
                    feedback += "\n ERROR: Invalid Contact ID.";
                }
            }
        }

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

        public string ContactStatus
        {
            get
            {
                return contactStatus;
            }
            set
            {
                //Check for empty spaces
#pragma warning disable CS0436 // Type conflicts with imported type
                if (validation.dataEntered(value))
#pragma warning restore CS0436 // Type conflicts with imported type
                {
                    contactStatus = value; //if the value isn't null, store it
                }
                else
                {
                    feedback += "\n <br> ERROR: Response required.";
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
            contactStatus = "";
            contactID = 0;
            feedback = "";

        }
        
        
        
        //Utility function -- controls all SQL Server login infos
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


            //Send out command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL; //Commander knows what to say
            comm.Connection = Conn; //Where is the phone? Right here.


            //Fill in all perameters in the same order as initilization
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

         

        //--------------------------------------------------------- DATA SERVER - P1: DRILL DOWN SEARCH | DS ----------------------------------------------------

        public DataSet SearchContactUs(string strCustomerName, string strCustomerEmail)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();

            //Create a command for SQL statement
            SqlCommand comm = new SqlCommand();

            //SQL select statement to perform the search in DB
            String strSQL = "SELECT contactName, contactEmail, contactMessage, contactID FROM contactUs WHERE 0=0";
            //ADDED contactID ^

            //If first/last name is filled in, include it as search critera
            if (strCustomerName.Length > 0)
            {
                strSQL += "AND contactName LIKE @contactName";
                comm.Parameters.AddWithValue("@contactName", "%" + strCustomerName + "%");
            }
            if (strCustomerEmail.Length > 0)
            {
                strSQL += "AND contactEmail LIKE @contactEmail";
                comm.Parameters.AddWithValue("@contactemail", "%" + strCustomerEmail + "%");
            }




            //----------------------------------------------------------- Create a Database Tools & Configure | DS ---------------------------------------------- 

            SqlConnection conn = new SqlConnection();

            //Create who/what/where of Database
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            //Fill in basic information to command prompt

            //Tell commander which connection to use 
            comm.Connection = conn;
            //Tell the command what to say 
            comm.CommandText = strSQL;


            //--------------------------------------------------------- Create Data Adapter | DS --------------------------------------------------------------------

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm; //Commander needs translator (dataAdapater) that speaks with datasets 


            //--------------------------------------------------------- Get Data | DS ------------------------------------------------------------------------------

            //Open connection "Pick up the Phone"
            conn.Open();

            //Fill dataset with results from database and call it with: contactUs_Temp"
            da.Fill(ds, "contactUs_Temp");

            //Close connection "Hang up the Phone"
            conn.Close();

            //Return the data
            return ds;

        }

        //--------------------------------------------------------- DATA READER - P1: DRILL DOWN SEARCH (ONLY GOES FORWARD) | DR ----------------------------------------------------

        public SqlDataReader SearchContactUs_dr(String strCustomerName, string strCustomerEmail)
        {
            //Declare DataReader to returned filled 
            SqlDataReader dr;

            //Create a command for SQL statement
            SqlCommand comm = new SqlCommand();

            //Write a select statement to preform search in DB
            string strSQL = "SELECT contactName, contactEmail, contactMessage FROM contactUs WHERE 0=0";

            //If name is filled in, include it as search critera
            if (strCustomerName.Length > 0)
            {
                strSQL += "AND contactName LIKE @contactName";
                comm.Parameters.AddWithValue("@contactName", "%" + strCustomerName + "%");
            }
            if (strCustomerEmail.Length > 0)
            {
                strSQL += "AND contactEmail LIKE @contactEmail";
                comm.Parameters.AddWithValue("@contactEmail", "%" + strCustomerEmail + "%");
            }



            //----------------------------------------------------------- Create a Database Tools & Configure | DR ---------------------------------------------- 

            SqlConnection conn = new SqlConnection();

            //Create who/what/where of Database
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            //Fill in basic information to command prompt

            //Tell commander which connection to use 
            comm.Connection = conn;
            //Tell the command what to say 
            comm.CommandText = strSQL;


            //--------------------------------------------------------- Get Data | DR ------------------------------------------------------------------------------

            //Open connection "Pick up the Phone"
            conn.Open(); 

            dr = comm.ExecuteReader();

            //Close connection "Hang up the Phone"
            // conn.Close(); <-- don't do this, it'll destory the connection 

            //Return the data
            return dr;

        }


        //--------------------------------------------------------- Find Data Based On ID ------------------------------------------------------------------------------


        public SqlDataReader FindCustomer(int intContactID)
        {
            //Create and initialize DB tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            //Select SQL statement will select and display everything in DB for contactUs table
            string sqlString = "SELECT * FROM contactUs WHERE contactID = @contactID;";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@contactID", intContactID);



            conn.Open();

            return comm.ExecuteReader();


        }



        //--------------------------------------------------------- Delete A Record By ID ------------------------------------------------------------------------------
        /*  public string DelectContact(int intContactID)
          {
              Int32 intRecords = 0;
              string strResult = "";


              //Create and initialize DB tools
              SqlConnection conn = new SqlConnection();
              SqlCommand comm = new SqlCommand();

              //Connect
              string strConn = GetConnected();

              string sqlString = "DELETE from wingFlavors WHERE wingID = @wingID;";

              conn.ConnectionString = strConn;

              //Give command object the information it needs
              comm.Connection = conn;
              comm.CommandText = sqlString;
              comm.Parameters.AddWithValue("wingID", intEwingID);


              try
              {
                  conn.Open();

                  //Run the deleted and store record effected
                  intRecords = comm.ExecuteNonQuery();
                  strResult = intRecords.ToString() + "Records deleted.";
              }
              catch (Exception err)
              {
                  strResult = "ERROR: " + err.Message;
              }
              finally
              {
                  conn.Close();
              }
              return strResult;

          }*/


     
 

        //------------------------------------------------------------------ Update a Record In DB ------------------------------------------------------
        public string UpdateARecord()
        {
            Int32 intRecords = 0;
            string strResult = "";
             


            //Update SQL command string
            string strSQL = "UPDATE contactUs SET contactStatus = @contactStatus WHERE contactID = @contactID;";

            //string strSQL = "UPDATE contactUs SET contactName = @contactName, contactEmail = @contactEmail, contactMessage = @contactMessage, contactStatus = @contactStatus WHERE contactID = @contactID;";

            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;



            //Fill in all perameters in the same order
            comm.Parameters.AddWithValue("@contactName", contactName);
            comm.Parameters.AddWithValue("@contactEmail", contactEmail);
            comm.Parameters.AddWithValue("@contactID", contactID);
            comm.Parameters.AddWithValue("@contactMessage", contactMessage);
            comm.Parameters.AddWithValue("@contactStatus", contactStatus);



            try
            {
                conn.Open();

                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " Records Updated.";
                conn.Close();
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
            return strResult;
        }

    }
}



 