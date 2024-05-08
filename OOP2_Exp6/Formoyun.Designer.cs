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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonoyunubitir = new System.Windows.Forms.Button();
            this.buttontahminet = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.pictureBoxAdamAsmaca = new System.Windows.Forms.PictureBox();
            this.lblKelimeUzunlugu = new System.Windows.Forms.Label();
            this.lblyanlıstahminler = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblTahminEdilenKelime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.class11 = new OOP2_Exp6.Class1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdamAsmaca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 64);
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
            this.listBox2.Size = new System.Drawing.Size(360, 392);
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
            this.txtTahmin.Location = new System.Drawing.Point(92, 456);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(92, 20);
            this.txtTahmin.TabIndex = 8;
            // 
            // pictureBoxAdamAsmaca
            // 
            this.pictureBoxAdamAsmaca.BackgroundImage = global::OOP2_Exp6.Properties.Resources.man_01;
            this.pictureBoxAdamAsmaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAdamAsmaca.Location = new System.Drawing.Point(524, 142);
            this.pictureBoxAdamAsmaca.Name = "pictureBoxAdamAsmaca";
            this.pictureBoxAdamAsmaca.Size = new System.Drawing.Size(312, 334);
            this.pictureBoxAdamAsmaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAdamAsmaca.TabIndex = 9;
            this.pictureBoxAdamAsmaca.TabStop = false;
            // 
            // lblKelimeUzunlugu
            // 
            this.lblKelimeUzunlugu.AutoSize = true;
            this.lblKelimeUzunlugu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelimeUzunlugu.Location = new System.Drawing.Point(89, 294);
            this.lblKelimeUzunlugu.Name = "lblKelimeUzunlugu";
            this.lblKelimeUzunlugu.Size = new System.Drawing.Size(106, 15);
            this.lblKelimeUzunlugu.TabIndex = 10;
            this.lblKelimeUzunlugu.Text = "kelimeuzunluğu";
            // 
            // lblyanlıstahminler
            // 
            this.lblyanlıstahminler.AutoSize = true;
            this.lblyanlıstahminler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyanlıstahminler.Location = new System.Drawing.Point(89, 335);
            this.lblyanlıstahminler.Name = "lblyanlıstahminler";
            this.lblyanlıstahminler.Size = new System.Drawing.Size(109, 15);
            this.lblyanlıstahminler.TabIndex = 11;
            this.lblyanlıstahminler.Text = "yanlış tahminler";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuan.Location = new System.Drawing.Point(88, 374);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(55, 22);
            this.lblPuan.TabIndex = 12;
            this.lblPuan.Text = "puan";
            this.lblPuan.Click += new System.EventHandler(this.lblPuan_Click);
            // 
            // lblTahminEdilenKelime
            // 
            this.lblTahminEdilenKelime.AutoSize = true;
            this.lblTahminEdilenKelime.BackColor = System.Drawing.Color.Gray;
            this.lblTahminEdilenKelime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTahminEdilenKelime.Location = new System.Drawing.Point(206, 142);
            this.lblTahminEdilenKelime.Name = "lblTahminEdilenKelime";
            this.lblTahminEdilenKelime.Size = new System.Drawing.Size(93, 32);
            this.lblTahminEdilenKelime.TabIndex = 14;
            this.lblTahminEdilenKelime.Text = "label2";
            this.lblTahminEdilenKelime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTahminEdilenKelime.Click += new System.EventHandler(this.lblTahminEdilenKelime_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "İPUCU?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // class11
            // 
            this.class11.CornerRadius = 40;
            this.class11.TargetControl = this.buttontahminet;
            // 
            // Formoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(914, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTahminEdilenKelime);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblyanlıstahminler);
            this.Controls.Add(this.lblKelimeUzunlugu);
            this.Controls.Add(this.pictureBoxAdamAsmaca);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdamAsmaca)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxAdamAsmaca;
        private System.Windows.Forms.Label lblKelimeUzunlugu;
        private System.Windows.Forms.Label lblyanlıstahminler;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblTahminEdilenKelime;
        private System.Windows.Forms.Button button1;
    }
}