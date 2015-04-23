namespace IPCalculator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using IPCalculator.Engine;

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_ip_submit_Click(object sender, EventArgs e)
        {        
            string address = txt_ip_input.Text;

            lbl_ip_adddres_result.Text = Engine.Engine.ConvertAddressToBinary(address);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label_binaryID_Click(object sender, EventArgs e)
        {

        }

    }
}
