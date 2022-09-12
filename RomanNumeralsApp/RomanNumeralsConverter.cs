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

        public int RConvert(string num)
        {
            num = num.ToUpper().Trim();
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
