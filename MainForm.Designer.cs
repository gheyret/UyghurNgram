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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
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
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(669, 45);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(141, 24);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "1 gram";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(669, 75);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(141, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "1 && 2 gram";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(669, 105);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(141, 24);
			this.radioButton3.TabIndex = 3;
			this.radioButton3.Text = "1 && 2 && 3 gram";
			this.radioButton3.UseVisualStyleBackColor = true;
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
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 460);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.lstFiles);
			this.Name = "MainForm";
			this.Text = "Make Uyghur Ngram ";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFormDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFormDragEnter);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.CheckedListBox lstFiles;
	}
}
