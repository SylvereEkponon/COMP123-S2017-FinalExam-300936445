using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpashFormTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();

            SpashFormTimer.Enabled = false;
        }
    }
}
