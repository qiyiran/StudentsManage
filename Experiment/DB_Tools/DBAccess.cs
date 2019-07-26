using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Experiment.DB_Tools
{
    class DBAccess
    {
        //使用关键自static，在其他文件中调用它时不需要实例化对象
        private static string ConnStr = ConfigurationManager.ConnectionStrings["ExperimentConnectionString"].ToString();


        ///------------------------------------------------------------------------*
        /// <summary>                                                              *
        /// 属 性 名：_connectionString                                            *
        /// 属性功能：获得属性字段_connectionString的值                            *
        /// </summary>                                                             *
        /// -----------------------------------------------------------------------*
        public static string _connectionString
        {
            get
            {
                return ConnStr;
            }
            set
            {
                ConnStr = value;
            }
        }





        ///-------------------------------------------------------------------------*
        /// <summary>                                                               *
        /// 函数名：ConnectTest                                                     *
        /// 功  能：测试数据库是否连接成功                                          *
        /// </summary>                                                              *
        /// <returns>数据库连接成功返回true,否则返回false</returns>                 *
        ///-------------------------------------------------------------------------*  
        public static bool ConnectTest()
        {
            //using语句：定义一个范围，将在此范围之外释放一个或多个对象
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }






        ///------------------------------------------------------------------------*
        /// <summary>　　　　　　　　　　　　　　　　                              *
        /// 函数名： ExecuteQueryReturnDT                                          *
        /// 功  能：由Sql查询语句得到DataTable                                     *
        /// </summary>                                                             *
        /// <param name="myCommandString">sql语句</param>                          *
        /// <returns>查询的结果，放在数据表中</returns>                            *
        /// -----------------------------------------------------------------------*
        public static DataTable ExecuteQueryReturnDT(string myCommandString)
        {
            //会自动释放connection变量
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();   //打开连接
                    }
                    SqlCommand myCommand = new SqlCommand(myCommandString, connection);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
                    myAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    connection.Close();
                }
                return dataTable;
            }
        }




        ///------------------------------------------------------------------------*
        /// <summary>                                                              *
        /// 函数名： ExecuteDataSet                                                *
        /// 功  能：由Sql查询语句得到DataSet                                       *
        /// </summary>                                                             *
        /// <param name="sqlstr">sql语句</param>　　　                             *
        /// <param name="ds">数据集</param>                                        *
        /// <param name="TableName">数据表</param>                                 *
        /// <returns>查询的结果，放在数据集中</returns>                            *
        /// -----------------------------------------------------------------------*
        public static DataSet ExecuteDataSet(string sqlstr)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();   //打开连接
                    }
                    //2、新建数据适配
                    SqlDataAdapter thisAdapter = new SqlDataAdapter(sqlstr, connection);
                    //4、将数据库中数据通过数据适配器的Fill()方法填充到DataSet中

                    DataSet ds = new DataSet();
                    thisAdapter.Fill(ds);
                    connection.Close();//5、关闭连接
                    return ds;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    if (connection.State != ConnectionState.Closed)
                        connection.Close();
                    return null;
                }
            }
        }








        ///------------------------------------------------------------------------*
        /// <summary>                                                              *
        /// 函数名： ExecuteNonQuery                                               *
        /// 功  能：执行非查询操作                                                 *
        /// </summary>                                                             *
        /// <param name="strsql">sql语句</param>                                   *
        /// <returns>执行成功的结果数目</returns>                                  *
        /// -----------------------------------------------------------------------*
        public static int ExecuteNonQuery(string strsql)
        {
            //会自动释放connection变量，相当于finally语句
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand cmd = new SqlCommand(strsql, connection);
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    connection.Close();
                    return -1;
                }
            }
        }
    }
}
