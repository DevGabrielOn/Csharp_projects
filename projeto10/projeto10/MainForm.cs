/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 28/08/2023
 * Time: 17:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace projeto10
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private bool alarme=false;
private bool despertar=false;
private bool controle=false;
private string nomesom;
private void TocarSom(string aux)
{
SoundPlayer som = new SoundPlayer(@aux);
som.Play();

}
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
		private void TmrRelogio Tick l(object sender, EventArgs e)
{
LblHora.Text = DateTime.Now.ToLongTimeString();
}
private void RbtNegrito_CheckedChanged(object sender, EventArgs e)
{
if (RbtNegrito.Checked == true)
LblHora.Font = new Font(LblHora.Font, FontStyle.Bold);
else
LblHora.Font = new Font(LblHora.Font, FontStyle.Regular);
}

		
	}
}
