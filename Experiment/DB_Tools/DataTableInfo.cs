using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.DB_Tools
{
    class DataTableInfo
    {
        //获得数据库中的所有表信息
        public static DataTable GetTableInfo()
        {
            string sql = "select * from INFORMATION_SCHEMA.TABLES";
            return DBAccess.ExecuteQueryReturnDT(sql);
        }

        //获得某一个表的所有列信息
        public static DataTable GetColumnsInfo(string tablename)
        {
            string sql = "select * from INFORMATION_SCHEMA.COLUMNS t where t.TABLE_NAME = '" + tablename + "'";
            return DBAccess.ExecuteQueryReturnDT(sql);
        }

        //获得表中的数据
        public static DataTable GetDataByTableName(string tablename)
        {
            string sql = "select * from " + tablename;
            return DBAccess.ExecuteQueryReturnDT(sql);
        }

    }
}
