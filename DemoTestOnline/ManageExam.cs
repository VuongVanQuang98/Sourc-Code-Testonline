using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DemoTestOnline
{
  public  class ManageExam
    {
        
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection("SERVER = DESKTOP-P94RDLC; Database = DemoTestOnline; uid = sa; pwd = 12345");
            return conn;
        }
        public bool AddNewExam (string id , string date)
        {
            string sql = "INSERT INTO tblExam ( _id , _date  ) VALUES (@i,@d) ";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@d", date);
         
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public bool AddExamDetail (string eid, string qid)
        {
            string sql = "INSERT INTO tblExamDetail (_eID,_qID) VALUES (@e,@q)";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@e", eid);
            cmd.Parameters.AddWithValue("@q", qid);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        public bool UpdateExam(string id , string date , string status)
        {
            string sql = "Update tblExam SET _date=@dt,_status=@st WHERE _id =@i ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@dt", date);
            cmd.Parameters.AddWithValue("@st", status);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
      

        public bool CheckExist(string examcode)
        {
            bool result = false;
            string sql = "SELECT * FROM tblExam WHERE _id = @id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", examcode);
            SqlDataReader rd = cmd.ExecuteReader();
            result = rd.HasRows;
            cmd.Connection.Close();
            return !result;
        }

        public DataTable GetExams()
        {
            string sql = "SELECT * FROM tblExam";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }
        public List<Question> GetQuestions(string sid)
        {
            List<Question> list = new List<Question>();
            string sql = "SELECT * FROM tblQuestion WHERE _sid ='" + sid + "'";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                Question q = new Question();
                q.ID = rd.GetString(0);
                q.Content = rd.GetString(1);
                q.A = rd.GetString(2);
                q.B = rd.GetString(3);
                q.C = rd.GetString(4);
                q.D = rd.GetString(5);
                q.Correct = rd.GetString(6);
                list.Add(q);

            }
            rd.Close();
            cmd.Connection.Close();
            return list;
        }
            public List<Question> GetRanDomQuestion (string sid )
            {
                 List<Question> q25 = new List<Question>();
                  List<Question> listfull = GetQuestions(sid);
                int count = 0;
                 while (count < 5)
                {
                     Random r = new Random();
                     int i = r.Next(0, listfull.Count - 1);
                     Question q = listfull[i];
                     if (CheckExist(q.ID, q25))
                         {
                            q25.Add(q);
                             count++;
                        }

                }
            return q25;
            }
        
        public bool CheckExist (string id , List<Question> qs)
        {
            foreach (var item in qs)
                if (item.ID.Equals(id))
                    return false;
            return true;
        }
        public DataTable SearchByIdExam(string id)
        {
            string sql = "SELECT * FROM tblExam WHERE _id = '" + id + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            da.Fill(dt);
            return dt;
        }



    }
}
