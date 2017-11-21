using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace DXApplication4
{
    class mysql
    {
        
        public static int ExecuteNonQuery(string conn, string sql)
        {
            return MySqlHelper.ExecuteNonQuery(conn, sql, null);            
        }
        public static DataTable dt(string connStr, string sql)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = conn;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                adapter.Dispose();
                conn.Close();
            }
            return dt;
        }
        public static DataSet ds(string connStr,string sql)
        {
            DataSet ds = new DataSet();
            ds = MySqlHelper.ExecuteDataset(connStr, sql);
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"> and 开头</param>
        /// <param name="idName"></param>
        /// <param name="page_id"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static string getSqlPager(string result, string tableName,
            string where, string idName,string order, int page_id, int pageSize)
        {
            if (page_id > 1)
            {
                return @"SELECT  " + result + @" 
                FROM " + tableName + @" 
                WHERE (" + idName + @" >
                          (SELECT MAX(" + idName + @")
                         FROM (SELECT  " + idName + @" 
                                 FROM " + tableName + @"
                                where 1=1 " + where + @"
                                 ORDER BY " + idName + @" "+order+@" LIMIT "+(page_id - 1) * pageSize +@" ) AS T)
                         " + where + @"
                )
                ORDER BY " + idName+" "+order+" LIMIT "+pageSize;
            }
            else
            {
                return "select " + result + " from " + tableName + " where 1=1 " + where + " ORDER BY " + idName + " " + order + " LIMIT " + pageSize;
            }
        }

        public static string getSqlPager1(string result, string tableName,
            string where, string idName, string group, int page_id, int pageSize)
        {
            if (page_id > 1)
            {
                return @"SELECT  " + result + @" 
                FROM " + tableName + @" 
                WHERE (" + idName + @" >
                          (SELECT MAX(" + idName + @")
                         FROM (SELECT  " + idName + @" 
                                 FROM " + tableName + @"
                                where 1=1 " + where + @"
                                 GROUP BY " + group + @" LIMIT " + (page_id - 1) * pageSize + @" ) AS T)
                         " + where + @"
                )
                GROUP BY " + group + "  LIMIT " + pageSize;
            }
            else
            {
                return "select " + result + " from " + tableName + " where 1=1 " + where + " GROUP BY "+group+" LIMIT " + pageSize;
            }
        }
        public static string getSqlPager1(string result, string tableName,
            string where, string idName, string group, int page_id, int pageSize, string idName1)
        {
            if (page_id > 1)
            {
                return @"SELECT  " + result + @" 
                FROM " + tableName + @" 
                WHERE (" + idName + @" >
                          (SELECT MAX(" + idName1 + @")
                         FROM (SELECT  " + idName + @" 
                                 FROM " + tableName + @"
                                where 1=1 " + where + @"
                                 GROUP BY " + group + @" LIMIT " + (page_id - 1) * pageSize + @" ) AS T)
                         " + where + @"
                )
                GROUP BY " + group + "  LIMIT " + pageSize;
            }
            else
            {
                return "select " + result + " from " + tableName + " where 1=1 " + where + " GROUP BY " + group + " LIMIT " + pageSize;
            }
        }
        public static DataTable dt_getPager(string sql_split,string sql_total,string con,out int total)
        {
            total = dt(con, sql_total).Rows.Count;
            return dt(con, sql_split);
        }
    }
}
