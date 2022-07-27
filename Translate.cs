using System;
using System.Linq;

namespace _10_to_2_ss
{
    public class Translate
    {
        private int digit = 32;
        private string result;
        private string inputString;
        public Translate(string str)
        {
            inputString = str;
        }
        public string CovertToBinary()
        {
            string[] domain = inputString.Split('.', ',');
            result += Convert.ToString(Convert.ToInt32(domain[0]), 2);
            if (domain.Length == 1) throw new Exception("Введено целое число!");
            else if (domain.Length > 2) throw new Exception("Введено неккоректное число!");
            result += '.';
            int right = Convert.ToInt32(domain[1]);
            for (int i = 0; i < digit; i++)
            {
                right = right * 2;
                if (right.ToString().Count() > domain[1].Count())
                {
                    string buf = right.ToString();
                    buf = buf.Remove(0, 1);
                    right = Convert.ToInt32(buf);
                    result += '1';
                }
                else
                {
                    result += '0';
                }
            }
            return result;
        }
    }
}
