using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ideology
{
	/// <summary>
	/// about 的摘要说明。
	/// </summary>
	public class about : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
	

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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			// 
			// about
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(304, 224);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "about";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "about";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.about_Load);
			this.DoubleClick += new System.EventHandler(this.about_DoubleClick);

		}
		#endregion

		private void about_Load(object sender, System.EventArgs e)
		{
			fromOpacity(10,80)	;		
		}
		private void fromOpacity(int BegOpacity,int EndOpacity)
		{
		 this.Opacity =0.1;
		 
		 timer1.Start();
         timer1.Tick+=new  EventHandler(timer1_Tick);
		}
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (this.Opacity<0.8)
			{
				this.Opacity=this.Opacity+0.1;
			}
			else
			{
			timer1.Stop();
			}
		}

		private void about_DoubleClick(object sender, System.EventArgs e)
		{
			this.Close();
		}
		

	}
}
