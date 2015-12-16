/*
 * Created by SharpDevelop.
 * User: gheyret
 * Date: 2010/01/06
 * Time: 9:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Text;

namespace UyghurNgram
{
	/// <summary>
	/// Description of utils.
	/// </summary>
	public class utils
	{
		// Uyghurce Unicode (kona yeziq heriplerning Unicodesi)
		//A
		public const char UYG_UN_A_6 =  (char)0x0627; //Yalghuz
		public const char UYG_UN_A_Y = (char)0xFE8D; //Yalghuz
		public const char UYG_UN_A_A = (char)0xFE8E; //Ayaq
		// E Heripi
		public const char UYG_UN_E_6 = (char)0x06D5; //Yalghuz;
		public const char UYG_UN_E_Y = (char)0xFEE9; //Yalghuz;
		public const char UYG_UN_E_A = (char)0xFEEA; //Ayaq;
		// B
		public const char UYG_UN_B_6 = (char)0x0628; //Yalghuz;
		public const char UYG_UN_B_Y = (char)0xFE8F; //Yalghuz;
		public const char UYG_UN_B_A = (char)0xFE90; //Ayaq;
		public const char UYG_UN_B_B = (char)0xFE91; //Bax;
		public const char UYG_UN_B_O = (char)0xFE92; //Ottura;
		//P
		public const char UYG_UN_P_6 = (char)0x067E; //Yalghuz;
		public const char UYG_UN_P_Y = (char)0xFB56; //Yalghuz;
		public const char UYG_UN_P_A = (char)0xFB57; //Ayaq;
		public const char UYG_UN_P_B = (char)0xFB58; //Bax;
		public const char UYG_UN_P_O = (char)0xFB59; //Ottura;
		//T
		public const char UYG_UN_T_6 = (char)0x062A; //Yalghuz;
		public const char UYG_UN_T_Y = (char)0xFE95; //Yalghuz;
		public const char UYG_UN_T_A = (char)0xFE96; //Ayaq;
		public const char UYG_UN_T_B = (char)0xFE97; //Bax;
		public const char UYG_UN_T_O = (char)0xFE98; //Ottura;
		//J
		public const char UYG_UN_J_6 = (char)0x062C; //Yalghuz;
		public const char UYG_UN_J_Y = (char)0xFE9D; //Yalghuz;
		public const char UYG_UN_J_A = (char)0xFE9E; //Ayaq;
		public const char UYG_UN_J_B = (char)0xFE9F; //Bax;
		public const char UYG_UN_J_O = (char)0xFEA0; //Ottura;
		//Ch
		public const char UYG_UN_CH_6 = (char)0x0686; //Yalghuz;
		public const char UYG_UN_CH_Y = (char)0xFB7A; //Yalghuz;
		public const char UYG_UN_CH_A = (char)0xFB7B; //Ayaq;
		public const char UYG_UN_CH_B = (char)0xFB7C; //Bax;
		public const char UYG_UN_CH_O = (char)0xFB7D; //Ottura;
		//X
		public const char UYG_UN_X_6 = (char)0x062E; //Yalghuz;
		public const char UYG_UN_X_Y = (char)0xFEA5; //Yalghuz;
		public const char UYG_UN_X_A = (char)0xFEA6; //Ayaq;
		public const char UYG_UN_X_B = (char)0xFEA7; //Bax;
		public const char UYG_UN_X_O = (char)0xFEA8; //Ottura;
		//D
		public const char UYG_UN_D_6 = (char)0x062F; //Yalghuz;
		public const char UYG_UN_D_Y = (char)0xFEA9; //Yalghuz;
		public const char UYG_UN_D_A = (char)0xFEAA; //Ayaq;
		//R
		public const char UYG_UN_R_6 = (char)0x0631; //Yalghuz;
		public const char UYG_UN_R_Y = (char)0xFEAD; //Yalghuz;
		public const char UYG_UN_R_A = (char)0xFEAE; //Ayaq;
		//Z
		public const char UYG_UN_Z_6 = (char)0x0632; //Yalghuz;
		public const char UYG_UN_Z_Y = (char)0xFEAF; //Yalghuz;
		public const char UYG_UN_Z_A = (char)0xFEB0; //Ayaq;
		//Z..
		public const char UYG_UN_ZZ_6 = (char)0x0698; //Yalghuz;
		public const char UYG_UN_ZZ_Y = (char)0xFB8A; //Yalghuz;
		public const char UYG_UN_ZZ_A = (char)0xFB8B; //Ayaq;
		//S
		public const char UYG_UN_S_6 = (char)0x0633; //Yalghuz;
		public const char UYG_UN_S_Y = (char)0xFEB1; //Yalghuz;
		public const char UYG_UN_S_A = (char)0xFEB2; //Ayaq;
		public const char UYG_UN_S_B = (char)0xFEB3; //Bax;
		public const char UYG_UN_S_O = (char)0xFEB4; //Ottura;
		//SH
		public const char UYG_UN_SH_6 = (char)0x0634; //Yalghuz;
		public const char UYG_UN_SH_Y = (char)0xFEB5; //Yalghuz;
		public const char UYG_UN_SH_A = (char)0xFEB6; //Ayaq;
		public const char UYG_UN_SH_B = (char)0xFEB7; //Bax;
		public const char UYG_UN_SH_O = (char)0xFEB8; //Ottura;
		//GH
		public const char UYG_UN_GH_6 = (char)0x063A; //Yalghuz;
		public const char UYG_UN_GH_Y = (char)0xFECD; //Yalghuz;
		public const char UYG_UN_GH_A = (char)0xFECE; //Ayaq;
		public const char UYG_UN_GH_B = (char)0xFECF; //Bax;
		public const char UYG_UN_GH_O = (char)0xFED0; //Ottura;
		//F
		public const char UYG_UN_F_6 = (char)0x0641; //Yalghuz;
		public const char UYG_UN_F_Y = (char)0xFED1; //Yalghuz;
		public const char UYG_UN_F_A = (char)0xFED2; //Ayaq;
		public const char UYG_UN_F_B = (char)0xFED3; //Bax;
		public const char UYG_UN_F_O = (char)0xFED4; //Ottura;
		//Q;
		public const char UYG_UN_Q_6 = (char)0x0642; //Yalghuz;
		public const char UYG_UN_Q_Y = (char)0xFED5; //Yalghuz;
		public const char UYG_UN_Q_A = (char)0xFED6; //Ayaq;
		public const char UYG_UN_Q_B = (char)0xFED7; //Bax;
		public const char UYG_UN_Q_O = (char)0xFED8; //Ottura;
		//K
		public const char UYG_UN_K_6 = (char)0x0643; //Yalghuz;
		public const char UYG_UN_K_Y = (char)0xFED9; //Yalghuz;
		public const char UYG_UN_K_A = (char)0xFEDA; //Ayaq;
		public const char UYG_UN_K_B = (char)0xFEDB; //Bax;
		public const char UYG_UN_K_O = (char)0xFEDC; //Ottura;
		//G
		public const char UYG_UN_G_6 = (char)0x06AF; //Yalghuz;
		public const char UYG_UN_G_Y = (char)0xFB92; //Yalghuz;
		public const char UYG_UN_G_A = (char)0xFB93; //Ayaq;
		public const char UYG_UN_G_B = (char)0xFB94; //Bax;
		public const char UYG_UN_G_O = (char)0xFB95; //Ottura;
		//NG
		public const char UYG_UN_NG_6 = (char)0x06AD; //Yalghuz;
		public const char UYG_UN_NG_Y = (char)0xFBD3; //Yalghuz;
		public const char UYG_UN_NG_A = (char)0xFBD4; //Ayaq;
		public const char UYG_UN_NG_B = (char)0xFBD5; //Bax;
		public const char UYG_UN_NG_O = (char)0xFBD6; //Ottura;
		//L
		public const char UYG_UN_L_6 = (char)0x0644; //Yalghuz;
		public const char UYG_UN_L_Y = (char)0xFEDD; //Yalghuz;
		public const char UYG_UN_L_A = (char)0xFEDE; //Ayaq;
		public const char UYG_UN_L_B = (char)0xFEDF; //Bax;
		public const char UYG_UN_L_O = (char)0xFEE0; //Ottura;
		//M
		public const char UYG_UN_M_6 = (char)0x0645; //Yalghuz;
		public const char UYG_UN_M_Y = (char)0xFEE1; //Yalghuz;
		public const char UYG_UN_M_A = (char)0xFEE2; //Ayaq;
		public const char UYG_UN_M_B = (char)0xFEE3; //Bax;
		public const char UYG_UN_M_O = (char)0xFEE4; //Ottura;
		//N
		public const char UYG_UN_N_6 = (char)0x0646; //Yalghuz;
		public const char UYG_UN_N_Y = (char)0xFEE5; //Yalghuz;
		public const char UYG_UN_N_A = (char)0xFEE6; //Ayaq;
		public const char UYG_UN_N_B = (char)0xFEE7; //Bax;
		public const char UYG_UN_N_O = (char)0xFEE8; //Ottura;
		//H..
		public const char UYG_UN_H_6 = (char)0x06BE; //Yalghuz;
		public const char UYG_UN_H_Y = (char)0xFBAA; //Yalghuz;
		public const char UYG_UN_H_A = (char)0xFBAB; //Ayaq;
		public const char UYG_UN_H_B = (char)0xFBAC; //Bax;
		public const char UYG_UN_H_O = (char)0xFBAD; //Ottura;

		//O
		public const char UYG_UN_O_6 = (char)0x0648; //Yalghuz;
		public const char UYG_UN_O_Y = (char)0xFEED; //Yalghuz;
		public const char UYG_UN_O_A = (char)0xFEEE; //Ayaq;
		//U
		public const char UYG_UN_U_6 = (char)0x06C7; //Yalghuz;
		public const char UYG_UN_U_Y = (char)0xFBD7; //Yalghuz;
		public const char UYG_UN_U_A = (char)0xFBD8; //Ayaq;
		//O..
		public const char UYG_UN_OO_6 = (char)0x06C6; //Yalghuz;
		public const char UYG_UN_OO_Y = (char)0xFBD9; //Yalghuz;
		public const char UYG_UN_OO_A = (char)0xFBDA; //Ayaq;
		//U..
		public const char UYG_UN_UU_6 = (char)0x06C8; //Yalghuz;
		public const char UYG_UN_UU_Y = (char)0xFBDB; //Yalghuz;
		public const char UYG_UN_UU_A = (char)0xFBDC; //Ayaq;
		//W
		public const char UYG_UN_W_6 = (char)0x06CB; //Yalghuz;
		public const char UYG_UN_W_Y = (char)0xFBDE; //Yalghuz;
		public const char UYG_UN_W_A = (char)0xFBDF; //Ayaq;
		//E..
		public const char UYG_UN_EE_6 = (char)0x06D0; //Yalghuz;
		public const char UYG_UN_EE_Y = (char)0xFBE4; //Yalghuz;
		public const char UYG_UN_EE_A = (char)0xFBE5; //Ayaq;
		public const char UYG_UN_EE_B = (char)0xFBE6; //Bax;
		public const char UYG_UN_EE_O = (char)0xFBE7; //Ottura;
		//I
		public const char UYG_UN_I_6 = (char)0x0649; //Yalghuz;
		public const char UYG_UN_I_Y = (char)0xFEEF; //Yalghuz;
		public const char UYG_UN_I_A = (char)0xFEF0; //Ayaq;
		public const char UYG_UN_I_B = (char)0xFBE8; //Bax;
		public const char UYG_UN_I_O = (char)0xFBE9; //Ottura;
		//Y
		public const char UYG_UN_Y_6 = (char)0x064A; //Yalghuz;
		public const char UYG_UN_Y_Y = (char)0xFEF1; //Yalghuz;
		public const char UYG_UN_Y_A = (char)0xFEF2; //Ayaq;
		public const char UYG_UN_Y_B = (char)0xFEF3; //Bax;
		public const char UYG_UN_Y_O = (char)0xFEF4; //Ottura;

		//La
		public const char UYG_UN_LA_6 = (char)0xFEFB; //Yalghuz;
		public const char UYG_UN_LA_Y = (char)0xFEFB; //Yalghuz;
		public const char UYG_UN_LA_A = (char)0xFEFC; //Ayaq;
		//Amza
		public const char UYG_UN_HM_6 = (char)0x0626; //Yalghuz;
		public const char UYG_UN_HM_Y = (char)0xFE8B; //Yalghuz;
		public const char UYG_UN_HM_O = (char)0xFE8C; //Ottura;

		// Towendikiler Uyghurche Heripler
		// Biraq ular KeyBord Arqiliq kirguzgende ishlitilmidi

		// hemze bilen A
		public const char UYGE_UN_HA_Y = (char)0xFBEA; //Yalghuz;
		public const char UYGE_UN_HA_A = (char)0xFBEB; //Ayaq;

		//hemze bilen E
		public const char UYGE_UN_HE_Y = (char)0xFBEC; //Yalghuz;
		public const char UYGE_UN_HE_A = (char)0xFBED; //Ayaq;

		//hemze bilen O
		public const char UYGE_UN_HO_Y = (char)0xFBEE; //Yalghuz;
		public const char UYGE_UN_HO_A = (char)0xFBEF; //Ayaq;

		//hemze bilen U
		public const char UYGE_UN_HU_Y = (char)0xFBF0; //Yalghuz;
		public const char UYGE_UN_HU_A = (char)0xFBF1; //Ayaq;

		//hemze bilen OO
		public const char UYGE_UN_HOO_Y = (char)0xFBF2; //Yalghuz;
		public const char UYGE_UN_HOO_A = (char)0xFBF3; //Ayaq;

		//hemze bilen UU
		public const char UYGE_UN_HUU_Y = (char)0xFBF4; //Yalghuz;
		public const char UYGE_UN_HUU_A = (char)0xFBF5; //Ayaq;

		//hemze bilen EE
		public const char UYGE_UN_HEE_Y = (char)0xFBF6; //Yalghuz;
		public const char UYGE_UN_HEE_A = (char)0xFBF7; //Ayaq;
		public const char UYGE_UN_HEE_B = (char)0xFBF8; //Ayaq;

		//hemze bilen I
		public const char UYGE_UN_HI_Y = (char)0xFBF9; //Yalghuz;
		public const char UYGE_UN_HI_A = (char)0xFBFA; //Ayaq;
		public const char UYGE_UN_HI_B = (char)0xFBFB; //Ayaq;

		// Bu Artuq Ishlitilgen H heripi(Hemze emes)
		public const char UYGE_UN_H_Y = (char)0xFEEB; //Yalghuz;
		public const char UYGE_UN_H_A = (char)(char)0xFEEC; //Ayaq;
		
		public static String[] GetSozler(String str)
		{
			char[] sp={' '};
			String[] sozler=str.Split(sp);
			ArrayList buf=new ArrayList();
			foreach(String soz in sozler)
			{
				if(soz.Length<30 ){
					buf.Add(soz);
				}
				else if(soz.IndexOf('-')!=-1 && soz.Length<50){
					buf.Add(soz);
				}
			}
			sozler=new string[buf.Count];
			int i=0;
			foreach(String soz in buf)
			{
				sozler[i++]=soz;
			}
			return sozler;
		}
		
		public static bool HemmisiUyghurchimu(String soz)
		{
			bool ret=true;
			foreach(char Herp in soz)
			{
				if(Herp!='-' && IsUyghurcheHerp(Herp)==false)
				{
					ret=false;
					break;
				}
			}
			return ret;
		}
		
		public static bool UyghurcheBarmu(String soz)
		{
			bool ret=false;
			foreach(char Herp in soz)
			{
				if(IsUyghurcheHerp(Herp)==true)
				{
					ret=true;
					break;
				}
			}
			return ret;
		}

		public static string[] GetJumle(String abzas){
			char[] sp={'.','،','؛','؟',':','[',']','(',')','<','>'};
			StringBuilder buf=new StringBuilder();
			string[] jumle;
			bool boshluq=false;
			char herp;
			for(int i=0;i<abzas.Length;i++){
				if((abzas[i]>=0x0620 && abzas[i]<=0x06FF)||(abzas[i]>='0' && abzas[i]<='9'))
				{
					if(abzas[i]=='ة'){
						buf.Append('ە');
					}
					else if(abzas[i]=='ط'||abzas[i]=='ه'){
						buf.Append('ھ');
					}
					else if(abzas[i]=='ع'){
						buf.Append('ى');
					}
					else if(abzas[i]=='ذ'){
						buf.Append('ۇ');
					}
					else if(abzas[i]=='ظ'){
						buf.Append('ب');
					}
					else if(abzas[i]=='ث'){
						buf.Append('ڭ');
					}
					else if(abzas[i]=='ض'){
						buf.Append('گ');
					}
					else if(abzas[i]=='ح'){
						buf.Append('چ');
					}
					else if(abzas[i]=='إ'){
						buf.Append('ۆ');
					}
					else if(abzas[i]=='ؤ'){
						buf.Append('ۋ');
					}
					else{
						if(abzas[i]!=0x0640){
							buf.Append(abzas[i]);
						}
					}
					boshluq=false;
				}
				else if(abzas[i]=='-' || abzas[i]=='−'||abzas[i]=='-'||abzas[i]=='–'){
					buf.Append('-');
					boshluq=false;
				}
				else if(Array.IndexOf(sp,abzas[i])!=-1){
					buf.Append(abzas[i]);
					boshluq=false;
				}
				else if((abzas[i]>=0xFB00 && abzas[i]<0xFEFF)){
					herp=ToBaseCodeUyghur(abzas[i]);
					if(herp>=0x0620 && herp<=0x06FF){
						buf.Append(herp);
					}
					else{
						System.Diagnostics.Debug.WriteLine("Neme boldi?");
					}
					boshluq=false;
				}else{
					if(boshluq==false){
						buf.Append(' ');
						boshluq=true;
					}
				}
			}
			jumle=buf.ToString().Replace("  ", " ").Replace(" - ", "-").Replace(" -", "-").Replace("- ", "-").Split(sp,StringSplitOptions.RemoveEmptyEntries);
			for(int i=0;i<jumle.Length;i++){
				if(UyghurcheBarmu(jumle[i])){
					jumle[i]=jumle[i].Trim();
					while(jumle[i].EndsWith("-")){
						jumle[i]=jumle[i].Substring(0,jumle[i].Length-1);
					}
					while(jumle[i].StartsWith("-")){
						jumle[i]=jumle[i].Substring(1);
					}
					while(jumle[i].IndexOf("--")!=-1){
						jumle[i]=jumle[i].Replace("--", "-");
					}
				}
				else{
					jumle[i]="";
				}
			}
			return jumle;
		}
		
		
		public static bool IsUyghurcheHerp(char Herp)
		{
			bool ret=false;
			switch(Herp)
			{
				case  UYG_UN_A_6  :
				case  UYG_UN_E_6  :
				case  UYG_UN_B_6  :
				case  UYG_UN_P_6 :
				case  UYG_UN_T_6  :
				case  UYG_UN_J_6  :
				case  UYG_UN_CH_6 :
				case  UYG_UN_X_6 :
				case  UYG_UN_D_6  :
				case  UYG_UN_R_6 :
				case  UYG_UN_Z_6 :
				case  UYG_UN_ZZ_6 :
				case  UYG_UN_S_6 :
				case  UYG_UN_SH_6 :
				case  UYG_UN_GH_6 :
				case  UYG_UN_F_6  :
				case  UYG_UN_Q_6 :
				case  UYG_UN_K_6 :
				case  UYG_UN_G_6  :
				case  UYG_UN_NG_6  :
				case  UYG_UN_L_6  :
				case  UYG_UN_M_6  :
				case  UYG_UN_N_6 :
				case  UYG_UN_H_6  :
				case  UYG_UN_O_6  :
				case  UYG_UN_U_6  :
				case  UYG_UN_OO_6 :
				case  UYG_UN_UU_6 :
				case  UYG_UN_W_6 :
				case  UYG_UN_EE_6 :
				case  UYG_UN_I_6  :
				case  UYG_UN_Y_6  :
				case  UYG_UN_HM_6 :
					ret=true;
					break;
				default:
					ret=false;
					break;
			}
			return ret;
		}
		
		//0x0600 din 0x06FF qiche bolghan asas kodqa aylandurup
		public static char ToBaseCodeUyghur(char Herp)
		{
			char ret=Herp;
			if(ret>=0x0600 && ret<=0x06FF){
				
			}
			else{
				switch (Herp) {
					case UYG_UN_A_Y:
					case UYG_UN_A_A:
					case UYGE_UN_HA_Y:
					case UYGE_UN_HA_A:
						ret = UYG_UN_A_6;
						break;
					case UYG_UN_E_Y:
					case UYG_UN_E_A:
					case UYGE_UN_HE_Y:
					case UYGE_UN_HE_A:
						ret = UYG_UN_E_6;
						break;
					case UYG_UN_B_Y:
					case UYG_UN_B_B:
					case UYG_UN_B_O:
					case UYG_UN_B_A:
						ret = UYG_UN_B_6;
						break;
					case UYG_UN_P_Y:
					case UYG_UN_P_B:
					case UYG_UN_P_O:
					case UYG_UN_P_A:
						ret = UYG_UN_P_6;
						break;
					case UYG_UN_T_Y:
					case UYG_UN_T_B:
					case UYG_UN_T_O:
					case UYG_UN_T_A:
						ret = UYG_UN_T_6;
						break;
					case UYG_UN_J_Y:
					case UYG_UN_J_B:
					case UYG_UN_J_O:
					case UYG_UN_J_A:
						ret = UYG_UN_J_6;
						break;
					case UYG_UN_CH_Y:
					case UYG_UN_CH_B:
					case UYG_UN_CH_O:
					case UYG_UN_CH_A:
						ret = UYG_UN_CH_6;
						break;
					case UYG_UN_X_Y:
					case UYG_UN_X_B:
					case UYG_UN_X_O:
					case UYG_UN_X_A:
						ret = UYG_UN_X_6;
						break;
					case UYG_UN_D_Y:
					case UYG_UN_D_A:
						ret = UYG_UN_D_6;
						break;
					case UYG_UN_R_Y:
					case UYG_UN_R_A:
						ret = UYG_UN_R_6;
						break;
					case UYG_UN_Z_Y:
					case UYG_UN_Z_A:
						ret = UYG_UN_Z_6;
						break;
					case UYG_UN_ZZ_Y:
					case UYG_UN_ZZ_A:
						ret = UYG_UN_ZZ_6;
						break;
					case UYG_UN_S_Y:
					case UYG_UN_S_B:
					case UYG_UN_S_O:
					case UYG_UN_S_A:
						ret = UYG_UN_S_6;
						break;
					case UYG_UN_SH_Y:
					case UYG_UN_SH_B:
					case UYG_UN_SH_O:
					case UYG_UN_SH_A:
						ret = UYG_UN_SH_6;
						break;
					case UYG_UN_GH_Y:
					case UYG_UN_GH_B:
					case UYG_UN_GH_O:
					case UYG_UN_GH_A:
						ret = UYG_UN_GH_6;
						break;
					case UYG_UN_F_Y:
					case UYG_UN_F_B:
					case UYG_UN_F_O:
					case UYG_UN_F_A:
						ret = UYG_UN_F_6;
						break;
					case UYG_UN_Q_Y:
					case UYG_UN_Q_B:
					case UYG_UN_Q_O:
					case UYG_UN_Q_A:
						ret = UYG_UN_Q_6;
						break;
					case UYG_UN_K_Y:
					case UYG_UN_K_B:
					case UYG_UN_K_O:
					case UYG_UN_K_A:
						ret = UYG_UN_K_6;
						break;
					case UYG_UN_G_Y:
					case UYG_UN_G_B:
					case UYG_UN_G_O:
					case UYG_UN_G_A:
						ret = UYG_UN_G_6;
						break;
					case UYG_UN_NG_Y:
					case UYG_UN_NG_B:
					case UYG_UN_NG_O:
					case UYG_UN_NG_A:
						ret = UYG_UN_NG_6;
						break;
					case UYG_UN_L_Y:
					case UYG_UN_L_B:
					case UYG_UN_L_O:
					case UYG_UN_L_A:
						ret = UYG_UN_L_6;
						break;
					case UYG_UN_M_Y:
					case UYG_UN_M_B:
					case UYG_UN_M_O:
					case UYG_UN_M_A:
						ret = UYG_UN_M_6;
						break;
					case UYG_UN_N_Y:
					case UYG_UN_N_B:
					case UYG_UN_N_O:
					case UYG_UN_N_A:
						ret = UYG_UN_N_6;
						break;
					case UYG_UN_H_Y:
					case UYG_UN_H_A:
					case UYG_UN_H_B:
					case UYG_UN_H_O:
					case UYGE_UN_H_Y:
					case UYGE_UN_H_A:
						ret = UYG_UN_H_6;
						break;
					case UYG_UN_O_Y:
					case UYG_UN_O_A:
					case UYGE_UN_HO_Y:
					case UYGE_UN_HO_A:
						ret = UYG_UN_O_6;
						break;
					case UYG_UN_U_Y:
					case UYG_UN_U_A:
					case UYGE_UN_HU_Y:
					case UYGE_UN_HU_A:
						ret = UYG_UN_U_6;
						break;
					case UYG_UN_OO_Y:
					case UYG_UN_OO_A:
					case UYGE_UN_HOO_Y:
					case UYGE_UN_HOO_A:
						ret = UYG_UN_OO_6;
						break;
					case UYG_UN_UU_Y:
					case UYG_UN_UU_A:
					case UYGE_UN_HUU_Y:
					case UYGE_UN_HUU_A:
						ret = UYG_UN_UU_6;
						break;
					case UYG_UN_W_Y:
					case UYG_UN_W_A:
						ret = UYG_UN_W_6;
						break;
					case UYG_UN_EE_Y:
					case UYG_UN_EE_B:
					case UYG_UN_EE_O:
					case UYG_UN_EE_A:
					case UYGE_UN_HEE_Y:
					case UYGE_UN_HEE_A:
					case UYGE_UN_HEE_B:
						ret = UYG_UN_EE_6;
						break;
					case UYG_UN_I_Y:
					case UYG_UN_I_B:
					case UYG_UN_I_O:
					case UYG_UN_I_A:
					case UYGE_UN_HI_Y:
					case UYGE_UN_HI_A:
					case UYGE_UN_HI_B:
						ret = UYG_UN_I_6;
						break;
					case UYG_UN_Y_Y:
					case UYG_UN_Y_B:
					case UYG_UN_Y_O:
					case UYG_UN_Y_A:
						ret = UYG_UN_Y_6;
						break;
					case UYG_UN_LA_Y:
					case UYG_UN_LA_A:
						ret = UYG_UN_LA_Y;
						break;
					case UYG_UN_HM_Y:
					case UYG_UN_HM_O:
						ret = UYG_UN_HM_6;
						break;
					default:
						ret=Herp;
						break;
				}
			}
			return ret;
		}
	}
}
