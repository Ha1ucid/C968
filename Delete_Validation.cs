using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_performance_assessment
{
    public partial class DeleteValidation : Form
    {
        public DeleteValidation()
        {
            InitializeComponent();
        }

        public static bool yesButtonWasClicked = false;

        public static bool DeleteReturn()
        {   
            if (yesButtonWasClicked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            yesButtonWasClicked = true;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            yesButtonWasClicked = false;
        }
    }
}
