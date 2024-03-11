
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace estudoprova1
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			
			InitializeComponent();
			
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				pictureBox1.Load(openFileDialog1.FileName);
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(colorDialog1.ShowDialog()==DialogResult.OK)
			{
				pictureBox1.BackColor=colorDialog1.Color;
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			pictureBox1.Image=null;
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
				pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
			   else
			   	pictureBox1.SizeMode=PictureBoxSizeMode.Normal;
		}
	}
}
