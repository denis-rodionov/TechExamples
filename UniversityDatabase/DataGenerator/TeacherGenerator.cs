using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataGenerator
{
    class TeacherGenerator : BaseGenerator
    {
        SqlConnection _conn;

        public TeacherGenerator(string connString)
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
            int degree = getDegree();
            int age = getAge();
            string phone = getPhone();
            string address = getAddress();
            int post = getPost();
            int rank = getRank();

            SqlCommand comm = new SqlCommand("", _conn);
            comm.Parameters.Add("@firstName", SqlDbType.VarChar).Value = name;
            comm.Parameters.Add("@lastName", SqlDbType.VarChar).Value = surname;
            comm.Parameters.Add("@thirdName", SqlDbType.VarChar).Value = thirdname;
            comm.Parameters.Add("@pasNo", SqlDbType.VarChar).Value = pasNo;
            comm.Parameters.Add("@age", SqlDbType.SmallInt).Value = age;
            comm.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            comm.Parameters.Add("@degree", SqlDbType.SmallInt).Value = degree;
            comm.Parameters.Add("@post", SqlDbType.SmallInt).Value = post;
            comm.Parameters.Add("@rank", SqlDbType.SmallInt).Value = rank;

            comm.CommandText = "INSERT Teachers OUTPUT Inserted.teachID " +
                               "VALUES(@firstName, @lastName, @thirdName, @pasNO, @degree, @age, @phone, NULL, NULL, @post, @rank)";

            return (int)comm.ExecuteNonQuery();
        }  
    }
}
