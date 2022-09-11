using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			lngComboBox.SelectedText = "TR";
			lngComboBox.Items.Add("TR");
			lngComboBox.Items.Add("EN");
			lngComboBox.SelectedIndex = 0;
		}

        private void btn_Addition_Click(object sender, EventArgs e)
        {
			if (lngComboBox.Text == "TR")
			{
				ulong valWord1 = WordsToNumbersTr(txtValue1.Text);
				ulong valWord2 = WordsToNumbersTr(txtValue2.Text);
				int sum = Convert.ToInt32(valWord1 + valWord2);
				string res = ConvertNumberToStringTr(sum);
				txtResult.Text = res;
			}

            if (lngComboBox.Text == "EN") 
			{
				ulong valWord1 = WordsToNumbersEng(txtValue1.Text);
				ulong valWord2 = WordsToNumbersEng(txtValue2.Text);
				int sum = Convert.ToInt32(valWord1 + valWord2);
				string res = ConvertNumberToStringEn(sum);
				txtResult.Text = res;
			}
	    }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
			if (lngComboBox.Text == "TR")
			{
				ulong valWord1 = WordsToNumbersTr(txtValue1.Text);
				ulong valWord2 = WordsToNumbersTr(txtValue2.Text);
				try
				{
					int sum = Convert.ToInt32(valWord1 - valWord2);
					string res = ConvertNumberToStringTr(sum);
					txtResult.Text = res;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hata");
				}
			}

			if (lngComboBox.Text == "EN")
			{
				ulong valWord1 = WordsToNumbersEng(txtValue1.Text);
				ulong valWord2 = WordsToNumbersEng(txtValue2.Text);
                try
                {
					int sum = Convert.ToInt32(valWord1 - valWord2);
					string res = ConvertNumberToStringEn(sum);
					txtResult.Text = res;
				}
                catch (Exception ex)
                {
					MessageBox.Show("Error");
                }
			}
		}

        private void btn_Division_Click(object sender, EventArgs e)
        {
			if (lngComboBox.Text == "TR")
			{
				ulong valWord1 = WordsToNumbersTr(txtValue1.Text);
				ulong valWord2 = WordsToNumbersTr(txtValue2.Text);
				int sum = Convert.ToInt32(valWord1 / valWord2);
				string res = ConvertNumberToStringTr(sum);
				txtResult.Text = res;
			}

			if (lngComboBox.Text == "EN")
			{
				ulong valWord1 = WordsToNumbersEng(txtValue1.Text);
				ulong valWord2 = WordsToNumbersEng(txtValue2.Text);
				int sum = Convert.ToInt32(valWord1 / valWord2);
				string res = ConvertNumberToStringEn(sum);
				txtResult.Text = res;
			}
		}

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
			if (lngComboBox.Text == "TR")
			{
				ulong valWord1 = WordsToNumbersTr(txtValue1.Text);
				ulong valWord2 = WordsToNumbersTr(txtValue2.Text);
				int sum = Convert.ToInt32(valWord1 * valWord2);
				string res = ConvertNumberToStringTr(sum);
				txtResult.Text = res;
			}

			if (lngComboBox.Text == "EN")
			{
				ulong valWord1 = WordsToNumbersEng(txtValue1.Text);
				ulong valWord2 = WordsToNumbersEng(txtValue2.Text);
				int sum = Convert.ToInt32(valWord1 * valWord2);
				string res = ConvertNumberToStringEn(sum);
				txtResult.Text = res;
			}
		}

		public static string ConvertNumberToStringEn(int n)
		{
			if (n < 0)
				throw new NotSupportedException("negative numbers not supported");
			if (n == 0)
				return "zero";
			if (n < 10)
				return ConvertDigitToStringEn(n);
			if (n < 20)
				return ConvertTeensToStringEn(n);
			if (n < 100)
				return ConvertHighTensToStringEn(n);
			if (n < 1000)
				return ConvertBigNumberToStringEn(n, (int)1e2, "hundred");
			if (n < 1e6)
				return ConvertBigNumberToStringEn(n, (int)1e3, "thousand");
			if (n < 1e9)
				return ConvertBigNumberToStringEn(n, (int)1e6, "million");
			//if (n < 1e12)
			return ConvertBigNumberToStringEn(n, (int)1e9, "billion");
		}

		public static string ConvertNumberToStringTr(int n)
		{
			if (n < 0)
				throw new NotSupportedException("negatif sayı girmeyiniz");
			if (n == 0)
				return "sıfır";
			if (n < 10)
				return ConvertDigitToStringTr(n);
			if (n < 20)
				return ConvertTeensToStringTr(n);
			if (n < 100)
				return ConvertHighTensToStringTr(n);
			if (n < 1000)
				return ConvertBigNumberToStringTr(n, (int)1e2, "yüz");
			if (n < 1e6)
				return ConvertBigNumberToStringTr(n, (int)1e3, "bin");
			if (n < 1e9)
				return ConvertBigNumberToStringTr(n, (int)1e6, "milyar");
			//if (n < 1e12)
			return ConvertBigNumberToStringTr(n, (int)1e9, "milyon");
		}






		private static string ConvertBigNumberToStringEn(int n, int baseNum, string baseNumStr)
		{
			string separator = (baseNumStr != "hundred") ? ", " : " ";
			int bigPart = (int)(Math.Floor((double)n / baseNum));
			string bigPartStr = ConvertNumberToStringEn(bigPart) + " " + baseNumStr;
			if (n % baseNum == 0) return bigPartStr;
			int restOfNumber = n - bigPart * baseNum;
			return bigPartStr + separator + ConvertNumberToStringEn(restOfNumber);
		}

		private static string ConvertBigNumberToStringTr(int n, int baseNum, string baseNumStr)
		{
			string separator = (baseNumStr != "yüz") ? ", " : " ";
			int bigPart = (int)(Math.Floor((double)n / baseNum));
			string bigPartStr = ConvertNumberToStringTr(bigPart) + " " + baseNumStr;
			if (n % baseNum == 0) return bigPartStr;
			int restOfNumber = n - bigPart * baseNum;
			return bigPartStr + separator + ConvertNumberToStringTr(restOfNumber);
		}


		private static string ConvertDigitToStringEn(int i)
		{
			switch (i)
			{
				case 0: return "";
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
				default:
					throw new IndexOutOfRangeException(String.Format("{0} not a digit", i));
			}
		}

		private static string ConvertDigitToStringTr(int i)
		{
			switch (i)
			{
				case 0: return "";
				case 1: return "bir";
				case 2: return "iki";
				case 3: return "üç";
				case 4: return "dört";
				case 5: return "beş";
				case 6: return "altı";
				case 7: return "yedi";
				case 8: return "sekiz";
				case 9: return "dokuz";
				default:
					throw new IndexOutOfRangeException(String.Format("{0} bir rakam değildir", i));
			}
		}

		//assumes a number between 10 & 19
		private static string ConvertTeensToStringEn(int n)
		{
			switch (n)
			{
				case 10: return "ten";
				case 11: return "eleven";
				case 12: return "twelve";
				case 13: return "thirteen";
				case 14: return "fourteen";
				case 15: return "fiveteen";
				case 16: return "sixteen";
				case 17: return "seventeen";
				case 18: return "eighteen";
				case 19: return "nineteen";
				default:
					throw new IndexOutOfRangeException(String.Format("{0} not a teen", n));
			}
		}


		private static string ConvertTeensToStringTr(int n)
		{
			switch (n)
			{
				case 10: return "on";
				case 11: return "on bir";
				case 12: return "on iki";
				case 13: return "on üç";
				case 14: return "on dört";
				case 15: return "on beş";
				case 16: return "on altı";
				case 17: return "on yedi";
				case 18: return "on sekiz";
				case 19: return "on dokuz";
				default:
					throw new IndexOutOfRangeException(String.Format("{0} onluk değil", n));
			}
		}
		//assumes a number between 20 and 99
		private static string ConvertHighTensToStringEn(int n)
		{
			int tensDigit = (int)(Math.Floor((double)n / 10.0));

			string tensStr;
			switch (tensDigit)
			{
				case 2: tensStr = "twenty"; break;
				case 3: tensStr = "thirty"; break;
				case 4: tensStr = "forty"; break;
				case 5: tensStr = "fifty"; break;
				case 6: tensStr = "sixty"; break;
				case 7: tensStr = "seventy"; break;
				case 8: tensStr = "eighty"; break;
				case 9: tensStr = "ninety"; break;
				default:
					throw new IndexOutOfRangeException(String.Format("{0} not in range 20-99", n));
			}
			if (n % 10 == 0) return tensStr;
			string onesStr = ConvertDigitToStringEn(n - tensDigit * 10);
			return tensStr + "-" + onesStr;
		}
		private static string ConvertHighTensToStringTr(int n)
		{
			int tensDigit = (int)(Math.Floor((double)n / 10.0));

			string tensStr;
			switch (tensDigit)
			{
				case 2: tensStr = "yirmi"; break;
				case 3: tensStr = "otuz"; break;
				case 4: tensStr = "kırk"; break;
				case 5: tensStr = "elli"; break;
				case 6: tensStr = "altmış"; break;
				case 7: tensStr = "yetmiş"; break;
				case 8: tensStr = "seksen"; break;
				case 9: tensStr = "doksan"; break;
				default:
					throw new IndexOutOfRangeException(String.Format("{0} 20-99 aralığında değil. ", n));
			}
			if (n % 10 == 0) return tensStr;
			string onesStr = ConvertDigitToStringTr(n - tensDigit * 10);
			return tensStr + "-" + onesStr;
		}

		public static ulong WordsToNumbersEng(string words)
		{
			if (string.IsNullOrEmpty(words)) 
				return 0;

			words = words.Trim();
			words += ' ';

			ulong number = 0;

			string[] singles = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
			string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
			string[] tens = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };
			string[] powers = new string[] { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion" };

			for (int i = powers.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(powers[i]))
				{
					int index = words.IndexOf(powers[i]);

					if (index >= 0 && words[index + powers[i].Length] == ' ')
					{
						ulong count = WordsToNumbersEng(words.Substring(0, index));
						number += count * (ulong)Math.Pow(1000, i);
						words = words.Remove(0, index);
					}
				}
			}

			{
				int index = words.IndexOf("hundred");

				if (index >= 0 && words[index + "hundred".Length] == ' ')
				{
					ulong count = WordsToNumbersEng(words.Substring(0, index));
					number += count * 100;
					words = words.Remove(0, index);
				}
			}

			for (int i = tens.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(tens[i]))
				{
					int index = words.IndexOf(tens[i]);

					if (index >= 0 && words[index + tens[i].Length] == ' ')
					{
						number += (uint)(i * 10);
						words = words.Remove(0, index);
					}
				}
			}

			for (int i = teens.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(teens[i]))
				{
					int index = words.IndexOf(teens[i]);

					if (index >= 0 && words[index + teens[i].Length] == ' ')
					{
						number += (uint)(i + 10);
						words = words.Remove(0, index);
					}
				}
			}

			for (int i = singles.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(singles[i]))
				{
					int index = words.IndexOf(singles[i] + ' ');

					if (index >= 0 && words[index + singles[i].Length] == ' ')
					{
						number += (uint)(i);
						words = words.Remove(0, index);
					}
				}
			}

			return number;
		}



		public static ulong WordsToNumbersTr(string words)
		{
			if (string.IsNullOrEmpty(words))
				return 0;

			words = words.Trim();
			words += ' ';

			ulong number = 0;

			string[] singles = new string[] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
			string[] teens = new string[] { "on", "on bir", "on iki", "on üç", "on dört", "on beş", "on altı", "on yedi", "on sekiz", "on dokuz" };
			string[] tens = new string[] { "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
			string[] powers = new string[] { "bin", "milyon", "milyar", "trilyon", "katrilyon", "kentilyon" };

			for (int i = powers.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(powers[i]))
				{
					int index = words.IndexOf(powers[i]);

					if (index >= 0 && words[index + powers[i].Length] == ' ')
					{
						ulong count = WordsToNumbersTr(words.Substring(0, index));
						number += count * (ulong)Math.Pow(1000, i);
						words = words.Remove(0, index);
					}
				}
			}

			{
				int index = words.IndexOf("yüz");
		
				if (index >= 0 && words[index + "yüz".Length] == ' ')
				{
					ulong count = WordsToNumbersTr(words.Substring(0, index));
					number += count * 100;
					words = words.Remove(0, index);
				}
			}
		
			for (int i = tens.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(tens[i]))
				{
					int index = words.IndexOf(tens[i]);
		
					if (index >= 0 && words[index + tens[i].Length] == ' ')
					{
						number += (uint)(i * 10);
						words = words.Remove(0, index);
					}
				}
			}
		
			for (int i = teens.Length - 1; i >= 0; i--)
			{
				if (!string.IsNullOrEmpty(teens[i]))
				{
					int index = words.IndexOf(teens[i]);
		
					if (index >= 0 && words[index + teens[i].Length] == ' ')
					{
						number += (uint)(i + 10);
						words = words.Remove(0, index);
					}
				}
			}

		  for (int i = singles.Length - 1; i >= 0; i--)
		  {
		  		if (!string.IsNullOrEmpty(singles[i]))
		  		{
		  			int index = words.IndexOf(singles[i] + ' ');
		  
		  			if (index >= 0 && words[index + singles[i].Length] == ' ')
		  			{
		  				number += (uint)(i);
		  				words = words.Remove(0, index);
		  			}
		  		}
		  }
            if (number == 2 || number == 3 || number == 1 || number == 4 || number == 5 || number == 6 || number == 7 || number == 8 || number == 9)
            {
				return number;
			}
            else
            {
				return number / 2;
			}

			
		}

        private void lngComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lngComboBox.Text=="TR")//tr
            {
				lblLang.Text = "Dil Seçimi";
				lblRes.Text = "Sonuç";
				lblVal1.Text = "1. sayı";
				lblVal2.Text = "2. sayı";
			}
			if (lngComboBox.Text == "EN")//en
			{
				lblLang.Text = "Language";
				lblRes.Text = "Result";
				lblVal1.Text = "First Value";
				lblVal2.Text = "Second Value";
			}

		}
    }
}
