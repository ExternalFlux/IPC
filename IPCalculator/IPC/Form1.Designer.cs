namespace IPC
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

        //WHY WNOT THIS OWK
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ip_submit = new System.Windows.Forms.Button();
            this.txt_ip_input = new System.Windows.Forms.TextBox();
            this.txt_subnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_class = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_network = new System.Windows.Forms.Label();
            this.label_bitmask = new System.Windows.Forms.Label();
            this.label_netmask = new System.Windows.Forms.Label();
            this.label_hostrange = new System.Windows.Forms.Label();
            this.label_broadcast = new System.Windows.Forms.Label();
            this.label_totalAdresses = new System.Windows.Forms.Label();
            this.label_binaryID = new System.Windows.Forms.Label();
            this.label_short = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cbtn_lose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ip_submit
            // 
            this.btn_ip_submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ip_submit.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ip_submit.Location = new System.Drawing.Point(227, 11);
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
            this.txt_ip_input.Size = new System.Drawing.Size(167, 20);
            this.txt_ip_input.TabIndex = 1;
            this.txt_ip_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_subnet
            // 
            this.txt_subnet.Location = new System.Drawing.Point(44, 38);
            this.txt_subnet.Name = "txt_subnet";
            this.txt_subnet.Size = new System.Drawing.Size(167, 20);
            this.txt_subnet.TabIndex = 3;
            this.txt_subnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label_class.Location = new System.Drawing.Point(3, 24);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(32, 13);
            this.label_class.TabIndex = 6;
            this.label_class.Text = "Class";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(3, 49);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "Type";
            // 
            // label_network
            // 
            this.label_network.AutoSize = true;
            this.label_network.Location = new System.Drawing.Point(3, 75);
            this.label_network.Name = "label_network";
            this.label_network.Size = new System.Drawing.Size(47, 13);
            this.label_network.TabIndex = 8;
            this.label_network.Text = "Network";
            // 
            // label_bitmask
            // 
            this.label_bitmask.AutoSize = true;
            this.label_bitmask.Location = new System.Drawing.Point(3, 101);
            this.label_bitmask.Name = "label_bitmask";
            this.label_bitmask.Size = new System.Drawing.Size(44, 13);
            this.label_bitmask.TabIndex = 9;
            this.label_bitmask.Text = "Bitmask";
            // 
            // label_netmask
            // 
            this.label_netmask.AutoSize = true;
            this.label_netmask.Location = new System.Drawing.Point(3, 127);
            this.label_netmask.Name = "label_netmask";
            this.label_netmask.Size = new System.Drawing.Size(49, 13);
            this.label_netmask.TabIndex = 10;
            this.label_netmask.Text = "Netmask";
            // 
            // label_hostrange
            // 
            this.label_hostrange.AutoSize = true;
            this.label_hostrange.Location = new System.Drawing.Point(12, 294);
            this.label_hostrange.Name = "label_hostrange";
            this.label_hostrange.Size = new System.Drawing.Size(59, 13);
            this.label_hostrange.TabIndex = 12;
            this.label_hostrange.Text = "Host range";
            // 
            // label_broadcast
            // 
            this.label_broadcast.AutoSize = true;
            this.label_broadcast.Location = new System.Drawing.Point(283, 141);
            this.label_broadcast.Name = "label_broadcast";
            this.label_broadcast.Size = new System.Drawing.Size(95, 13);
            this.label_broadcast.TabIndex = 13;
            this.label_broadcast.Text = "Broadcast address";
            // 
            // label_totalAdresses
            // 
            this.label_totalAdresses.AutoSize = true;
            this.label_totalAdresses.Location = new System.Drawing.Point(285, 193);
            this.label_totalAdresses.Name = "label_totalAdresses";
            this.label_totalAdresses.Size = new System.Drawing.Size(87, 13);
            this.label_totalAdresses.TabIndex = 14;
            this.label_totalAdresses.Text = "Hosts per subnet";
            // 
            // label_binaryID
            // 
            this.label_binaryID.AutoSize = true;
            this.label_binaryID.Location = new System.Drawing.Point(12, 268);
            this.label_binaryID.Name = "label_binaryID";
            this.label_binaryID.Size = new System.Drawing.Size(50, 13);
            this.label_binaryID.TabIndex = 20;
            this.label_binaryID.Text = "Binary ID";
            this.label_binaryID.Click += new System.EventHandler(this.label_binaryID_Click);
            // 
            // label_short
            // 
            this.label_short.AutoSize = true;
            this.label_short.Location = new System.Drawing.Point(313, 90);
            this.label_short.Name = "label_short";
            this.label_short.Size = new System.Drawing.Size(32, 13);
            this.label_short.TabIndex = 15;
            this.label_short.Text = "Short";
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Location = new System.Drawing.Point(62, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox3.Location = new System.Drawing.Point(62, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(162, 20);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Location = new System.Drawing.Point(62, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(162, 20);
            this.textBox4.TabIndex = 26;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox5.Location = new System.Drawing.Point(62, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(162, 20);
            this.textBox5.TabIndex = 27;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox6.Location = new System.Drawing.Point(62, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(162, 20);
            this.textBox6.TabIndex = 28;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox7.Location = new System.Drawing.Point(257, 106);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(141, 20);
            this.textBox7.TabIndex = 29;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox8.Location = new System.Drawing.Point(257, 157);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(141, 20);
            this.textBox8.TabIndex = 30;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox9.Location = new System.Drawing.Point(71, 291);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(327, 20);
            this.textBox9.TabIndex = 31;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox10.Location = new System.Drawing.Point(257, 209);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(141, 20);
            this.textBox10.TabIndex = 32;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox11.Location = new System.Drawing.Point(71, 265);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(327, 20);
            this.textBox11.TabIndex = 33;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clear
            // 
            this.btn_clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_clear.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(227, 37);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cbtn_lose
            // 
            this.cbtn_lose.FlatAppearance.BorderSize = 2;
            this.cbtn_lose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.cbtn_lose.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn_lose.Location = new System.Drawing.Point(308, 11);
            this.cbtn_lose.Name = "cbtn_lose";
            this.cbtn_lose.Size = new System.Drawing.Size(90, 49);
            this.cbtn_lose.TabIndex = 35;
            this.cbtn_lose.Text = "Close";
            this.cbtn_lose.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label_netmask);
            this.groupBox1.Controls.Add(this.label_bitmask);
            this.groupBox1.Controls.Add(this.label_network);
            this.groupBox1.Controls.Add(this.label_type);
            this.groupBox1.Controls.Add(this.label_class);
            this.groupBox1.Location = new System.Drawing.Point(9, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 153);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btn_clear;
            this.ClientSize = new System.Drawing.Size(410, 333);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbtn_lose);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label_binaryID);
            this.Controls.Add(this.label_short);
            this.Controls.Add(this.label_totalAdresses);
            this.Controls.Add(this.label_broadcast);
            this.Controls.Add(this.label_hostrange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_subnet);
            this.Controls.Add(this.txt_ip_input);
            this.Controls.Add(this.btn_ip_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ip_submit;
        private System.Windows.Forms.TextBox txt_ip_input;
        private System.Windows.Forms.TextBox txt_subnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_network;
        private System.Windows.Forms.Label label_bitmask;
        private System.Windows.Forms.Label label_netmask;
        private System.Windows.Forms.Label label_hostrange;
        private System.Windows.Forms.Label label_broadcast;
        private System.Windows.Forms.Label label_totalAdresses;
        private System.Windows.Forms.Label label_binaryID;
        private System.Windows.Forms.Label label_short;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button cbtn_lose;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

