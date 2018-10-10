using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ideology
{
    /// <summary>
    /// about 的摘要说明。
    /// </summary>
    public class about : Form
    {
        private Timer timer1;
        private IContainer components;


        public about()
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
            this.components = new Container();
            this.timer1 = new Timer(this.components);
            // 
            // about
            // 
            this.AutoScaleBaseSize = new Size(6, 14);
            this.BackColor = Color.GhostWhite;
            this.ClientSize = new Size(304, 224);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "about";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "about";
            this.TopMost = true;
            this.Load += new EventHandler(this.about_Load);
            this.DoubleClick += new EventHandler(this.about_DoubleClick);
        }

        #endregion

        private void about_Load(object sender, EventArgs e)
        {
            fromOpacity(10, 80);
        }

        private void fromOpacity(int BegOpacity, int EndOpacity)
        {
            this.Opacity = 0.1;

            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 0.8)
            {
                this.Opacity = this.Opacity + 0.1;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void about_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}