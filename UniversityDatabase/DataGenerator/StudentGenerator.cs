using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace DataGenerator
{
    class StudentGenerator : BaseGenerator
    {
        SqlConnection _conn;

        public StudentGenerator(string connString)
        {
            _conn = new SqlConnection(connString);
        }

        /// <summary>
        /// Renerates student, add student in 
        /// DB
        /// </summary>
        /// <returns>ID of added student</returns>
        public override int generate()
        {
            string name = getName();
            string surname = getSurname();
            string thirdname = getThirdname();
            string pasNo = getPassportNumber();
            string recordBook = getPassportNumber();
            int age = getAge();
            int startYear = getRecentYear();
            string phone = getPhone();
            string address = getAddress();

            SqlCommand comm = new SqlCommand("", _conn);
            comm.Parameters.Add("@firstName", SqlDbType.VarChar).Value = name;
            comm.Parameters.Add("@lastName", SqlDbType.VarChar).Value = surname;
            comm.Parameters.Add("@thirdName", SqlDbType.VarChar).Value = thirdname;
            comm.Parameters.Add("@pasNo", SqlDbType.VarChar).Value = pasNo;
            comm.Parameters.Add("@recordBook", SqlDbType.VarChar).Value = recordBook;
            comm.Parameters.Add("@age", SqlDbType.SmallInt).Value = age;
            comm.Parameters.Add("@startYear", SqlDbType.SmallInt).Value = startYear;
            comm.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;

            comm.CommandText = "INSERT Students OUTPUT Inserted.studID " +
                               "VALUES(@firstName, @lastName, @thirdName, @pasNo, @recordBook, @age, @startYear, @phone, NULL, NULL)";

            return (int)comm.ExecuteNonQuery();
        }        
    }
}
