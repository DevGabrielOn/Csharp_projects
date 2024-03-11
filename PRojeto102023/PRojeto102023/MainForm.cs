/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 19/09/2023
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PRojeto102023
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Timer1Tick(object sender, EventArgs e)
		{
	LblHora.Text = DateTime.Now.ToLongTimeString();
		}
		void RbtNegritoCheckedChanged(object sender, EventArgs e)
		{
	if (RbtNegrito.Checked == true)
LblHora.Font = new Font(LblHora.Font, FontStyle.Bold);
else
LblHora.Font = new Font(LblHora.Font, FontStyle.Regular);
		}
		void RbtItalicoCheckedChanged(object sender, EventArgs e)
		{
	if (RbtItalico.Checked == true)
LblHora.Font = new Font(LblHora.Font, FontStyle.Italic);
else
LblHora.Font = new Font(LblHora.Font, FontStyle.Regular);
		}
		void RbtSublinhadoCheckedChanged(object sender, EventArgs e)
		{
	if (RbtSublinhado.Checked == true)
LblHora.Font = new Font(LblHora.Font, FontStyle.Underline);
else
LblHora.Font = new Font(LblHora.Font, FontStyle.Regular);
		}
	}
}
