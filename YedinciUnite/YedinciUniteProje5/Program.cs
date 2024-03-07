using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YedinciUniteProje5
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("İsim Girin: ");
            ads = Console.ReadLine();
            ks.kisilerlistesi(ads);
            Console.Read();
        }
    }
}
