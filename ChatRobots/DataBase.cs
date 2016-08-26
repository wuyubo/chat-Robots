using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;//数据库
using System.Data.SqlClient;//数据库

namespace ChatRobots
{
    class DataBase
    {
        public static List<conversation> search(string sql)//根据接收到的字符串返回数据
        {
            List<conversation> answer = new List<conversation>();
            conversation con = null;
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|ChatRobot.mdb");
            ///连接数据库
            conn.Open();
            OleDbCommand com = new OleDbCommand(sql, conn);//执行sql查询
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())//读取查询结果
            {
                con = new conversation(reader.GetString(0), reader.GetString(1));
                answer.Add(con);
            }
            conn.Close();
            return answer;
        }
        public static void Insert(string ask,string answer)///数据库插入数据
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|ChatRobot.mdb");
            conn.Open();
            string sql = "INSERT INTO chatwords (ask, answer)  VALUES   ( '" + ask + "', '" + answer + "')";
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader reader = com.ExecuteReader();
            reader.Read();
            conn.Close();
        }
    }
    class conversation //对话类，存放ask和answer
    {
        public string ask;
        public string answer;
        public conversation(string _ask, string _answer)
        {
            this.ask = _ask;
            this.answer = _answer;
        }
    }
}
