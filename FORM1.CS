using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace ideology
{
    /// <summary>
    /// Form1 的摘要说明。
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {

        private System.Windows.Forms.Timer mytime;
        private System.ComponentModel.IContainer components;


        private int DataTotal;    //记录数
        private System.Random RandomNumber;
        private System.Data.DataTable dTable;
        private ArrayList ArrayMsg = new ArrayList();
        private ArrayList ArraySys = new ArrayList();


        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button F_begin;
        private System.Windows.Forms.Button F_open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;


        private System.Windows.Forms.PictureBox biaozhi;
        private System.Windows.Forms.Button tol_close;
        private System.Windows.Forms.Button tol_min;

        private System.Windows.Forms.Button tol_max;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

        //---------------
        private ArrayList ArrayName = new ArrayList();
        int randomdata, Datanum1;
        string[] Goupdata1 = new string[15];
        private Label label7;
        private Label label13;
        string[] Goupdata2 = new string[15];

        //----------------
        public Form1()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mytime = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.F_begin = new System.Windows.Forms.Button();
            this.F_open = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.biaozhi = new System.Windows.Forms.PictureBox();
            this.tol_close = new System.Windows.Forms.Button();
            this.tol_min = new System.Windows.Forms.Button();
            this.tol_max = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.biaozhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "李华编写 版权所有！";
            // 
            // F_begin
            // 
            this.F_begin.BackColor = System.Drawing.Color.Transparent;
            this.F_begin.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.F_begin.ForeColor = System.Drawing.Color.MediumBlue;
            this.F_begin.Location = new System.Drawing.Point(150, 335);
            this.F_begin.Name = "F_begin";
            this.F_begin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.F_begin.Size = new System.Drawing.Size(216, 40);
            this.F_begin.TabIndex = 12;
            this.F_begin.Text = "摇 号（ENTER）";
            this.F_begin.UseVisualStyleBackColor = false;
            this.F_begin.Click += new System.EventHandler(this.F_begin_Click);
            // 
            // F_open
            // 
            this.F_open.BackColor = System.Drawing.Color.Transparent;
            this.F_open.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.F_open.ForeColor = System.Drawing.Color.MediumBlue;
            this.F_open.Location = new System.Drawing.Point(150, 390);
            this.F_open.Name = "F_open";
            this.F_open.Size = new System.Drawing.Size(216, 40);
            this.F_open.TabIndex = 13;
            this.F_open.Text = "开 号（SPACE）";
            this.F_open.UseVisualStyleBackColor = false;
            this.F_open.Click += new System.EventHandler(this.F_open_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 10;
            // 
            // biaozhi
            // 
            this.biaozhi.BackColor = System.Drawing.Color.Transparent;
            this.biaozhi.Image = ((System.Drawing.Image)(resources.GetObject("biaozhi.Image")));
            this.biaozhi.InitialImage = ((System.Drawing.Image)(resources.GetObject("biaozhi.InitialImage")));
            this.biaozhi.Location = new System.Drawing.Point(37, 96);
            this.biaozhi.Name = "biaozhi";
            this.biaozhi.Size = new System.Drawing.Size(695, 99);
            this.biaozhi.TabIndex = 19;
            this.biaozhi.TabStop = false;
            // 
            // tol_close
            // 
            this.tol_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tol_close.BackColor = System.Drawing.Color.Transparent;
            this.tol_close.Location = new System.Drawing.Point(65, 15);
            this.tol_close.Name = "tol_close";
            this.tol_close.Size = new System.Drawing.Size(12, 12);
            this.tol_close.TabIndex = 25;
            this.tol_close.UseVisualStyleBackColor = false;
            this.tol_close.Click += new System.EventHandler(this.tol_close_Click);
            // 
            // tol_min
            // 
            this.tol_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tol_min.BackColor = System.Drawing.Color.Transparent;
            this.tol_min.Location = new System.Drawing.Point(12, 15);
            this.tol_min.Name = "tol_min";
            this.tol_min.Size = new System.Drawing.Size(12, 12);
            this.tol_min.TabIndex = 26;
            this.tol_min.UseVisualStyleBackColor = false;
            this.tol_min.Click += new System.EventHandler(this.tol_min_Click);
            // 
            // tol_max
            // 
            this.tol_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tol_max.BackColor = System.Drawing.Color.Transparent;
            this.tol_max.Location = new System.Drawing.Point(39, 15);
            this.tol_max.Name = "tol_max";
            this.tol_max.Size = new System.Drawing.Size(12, 12);
            this.tol_max.TabIndex = 34;
            this.tol_max.UseVisualStyleBackColor = false;
            this.tol_max.Click += new System.EventHandler(this.tol_max_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 36);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 36);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("黑体", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 59);
            this.label1.TabIndex = 42;
            this.label1.Text = "学 生 学 号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(137, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 76);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.tol_min);
            this.panel2.Controls.Add(this.tol_max);
            this.panel2.Controls.Add(this.tol_close);
            this.panel2.Location = new System.Drawing.Point(702, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 36);
            this.panel2.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 108);
            this.panel3.TabIndex = 45;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(310, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 12);
            this.label13.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 12);
            this.label12.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 12);
            this.label11.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(258, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 12);
            this.label10.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(173, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 12);
            this.label9.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("隶书", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(473, 340);
            this.label7.MinimumSize = new System.Drawing.Size(222, 35);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(239, 35);
            this.label7.TabIndex = 46;
            this.label7.Text = " 学 生 姓 名";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.biaozhi);
            this.Controls.Add(this.F_open);
            this.Controls.Add(this.F_begin);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选学号";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biaozhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());

        }

        private void F_close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        //Provider=Microsoft.Jet.OLEDB.4.0;Data    User   Id=admin;Password=;D:\c 抽奖\20090504144352990\codefans.net\C#SQL抽奖程序\bin\Debug\lottery.mdb;

        private void Form1_Load(object sender, System.EventArgs e)
        {

            String SQLstr = "";
            SQLstr = "SELECT * FROM data1";
            OleDbConnection myconn; //
            OleDbDataAdapter myrs;
            OleDbCommand myCmd;
            DataSet dtSet;
            DataRow myrow;
            myconn = new OleDbConnection("Provider="
            + "Microsoft.Jet.OLEDB.4.0;Data Source=lottery.asf");
            myrs = new OleDbDataAdapter(SQLstr, myconn);
            dtSet = new DataSet();
            myrs.Fill(dtSet, "data1");

            dTable = dtSet.Tables["data1"];
            DataTotal = dTable.Rows.Count;

        }

        private void F_begin_Click(object sender, System.EventArgs e)
        {
            //this.label1.ForeColor = System.Drawing.Color.White;
            mytime.Start();
            mytime.Tick += new EventHandler(mytime_Tick);
            this.F_open.Focus();
        }

        private void F_system_Click(object sender, System.EventArgs e)
        {
            
        }
        private void mytime_Tick(object sender, System.EventArgs e)
        {

            RandomNumber = new Random((int)DateTime.Now.Ticks);
            randomdata = RandomNumber.Next(DataTotal);
            label5.Text = RandomNumber.Next(DataTotal).ToString();
            label1.Text = dTable.Rows[randomdata].ItemArray.GetValue(0).ToString();
            label7.Text = "";


        }
        //---------------------------------------

        private void GroupData(int DataNum, string SigData, string NameData)
        {

            if (!ArrayMsg.Contains(SigData))
            {
                if (ArrayMsg.Count < DataNum)
                {
                    ArrayMsg.Add(SigData);
                    ArrayName.Add(NameData);
                }
                else
                {

                    //GroupBaseData.Clear();
                    Datanum1 = ArrayMsg.Count;

                    ArrayMsg.CopyTo(0, Goupdata1, 0, DataNum);
                    ArrayName.CopyTo(0, Goupdata2, 0, DataNum);
                    ArrayMsg.Clear();
                    ArrayName.Clear();
                }
            }

        }

        //-------------------------------------------
        private void F_open_Click(object sender, System.EventArgs e)
        {
            mytime.Stop();
            this.F_begin.Focus();
            label7.Text = dTable.Rows[randomdata].ItemArray.GetValue(1).ToString();
        }



        private void Data_Save(int DataNum, string newclass)
        {

            for (int i = 0; i < DataNum; i++)
            {

                string SaveSql = "insert into data2 values('" + Goupdata1[i].ToString() + "','" + Goupdata2[i].ToString() + "','" + newclass + "')";

            }
        }
        private void F_site_Click(object sender, System.EventArgs e)
        {

        }



        private void tol_close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void tol_min_Click(object sender, System.EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }

        private void SysMenu1_Popup(object sender, System.EventArgs e)
        {

        }

        private void Form1_Click(object sender, System.EventArgs e)
        {
            this.F_begin.Focus();
        }


        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                this.F_open.Focus();
            }
        }

        private void tol_max_Click(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
