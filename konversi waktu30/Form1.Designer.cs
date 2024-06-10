namespace konversi_waktu30
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbWaktu1 = new System.Windows.Forms.ComboBox();
            this.cbWaktu = new System.Windows.Forms.ComboBox();
            this.btHasil = new System.Windows.Forms.Button();
            this.txhasil = new System.Windows.Forms.TextBox();
            this.cbWaktu2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txWaktu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KONVERSI WAKTU";
            // 
            // cbWaktu1
            // 
            this.cbWaktu1.FormattingEnabled = true;
            this.cbWaktu1.Items.AddRange(new object[] {
            " jam",
            "menit",
            "second",
            "mili second"});
            this.cbWaktu1.Location = new System.Drawing.Point(90, 154);
            this.cbWaktu1.Name = "cbWaktu1";
            this.cbWaktu1.Size = new System.Drawing.Size(121, 21);
            this.cbWaktu1.TabIndex = 2;
            // 
            // cbWaktu
            // 
            this.cbWaktu.FormattingEnabled = true;
            this.cbWaktu.Items.AddRange(new object[] {
            "menit ",
            "second",
            "mili second",
            "jam"});
            this.cbWaktu.Location = new System.Drawing.Point(90, 127);
            this.cbWaktu.Name = "cbWaktu";
            this.cbWaktu.Size = new System.Drawing.Size(121, 21);
            this.cbWaktu.TabIndex = 3;
            this.cbWaktu.SelectedIndexChanged += new System.EventHandler(this.cbWaktu_SelectedIndexChanged);
            // 
            // btHasil
            // 
            this.btHasil.Location = new System.Drawing.Point(305, 215);
            this.btHasil.Name = "btHasil";
            this.btHasil.Size = new System.Drawing.Size(105, 23);
            this.btHasil.TabIndex = 4;
            this.btHasil.Text = "Hasil";
            this.btHasil.UseVisualStyleBackColor = true;
            this.btHasil.Click += new System.EventHandler(this.btHasil_Click);
            // 
            // txhasil
            // 
            this.txhasil.Location = new System.Drawing.Point(279, 244);
            this.txhasil.Multiline = true;
            this.txhasil.Name = "txhasil";
            this.txhasil.Size = new System.Drawing.Size(173, 59);
            this.txhasil.TabIndex = 5;
            // 
            // cbWaktu2
            // 
            this.cbWaktu2.FormattingEnabled = true;
            this.cbWaktu2.Items.AddRange(new object[] {
            " second",
            "menit",
            "milli second",
            "jam"});
            this.cbWaktu2.Location = new System.Drawing.Point(90, 181);
            this.cbWaktu2.Name = "cbWaktu2";
            this.cbWaktu2.Size = new System.Drawing.Size(121, 21);
            this.cbWaktu2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ke";
            // 
            // txWaktu
            // 
            this.txWaktu.Location = new System.Drawing.Point(163, 79);
            this.txWaktu.Name = "txWaktu";
            this.txWaktu.Size = new System.Drawing.Size(114, 20);
            this.txWaktu.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 315);
            this.Controls.Add(this.txWaktu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbWaktu2);
            this.Controls.Add(this.txhasil);
            this.Controls.Add(this.btHasil);
            this.Controls.Add(this.cbWaktu);
            this.Controls.Add(this.cbWaktu1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWaktu1;
        private System.Windows.Forms.ComboBox cbWaktu;
        private System.Windows.Forms.Button btHasil;
        private System.Windows.Forms.TextBox txhasil;
        private System.Windows.Forms.ComboBox cbWaktu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txWaktu;
    }
}

