/*
 * Created by SharpDevelop.
 * User: Gheyret Kenji
 * Date: 2015/12/11
 * Time: 8:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UyghurNgram
{
	partial class MainForm
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
			this.lstFiles = new System.Windows.Forms.CheckedListBox();
			this.radio1Grm = new System.Windows.Forms.RadioButton();
			this.radio12Grm = new System.Windows.Forms.RadioButton();
			this.radio123Grm = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.radio2Grm = new System.Windows.Forms.RadioButton();
			this.radio3Grm = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// lstFiles
			// 
			this.lstFiles.FormattingEnabled = true;
			this.lstFiles.IntegralHeight = false;
			this.lstFiles.Location = new System.Drawing.Point(12, 42);
			this.lstFiles.Name = "lstFiles";
			this.lstFiles.Size = new System.Drawing.Size(634, 406);
			this.lstFiles.TabIndex = 0;
			// 
			// radio1Grm
			// 
			this.radio1Grm.Checked = true;
			this.radio1Grm.Location = new System.Drawing.Point(669, 45);
			this.radio1Grm.Name = "radio1Grm";
			this.radio1Grm.Size = new System.Drawing.Size(141, 24);
			this.radio1Grm.TabIndex = 1;
			this.radio1Grm.TabStop = true;
			this.radio1Grm.Text = "1 gram";
			this.radio1Grm.UseVisualStyleBackColor = true;
			// 
			// radio12Grm
			// 
			this.radio12Grm.Location = new System.Drawing.Point(669, 105);
			this.radio12Grm.Name = "radio12Grm";
			this.radio12Grm.Size = new System.Drawing.Size(141, 24);
			this.radio12Grm.TabIndex = 2;
			this.radio12Grm.Text = "1 && 2 gram";
			this.radio12Grm.UseVisualStyleBackColor = true;
			// 
			// radio123Grm
			// 
			this.radio123Grm.Location = new System.Drawing.Point(669, 166);
			this.radio123Grm.Name = "radio123Grm";
			this.radio123Grm.Size = new System.Drawing.Size(141, 24);
			this.radio123Grm.TabIndex = 3;
			this.radio123Grm.Text = "1 && 2 && 3 gram";
			this.radio123Grm.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(681, 420);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 28);
			this.button1.TabIndex = 4;
			this.button1.Text = "Make";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(634, 26);
			this.label1.TabIndex = 5;
			this.label1.Text = "Drag && Drop Text files or folders here ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// radio2Grm
			// 
			this.radio2Grm.Location = new System.Drawing.Point(669, 75);
			this.radio2Grm.Name = "radio2Grm";
			this.radio2Grm.Size = new System.Drawing.Size(141, 24);
			this.radio2Grm.TabIndex = 6;
			this.radio2Grm.Text = "2 gram";
			this.radio2Grm.UseVisualStyleBackColor = true;
			// 
			// radio3Grm
			// 
			this.radio3Grm.Location = new System.Drawing.Point(669, 135);
			this.radio3Grm.Name = "radio3Grm";
			this.radio3Grm.Size = new System.Drawing.Size(141, 24);
			this.radio3Grm.TabIndex = 7;
			this.radio3Grm.Text = "3 gram";
			this.radio3Grm.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 460);
			this.Controls.Add(this.radio3Grm);
			this.Controls.Add(this.radio2Grm);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radio123Grm);
			this.Controls.Add(this.radio12Grm);
			this.Controls.Add(this.radio1Grm);
			this.Controls.Add(this.lstFiles);
			this.Name = "MainForm";
			this.Text = "Make Uyghur Ngram ";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton radio3Grm;
		private System.Windows.Forms.RadioButton radio2Grm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radio123Grm;
		private System.Windows.Forms.RadioButton radio12Grm;
		private System.Windows.Forms.RadioButton radio1Grm;
		private System.Windows.Forms.CheckedListBox lstFiles;
	}
}
