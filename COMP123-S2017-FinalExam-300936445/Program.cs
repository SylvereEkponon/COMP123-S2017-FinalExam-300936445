using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Sylvere Ekponon
 * Student ID: 300936445
 * Date: August 17, 2017
 * Description: Pick Highest Card
 * version: 0.1 - Created SplashFormTimer Tick event
 */

namespace COMP123_S2017_FinalExam_300936445
{
    public static class Program
    {
        public static PickHighestCardForm PickHighestCardform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PickHighestCardform = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
