using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Experiment.DB_Tools;
using Experiment.Class;
using System.Text.RegularExpressions;

namespace Experiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitTreeView();
        }

        //初始化TreeView，显示数据库的表的相关信息
        private void InitTreeView()
        {
            this.tvData.Nodes.Clear();
            //获得数据库中的所有表信息
            DataTable dtTables = DataTableInfo.GetTableInfo();

            TreeNode nodeTable = new TreeNode("Student");
            nodeTable.Expand();

            //获得表的所有信息
            DataTable dtStuInfo = DataTableInfo.GetDataByTableName("Student");
            for (int i = 0; i < dtStuInfo.Rows.Count; i++)
            {
                //提取出学号，并根据学号获得所有信息
                TreeNode nodeStuID = new TreeNode(dtStuInfo.Rows[i]["StuID"].ToString());
                DataTable dtData = DB_Student.GetStuInfoByID(dtStuInfo.Rows[i]["StuID"].ToString());

                TreeNode nodeStuName = new TreeNode(dtData.Rows[0]["StuName"].ToString());
                TreeNode nodeStuClassID = new TreeNode(dtData.Rows[0]["StuClassID"].ToString());
                TreeNode nodeStuClassName = new TreeNode(dtData.Rows[0]["StuClassName"].ToString());
                TreeNode nodeStuClassTeacher = new TreeNode(dtData.Rows[0]["StuClassTeacher"].ToString());

                TreeNode nodeStuSex = new TreeNode("男");
                if (0 == Convert.ToInt32(dtData.Rows[0]["StuSex"]))
                    nodeStuSex.Name = "女";

                TreeNode nodeClassID = new TreeNode(dtData.Rows[0]["StuClassID"].ToString());
                TreeNode nodeStuAge = new TreeNode(dtData.Rows[0]["StuAge"].ToString());
                TreeNode nodeStuHeight = new TreeNode(dtData.Rows[0]["StuHeight"].ToString());
                TreeNode nodeStuWeight = new TreeNode(dtData.Rows[0]["StuWeight"].ToString());
                TreeNode nodeStuAddress = new TreeNode(dtData.Rows[0]["StuAddress"].ToString());

                nodeStuID.Nodes.Add(nodeStuName);
                nodeStuID.Nodes.Add(nodeStuClassID);
                nodeStuID.Nodes.Add(nodeStuClassName);
                nodeStuID.Nodes.Add(nodeStuClassTeacher);
                nodeStuID.Nodes.Add(nodeStuSex);
                nodeStuID.Nodes.Add(nodeClassID);
                nodeStuID.Nodes.Add(nodeStuAge);
                nodeStuID.Nodes.Add(nodeStuHeight);
                nodeStuID.Nodes.Add(nodeStuWeight);
                nodeStuID.Nodes.Add(nodeStuAddress);

                nodeTable.Nodes.Add(nodeStuID);
            }
            this.tvData.Nodes.Add(nodeTable);

        }

        //点击学号，显示对应的数据
        private void tvData_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string parenttext = "";
            try { parenttext = this.tvData.SelectedNode.Parent.Text; }
            catch { }
            Regex reg = new Regex("[0-9]+");
            if (reg.IsMatch(this.tvData.SelectedNode.Text) && parenttext.Equals("Student"))
            {
                this.txtSearchStu.Text = this.tvData.SelectedNode.Text;
                btnStuSearch_Click(sender, e);
            }
        }

        //查询树
        private void btnDataSearch_Click(object sender, EventArgs e)
        {
			InitTreeView();
            string keyword = "1001";
            if(!this.txtTableSearch.Text.Trim().ToString().Equals(""))
                keyword = this.txtTableSearch.Text.Trim().ToString();

            DataTable dt = DB_Student.SearchStuByWord(keyword);
            if (dt.Rows.Count > 0)
            {
                this.txtSearchStu.Text = dt.Rows[0]["StuID"].ToString();
                foreach (TreeNode node in this.tvData.Nodes[0].Nodes)
                {
                    if (node.Text.Equals(dt.Rows[0]["StuID"].ToString()))
                    {
                        node.Expand();
                        node.BackColor = System.Drawing.Color.Red;
                        break;
                    }
                }
                btnStuSearch_Click(sender, e);
            }
        }
        

        //学生信息搜索
        private void btnStuSearch_Click(object sender, EventArgs e)
        {
            //获得搜索的学生学号
            string stuID = this.txtSearchStu.Text;
            if (stuID.Equals(""))
            {
                MessageBox.Show("请输入学号！", "【提示】");
            }
            else
            {
                DataTable dt = DB_Student.GetStuInfoByID(stuID);
                if (dt.Rows.Count > 0)
                {
                    InitStudentInfo(dt);
                }
                else
                {
                    MessageBox.Show("暂无此学生信息！", "【提示】");
                }
            }
        }

        //图书信息搜索
        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            //获得搜索的图书编号
            string bookID = this.txtBookIDSearch.Text;
            if (bookID.Equals(""))
            {
                MessageBox.Show("请输入图书编号！", "【提示】");
            }
            else
            {
                DataTable dt = DB_Book.GetBookInfoByID(bookID);
                if (dt.Rows.Count > 0)
                {
                    InitBookInfo(dt);
                }
                else
                {
                    MessageBox.Show("暂无此图书信息！", "【提示】");
                }
            }
        }

        //根据查询到的结果，加载学生信息
        public void InitStudentInfo(DataTable dt)
        {
            this.txtStuID.Text = dt.Rows[0]["StuID"].ToString();
            this.txtStuName.Text = dt.Rows[0]["StuName"].ToString();
            this.txtStuClassID.Text = dt.Rows[0]["StuClassID"].ToString();
            this.txtStuClassName.Text = dt.Rows[0]["StuClassName"].ToString();
            this.txtStuClassTeacher.Text = dt.Rows[0]["StuClassTeacher"].ToString();

            if (0 == Convert.ToInt32(dt.Rows[0]["StuSex"]))
                this.rdbWoman.Checked = true;

            this.txtStuAge.Text = dt.Rows[0]["StuAge"].ToString();
            this.txtStuHeight.Text = dt.Rows[0]["StuHeight"].ToString();
            this.txtStuWeight.Text = dt.Rows[0]["StuWeight"].ToString();
            this.txtStuAddress.Text = dt.Rows[0]["StuAddress"].ToString();
        }

        //根据查询到的结果，加载图书
        public void InitBookInfo(DataTable dt)
        {
            this.txtBookID.Text = dt.Rows[0]["BookID"].ToString();
            this.txtBookName.Text = dt.Rows[0]["BookName"].ToString();
            this.txtBookAuthor.Text = dt.Rows[0]["BookAuthor"].ToString();
            this.dtBookPublishTime.Text = dt.Rows[0]["BookPublishTime"].ToString();
            this.txtBookPublisher.Text = dt.Rows[0]["BookPublisher"].ToString();
            this.txtBookPrice.Text = dt.Rows[0]["BookPrice"].ToString();
            this.txtBookCategory.Text = dt.Rows[0]["BookCategory"].ToString();
            this.txtBookDescription.Text = dt.Rows[0]["BookDescription"].ToString();

            if (0 == Convert.ToInt32(dt.Rows[0]["BookResources"]))
                this.rdbBookNo.Checked = true;

            this.txtBookImage.Text = dt.Rows[0]["BookImage"].ToString();
            if (!dt.Rows[0]["BookImage"].ToString().Equals(""))
                this.picBookImage.Image = Image.FromFile(dt.Rows[0]["BookImage"].ToString());
        }

        //新增学生数据
        private void btnAddStu_Click(object sender, EventArgs e)
        {
            bool isMan = true;
            if (CheckStuInfo())
            {
                //判断是男性还是女性
                if (this.rdbWoman.Checked)
                    isMan = false;
                //实例化学生对象
                Student stu = new Student(this.txtStuID.Text.Trim().ToString(), this.txtStuName.Text.Trim().ToString(), this.txtStuClassID.Text.Trim().ToString()
                    , this.txtStuClassName.Text.Trim().ToString(), this.txtStuClassTeacher.Text.Trim().ToString(), isMan, Convert.ToInt32(this.txtStuAge.Text.Trim().ToString())
                    , Convert.ToDecimal(this.txtStuHeight.Text.Trim().ToString()), Convert.ToDecimal(this.txtStuWeight.Text.Trim().ToString()), this.txtStuAddress.Text.ToString());

                //获得学生学号
                string stuID = this.txtStuID.Text;

                DataTable dt = DB_Student.GetStuInfoByID(stuID);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("已存在学生信息，请检查学号", "【提示】");
                    return;
                }
                else if (DB_Student.AddStuInfo(stu) != -1)
                {
                    //将学生信息插入
                    MessageBox.Show("学生信息插入成功", "【提示】");
                }
            }
        }

        //学生信息合法性校验，不验证学号是否已存在，需额外判断
        public bool CheckStuInfo()
        {
            if (this.txtStuID.Text.Trim().Equals(""))
                MessageBox.Show("请输入学号", "【提示】");
            else if (this.txtStuName.Text.Trim().Equals(""))
                MessageBox.Show("请输入姓名", "【提示】");
            else if (this.txtStuClassID.Text.Trim().Equals(""))
                MessageBox.Show("请输入班级ID", "【提示】");
            else if (this.txtStuClassName.Text.Trim().Equals(""))
                MessageBox.Show("请输入班级名", "【提示】");
            else if (this.txtStuClassTeacher.Text.Trim().Equals(""))
                MessageBox.Show("请输入班主任姓名", "【提示】");
            else if (this.txtStuAge.Text.Trim().Equals(""))
                MessageBox.Show("请输入年龄", "【提示】");
            else if (this.txtStuHeight.Text.Trim().Equals(""))
                MessageBox.Show("请输入身高", "【提示】");
            else if (this.txtStuWeight.Text.Trim().Equals(""))
                MessageBox.Show("请输入体重", "【提示】");
            else
                return true;//没有未输入的信息
            return false;
        }

        //修改学生信息
        private void btnEditStu_Click(object sender, EventArgs e)
        {
            bool isMan = true;
            if (CheckStuInfo())
            {
                //判断是男性还是女性
                if (this.rdbWoman.Checked)
                    isMan = false;
                //实例化学生对象
                Student stu = new Student(this.txtStuID.Text.Trim().ToString(), this.txtStuName.Text.Trim().ToString(), this.txtStuClassID.Text.Trim().ToString()
                    , this.txtStuClassName.Text.Trim().ToString(), this.txtStuClassTeacher.Text.Trim().ToString(), isMan, Convert.ToInt32(this.txtStuAge.Text.Trim().ToString())
                    , Convert.ToDecimal(this.txtStuHeight.Text.Trim().ToString()), Convert.ToDecimal(this.txtStuWeight.Text.Trim().ToString()), this.txtStuAddress.Text.ToString());

                //获得学生学号
                string stuID = this.txtStuID.Text;

                DataTable dt = DB_Student.GetStuInfoByID(stuID);
                if (dt.Rows.Count > 0)
                {
                    if (DB_Student.UpdateStuInfo(stu) != -1)
                        //将学生信息插入
                        MessageBox.Show("学生信息修改成功", "【提示】");
                }
                else
                    MessageBox.Show("修改失败，无此学生信息", "【提示】");
            }
        }

        //删除学生信息
        private void btnDelStu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string stuID = this.txtStuID.Text;
                if (DB_Student.DelStuInfo(stuID) != -1)
                    MessageBox.Show("学生信息删除成功", "【提示】");
                else
                    MessageBox.Show("学生信息删除失败", "【提示】");
            }
            else
                return;

            //清空内容
            this.txtStuID.Text = "";
            this.txtStuName.Text = "";
            this.txtStuClassID.Text = "";
            this.txtStuClassName.Text = "";
            this.txtStuClassTeacher.Text = "";
            this.rdbMan.Checked = true;
            this.txtStuAge.Text = "";
            this.txtStuHeight.Text = "";
            this.txtStuWeight.Text = "";
            this.txtStuAddress.Text = "";
        }

        //图书封面选择
        private void btnBookImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog lvse = new OpenFileDialog())
            {
                lvse.Title = "选择图片";
                lvse.InitialDirectory = "";
                lvse.Filter = "图片文件|*.bmp;*.jpg;*.jpeg;*.png";
                lvse.FilterIndex = 1;
                if (lvse.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(lvse.FileName);
                    this.txtBookImage.Text = lvse.FileName;
                    this.picBookImage.Image = Image.FromFile(lvse.FileName);
                }
            }
        }

        //添加图书信息
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            bool isRes = false;
            if (CheckBookInfo())
            {
                if (this.rdbBookYes.Checked)
                    isRes = true;
                //实例化图书对象
                Book book = new Book(this.txtBookID.Text.Trim().ToString(), this.txtBookName.Text.Trim().ToString(), this.txtBookAuthor.Text.Trim().ToString()
                    , this.dtBookPublishTime.Value, this.txtBookPublisher.Text.Trim().ToString(), Convert.ToDecimal(this.txtBookPrice.Text.Trim().ToString())
                    , this.txtBookCategory.Text.Trim().ToString(), this.txtBookDescription.Text.Trim().ToString(), isRes, this.txtBookImage.Text.ToString());

                //获得搜索的图书编号
                string bookID = this.txtBookID.Text;

                DataTable dt = DB_Book.GetBookInfoByID(bookID);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("已存在图书信息，请检查图书编号", "【提示】");
                }
                else if (DB_Book.AddBookInfo(book) != -1)
                {
                    MessageBox.Show("图书信息插入成功", "【提示】");
                }
            }
        }

        //修改图书信息
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            bool isRes = false;
            if (CheckBookInfo())
            {
                if (this.rdbBookYes.Checked)
                    isRes = true;
                //实例化图书对象
                Book book = new Book(this.txtBookID.Text.Trim().ToString(), this.txtBookName.Text.Trim().ToString(), this.txtBookAuthor.Text.Trim().ToString()
                    , this.dtBookPublishTime.Value, this.txtBookPublisher.Text.Trim().ToString(), Convert.ToDecimal(this.txtBookPrice.Text.Trim().ToString())
                    , this.txtBookCategory.Text.Trim().ToString(), this.txtBookDescription.Text.Trim().ToString(), isRes, this.txtBookImage.Text.ToString());

                //获得搜索的图书编号
                string bookID = this.txtBookID.Text;

                DataTable dt = DB_Book.GetBookInfoByID(bookID);
                if (dt.Rows.Count > 0)
                {
                    if (DB_Book.UpdateBookInfo(book) != -1)
                    {
                        MessageBox.Show("图书信息修改成功", "【提示】");
                    }
                }
                else
                {
                    MessageBox.Show("修改失败，无此图书信息", "【提示】");
                }
            }
        }

        //删除图书信息
        private void btnDelBook_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string bookID = this.txtBookID.Text;
                if (DB_Book.DelBookInfo(bookID) != -1)
                    MessageBox.Show("图书信息删除成功", "【提示】");
                else
                    MessageBox.Show("图书信息删除失败", "【提示】");
            }
            else
                return;

            //清空内容
            this.txtBookID.Text = "";
            this.txtBookName.Text = "";
            this.txtBookAuthor.Text = "";
            this.dtBookPublishTime.Text = "";
            this.txtBookPublisher.Text = "";
            this.txtBookPrice.Text = "";
            this.txtBookCategory.Text = "";
            this.txtBookDescription.Text = "";
            this.rdbBookNo.Checked = true;
            this.txtBookImage.Text = "";
            this.picBookImage.Image = Image.FromFile(@"D:\Visual Studio 2013 Projects\study and practice\事件\Experiment\Experiment\bin\Debug\NoImage.jpg");
        }



        //图书信息合法性校验，不验证学号是否已存在，需额外判断
        public bool CheckBookInfo()
        {
            if (this.txtBookID.Text.Trim().Equals(""))
                MessageBox.Show("请输入图书编号", "【提示】");
            else if (this.txtBookName.Text.Trim().Equals(""))
                MessageBox.Show("请输入图书名称", "【提示】");
            else if (this.txtBookAuthor.Text.Trim().Equals(""))
                MessageBox.Show("请输入图书作者", "【提示】");
            else if (this.txtBookPrice.Text.Trim().Equals(""))
                MessageBox.Show("请输入图书单价", "【提示】");
            else
                return true;//没有未输入的信息
            return false;
        }
    }
}
