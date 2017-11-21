using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using System.Data;

namespace DXApplication4
{
    class kczj
    {
        /*加库存*/
        public static bool kc_add(string yfbh, string sl)
        {
            try
            {
                string sql = "select * from gl_kc where kc_yf_bh ='" + yfbh + "'";
                DataTable dt = mysql.dt(confighelper.connStr, sql);
                if (dt.Rows.Count == 0)
                {
                    sql = "insert into gl_kc(kc_yf_bh,kc_yf_sl) values('" + yfbh + "'," + sl + ")";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                }
                else
                {
                    sql = "update gl_kc set gl_kc.kc_yf_sl=gl_kc.kc_yf_sl+" + sl + " where kc_yf_bh='" + yfbh + "'";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /*减库存*/
        public static bool kc_reduce(string yfbh, string sl)
        {
            try
            {
                string sql = "select * from gl_kc where kc_yf_bh ='" + yfbh + "'";
                DataTable dt = mysql.dt(confighelper.connStr, sql);
                if (dt.Rows.Count == 0)
                {
                    sql = "insert into gl_kc(kc_yf_bh,kc_yf_sl) values('" + yfbh + "',-" + sl + ")";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                }
                else
                {
                    sql = "update gl_kc set gl_kc.kc_yf_sl=gl_kc.kc_yf_sl-" + sl + " where kc_yf_bh='" + yfbh + "'";
                    mysql.ExecuteNonQuery(confighelper.connStr, sql);
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
