using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClientApp
{
   public  class ClientModel
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("SERVER = DESKTOP-P94RDLC; Database = DemoTestOnline; uid = sa; pwd = 12345");
            return conn;
        }
        public bool CheckLogin ( string user , string pass)
        {
         
            string sql = "SELECT * FROM tblStudent WHERE _Username =@u and _password =@p";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", user);
            cmd.Parameters.AddWithValue("@p", pass);
            SqlDataReader rd = cmd.ExecuteReader();
            bool result = rd.HasRows;
            rd.Close();
            cmd.Connection.Close();
            return result;
        }
        public bool CheckExam(string examcode)
        {
            bool result = false;
            string sql = "SELECT * FROM tblExam WHERE _id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", examcode);
            SqlDataReader red = cmd.ExecuteReader();
            while (red.Read())
            {
                string stt = red.GetString(2);
                result = stt.Equals("D");
            }
            cmd.Connection.Close();
            return result;
        }
        public List<string> GetQuestionByExam(string examCode)
        {
            string sql = "SELECT * FROM tblExamDetail WHERE _eID =@u";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", examCode);
            SqlDataReader rd = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (rd.Read())
            {
                list.Add(rd.GetString(1));
            }
            rd.Close();
            cmd.Connection.Close();
            return list;
        }
        
        public Question GetQuestionByID(string id)
        {
            string sql = "SELECT * FROM tblQuestion WHERE _id =@u";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@u", id);
            // cmd.Parameters.AddWithValue("@p", pass);
            SqlDataReader rd = cmd.ExecuteReader();
            Question q = null;
            while (rd.Read())
            {
                q = new Question();
                q.ID = rd.GetString(0);
                q.Content = rd.GetString(1);
                q.A = rd.GetString(2);
                q.B = rd.GetString(3);
                q.C = rd.GetString(4);
                q.D = rd.GetString(5);
                q.Correct = rd.GetString(6);
              
            }
            rd.Close();
            cmd.Connection.Close();
            return q;
        }

    }
}
