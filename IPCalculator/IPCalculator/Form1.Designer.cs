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
            this.SuspendLayout();
            // 
            // btn_ip_submit
            // 
            this.btn_ip_submit.Location = new System.Drawing.Point(327, 254);
            this.btn_ip_submit.Name = "btn_ip_submit";
            this.btn_ip_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_ip_submit.TabIndex = 0;
            this.btn_ip_submit.Text = "Submit";
            this.btn_ip_submit.UseVisualStyleBackColor = true;
            this.btn_ip_submit.Click += new System.EventHandler(this.btn_ip_submit_Click);
            // 
            // txt_ip_input
            // 
            this.txt_ip_input.Location = new System.Drawing.Point(408, 257);
            this.txt_ip_input.Name = "txt_ip_input";
            this.txt_ip_input.Size = new System.Drawing.Size(100, 20);
            this.txt_ip_input.TabIndex = 1;
            // 
            // lbl_ip_adddres_result
            // 
            this.lbl_ip_adddres_result.AutoSize = true;
            this.lbl_ip_adddres_result.Location = new System.Drawing.Point(514, 260);
            this.lbl_ip_adddres_result.Name = "lbl_ip_adddres_result";
            this.lbl_ip_adddres_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_ip_adddres_result.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 422);
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
    }
}

