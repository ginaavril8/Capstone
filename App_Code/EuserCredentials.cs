using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Capstone.App_Code;

namespace Capstone.App_Code
{
    public class EuserCredentials : userCredentials
    {
        //Create variable to hold EWing's ID assigned by database
        private int userID;

        public Int32 UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if (value >= 0)
                {
                    userID = value;
                }
                else
                {
                    //Error message
                    feedback += "\n ERROR: Invalid User ID.";
                }

            }
        }


        //Utility function -- controls all SQL Server login info

        private string GetConnected()
        {
            return @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE245_GMartin;User Id=SE245_GMartin;Password=008003563;";
        }

        //Default Constructor
        public EuserCredentials() : base() //Calls the parents constructor
        {
            // BookmarkPage = 0;
            // dateRentalExpires = DateTime.Now.AddDays(14);
            userID = 0;

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
            comm.Connection = Conn; //Where is the phone? Right here.

            //ADD USER ID??? 2/17/21

            //Fill in all perameters in the same order
            comm.Parameters.AddWithValue("@firstName", FirstName);
            comm.Parameters.AddWithValue("@lastName", LastName);
            comm.Parameters.AddWithValue("@userPassword", UserPassword);
            comm.Parameters.AddWithValue("@userEmail", UserEmail);
            comm.Parameters.AddWithValue("@wingTally", WingTally);
            comm.Parameters.AddWithValue("@userID", UserID);

          
            //Attempt connection to the server

            try
            {
                Conn.Open();
                //Phone or "dial" the DB
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records."; //Report that DB accepted record 
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

        public DataSet SearchUser(string strFirstName, string strUserName)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();

            //Create a command for SQL statement
            SqlCommand comm = new SqlCommand();

            //Write a select statement to perform the search
            String strSQL = "SELECT userID, firstName, lastName, userName FROM userCredentials WHERE 0=0";

            //If first/last name is filled in, include it as search critera
            if (strFirstName.Length > 0)
            {
                strSQL += "AND firstName LIKE @firstName";
                comm.Parameters.AddWithValue("@firstName", "%" + strFirstName + "%");
            }
            if (strUserName.Length > 0)
            {
                strSQL += "AND userName LIKE @userName";
                comm.Parameters.AddWithValue("@userName", "%" + strUserName + "%");
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

            //Fill dataset with results from database and call it with: EwingID_Temp"
            da.Fill(ds, "EuserCredentials_Temp");

            //Close connection "Hang up the Phone"
            conn.Close();

            //Return the data
            return ds;

        }

        //--------------------------------------------------------- DATA READER - P1: DRILL DOWN SEARCH (ONLY GOES FORWARD) | DR ----------------------------------------------------

        public SqlDataReader SearchUser_DR(String strFirstName, string strUserName)
        {
            //Declare DataReader to returned filled 
            SqlDataReader dr;

            //Create a command for SQL statement
            SqlCommand comm = new SqlCommand();

            //Write a select statement to preform search
            string strSQL = "SELECT userID, firstName, userName FROM userCredentials WHERE 0=0";

            //If name is filled in, include it as search critera
            if (strFirstName.Length > 0)
            {
                strSQL += "AND firstName LIKE @firstName";
                comm.Parameters.AddWithValue("@firstName", "%" + strFirstName + "%");
            }
            if (strUserName.Length > 0)
            {
                strSQL += "AND userName LIKE @userName";
                comm.Parameters.AddWithValue("@userName", "%" + strUserName + "%");
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

            //Fill dataset with results from database and call it with :EBooks_Temp"
            dr = comm.ExecuteReader();

            //Close connection "Hang up the Phone"
            // conn.Close(); <-- don't do this, it'll destory the connection 

            //Return the data
            return dr;

        }


        //--------------------------------------------------------- Find Data Based On ID ------------------------------------------------------------------------------


        public SqlDataReader FindUser(int intUserID)
        {
            //Create and initialize DB tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            string sqlString = "SELECT * FROM userCredentials WHERE userID = @userID;";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@userID", intUserID);



            conn.Open();

            return comm.ExecuteReader();


        }



        //--------------------------------------------------------- Delete A Record By ID ------------------------------------------------------------------------------
        public string DeleteUser(int intUserID)
        {
            Int32 intRecords = 0;
            string strResult = "";


            //Create and initialize DB tools
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //Connect
            string strConn = GetConnected();

            string sqlString = "DELETE from userCredentials WHERE userID = @userID;";

            conn.ConnectionString = strConn;

            //Give command object the information it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("userID", intUserID);


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

        }




        //------------------------------------------------------------------ Update a Record In DB ------------------------------------------------------
        public string UpdateARecord()
        {
            Int32 intRecords = 0;
            string strResult = "";


            //Update SQL command string
            string strSQL = "UPDATE userCredentials SET firstName = @firstName, lastName = @lastName, userName = @userName, userEmail = @userEmail, userPassword = @userPassword, wingTally = @wingTally WHERE userID = @userID;";

            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            //Fill in all perameters in the same order
            comm.Parameters.AddWithValue("@firstName", FirstName);
            comm.Parameters.AddWithValue("@lastName", LastName);
            comm.Parameters.AddWithValue("@userName", UserName);
            comm.Parameters.AddWithValue("@userEmail", UserEmail);
            comm.Parameters.AddWithValue("@userPassword", UserPassword);
            comm.Parameters.AddWithValue("@wingTally", WingTally);


            try
            {
                conn.Open();

                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + "Records Updated.";
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