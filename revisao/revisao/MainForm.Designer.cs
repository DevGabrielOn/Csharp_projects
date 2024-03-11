/*
 * Created by SharpDevelop.
 * User: Gabriel
 * Date: 28/08/2023
 * Time: 15:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace revisao
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox TXTPONTOS;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox CHMANDARIM;
		private System.Windows.Forms.CheckBox CHESPANHOL;
		private System.Windows.Forms.CheckBox CHINGLES;
		private System.Windows.Forms.GroupBox Idioma;
		private System.Windows.Forms.ComboBox CMBFAIXA;
		private System.Windows.Forms.TextBox TXTPROVA;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton OPTGRAD;
		private System.Windows.Forms.RadioButton OPTPOS;
		private System.Windows.Forms.RadioButton OPTMEDIO;
		private System.Windows.Forms.TextBox TXTNOME;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.TXTPONTOS = new System.Windows.Forms.TextBox();
			this.TXTNOME = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CHMANDARIM = new System.Windows.Forms.CheckBox();
			this.CHESPANHOL = new System.Windows.Forms.CheckBox();
			this.CHINGLES = new System.Windows.Forms.CheckBox();
			this.Idioma = new System.Windows.Forms.GroupBox();
			this.CMBFAIXA = new System.Windows.Forms.ComboBox();
			this.TXTPROVA = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.OPTGRAD = new System.Windows.Forms.RadioButton();
			this.OPTPOS = new System.Windows.Forms.RadioButton();
			this.OPTMEDIO = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.Idioma.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
			"cachoro",
			"macaco ",
			"grilo ",
			"pernil ",
			"jabuti"});
			this.listBox1.Location = new System.Drawing.Point(6, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(76, 69);
			this.listBox1.TabIndex = 1;
			// 
			// TXTPONTOS
			// 
			this.TXTPONTOS.Location = new System.Drawing.Point(304, 248);
			this.TXTPONTOS.Name = "TXTPONTOS";
			this.TXTPONTOS.Size = new System.Drawing.Size(100, 20);
			this.TXTPONTOS.TabIndex = 5;
			// 
			// TXTNOME
			// 
			this.TXTNOME.Location = new System.Drawing.Point(12, 30);
			this.TXTNOME.Name = "TXTNOME";
			this.TXTNOME.Size = new System.Drawing.Size(100, 20);
			this.TXTNOME.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(88, 86);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CHMANDARIM);
			this.groupBox2.Controls.Add(this.CHESPANHOL);
			this.groupBox2.Controls.Add(this.CHINGLES);
			this.groupBox2.Location = new System.Drawing.Point(106, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(105, 120);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "IDIOMA";
			// 
			// CHMANDARIM
			// 
			this.CHMANDARIM.Location = new System.Drawing.Point(6, 80);
			this.CHMANDARIM.Name = "CHMANDARIM";
			this.CHMANDARIM.Size = new System.Drawing.Size(104, 24);
			this.CHMANDARIM.TabIndex = 2;
			this.CHMANDARIM.Text = "MANDARIM";
			this.CHMANDARIM.UseVisualStyleBackColor = true;
			// 
			// CHESPANHOL
			// 
			this.CHESPANHOL.Location = new System.Drawing.Point(6, 50);
			this.CHESPANHOL.Name = "CHESPANHOL";
			this.CHESPANHOL.Size = new System.Drawing.Size(104, 24);
			this.CHESPANHOL.TabIndex = 1;
			this.CHESPANHOL.Text = "ESPANHOL";
			this.CHESPANHOL.UseVisualStyleBackColor = true;
			// 
			// CHINGLES
			// 
			this.CHINGLES.Location = new System.Drawing.Point(6, 20);
			this.CHINGLES.Name = "CHINGLES";
			this.CHINGLES.Size = new System.Drawing.Size(104, 24);
			this.CHINGLES.TabIndex = 0;
			this.CHINGLES.Text = "INGLES";
			this.CHINGLES.UseVisualStyleBackColor = true;
			// 
			// Idioma
			// 
			this.Idioma.Controls.Add(this.CMBFAIXA);
			this.Idioma.Location = new System.Drawing.Point(12, 182);
			this.Idioma.Name = "Idioma";
			this.Idioma.Size = new System.Drawing.Size(130, 86);
			this.Idioma.TabIndex = 2;
			this.Idioma.TabStop = false;
			this.Idioma.Text = "FAIXA";
			// 
			// CMBFAIXA
			// 
			this.CMBFAIXA.FormattingEnabled = true;
			this.CMBFAIXA.Items.AddRange(new object[] {
			"18 a 25",
			"26 a 35",
			"36 a 45",
			"46 a 55",
			"Acima de 55"});
			this.CMBFAIXA.Location = new System.Drawing.Point(6, 19);
			this.CMBFAIXA.Name = "CMBFAIXA";
			this.CMBFAIXA.Size = new System.Drawing.Size(121, 21);
			this.CMBFAIXA.TabIndex = 0;
			this.CMBFAIXA.Tag = "";
			this.CMBFAIXA.Text = "cmbfaixa";
			// 
			// TXTPROVA
			// 
			this.TXTPROVA.Location = new System.Drawing.Point(267, 37);
			this.TXTPROVA.Name = "TXTPROVA";
			this.TXTPROVA.Size = new System.Drawing.Size(100, 20);
			this.TXTPROVA.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(148, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(151, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "CALCULAR PONTUAÇÃO";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.OPTGRAD);
			this.groupBox3.Controls.Add(this.OPTPOS);
			this.groupBox3.Controls.Add(this.OPTMEDIO);
			this.groupBox3.Location = new System.Drawing.Point(222, 63);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(191, 113);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "GRAU DE ESCOLARIDADE";
			// 
			// OPTGRAD
			// 
			this.OPTGRAD.Location = new System.Drawing.Point(13, 83);
			this.OPTGRAD.Name = "OPTGRAD";
			this.OPTGRAD.Size = new System.Drawing.Size(104, 24);
			this.OPTGRAD.TabIndex = 2;
			this.OPTGRAD.TabStop = true;
			this.OPTGRAD.Text = "GRADUAÇÃO";
			this.OPTGRAD.UseVisualStyleBackColor = true;
			// 
			// OPTPOS
			// 
			this.OPTPOS.Location = new System.Drawing.Point(13, 49);
			this.OPTPOS.Name = "OPTPOS";
			this.OPTPOS.Size = new System.Drawing.Size(122, 24);
			this.OPTPOS.TabIndex = 1;
			this.OPTPOS.TabStop = true;
			this.OPTPOS.Text = "PÓS-GRADUAÇÃO";
			this.OPTPOS.UseVisualStyleBackColor = true;
			// 
			// OPTMEDIO
			// 
			this.OPTMEDIO.Location = new System.Drawing.Point(13, 19);
			this.OPTMEDIO.Name = "OPTMEDIO";
			this.OPTMEDIO.Size = new System.Drawing.Size(104, 24);
			this.OPTMEDIO.TabIndex = 0;
			this.OPTMEDIO.TabStop = true;
			this.OPTMEDIO.Text = "MÉDIO";
			this.OPTMEDIO.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(267, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 23);
			this.label1.TabIndex = 14;
			this.label1.Text = "PONTOS NA PROVA";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "NOME";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(171, 257);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 315);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TXTPROVA);
			this.Controls.Add(this.Idioma);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TXTNOME);
			this.Controls.Add(this.TXTPONTOS);
			this.Name = "MainForm";
			this.Text = "revisao";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.Idioma.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
