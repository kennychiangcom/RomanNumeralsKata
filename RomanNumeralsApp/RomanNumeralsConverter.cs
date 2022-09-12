using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsApp
{
    public class RomanNumeralsConverter
    {
        public static void Main()
        {
        }

        public string NConvert(int num)
        {
            if (num < 1 || num > 3999) return "";
            string snum = num.ToString();
            Console.WriteLine($"{snum}  {snum.Length}\r\n{num}\r\n");
            string[,] rnValue = new string[,]
            {
                {"","M","MM","MMM","","","","","","" },
                {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM" },
                {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC" },
                {"","I","II","III","IV","V","VI","VII","VIII","IX" }
            };
            Console.WriteLine($"{rnValue[3,3]}  {rnValue[2, 8]}  {rnValue[1, 8]}  {rnValue[0, 8]}\r\n");

            string rnum = "";
            for (int x = snum.Length - 1; x >= 0; x--)
            {
                Console.WriteLine($"{x}  {int.Parse(snum.Substring(x, 1))}\r\n");
                rnum = rnValue[x, int.Parse(snum.Substring(x, 1))] + rnum;
            }
            Console.WriteLine(rnum);
            return rnum;
        }

        public int RConvert(string num)
        {
            num = num.ToUpper().Trim();
            if (num.Contains("IIII")) return -1;
            else if (num.Contains("VV")) return -1;
            else if (num.Contains("XXXX")) return -1;
            else if (num.Contains("LL")) return -1;
            else if (num.Contains("CCCC")) return -1;
            else if (num.Contains("DD")) return -1;
            else if (num.Contains("MMMM")) return -1;
            else if (num.Contains("VX")) return -1;
            else if (num.Contains("LC")) return -1;
            else if (num.Contains("DM")) return -1;

            int[] numValue = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                switch (num.Substring(i, 1))
                {
                    case "M":
                        numValue[i] = 1000;
                        break;
                    case "D":
                        numValue[i] = 500;
                        break;
                    case "C":
                        numValue[i] = 100;
                        break;
                    case "L":
                        numValue[i] = 50;
                        break;
                    case "X":
                        numValue[i] = 10;
                        break;
                    case "V":
                        numValue[i] = 5;
                        break;
                    case "I":
                        numValue[i] = 1;
                        break;
                    default:
                        return -1;
                }
            }
            for (int i = 0; i < numValue.Length - 1; i++)
            {
                if (numValue[i] < numValue[i + 1]) numValue[i] = -numValue[i];
            }
            return numValue.Sum();
        }
    }
}
