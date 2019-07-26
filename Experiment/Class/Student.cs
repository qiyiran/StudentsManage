using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment.Class
{
    class Student
    {
        public Student()
        { }

        public Student(string _stuid, string _stuname, string _stuclassid, string _stuclassname, string _stuclassteacher, bool _stusex, int _stuage, decimal? _stuheight, decimal? _stuweight, string _stuaddress)
        {
            this.StuID = _stuid;
            this.StuName = _stuname;
            this.StuClassID = _stuclassid;
            this.StuClassName = _stuclassname;
            this.StuClassTeacher = _stuclassteacher;
            this.StuSex = _stusex;
            this.StuAge = _stuage;
            this.StuHeight = _stuheight;
            this.StuWeight = _stuweight;
            this.StuAddress = _stuaddress;
        }

        #region Model
        private string _stuid;
        private string _stuname;
        private string _stuclassid;
        private string _stuclassname;
        private string _stuclassteacher;
        private bool _stusex;
        private int _stuage;
        private decimal? _stuheight;
        private decimal? _stuweight;
        private string _stuaddress;
        /// <summary>
        /// 
        /// </summary>
        public string StuID
        {
            set { _stuid = value; }
            get { return _stuid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StuName
        {
            set { _stuname = value; }
            get { return _stuname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StuClassID
        {
            set { _stuclassid = value; }
            get { return _stuclassid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StuClassName
        {
            set { _stuclassname = value; }
            get { return _stuclassname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StuClassTeacher
        {
            set { _stuclassteacher = value; }
            get { return _stuclassteacher; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool StuSex
        {
            set { _stusex = value; }
            get { return _stusex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int StuAge
        {
            set { _stuage = value; }
            get { return _stuage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? StuHeight
        {
            set { _stuheight = value; }
            get { return _stuheight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? StuWeight
        {
            set { _stuweight = value; }
            get { return _stuweight; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StuAddress
        {
            set { _stuaddress = value; }
            get { return _stuaddress; }
        }
        #endregion Model
    }
}
