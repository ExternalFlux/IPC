namespace IPC
{
    partial class IPC
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
            this.label_class = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_network = new System.Windows.Forms.Label();
            this.label_bitmask = new System.Windows.Forms.Label();
            this.label_broadcast = new System.Windows.Forms.Label();
            this.label_totalAdresses = new System.Windows.Forms.Label();
            this.label_binaryID = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_network = new System.Windows.Forms.TextBox();
            this.txt_wildcard = new System.Windows.Forms.TextBox();
            this.txt_broadcast = new System.Windows.Forms.TextBox();
            this.txt_host_range = new System.Windows.Forms.TextBox();
            this.txt_hosts_per_subnet = new System.Windows.Forms.TextBox();
            this.txt_binary_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_mask = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ip_submit
            // 
            this.btn_ip_submit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ip_submit.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ip_submit.Location = new System.Drawing.Point(167, 19);
            this.btn_ip_submit.Name = "btn_ip_submit";
            this.btn_ip_submit.Size = new System.Drawing.Size(96, 47);
            this.btn_ip_submit.TabIndex = 0;
            this.btn_ip_submit.Text = "Submit";
            this.btn_ip_submit.UseVisualStyleBackColor = true;
            this.btn_ip_submit.Click += new System.EventHandler(this.btn_ip_submit_Click);
            // 
            // txt_ip_input
            // 
            this.txt_ip_input.Location = new System.Drawing.Point(12, 19);
            this.txt_ip_input.Name = "txt_ip_input";
            this.txt_ip_input.Size = new System.Drawing.Size(154, 20);
            this.txt_ip_input.TabIndex = 1;
            this.txt_ip_input.Text = "78.90.149.55";
            this.txt_ip_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_class
            // 
            this.label_class.AutoSize = true;
            this.label_class.Location = new System.Drawing.Point(13, 81);
            this.label_class.Name = "label_class";
            this.label_class.Size = new System.Drawing.Size(32, 13);
            this.label_class.TabIndex = 6;
            this.label_class.Text = "Class";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(13, 106);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 7;
            this.label_type.Text = "Type";
            // 
            // label_network
            // 
            this.label_network.AutoSize = true;
            this.label_network.Location = new System.Drawing.Point(13, 132);
            this.label_network.Name = "label_network";
            this.label_network.Size = new System.Drawing.Size(47, 13);
            this.label_network.TabIndex = 8;
            this.label_network.Text = "Network";
            // 
            // label_bitmask
            // 
            this.label_bitmask.AutoSize = true;
            this.label_bitmask.Location = new System.Drawing.Point(13, 158);
            this.label_bitmask.Name = "label_bitmask";
            this.label_bitmask.Size = new System.Drawing.Size(49, 13);
            this.label_bitmask.TabIndex = 9;
            this.label_bitmask.Text = "Wildcard";
            // 
            // label_broadcast
            // 
            this.label_broadcast.AutoSize = true;
            this.label_broadcast.Location = new System.Drawing.Point(13, 184);
            this.label_broadcast.Name = "label_broadcast";
            this.label_broadcast.Size = new System.Drawing.Size(55, 13);
            this.label_broadcast.TabIndex = 13;
            this.label_broadcast.Text = "Broadcast";
            // 
            // label_totalAdresses
            // 
            this.label_totalAdresses.AutoSize = true;
            this.label_totalAdresses.Location = new System.Drawing.Point(13, 210);
            this.label_totalAdresses.Name = "label_totalAdresses";
            this.label_totalAdresses.Size = new System.Drawing.Size(34, 13);
            this.label_totalAdresses.TabIndex = 14;
            this.label_totalAdresses.Text = "Hosts";
            // 
            // label_binaryID
            // 
            this.label_binaryID.AutoSize = true;
            this.label_binaryID.Location = new System.Drawing.Point(13, 241);
            this.label_binaryID.Name = "label_binaryID";
            this.label_binaryID.Size = new System.Drawing.Size(50, 13);
            this.label_binaryID.TabIndex = 20;
            this.label_binaryID.Text = "Binary ID";
            this.label_binaryID.Click += new System.EventHandler(this.label_binaryID_Click);
            // 
            // txt_class
            // 
            this.txt_class.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_class.Location = new System.Drawing.Point(72, 78);
            this.txt_class.Name = "txt_class";
            this.txt_class.ReadOnly = true;
            this.txt_class.Size = new System.Drawing.Size(162, 20);
            this.txt_class.TabIndex = 24;
            this.txt_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_type
            // 
            this.txt_type.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_type.Location = new System.Drawing.Point(72, 103);
            this.txt_type.Name = "txt_type";
            this.txt_type.ReadOnly = true;
            this.txt_type.Size = new System.Drawing.Size(162, 20);
            this.txt_type.TabIndex = 25;
            this.txt_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_network
            // 
            this.txt_network.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_network.Location = new System.Drawing.Point(72, 129);
            this.txt_network.Name = "txt_network";
            this.txt_network.ReadOnly = true;
            this.txt_network.Size = new System.Drawing.Size(162, 20);
            this.txt_network.TabIndex = 26;
            this.txt_network.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_wildcard
            // 
            this.txt_wildcard.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_wildcard.Location = new System.Drawing.Point(72, 155);
            this.txt_wildcard.Name = "txt_wildcard";
            this.txt_wildcard.ReadOnly = true;
            this.txt_wildcard.Size = new System.Drawing.Size(162, 20);
            this.txt_wildcard.TabIndex = 27;
            this.txt_wildcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_broadcast
            // 
            this.txt_broadcast.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_broadcast.Location = new System.Drawing.Point(72, 181);
            this.txt_broadcast.Name = "txt_broadcast";
            this.txt_broadcast.ReadOnly = true;
            this.txt_broadcast.Size = new System.Drawing.Size(162, 20);
            this.txt_broadcast.TabIndex = 30;
            this.txt_broadcast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_host_range
            // 
            this.txt_host_range.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_host_range.Location = new System.Drawing.Point(16, 296);
            this.txt_host_range.Name = "txt_host_range";
            this.txt_host_range.ReadOnly = true;
            this.txt_host_range.Size = new System.Drawing.Size(247, 20);
            this.txt_host_range.TabIndex = 31;
            this.txt_host_range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_hosts_per_subnet
            // 
            this.txt_hosts_per_subnet.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_hosts_per_subnet.Location = new System.Drawing.Point(72, 212);
            this.txt_hosts_per_subnet.Name = "txt_hosts_per_subnet";
            this.txt_hosts_per_subnet.ReadOnly = true;
            this.txt_hosts_per_subnet.Size = new System.Drawing.Size(162, 20);
            this.txt_hosts_per_subnet.TabIndex = 32;
            this.txt_hosts_per_subnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_binary_id
            // 
            this.txt_binary_id.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_binary_id.Location = new System.Drawing.Point(16, 257);
            this.txt_binary_id.Name = "txt_binary_id";
            this.txt_binary_id.ReadOnly = true;
            this.txt_binary_id.Size = new System.Drawing.Size(247, 20);
            this.txt_binary_id.TabIndex = 33;
            this.txt_binary_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_mask);
            this.groupBox1.Controls.Add(this.txt_wildcard);
            this.groupBox1.Controls.Add(this.txt_network);
            this.groupBox1.Controls.Add(this.btn_ip_submit);
            this.groupBox1.Controls.Add(this.label_binaryID);
            this.groupBox1.Controls.Add(this.txt_ip_input);
            this.groupBox1.Controls.Add(this.txt_host_range);
            this.groupBox1.Controls.Add(this.txt_binary_id);
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.Controls.Add(this.txt_class);
            this.groupBox1.Controls.Add(this.label_bitmask);
            this.groupBox1.Controls.Add(this.txt_hosts_per_subnet);
            this.groupBox1.Controls.Add(this.label_network);
            this.groupBox1.Controls.Add(this.label_totalAdresses);
            this.groupBox1.Controls.Add(this.label_type);
            this.groupBox1.Controls.Add(this.txt_broadcast);
            this.groupBox1.Controls.Add(this.label_class);
            this.groupBox1.Controls.Add(this.label_broadcast);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 329);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Info";
            // 
            // combo_mask
            // 
            this.combo_mask.FormattingEnabled = true;
            this.combo_mask.Location = new System.Drawing.Point(12, 45);
            this.combo_mask.Name = "combo_mask";
            this.combo_mask.Size = new System.Drawing.Size(154, 21);
            this.combo_mask.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Host Range";
            // 
            // IPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(292, 351);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "IPC";
            this.Text = "IPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ip_submit;
        private System.Windows.Forms.TextBox txt_ip_input;
        private System.Windows.Forms.Label label_class;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_network;
        private System.Windows.Forms.Label label_bitmask;
        private System.Windows.Forms.Label label_broadcast;
        private System.Windows.Forms.Label label_totalAdresses;
        private System.Windows.Forms.Label label_binaryID;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_network;
        private System.Windows.Forms.TextBox txt_wildcard;
        private System.Windows.Forms.TextBox txt_broadcast;
        private System.Windows.Forms.TextBox txt_host_range;
        private System.Windows.Forms.TextBox txt_hosts_per_subnet;
        private System.Windows.Forms.TextBox txt_binary_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_mask;
        private System.Windows.Forms.Label label1;
    }
}

