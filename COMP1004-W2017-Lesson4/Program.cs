using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson4
{
    public static class Program
    {
        // declared public static form - Application GLOBAL
        public static SplashForm MySplashForm;

        //// declare public static form - Calculator Form 
        //public static CalculatorForm MyCalculatorForm; 1st

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize SplashForm and CalculatorForm
            Program.MySplashForm = new SplashForm();

            //Program.MyCalculatorForm = new CalculatorForm(); 1st

            Application.Run(Program.MySplashForm);
        }
    }
}
