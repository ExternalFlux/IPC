namespace IPCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ip_submit = new System.Windows.Forms.Button();
            this.txt_ip_input = new System.Windows.Forms.TextBox();
            this.lbl_ip_adddres_result = new System.Windows.Forms.Label();
            this.txt_subnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_network = new System.Windows.Forms.Label();
            this.label_bitmask = new System.Windows.Forms.Label();
            this.label_netmask = new System.Windows.Forms.Label();
            this.label_wildcardmask = new System.Windows.Forms.Label();
            this.label_hostrange = new System.Windows.Forms.Label();
            this.label_broadcast = new System.Windows.Forms.Label();
            this.label_totalAdresses = new System.Windows.Forms.Label();
            this.label_short = new System.Windows.Forms.Label();
            this.label_hexdecID1 = new System.Windows.Forms.Label();
            this.label_integerID = new System.Windows.Forms.Label();
            this.label_hexdecID2 = new System.Windows.Forms.Label();
            this.label_arpaFormat = new System.Windows.Forms.Label();
            this.label_binaryID = new System.Windows.Forms.Label();
            this.label_mappedIPv4 = new System.Windows.Forms.Label();
            this.label_6to4prefix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ip_submit
            // 
            this.btn_ip_submit.Location = new System.Drawing.Point(256, 9);
            this.btn_ip_submit.Name = "btn_ip_submit";
            this.btn_ip_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_ip_submit.TabIndex = 0;
            this.btn_ip_submit.Text = "Submit";
            this.btn_ip_submit.UseVisualStyleBackColor = true;
            this.btn_ip_submit.Click += new System.EventHandler(this.btn_ip_submit_Click);
            // 
            // txt_ip_input
            // 
            this.txt_ip_input.Location = new System.Drawing.Point(44, 12);
            this.txt_ip_input.Name = "txt_ip_input";
            this.txt_ip_input.Size = new System.Drawing.Size(137, 20);
            this.txt_ip_input.TabIndex = 1;
            // 
            // lbl_ip_adddres_result
            // 
            this.lbl_ip_adddres_result.AutoSize = true;
            this.lbl_ip_adddres_result.Location = new System.Drawing.Point(404, 198);
            this.lbl_ip_adddres_result.Name = "lbl_ip_adddres_result";
            this.lbl_ip_adddres_result.Size = new System.Drawing.Size(33, 13);
            this.lbl_ip_adddres_result.TabIndex = 2;
            this.lbl_ip_adddres_result.Text = "Label";
            // 
            // txt_subnet
            // 
            this.txt_subnet.Location = new System.Drawing.Point(44, 38);
            this.txt_subnet.Name = "txt_subnet";
            this.txt_subnet.Size = new System.Drawing.Size(137, 20);
            this.txt_subnet.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mask";
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(12, 100);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(31, 13);
            this.label_class.TabIndex = 6;
            this.label_class.Text = "class";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(12, 125);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(27, 13);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "type";
            // 
            // label_network
            // 
            this.label_network.AutoSize = true;
            this.label_network.Location = new System.Drawing.Point(12, 150);
            this.label_network.Name = "label_network";
            this.label_network.Size = new System.Drawing.Size(45, 13);
            this.label_network.TabIndex = 8;
            this.label_network.Text = "network";
            // 
            // label_bitmask
            // 
            this.label_bitmask.AutoSize = true;
            this.label_bitmask.Location = new System.Drawing.Point(12, 176);
            this.label_bitmask.Name = "label_bitmask";
            this.label_bitmask.Size = new System.Drawing.Size(43, 13);
            this.label_bitmask.TabIndex = 9;
            this.label_bitmask.Text = "bitmask";
            // 
            // label_netmask
            // 
            this.label_netmask.AutoSize = true;
            this.label_netmask.Location = new System.Drawing.Point(12, 198);
            this.label_netmask.Name = "label_netmask";
            this.label_netmask.Size = new System.Drawing.Size(47, 13);
            this.label_netmask.TabIndex = 10;
            this.label_netmask.Text = "netmask";
            // 
            // label_wildcardmask
            // 
            this.label_wildcardmask.AutoSize = true;
            this.label_wildcardmask.Location = new System.Drawing.Point(12, 224);
            this.label_wildcardmask.Name = "label_wildcardmask";
            this.label_wildcardmask.Size = new System.Drawing.Size(71, 13);
            this.label_wildcardmask.TabIndex = 11;
            this.label_wildcardmask.Text = "wildcardmask";
            // 
            // label_hostrange
            // 
            this.label_hostrange.AutoSize = true;
            this.label_hostrange.Location = new System.Drawing.Point(12, 254);
            this.label_hostrange.Name = "label_hostrange";
            this.label_hostrange.Size = new System.Drawing.Size(57, 13);
            this.label_hostrange.TabIndex = 12;
            this.label_hostrange.Text = "host range";
            // 
            // label_broadcast
            // 
            this.label_broadcast.AutoSize = true;
            this.label_broadcast.Location = new System.Drawing.Point(12, 283);
            this.label_broadcast.Name = "label_broadcast";
            this.label_broadcast.Size = new System.Drawing.Size(94, 13);
            this.label_broadcast.TabIndex = 13;
            this.label_broadcast.Text = "broadcast address";
            // 
            // label_totalAdresses
            // 
            this.label_totalAdresses.AutoSize = true;
            this.label_totalAdresses.Location = new System.Drawing.Point(12, 314);
            this.label_totalAdresses.Name = "label_totalAdresses";
            this.label_totalAdresses.Size = new System.Drawing.Size(91, 13);
            this.label_totalAdresses.TabIndex = 14;
            this.label_totalAdresses.Text = "total IP addresses";
            // 
            // label_short
            // 
            this.label_short.AutoSize = true;
            this.label_short.Location = new System.Drawing.Point(342, 100);
            this.label_short.Name = "label_short";
            this.label_short.Size = new System.Drawing.Size(30, 13);
            this.label_short.TabIndex = 15;
            this.label_short.Text = "short";
            // 
            // label_hexdecID1
            // 
            this.label_hexdecID1.AutoSize = true;
            this.label_hexdecID1.Location = new System.Drawing.Point(342, 150);
            this.label_hexdecID1.Name = "label_hexdecID1";
            this.label_hexdecID1.Size = new System.Drawing.Size(62, 13);
            this.label_hexdecID1.TabIndex = 16;
            this.label_hexdecID1.Text = "hexdec ID I";
            this.label_hexdecID1.Click += new System.EventHandler(this.label13_Click);
            // 
            // label_integerID
            // 
            this.label_integerID.AutoSize = true;
            this.label_integerID.Location = new System.Drawing.Point(342, 125);
            this.label_integerID.Name = "label_integerID";
            this.label_integerID.Size = new System.Drawing.Size(53, 13);
            this.label_integerID.TabIndex = 17;
            this.label_integerID.Text = "integer ID";
            // 
            // label_hexdecID2
            // 
            this.label_hexdecID2.AutoSize = true;
            this.label_hexdecID2.Location = new System.Drawing.Point(342, 176);
            this.label_hexdecID2.Name = "label_hexdecID2";
            this.label_hexdecID2.Size = new System.Drawing.Size(65, 13);
            this.label_hexdecID2.TabIndex = 18;
            this.label_hexdecID2.Text = "hexdec ID II";
            // 
            // label_arpaFormat
            // 
            this.label_arpaFormat.AutoSize = true;
            this.label_arpaFormat.Location = new System.Drawing.Point(342, 224);
            this.label_arpaFormat.Name = "label_arpaFormat";
            this.label_arpaFormat.Size = new System.Drawing.Size(95, 13);
            this.label_arpaFormat.TabIndex = 19;
            this.label_arpaFormat.Text = "in-addr.arpa format";
            // 
            // label_binaryID
            // 
            this.label_binaryID.AutoSize = true;
            this.label_binaryID.Location = new System.Drawing.Point(342, 198);
            this.label_binaryID.Name = "label_binaryID";
            this.label_binaryID.Size = new System.Drawing.Size(49, 13);
            this.label_binaryID.TabIndex = 20;
            this.label_binaryID.Text = "binary ID";
            // 
            // label_mappedIPv4
            // 
            this.label_mappedIPv4.AutoSize = true;
            this.label_mappedIPv4.Location = new System.Drawing.Point(342, 254);
            this.label_mappedIPv4.Name = "label_mappedIPv4";
            this.label_mappedIPv4.Size = new System.Drawing.Size(110, 13);
            this.label_mappedIPv4.TabIndex = 21;
            this.label_mappedIPv4.Text = "mapped IPv4 address";
            // 
            // label_6to4prefix
            // 
            this.label_6to4prefix.AutoSize = true;
            this.label_6to4prefix.Location = new System.Drawing.Point(342, 283);
            this.label_6to4prefix.Name = "label_6to4prefix";
            this.label_6to4prefix.Size = new System.Drawing.Size(56, 13);
            this.label_6to4prefix.TabIndex = 22;
            this.label_6to4prefix.Text = "6to4 prefix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 422);
            this.Controls.Add(this.label_6to4prefix);
            this.Controls.Add(this.label_mappedIPv4);
            this.Controls.Add(this.label_binaryID);
            this.Controls.Add(this.label_arpaFormat);
            this.Controls.Add(this.label_hexdecID2);
            this.Controls.Add(this.label_integerID);
            this.Controls.Add(this.label_hexdecID1);
            this.Controls.Add(this.label_short);
            this.Controls.Add(this.label_totalAdresses);
            this.Controls.Add(this.label_broadcast);
            this.Controls.Add(this.label_hostrange);
            this.Controls.Add(this.label_wildcardmask);
            this.Controls.Add(this.label_netmask);
            this.Controls.Add(this.label_bitmask);
            this.Controls.Add(this.label_network);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_class);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_subnet);
            this.Controls.Add(this.lbl_ip_adddres_result);
            this.Controls.Add(this.txt_ip_input);
            this.Controls.Add(this.btn_ip_submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ip_submit;
        private System.Windows.Forms.TextBox txt_ip_input;
        private System.Windows.Forms.Label lbl_ip_adddres_result;
        private System.Windows.Forms.TextBox txt_subnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_network;
        private System.Windows.Forms.Label label_bitmask;
        private System.Windows.Forms.Label label_netmask;
        private System.Windows.Forms.Label label_wildcardmask;
        private System.Windows.Forms.Label label_hostrange;
        private System.Windows.Forms.Label label_broadcast;
        private System.Windows.Forms.Label label_totalAdresses;
        private System.Windows.Forms.Label label_short;
        private System.Windows.Forms.Label label_hexdecID1;
        private System.Windows.Forms.Label label_integerID;
        private System.Windows.Forms.Label label_hexdecID2;
        private System.Windows.Forms.Label label_arpaFormat;
        private System.Windows.Forms.Label label_binaryID;
        private System.Windows.Forms.Label label_mappedIPv4;
        private System.Windows.Forms.Label label_6to4prefix;
    }
}

