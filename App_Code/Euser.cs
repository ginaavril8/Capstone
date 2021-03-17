using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Capstone.App_Code;

namespace Capstone.App_Code
{
    public class Euser : user
    {
        private int euserID;

        public Int32 EuserID
        {
            get
            {
                return euserID;
            }
            set
            {
                if (value >=0)
                {
                    euserID = value;
                }
                else
                {
                    feedback += "\nERROR: Invalid user ID.";
                }
            }
        }
        private string GetConnected()
        {
            return @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE245_GMartin;User Id=SE245_GMartin;Password=008003563;";
        }

        public Euser() : base()
        {
            euserID = 0;
        }

        public DataSet SearchEuser_DS(string strUserID, string strPassword)
        {
            DataSet ds = new DataSet();
            SqlCommand comm = new SqlCommand();

            String strSQL = "SELECT userID, firstName, lastName, userName FROM userCredentials WHERE 0=0";

            if (strUserID.Length > 0)
            {
                strSQL += " AND userID = @userID";
                comm.Parameters.AddWithValue("@userID", "%" + strUserID + "%");
            }
            if (strPassword.Length > 0)
            {
                strSQL += " AND userPassword = @userPassword";
                comm.Parameters.Add("@userPassword", "%" + strPassword + "%");

                    }

            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();

            da.Fill(ds, "Euser_temp");

            conn.Close();

            return ds;

        }

        public SqlDataReader SearchEuser_DR(String strUserID, string strPassword)
        {
            SqlDataReader dr;
            SqlCommand comm = new SqlCommand();
            string strSQL = "SELECT userID, firstName, lastName, userName, userPassword, userEmail FROM userCredentials WHERE 0=0";

            if (strUserID.Length > 0)
            {
                strSQL += " AND userID = @userID";
                comm.Parameters.AddWithValue("@userID", "%" + strUserID + "%");

            }

            if (strPassword.Length > 0)
            {
                strSQL += " AND userPassword = @userPassword";
                comm.Parameters.AddWithValue("@userPassword", "%" + strPassword + "%");
            }


            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;
            comm.Connection = conn;
            comm.CommandText = strSQL;
            conn.Open();
            dr = comm.ExecuteReader();

            return dr;
        }

        public SqlDataReader FindOneUser(int intUserID)
        {
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

        public string UpdateARecord()
        {
            Int32 intRecords = 0;
            string strResult = "";

            string strSQL = "UPDATE userCredentials SET userID = @userID, firstName = @firstName, lastName = @lastname, userName = @userName, userPassword = @userPassword, userEmail = @userEmail;";

            SqlConnection conn = new SqlConnection();
            string strConn = GetConnected();
            conn.ConnectionString = strConn;

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@userID", EuserID);
            comm.Parameters.AddWithValue("@firstName", UserFname);
            comm.Parameters.AddWithValue("@lastName", UserLname);
            comm.Parameters.AddWithValue("@userName", UserName);
            comm.Parameters.AddWithValue("@userPassword", UserPassword);
            comm.Parameters.AddWithValue("@userEmail", UserEmail);

            try
            {
                conn.Open();
                intRecords = comm.ExecuteNonQuery();
                strResult = intRecords.ToString() + " record updated.";
                conn.Close();

            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }
            return strResult;




        }


    }
}