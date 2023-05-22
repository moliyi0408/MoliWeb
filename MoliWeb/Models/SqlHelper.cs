using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MoliWeb.Models;

namespace MoliWeb
{

    public class SqlHelper
    {
        string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|Database1.mdf;" +
            "Integrated Security=True";
        public List<Userinfo> GetUser()
        {
            List<Userinfo> userinfos = new List<Userinfo>();
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand com = new SqlCommand("select * from Userinfo");
            com.Connection = conn;
            conn.Open();
            //SqlDataReader 在讀取資料庫時，是一行一行地讀取
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Userinfo userinfo = new Userinfo
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            UserName = reader.GetString(reader.GetOrdinal("UserName")),
                            Age = reader.GetInt32(reader.GetOrdinal("Age")),
                        };
                        userinfos.Add(userinfo);
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("執行 SQL 查詢時發生錯誤：{0}", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return userinfos;

        }

        public void NewUserInfo(Userinfo userinfo)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand com = new SqlCommand(@"insert into Userinfo values(@UserName,@Age)");
            com.Connection = conn;
            com.Parameters.Add(new SqlParameter("@UserName", userinfo.UserName));
            com.Parameters.Add(new SqlParameter("@Age", userinfo.Age));
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}