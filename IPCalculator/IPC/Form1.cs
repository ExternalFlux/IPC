namespace IPC
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
    using System.Net;
    using Engine;
    using Engine;

    public partial class IPC : Form
    {

        public IPC()
        {
            InitializeComponent();

            //Generate masks
            var masks_list = Engine.Engine.GenerateMasks();

            foreach (var item in masks_list)
            {
                combo_mask.Items.Add(item);
            }
            combo_mask.SelectedIndex = 0;


        }

        private void btn_ip_submit_Click(object sender, EventArgs e)
        {
            string ip = txt_ip_input.Text;
            string msk = combo_mask.Text;

            IPAddress address = IPAddress.Parse(ip);
            IPAddress mask;

            bool isMask;



            isMask = IPAddress.TryParse(msk, out mask);
            if (!isMask)
            {
                string tempMask = SubnetMask.ReturnSubnetmask(msk);
                mask = IPAddress.Parse(tempMask);
            }

            var broadcast = IPAddressExtensions.GetBroadcastAddress(address, mask);
            var network = IPAddressExtensions.GetNetworkAddress(address, mask);
            var net_class = SubnetMask.ReturnClass(mask.ToString());
            var binaryID = Engine.Engine.ConvertAddressToBinary(address.ToString());
            var hostRange = Engine.Engine.GetAddressRange(address.ToString(), mask.ToString());
            var type = IPAddressExtensions.isIPLocal(address);
            var wildcard = mask.ToString();
            var binaryMask = Engine.Engine.ConvertAddressToBinary(mask.ToString());
            int hostsPerSubnetCount = Engine.Engine.PowerOf(2, binaryMask.Count(x => x == '0')) - 2;


            txt_broadcast.Text = broadcast.ToString();
            txt_network.Text = network.ToString();
            txt_class.Text = net_class;
            txt_host_range.Text = hostRange[0] + "-" + hostRange[1];
            txt_binary_id.Text = binaryID;
            txt_type.Text = type;


            txt_hosts_per_subnet.Text = hostsPerSubnetCount.ToString();

            // Wildcard generation -- TODO : Make it a method and optimise 
            var wildArray = mask.ToString().Split('.').ToArray();
            byte[] newWild = new byte[wildArray.Length];

            for (int i = 0; i < wildArray.Length; i++)
            {
                newWild[i] = byte.Parse(wildArray[i]);
            }
            Engine.Engine.InvertArray(newWild);
            for (int i = 0; i < wildArray.Length; i++)
            {
                wildArray[i] = newWild[i].ToString();
            }

            txt_wildcard.Text = String.Join(".", wildArray);

            //End of wildcard
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label_binaryID_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
