namespace RomanNumeralsApp
{
    public class RomanNumeralsConverter
    {
        public static void Main()
        {
        }

        public string NConvert(int num)
        {
            const int ROMAN_NUMERAL_MIN = 1;
            const int ROMAN_NUMERAL_MAX = 3999;
            if (num < ROMAN_NUMERAL_MIN || num > ROMAN_NUMERAL_MAX) return "";
            string snum = num.ToString();
            string[,] rnValue = new string[,]
            {
                {"","I","II","III","IV","V","VI","VII","VIII","IX" },
                {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC" },
                {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM" },
                {"","M","MM","MMM","","","","","","" }
            };

            const int ZERO_BASE_ADJ = -1;
            int seqChar = snum.Length + ZERO_BASE_ADJ;
            string rnum = "";
            for (int x = seqChar; x >= 0; x--)
            {
                rnum += rnValue[x, int.Parse(snum.Substring(seqChar - x, 1))];
            }
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
            const int ZERO_BASE_ADJ = -1;
            for (int i = 0; i < numValue.Length + ZERO_BASE_ADJ; i++)
            {
                if (numValue[i] < numValue[i + 1]) numValue[i] = -numValue[i];
            }
            return numValue.Sum();
        }
    }
}
