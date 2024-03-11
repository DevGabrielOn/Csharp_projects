
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace testetudo
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
		void Button1Click(object sender, EventArgs e)
		{
			
			double RESULTADO=0;

if (comboBox1.SelectedIndex == 0)
RESULTADO = 50+2;
else if (comboBox1.SelectedIndex == 1)
RESULTADO = 30+2;
else if (comboBox1.SelectedIndex == 2)
RESULTADO = 20+2;
else if (comboBox1.SelectedIndex == 3)
RESULTADO = 40+2;
textBox1.Text = Convert.ToString(RESULTADO);
			
if (LSTOPCOES.SelectedIndex == 0)
RESULTADO = 50+2;
else if (LSTOPCOES.SelectedIndex == 1)
RESULTADO = 30+2;
else if (LSTOPCOES.SelectedIndex == 2)
RESULTADO = 20+2;
else if (LSTOPCOES.SelectedIndex == 3)
RESULTADO = 40+2;
textBox1.Text = Convert.ToString(RESULTADO);
		}
		void Button2Click(object sender, EventArgs e)
		{
			PICIMAGEM02.Load ("C:/.../Bandeira02.jpg");
		}
	}
}
