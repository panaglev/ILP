using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ILP
{
	public class RSA
	{
		static char[] characters = new char[] {'#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж','З', 'И', 'Й', 'К', 
												'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х',
												'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'K',
												'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а',
												'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к',
												'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х',
												'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я',
												'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
												'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
												'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c',
												'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
												'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
												'u', 'v', 'w', 'x', 'y', 'z', ' ', '1', '2', '3',
												'4', '5', '6', '7', '8', '9', '0'};
		public static string Encrypt(string s, double e, double n)
		{
            try 
			{
				List<string> result = new List<string>();

				BigInteger bi;

				for (int i = 0; i < s.Length; i++)
				{
					int index = Array.IndexOf(characters, s[i]); //Производит поиск по массиву и возвращает индекс первого найденного совпадения
					if (index == -1) 
					{
						MessageBox.Show("Встретился незнакомый символ " + s[i]);
					}
					else 
					{
						bi = new BigInteger(index);
						bi = BigInteger.Pow(bi, (int)e);

						BigInteger n_cpy = new BigInteger((int)n);

						bi = bi % n_cpy;

						result.Add(bi.ToString());
					}
				}
				string result1 = String.Join(",", result.ToArray());
				return result1;
			}
			catch (Exception) 
			{
				MessageBox.Show("Введите корректные данные");
			}
			return "";
		}

		public static string Decrypt(string message, double d, double n)
		{
			try 
			{
				List<string> input = message.Split(',').ToList();
				string result = " ";
				BigInteger bi;

				foreach (var word in input)
				{
					if (word == "-1") 
					{
						continue;
					}
					else 
					{
						bi = new BigInteger(Convert.ToDouble(word));
						bi = BigInteger.Pow(bi, (int)d);

						BigInteger n_cpy = new BigInteger((int)n);

						bi = bi % n_cpy;

						int index = Convert.ToInt32(bi.ToString());
						result += characters[index].ToString();
					}
				}
				return result;
			}
			catch (Exception) 
			{
				MessageBox.Show("Введите корректные данные");
			}
			return "";
		}
		public static string GetHash(string input) //Хэширование пароля
		{
			var md5 = MD5.Create();
			var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
			return Convert.ToBase64String(hash);
		}
	}
}
