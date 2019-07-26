namespace Experiment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvData = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.txtStuAddress = new System.Windows.Forms.TextBox();
            this.txtStuWeight = new System.Windows.Forms.TextBox();
            this.txtStuHeight = new System.Windows.Forms.TextBox();
            this.txtStuAge = new System.Windows.Forms.TextBox();
            this.txtStuClassTeacher = new System.Windows.Forms.TextBox();
            this.txtStuClassName = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuClassID = new System.Windows.Forms.TextBox();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStuSearch = new System.Windows.Forms.Button();
            this.txtSearchStu = new System.Windows.Forms.TextBox();
            this.labSearchStu = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbBookNo = new System.Windows.Forms.RadioButton();
            this.rdbBookYes = new System.Windows.Forms.RadioButton();
            this.btnBookImage = new System.Windows.Forms.Button();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.dtBookPublishTime = new System.Windows.Forms.DateTimePicker();
            this.picBookImage = new System.Windows.Forms.PictureBox();
            this.txtBookImage = new System.Windows.Forms.TextBox();
            this.txtBookDescription = new System.Windows.Forms.TextBox();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.txtBookIDSearch = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnEditStu = new System.Windows.Forms.Button();
            this.btnDelStu = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtTableSearch = new System.Windows.Forms.TextBox();
            this.btnDataSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tvData
            // 
            this.tvData.Location = new System.Drawing.Point(0, 23);
            this.tvData.Name = "tvData";
            this.tvData.Size = new System.Drawing.Size(173, 506);
            this.tvData.TabIndex = 0;
            this.tvData.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvData_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(173, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelStu);
            this.tabPage1.Controls.Add(this.btnEditStu);
            this.tabPage1.Controls.Add(this.btnAddStu);
            this.tabPage1.Controls.Add(this.rdbWoman);
            this.tabPage1.Controls.Add(this.rdbMan);
            this.tabPage1.Controls.Add(this.txtStuAddress);
            this.tabPage1.Controls.Add(this.txtStuWeight);
            this.tabPage1.Controls.Add(this.txtStuHeight);
            this.tabPage1.Controls.Add(this.txtStuAge);
            this.tabPage1.Controls.Add(this.txtStuClassTeacher);
            this.tabPage1.Controls.Add(this.txtStuClassName);
            this.tabPage1.Controls.Add(this.txtStuName);
            this.tabPage1.Controls.Add(this.txtStuClassID);
            this.tabPage1.Controls.Add(this.txtStuID);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnStuSearch);
            this.tabPage1.Controls.Add(this.txtSearchStu);
            this.tabPage1.Controls.Add(this.labSearchStu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "学生信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(196, 237);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(35, 16);
            this.rdbWoman.TabIndex = 8;
            this.rdbWoman.Text = "女";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Checked = true;
            this.rdbMan.Location = new System.Drawing.Point(134, 237);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(35, 16);
            this.rdbMan.TabIndex = 7;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "男";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // txtStuAddress
            // 
            this.txtStuAddress.Location = new System.Drawing.Point(134, 379);
            this.txtStuAddress.Multiline = true;
            this.txtStuAddress.Name = "txtStuAddress";
            this.txtStuAddress.Size = new System.Drawing.Size(257, 62);
            this.txtStuAddress.TabIndex = 12;
            // 
            // txtStuWeight
            // 
            this.txtStuWeight.Location = new System.Drawing.Point(134, 344);
            this.txtStuWeight.Name = "txtStuWeight";
            this.txtStuWeight.Size = new System.Drawing.Size(131, 21);
            this.txtStuWeight.TabIndex = 11;
            // 
            // txtStuHeight
            // 
            this.txtStuHeight.Location = new System.Drawing.Point(134, 308);
            this.txtStuHeight.Name = "txtStuHeight";
            this.txtStuHeight.Size = new System.Drawing.Size(131, 21);
            this.txtStuHeight.TabIndex = 10;
            // 
            // txtStuAge
            // 
            this.txtStuAge.Location = new System.Drawing.Point(134, 271);
            this.txtStuAge.Name = "txtStuAge";
            this.txtStuAge.Size = new System.Drawing.Size(131, 21);
            this.txtStuAge.TabIndex = 9;
            // 
            // txtStuClassTeacher
            // 
            this.txtStuClassTeacher.Location = new System.Drawing.Point(134, 200);
            this.txtStuClassTeacher.Name = "txtStuClassTeacher";
            this.txtStuClassTeacher.Size = new System.Drawing.Size(131, 21);
            this.txtStuClassTeacher.TabIndex = 6;
            // 
            // txtStuClassName
            // 
            this.txtStuClassName.Location = new System.Drawing.Point(134, 163);
            this.txtStuClassName.Name = "txtStuClassName";
            this.txtStuClassName.Size = new System.Drawing.Size(131, 21);
            this.txtStuClassName.TabIndex = 5;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(134, 92);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(131, 21);
            this.txtStuName.TabIndex = 3;
            // 
            // txtStuClassID
            // 
            this.txtStuClassID.Location = new System.Drawing.Point(134, 130);
            this.txtStuClassID.Name = "txtStuClassID";
            this.txtStuClassID.Size = new System.Drawing.Size(131, 21);
            this.txtStuClassID.TabIndex = 4;
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(134, 56);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(131, 21);
            this.txtStuID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(15, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "学生家庭住址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(47, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "学生身高";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(47, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "学生体重";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(47, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "学生年龄";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(47, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "学生性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "学生班主任";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(47, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "学生班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "学生班级编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "学生姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(47, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "学生学号";
            // 
            // btnStuSearch
            // 
            this.btnStuSearch.Location = new System.Drawing.Point(289, 9);
            this.btnStuSearch.Name = "btnStuSearch";
            this.btnStuSearch.Size = new System.Drawing.Size(58, 24);
            this.btnStuSearch.TabIndex = 1;
            this.btnStuSearch.Text = "查询";
            this.btnStuSearch.UseVisualStyleBackColor = true;
            this.btnStuSearch.Click += new System.EventHandler(this.btnStuSearch_Click);
            // 
            // txtSearchStu
            // 
            this.txtSearchStu.Location = new System.Drawing.Point(134, 10);
            this.txtSearchStu.Name = "txtSearchStu";
            this.txtSearchStu.Size = new System.Drawing.Size(131, 21);
            this.txtSearchStu.TabIndex = 0;
            // 
            // labSearchStu
            // 
            this.labSearchStu.AutoSize = true;
            this.labSearchStu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labSearchStu.Font = new System.Drawing.Font("宋体", 12F);
            this.labSearchStu.Location = new System.Drawing.Point(15, 12);
            this.labSearchStu.Name = "labSearchStu";
            this.labSearchStu.Size = new System.Drawing.Size(104, 16);
            this.labSearchStu.TabIndex = 13;
            this.labSearchStu.Text = "查询学生学号";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelBook);
            this.tabPage2.Controls.Add(this.btnEditBook);
            this.tabPage2.Controls.Add(this.btnAddBook);
            this.tabPage2.Controls.Add(this.rdbBookNo);
            this.tabPage2.Controls.Add(this.rdbBookYes);
            this.tabPage2.Controls.Add(this.btnBookImage);
            this.tabPage2.Controls.Add(this.txtBookPrice);
            this.tabPage2.Controls.Add(this.dtBookPublishTime);
            this.tabPage2.Controls.Add(this.picBookImage);
            this.tabPage2.Controls.Add(this.txtBookImage);
            this.tabPage2.Controls.Add(this.txtBookDescription);
            this.tabPage2.Controls.Add(this.txtBookCategory);
            this.tabPage2.Controls.Add(this.txtBookPublisher);
            this.tabPage2.Controls.Add(this.txtBookName);
            this.tabPage2.Controls.Add(this.txtBookAuthor);
            this.tabPage2.Controls.Add(this.txtBookID);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.btnBookSearch);
            this.tabPage2.Controls.Add(this.txtBookIDSearch);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图书信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdbBookNo
            // 
            this.rdbBookNo.AutoSize = true;
            this.rdbBookNo.Location = new System.Drawing.Point(196, 344);
            this.rdbBookNo.Name = "rdbBookNo";
            this.rdbBookNo.Size = new System.Drawing.Size(35, 16);
            this.rdbBookNo.TabIndex = 11;
            this.rdbBookNo.Text = "无";
            this.rdbBookNo.UseVisualStyleBackColor = true;
            // 
            // rdbBookYes
            // 
            this.rdbBookYes.AutoSize = true;
            this.rdbBookYes.Checked = true;
            this.rdbBookYes.Location = new System.Drawing.Point(134, 344);
            this.rdbBookYes.Name = "rdbBookYes";
            this.rdbBookYes.Size = new System.Drawing.Size(35, 16);
            this.rdbBookYes.TabIndex = 10;
            this.rdbBookYes.TabStop = true;
            this.rdbBookYes.Text = "有";
            this.rdbBookYes.UseVisualStyleBackColor = true;
            // 
            // btnBookImage
            // 
            this.btnBookImage.Location = new System.Drawing.Point(378, 377);
            this.btnBookImage.Name = "btnBookImage";
            this.btnBookImage.Size = new System.Drawing.Size(34, 24);
            this.btnBookImage.TabIndex = 13;
            this.btnBookImage.Text = "...";
            this.btnBookImage.UseVisualStyleBackColor = true;
            this.btnBookImage.Click += new System.EventHandler(this.btnBookImage_Click);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(134, 237);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(131, 21);
            this.txtBookPrice.TabIndex = 7;
            // 
            // dtBookPublishTime
            // 
            this.dtBookPublishTime.Location = new System.Drawing.Point(134, 163);
            this.dtBookPublishTime.Name = "dtBookPublishTime";
            this.dtBookPublishTime.Size = new System.Drawing.Size(131, 21);
            this.dtBookPublishTime.TabIndex = 5;
            // 
            // picBookImage
            // 
            this.picBookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBookImage.Image = ((System.Drawing.Image)(resources.GetObject("picBookImage.Image")));
            this.picBookImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBookImage.InitialImage")));
            this.picBookImage.Location = new System.Drawing.Point(296, 56);
            this.picBookImage.Name = "picBookImage";
            this.picBookImage.Size = new System.Drawing.Size(116, 178);
            this.picBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookImage.TabIndex = 62;
            this.picBookImage.TabStop = false;
            // 
            // txtBookImage
            // 
            this.txtBookImage.Location = new System.Drawing.Point(134, 379);
            this.txtBookImage.Name = "txtBookImage";
            this.txtBookImage.Size = new System.Drawing.Size(233, 21);
            this.txtBookImage.TabIndex = 12;
            // 
            // txtBookDescription
            // 
            this.txtBookDescription.Location = new System.Drawing.Point(134, 308);
            this.txtBookDescription.Multiline = true;
            this.txtBookDescription.Name = "txtBookDescription";
            this.txtBookDescription.Size = new System.Drawing.Size(131, 21);
            this.txtBookDescription.TabIndex = 9;
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Location = new System.Drawing.Point(134, 271);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(131, 21);
            this.txtBookCategory.TabIndex = 8;
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(134, 200);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(131, 21);
            this.txtBookPublisher.TabIndex = 6;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(134, 92);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(131, 21);
            this.txtBookName.TabIndex = 3;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(134, 130);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(131, 21);
            this.txtBookAuthor.TabIndex = 4;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(134, 56);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(131, 21);
            this.txtBookID.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(47, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "图书封面";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(47, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "图书简介";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(15, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 48;
            this.label13.Text = "图书配套资源";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(47, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "图书类别";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.Font = new System.Drawing.Font("宋体", 12F);
            this.label15.Location = new System.Drawing.Point(47, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "图书单价";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Font = new System.Drawing.Font("宋体", 12F);
            this.label16.Location = new System.Drawing.Point(31, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 45;
            this.label16.Text = "图书出版社";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label17.Font = new System.Drawing.Font("宋体", 12F);
            this.label17.Location = new System.Drawing.Point(15, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 44;
            this.label17.Text = "图书出版日期";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label18.Font = new System.Drawing.Font("宋体", 12F);
            this.label18.Location = new System.Drawing.Point(47, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "图书作者";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label19.Font = new System.Drawing.Font("宋体", 12F);
            this.label19.Location = new System.Drawing.Point(47, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 16);
            this.label19.TabIndex = 42;
            this.label19.Text = "图书名称";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label20.Font = new System.Drawing.Font("宋体", 12F);
            this.label20.Location = new System.Drawing.Point(47, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 41;
            this.label20.Text = "图书编号";
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(289, 9);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(58, 24);
            this.btnBookSearch.TabIndex = 1;
            this.btnBookSearch.Text = "查询";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // txtBookIDSearch
            // 
            this.txtBookIDSearch.Location = new System.Drawing.Point(134, 10);
            this.txtBookIDSearch.Name = "txtBookIDSearch";
            this.txtBookIDSearch.Size = new System.Drawing.Size(131, 21);
            this.txtBookIDSearch.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label21.Font = new System.Drawing.Font("宋体", 12F);
            this.label21.Location = new System.Drawing.Point(15, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 16);
            this.label21.TabIndex = 38;
            this.label21.Text = "查询图书编号";
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(205, 461);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(58, 24);
            this.btnAddStu.TabIndex = 13;
            this.btnAddStu.Text = "添加";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnEditStu
            // 
            this.btnEditStu.Location = new System.Drawing.Point(278, 461);
            this.btnEditStu.Name = "btnEditStu";
            this.btnEditStu.Size = new System.Drawing.Size(58, 24);
            this.btnEditStu.TabIndex = 14;
            this.btnEditStu.Text = "修改";
            this.btnEditStu.UseVisualStyleBackColor = true;
            this.btnEditStu.Click += new System.EventHandler(this.btnEditStu_Click);
            // 
            // btnDelStu
            // 
            this.btnDelStu.Location = new System.Drawing.Point(351, 461);
            this.btnDelStu.Name = "btnDelStu";
            this.btnDelStu.Size = new System.Drawing.Size(58, 24);
            this.btnDelStu.TabIndex = 15;
            this.btnDelStu.Text = "删除";
            this.btnDelStu.UseVisualStyleBackColor = true;
            this.btnDelStu.Click += new System.EventHandler(this.btnDelStu_Click);
            // 
            // btnDelBook
            // 
            this.btnDelBook.Location = new System.Drawing.Point(351, 461);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(58, 24);
            this.btnDelBook.TabIndex = 16;
            this.btnDelBook.Text = "删除";
            this.btnDelBook.UseVisualStyleBackColor = true;
            this.btnDelBook.Click += new System.EventHandler(this.btnDelBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(278, 461);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(58, 24);
            this.btnEditBook.TabIndex = 15;
            this.btnEditBook.Text = "修改";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(205, 461);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(58, 24);
            this.btnAddBook.TabIndex = 14;
            this.btnAddBook.Text = "添加";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtTableSearch
            // 
            this.txtTableSearch.Location = new System.Drawing.Point(0, 1);
            this.txtTableSearch.Name = "txtTableSearch";
            this.txtTableSearch.Size = new System.Drawing.Size(83, 21);
            this.txtTableSearch.TabIndex = 1;
            // 
            // btnDataSearch
            // 
            this.btnDataSearch.Location = new System.Drawing.Point(88, 1);
            this.btnDataSearch.Name = "btnDataSearch";
            this.btnDataSearch.Size = new System.Drawing.Size(41, 21);
            this.btnDataSearch.TabIndex = 2;
            this.btnDataSearch.Text = "查询";
            this.btnDataSearch.UseVisualStyleBackColor = true;
            this.btnDataSearch.Click += new System.EventHandler(this.btnDataSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(130, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(41, 21);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 530);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDataSearch);
            this.Controls.Add(this.txtTableSearch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tvData);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【课程实验】";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStuSearch;
        private System.Windows.Forms.TextBox txtSearchStu;
        private System.Windows.Forms.Label labSearchStu;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.TextBox txtStuAddress;
        private System.Windows.Forms.TextBox txtStuWeight;
        private System.Windows.Forms.TextBox txtStuHeight;
        private System.Windows.Forms.TextBox txtStuAge;
        private System.Windows.Forms.TextBox txtStuClassTeacher;
        private System.Windows.Forms.TextBox txtStuClassName;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuClassID;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.DateTimePicker dtBookPublishTime;
        private System.Windows.Forms.PictureBox picBookImage;
        private System.Windows.Forms.TextBox txtBookImage;
        private System.Windows.Forms.TextBox txtBookDescription;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.TextBox txtBookIDSearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnBookImage;
        private System.Windows.Forms.RadioButton rdbBookNo;
        private System.Windows.Forms.RadioButton rdbBookYes;
        private System.Windows.Forms.Button btnDelStu;
        private System.Windows.Forms.Button btnEditStu;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnDelBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtTableSearch;
        private System.Windows.Forms.Button btnDataSearch;
        private System.Windows.Forms.Button btnRefresh;
    }
}

