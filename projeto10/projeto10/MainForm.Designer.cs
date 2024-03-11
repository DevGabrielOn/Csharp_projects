/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 28/08/2023
 * Time: 17:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projeto10
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RadioButton RbtNegrito;
		private System.Windows.Forms.RadioButton RbtItalico;
		private System.Windows.Forms.RadioButton RbtSublinhado;
		public System.Windows.Forms.Timer TmrRelogio;
		private System.Windows.Forms.Label LblHora;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		
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
			this.RbtNegrito = new System.Windows.Forms.RadioButton();
			this.RbtItalico = new System.Windows.Forms.RadioButton();
			this.RbtSublinhado = new System.Windows.Forms.RadioButton();
			this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
			this.LblHora = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// RbtNegrito
			// 
			this.RbtNegrito.Location = new System.Drawing.Point(38, 176);
			this.RbtNegrito.Name = "RbtNegrito";
			this.RbtNegrito.Size = new System.Drawing.Size(104, 24);
			this.RbtNegrito.TabIndex = 1;
			this.RbtNegrito.TabStop = true;
			this.RbtNegrito.Text = "Negrito";
			this.RbtNegrito.UseVisualStyleBackColor = true;
			// 
			// RbtItalico
			// 
			this.RbtItalico.Location = new System.Drawing.Point(248, 185);
			this.RbtItalico.Name = "RbtItalico";
			this.RbtItalico.Size = new System.Drawing.Size(104, 24);
			this.RbtItalico.TabIndex = 2;
			this.RbtItalico.TabStop = true;
			this.RbtItalico.Text = "Italico";
			this.RbtItalico.UseVisualStyleBackColor = true;
			// 
			// RbtSublinhado
			// 
			this.RbtSublinhado.Location = new System.Drawing.Point(458, 190);
			this.RbtSublinhado.Name = "RbtSublinhado";
			this.RbtSublinhado.Size = new System.Drawing.Size(104, 24);
			this.RbtSublinhado.TabIndex = 3;
			this.RbtSublinhado.TabStop = true;
			this.RbtSublinhado.Text = "Sublinhado";
			this.RbtSublinhado.UseVisualStyleBackColor = true;
			// 
			// TmrRelogio
			// 
			this.TmrRelogio.Enabled = true;
			this.TmrRelogio.Interval = 70;
			this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogioTick);
			// 
			// LblHora
			// 
			this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHora.Location = new System.Drawing.Point(150, 25);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(295, 93);
			this.LblHora.TabIndex = 4;
			this.LblHora.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(62, 267);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(306, 271);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(81, 118);
			this.maskedTextBox1.Mask = "00:00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 327);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LblHora);
			this.Controls.Add(this.RbtSublinhado);
			this.Controls.Add(this.RbtItalico);
			this.Controls.Add(this.RbtNegrito);
			this.Name = "MainForm";
			this.Text = "projeto10";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
