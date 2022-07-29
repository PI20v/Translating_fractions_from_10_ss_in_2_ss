using System;
using System.Linq;
using System.Windows.Forms;

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

            if(domain[0] == "-0")
                result += "-";

            bool check = false;
            int left;            
            while (check == false)
            {  
                try
                {
                    left = Convert.ToInt32(domain[0]);

                    if (left < 0)
                    {
                        result += "-";
                        left *= -1;
                    }
                    result += Convert.ToString(left, 2);
                    check = true;
                }
                catch
                {
                   MessageBox.Show("Некорректный ввод!");
                   break;
                }
            }

            if (domain.Length == 1) return result;
            else if (domain.Length > 2)
            {
                MessageBox.Show("Некорректный ввод!");
                result = "0";
            }
            result += '.';

            int right = 0;
            check = false;
            while (check == false)
            {
                try
                {                   
                    right = Convert.ToInt32(domain[1]);
                    check = true;
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    break;
                }
            }
            for (int i = 0; i < digit; i++)
            {
                right *= 2;
                if (right.ToString().Count() > domain[1].Count())
                {
                    string buf = right.ToString();
                    buf = buf.Remove(0, 1);
                    right = Convert.ToInt32(buf);
                    result += '1';
                }
                else
                    result += '0';
            }
            return result;
        }
    }
}
