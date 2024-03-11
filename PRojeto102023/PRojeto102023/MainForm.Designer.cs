/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 19/09/2023
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PRojeto102023
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label LblHora;
		private System.Windows.Forms.RadioButton RbtNegrito;
		private System.Windows.Forms.RadioButton RbtItalico;
		private System.Windows.Forms.RadioButton RbtSublinhado;
		private System.Windows.Forms.Timer timer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.LblHora = new System.Windows.Forms.Label();
			this.RbtNegrito = new System.Windows.Forms.RadioButton();
			this.RbtItalico = new System.Windows.Forms.RadioButton();
			this.RbtSublinhado = new System.Windows.Forms.RadioButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// LblHora
			// 
			this.LblHora.Location = new System.Drawing.Point(109, 21);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(111, 64);
			this.LblHora.TabIndex = 0;
			this.LblHora.Text = "label1";
			this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RbtNegrito
			// 
			this.RbtNegrito.Location = new System.Drawing.Point(30, 151);
			this.RbtNegrito.Name = "RbtNegrito";
			this.RbtNegrito.Size = new System.Drawing.Size(104, 24);
			this.RbtNegrito.TabIndex = 1;
			this.RbtNegrito.TabStop = true;
			this.RbtNegrito.Text = "Negrito";
			this.RbtNegrito.UseVisualStyleBackColor = true;
			this.RbtNegrito.CheckedChanged += new System.EventHandler(this.RbtNegritoCheckedChanged);
			// 
			// RbtItalico
			// 
			this.RbtItalico.Location = new System.Drawing.Point(27, 181);
			this.RbtItalico.Name = "RbtItalico";
			this.RbtItalico.Size = new System.Drawing.Size(82, 20);
			this.RbtItalico.TabIndex = 2;
			this.RbtItalico.TabStop = true;
			this.RbtItalico.Text = "Italico";
			this.RbtItalico.UseVisualStyleBackColor = true;
			this.RbtItalico.CheckedChanged += new System.EventHandler(this.RbtItalicoCheckedChanged);
			// 
			// RbtSublinhado
			// 
			this.RbtSublinhado.Location = new System.Drawing.Point(27, 220);
			this.RbtSublinhado.Name = "RbtSublinhado";
			this.RbtSublinhado.Size = new System.Drawing.Size(104, 24);
			this.RbtSublinhado.TabIndex = 3;
			this.RbtSublinhado.TabStop = true;
			this.RbtSublinhado.Text = "Sublinhado";
			this.RbtSublinhado.UseVisualStyleBackColor = true;
			this.RbtSublinhado.CheckedChanged += new System.EventHandler(this.RbtSublinhadoCheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 262);
			this.Controls.Add(this.RbtSublinhado);
			this.Controls.Add(this.RbtItalico);
			this.Controls.Add(this.RbtNegrito);
			this.Controls.Add(this.LblHora);
			this.Name = "MainForm";
			this.Text = "Pratica 10 – Trabalhando com timer";
			this.ResumeLayout(false);

		}
	}
}
