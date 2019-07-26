using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Experiment.Class;

namespace Experiment.DB_Tools
{
    class DB_Student
    {
        //根据id获得学生信息
        public static DataTable GetStuInfoByID(string stuid)
        {
            string sql = "select * from Student where StuID = '" + stuid + "'";
            return DBAccess.ExecuteQueryReturnDT(sql);
        }

       
        public static int AddStuInfo(Student stu)
        {
            string sql = "insert into Student values ('" + stu.StuID + "','" + stu.StuName + "','" + stu.StuClassID + "','" + stu.StuClassName + "','" + stu.StuClassTeacher 
                + "','" + stu.StuSex + "','" + stu.StuAge + "','" + stu.StuHeight + "','" + stu.StuWeight + "','" + stu.StuAddress + "')";
            return DBAccess.ExecuteNonQuery(sql);
        }

        public static int UpdateStuInfo(Student stu)
        {
            string sql = "update Student set StuName='" + stu.StuName + "',StuClassID='" + stu.StuClassID + "',StuClassName='" + stu.StuClassName + "',StuClassTeacher='" + stu.StuClassTeacher
                + "',StuSex='" + stu.StuSex + "',StuAge='" + stu.StuAge + "',StuHeight='" + stu.StuHeight + "',StuWeight='" + stu.StuWeight + "',StuAddress='" + stu.StuAddress + "' where StuID = '" + stu.StuID + "'";
            return DBAccess.ExecuteNonQuery(sql);
        }

        public static int DelStuInfo(string stuid)
        {
            string sql = "delete from Student where StuID = '"+stuid+"'";
            return DBAccess.ExecuteNonQuery(sql);
        }

        public static DataTable SearchStuByWord(string keyword)
        {
            string sql = "select * from Student where StuID like '%" + keyword + "%' or StuName like '%" + keyword + "%' or StuClassID like '%" + keyword + "%' or StuClassName like '%"
                + keyword + "%' or StuClassTeacher like '%" + keyword + "%' or StuSex like '%" + keyword + "%' or StuAge like '%" + keyword + "%' or StuHeight like '%"
                + keyword + "%' or StuWeight like '%" + keyword + "%' or StuAddress like '%" + keyword + "%'";
            return DBAccess.ExecuteQueryReturnDT(sql);
        }
    }
}
