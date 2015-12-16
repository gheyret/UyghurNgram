/*
 * Created by SharpDevelop.
 * User: gheyret
 * Date: 2010/01/06
 * Time: 8:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.IO;
using System.Text;

namespace UyghurNgram
{
	/// <summary>
	/// Description of UGram.
	/// </summary>
	public class UGram: IComparer
	{
		private TstTree mBuf=new TstTree();
		private StringBuilder ngramBuf=new StringBuilder();
		private int gGramLen;

		public UGram(int gramlen) {
			gGramLen=gramlen;
		}

		public void Save(String name,int freq)
		{
			try{
				StreamWriter ofs=new StreamWriter(name,false,Encoding.UTF8);
				mBuf.Save(ofs,freq);
				ofs.Close();
			}catch(Exception ee){
				System.Console.WriteLine(ee.Message);
			}
			mBuf=null;
			mBuf=new TstTree();
		}

		public int GetCount(){
			return mBuf.Count;
		}

		public void PutString(String soz){
			mBuf.Add(soz);
		}
		
		//Bu birdin gGramLen ghiche uzunluqtiki gram yasaydu
		private void PutAllGram(String jumle)
		{
			int i,j;
			String[] sozler=utils.GetSozler(jumle);
			int N=gGramLen;
			int len;
			for(i=0;i<sozler.Length;i++){
				ngramBuf.Length=0;
				mBuf.Add(sozler[i]);
				ngramBuf.Append(sozler[i]);
				len=N+i;
				if(len>sozler.Length){
					len=sozler.Length;
				}
				for(j=i+1;j<len;j++){
					ngramBuf.Append(" "+sozler[j]);
					mBuf.Add(ngramBuf.ToString());
				}
			}
		}
		
		//Bu gGramLen uzunluqtiki gram yasaydu
		private void PutNGram(String jumle)
		{
			int i,j;
			String[] sozler=utils.GetSozler(jumle);
			int N=gGramLen;
			if(sozler.Length<N) return ;
			for(i=0;i<=sozler.Length-N;i++){
				ngramBuf.Length=0;
				for(j=i;j<N+i;j++){
					ngramBuf.Append(" "+sozler[j]);
				}
				mBuf.Add(ngramBuf.ToString());
			}
		}
		

		public void MakeN(String fileName){
			try{
				System.Console.WriteLine("Make Only "+ gGramLen+" gram using file "+ fileName);
				StringBuilder buf=new StringBuilder();
				StreamReader inr=new StreamReader(fileName,Encoding.UTF8);
				String jumle=inr.ReadLine();
				while(jumle!=null){
					if(string.IsNullOrEmpty(jumle)==false){
						PutNGram(jumle);
					}
					jumle = inr.ReadLine();
				}
				inr.Close();
				System.Console.WriteLine("Tamam nGram Sani =" +mBuf.Count);
			}catch(Exception ee){
				System.Console.WriteLine(ee.Message+ " Sani="+mBuf.Count);
			}
		}
		

		public void ParseAndMake(String fileName){
			try{
				StringBuilder buf=new StringBuilder();
				System.Console.WriteLine(fileName);
				StreamReader inr=new StreamReader(fileName,Encoding.UTF8);
				String abzas=inr.ReadLine();
				String[] jumle;
				while(abzas!=null){
					jumle=utils.GetJumle(abzas);
					foreach(String jm in jumle){
						PutAllGram(jm);
					}
					abzas = inr.ReadLine();
				}
				inr.Close();
			}catch(Exception ee){
				System.Console.WriteLine(ee.Message+ " Sani="+mBuf.Count);
			}
		}

		
		public ArrayList GetNGram(int freq)
		{
			ArrayList sanduq=new ArrayList();
			mBuf.GetAll(freq,sanduq);
			mBuf=null;
			mBuf=new TstTree();
			return sanduq;
		}

		public int Compare(Object a,Object b)
		{
			String aa=(String)a;
			String bb=(String)b;
			int frq1=int.Parse(aa.Split('\t')[1]);
			int frq2=int.Parse(bb.Split('\t')[1]);
			return frq2-frq1;
		}

		public ArrayList GetNGramSort(int freq)
		{
			ArrayList ret=new ArrayList();
			mBuf.GetAll(freq,ret);
			mBuf=null;
			mBuf=new TstTree();
			System.Console.WriteLine("Tiziwatidu Jemiy ="+ ret.Count+ " Soz");
			ret.Sort(this);
			return ret;
		}
	}
}
