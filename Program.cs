using System;
using System.Windows.Forms;

namespace _10_to_2_ss
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//    class DemoApi
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine(new Translate("10.6735").CovertToBinary());
//            }
//            catch (Exception exp)
//            {
//                MessageBox.Show(exp.Message);
//            }
//            Console.ReadLine();
//        }
//    }
