/*
 * Created by SharpDevelop.
 * User: Gheyret Kenji
 * Date: 2015/12/11
 * Time: 8:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UyghurNgram
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
		
		void MainFormDragEnter(object sender, DragEventArgs e)
		{
			String[] file=(String[])e.Data.GetData(DataFormats.FileDrop);
			
			foreach(string flnm in file){
				if(flnm.EndsWith(".txt",StringComparison.OrdinalIgnoreCase) || flnm.EndsWith(".uut",StringComparison.OrdinalIgnoreCase) ||Directory.Exists(flnm))
				{
					e.Effect= DragDropEffects.All;
					break;
				}
			}
		}
		
		void MainFormDragDrop(object sender, DragEventArgs e)
		{
			String[] dirFiles;
			List<string> files=new List<string>();
			String[] file=(String[])e.Data.GetData(DataFormats.FileDrop);
			foreach(string flnm in file){
				if(flnm.EndsWith(".txt",StringComparison.OrdinalIgnoreCase)||flnm.EndsWith(".uut",StringComparison.OrdinalIgnoreCase))
				{
					files.Add(flnm);
				}
				else if(Directory.Exists(flnm)){
					dirFiles=Directory.GetFiles(flnm,"*.txt");
					files.AddRange(dirFiles);
					dirFiles=Directory.GetFiles(flnm,"*.uut");
					files.AddRange(dirFiles);
				}
			}
			foreach(string fl in files){
				lstFiles.Items.Add(fl,true);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int   ngr=1;
			bool  xgram=false;
			if(radio1Grm.Checked){
				ngr=1;
				xgram=true;
			}
			else if(radio12Grm.Checked){
				ngr=2;
				xgram=true;
			}
			else if(radio123Grm.Checked){
				ngr=3;
				xgram=true;
			}
			else if(radio2Grm.Checked){
				ngr=2;
				xgram=false;
			}
			else if(radio3Grm.Checked){
				ngr=3;
				xgram=false;
			}
			
			button1.Enabled=false;
			UGram gram=new UGram(ngr);
			if(lstFiles.Items.Count>0){
				for(int i=0;i<lstFiles.Items.Count;i++)
				{
					lstFiles.SelectedIndex=i;
					if(lstFiles.GetItemCheckState(i)==CheckState.Checked){
						if(xgram==true){
							gram.MakeXGram(lstFiles.Items[i].ToString()); // Arilash gramni yasaydu
						}
						else{
							gram.MakeNGram(lstFiles.Items[i].ToString()); // Belgilengen gramnila yasaydu
						}
					}
					
				}
				gram.Save("netije.txt",2); //tekrarliqi 2 yaki ikkidin kop bolghanlirini hojjetke saqlaydu 
			}
			gram=null;
			button1.Enabled=true;
		}
	}
}
