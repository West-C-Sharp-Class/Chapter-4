using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_verification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int ageInput;

            ageInput = Convert.ToInt32(txtEnterAge.Text);

            if (ageInput <= 18)
            {
                lblResult.Text = "You are a miner";
            }
        }
    }
}
