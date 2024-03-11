/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 06/09/2023
 * Time: 11:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace prjagenda
{
	partial class FRMPRINCIPAL
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPRINCIPAL));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.cONTATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.oUTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cONTATOSToolStripMenuItem,
									this.oUTROSToolStripMenuItem,
									this.sOBREToolStripMenuItem,
									this.sAIRToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(727, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton1,
									this.toolStripButton2,
									this.toolStripButton3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(727, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// cONTATOSToolStripMenuItem
			// 
			this.cONTATOSToolStripMenuItem.Name = "cONTATOSToolStripMenuItem";
			this.cONTATOSToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.cONTATOSToolStripMenuItem.Text = "CONTATOS";
			// 
			// oUTROSToolStripMenuItem
			// 
			this.oUTROSToolStripMenuItem.Name = "oUTROSToolStripMenuItem";
			this.oUTROSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.oUTROSToolStripMenuItem.Text = "OUTROS";
			// 
			// sOBREToolStripMenuItem
			// 
			this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
			this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.sOBREToolStripMenuItem.Text = "SOBRE";
			// 
			// sAIRToolStripMenuItem
			// 
			this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
			this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.sAIRToolStripMenuItem.Text = "SAIR";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// FRMPRINCIPAL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(727, 419);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FRMPRINCIPAL";
			this.Text = "MENU PRINCIPAL";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem oUTROSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cONTATOSToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
