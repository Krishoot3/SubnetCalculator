namespace SubnetCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.ipNum4 = new System.Windows.Forms.NumericUpDown();
            this.ipNum3 = new System.Windows.Forms.NumericUpDown();
            this.ipNum2 = new System.Windows.Forms.NumericUpDown();
            this.ipNum1 = new System.Windows.Forms.NumericUpDown();
            this.cidrComboB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMaska = new System.Windows.Forms.Label();
            this.labelSubnet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelTrieda = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMaBi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelIpBi = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(358, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vypočítaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipNum4
            // 
            this.ipNum4.Location = new System.Drawing.Point(628, 116);
            this.ipNum4.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.ipNum4.Name = "ipNum4";
            this.ipNum4.Size = new System.Drawing.Size(149, 20);
            this.ipNum4.TabIndex = 2;
            this.ipNum4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ipNum3
            // 
            this.ipNum3.Location = new System.Drawing.Point(473, 116);
            this.ipNum3.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.ipNum3.Name = "ipNum3";
            this.ipNum3.Size = new System.Drawing.Size(149, 20);
            this.ipNum3.TabIndex = 3;
            // 
            // ipNum2
            // 
            this.ipNum2.Location = new System.Drawing.Point(318, 116);
            this.ipNum2.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.ipNum2.Name = "ipNum2";
            this.ipNum2.Size = new System.Drawing.Size(149, 20);
            this.ipNum2.TabIndex = 1;
            this.ipNum2.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            // 
            // ipNum1
            // 
            this.ipNum1.Location = new System.Drawing.Point(163, 116);
            this.ipNum1.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.ipNum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ipNum1.Name = "ipNum1";
            this.ipNum1.Size = new System.Drawing.Size(149, 20);
            this.ipNum1.TabIndex = 0;
            this.ipNum1.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            // 
            // cidrComboB
            // 
            this.cidrComboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidrComboB.FormattingEnabled = true;
            this.cidrComboB.Location = new System.Drawing.Point(163, 161);
            this.cidrComboB.Name = "cidrComboB";
            this.cidrComboB.Size = new System.Drawing.Size(149, 21);
            this.cidrComboB.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 81);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subnet Kalkulačka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "IP Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "CIDR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(75, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Maska:";
            // 
            // labelMaska
            // 
            this.labelMaska.AutoSize = true;
            this.labelMaska.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaska.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaska.Location = new System.Drawing.Point(159, 207);
            this.labelMaska.Name = "labelMaska";
            this.labelMaska.Size = new System.Drawing.Size(0, 23);
            this.labelMaska.TabIndex = 15;
            // 
            // labelSubnet
            // 
            this.labelSubnet.AutoSize = true;
            this.labelSubnet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSubnet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSubnet.Location = new System.Drawing.Point(159, 253);
            this.labelSubnet.Name = "labelSubnet";
            this.labelSubnet.Size = new System.Drawing.Size(0, 23);
            this.labelSubnet.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Počet Subnetov:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Počet Hostov:";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHost.Location = new System.Drawing.Point(159, 294);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(0, 23);
            this.labelHost.TabIndex = 19;
            // 
            // labelTrieda
            // 
            this.labelTrieda.AutoSize = true;
            this.labelTrieda.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTrieda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTrieda.Location = new System.Drawing.Point(485, 207);
            this.labelTrieda.Name = "labelTrieda";
            this.labelTrieda.Size = new System.Drawing.Size(0, 23);
            this.labelTrieda.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(385, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "IP Trieda:";
            // 
            // labelMaBi
            // 
            this.labelMaBi.AutoSize = true;
            this.labelMaBi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMaBi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMaBi.Location = new System.Drawing.Point(485, 253);
            this.labelMaBi.Name = "labelMaBi";
            this.labelMaBi.Size = new System.Drawing.Size(0, 23);
            this.labelMaBi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(338, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Maska Binárne:";
            // 
            // labelIpBi
            // 
            this.labelIpBi.AutoSize = true;
            this.labelIpBi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIpBi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIpBi.Location = new System.Drawing.Point(485, 294);
            this.labelIpBi.Name = "labelIpBi";
            this.labelIpBi.Size = new System.Drawing.Size(0, 23);
            this.labelIpBi.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(373, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 23);
            this.label10.TabIndex = 24;
            this.label10.Text = "IP Binárne:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(869, 443);
            this.Controls.Add(this.labelIpBi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelMaBi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTrieda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSubnet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMaska);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ipNum1);
            this.Controls.Add(this.ipNum3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ipNum4);
            this.Controls.Add(this.ipNum2);
            this.Controls.Add(this.cidrComboB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(885, 482);
            this.MinimumSize = new System.Drawing.Size(885, 482);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subnet Kalkulačka";
            ((System.ComponentModel.ISupportInitialize)(this.ipNum4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipNum1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ipNum4;
        private System.Windows.Forms.NumericUpDown ipNum3;
        private System.Windows.Forms.NumericUpDown ipNum2;
        private System.Windows.Forms.NumericUpDown ipNum1;
        private System.Windows.Forms.ComboBox cidrComboB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMaska;
        private System.Windows.Forms.Label labelSubnet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelTrieda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMaBi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelIpBi;
        private System.Windows.Forms.Label label10;
    }
}

