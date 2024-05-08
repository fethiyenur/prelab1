namespace OOP2_Exp6
{
    partial class Formoyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formoyun));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonoyunubitir = new System.Windows.Forms.Button();
            this.class11 = new OOP2_Exp6.Class1();
            this.buttontahminet = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HANGMAN";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(101, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightGray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 392);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LightGray;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(501, 109);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(287, 392);
            this.listBox2.TabIndex = 4;
            // 
            // buttonoyunubitir
            // 
            this.buttonoyunubitir.BackColor = System.Drawing.Color.Gold;
            this.buttonoyunubitir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonoyunubitir.Location = new System.Drawing.Point(319, 442);
            this.buttonoyunubitir.Name = "buttonoyunubitir";
            this.buttonoyunubitir.Size = new System.Drawing.Size(116, 44);
            this.buttonoyunubitir.TabIndex = 6;
            this.buttonoyunubitir.Text = "Oyunu Bitir";
            this.buttonoyunubitir.UseVisualStyleBackColor = false;
            this.buttonoyunubitir.Click += new System.EventHandler(this.buttonoyunubitir_Click);
            // 
            // class11
            // 
            this.class11.CornerRadius = 40;
            this.class11.TargetControl = this.buttontahminet;
            // 
            // buttontahminet
            // 
            this.buttontahminet.BackColor = System.Drawing.Color.YellowGreen;
            this.buttontahminet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontahminet.Location = new System.Drawing.Point(190, 442);
            this.buttontahminet.Name = "buttontahminet";
            this.buttontahminet.Size = new System.Drawing.Size(123, 44);
            this.buttontahminet.TabIndex = 7;
            this.buttontahminet.Text = "Tahmin Et";
            this.buttontahminet.UseVisualStyleBackColor = false;
            this.buttontahminet.Click += new System.EventHandler(this.buttontahminet_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(53, 456);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(131, 20);
            this.txtTahmin.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Formoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(873, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.buttontahminet);
            this.Controls.Add(this.buttonoyunubitir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Formoyun";
            this.Text = "Formoyun";
            this.Load += new System.EventHandler(this.Formoyun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonoyunubitir;
        private Class1 class11;
        private System.Windows.Forms.Button buttontahminet;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}