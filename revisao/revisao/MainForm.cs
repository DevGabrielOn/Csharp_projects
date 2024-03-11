
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace revisao
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{	
		}
	private	void (object sender
		void button1Click(object sender, EventArgs e)
		{

		} EventArgs e)
		{ double  RESULTADO;

RESULTADO = 0;
if (OPTMEDIO.Checked == true)
RESULTADO+=3;
else if (OPTGRAD.Checked == false)
RESULTADO+=5;
else if (OPTPOS.Checked == true)
RESULTADO +=10;


if (CMBFAIXA.SelectedIndex==0)
	RESULTADO+=2;
else	if (CMBFAIXA.SelectedIndex==1)
	RESULTADO+=3;
else	if (CMBFAIXA.SelectedIndex==2)
	RESULTADO+=4;
else	if (CMBFAIXA.SelectedIndex==3)
	RESULTADO+=5;
else	if (CMBFAIXA.SelectedIndex==4)
	RESULTADO+=6;
	
	if (CHINGLES.Checked == true)
RESULTADO+=3;
else if (CHESPANHOL.Checked == false)
RESULTADO+=6;
else if (CHMANDARIM.Checked == true)
RESULTADO +=10;
TXTPONTOS.Text = Convert.ToString(RESULTADO);

	}
		
		
		
	
		
	
		}
	}

