namespace Hesap_Makinesi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.islem = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_7 = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.number_0 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.daymode = new System.Windows.Forms.RadioButton();
            this.nightmode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.virgul = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.virgul);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.log);
            this.groupBox1.Controls.Add(this.bolme);
            this.groupBox1.Controls.Add(this.number_9);
            this.groupBox1.Controls.Add(this.number_8);
            this.groupBox1.Controls.Add(this.number_7);
            this.groupBox1.Controls.Add(this.carpma);
            this.groupBox1.Controls.Add(this.number_6);
            this.groupBox1.Controls.Add(this.number_5);
            this.groupBox1.Controls.Add(this.number_4);
            this.groupBox1.Controls.Add(this.cikarma);
            this.groupBox1.Controls.Add(this.number_3);
            this.groupBox1.Controls.Add(this.number_2);
            this.groupBox1.Controls.Add(this.number_1);
            this.groupBox1.Controls.Add(this.toplama);
            this.groupBox1.Controls.Add(this.number_0);
            this.groupBox1.Location = new System.Drawing.Point(27, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.islem);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 66);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // islem
            // 
            this.islem.BackColor = System.Drawing.SystemColors.Info;
            this.islem.Enabled = false;
            this.islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem.Location = new System.Drawing.Point(17, 19);
            this.islem.Multiline = true;
            this.islem.Name = "islem";
            this.islem.ReadOnly = true;
            this.islem.Size = new System.Drawing.Size(205, 31);
            this.islem.TabIndex = 16;
            this.islem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.clear.Location = new System.Drawing.Point(118, 70);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(43, 34);
            this.clear.TabIndex = 15;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.log.Location = new System.Drawing.Point(17, 70);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(97, 34);
            this.log.TabIndex = 14;
            this.log.Text = "LOG";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // bolme
            // 
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.bolme.Location = new System.Drawing.Point(167, 112);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(55, 34);
            this.bolme.TabIndex = 13;
            this.bolme.Text = "÷";
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.Islem);
            // 
            // number_9
            // 
            this.number_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_9.Location = new System.Drawing.Point(120, 112);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(41, 34);
            this.number_9.TabIndex = 12;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = true;
            this.number_9.Click += new System.EventHandler(this.Ekle);
            // 
            // number_8
            // 
            this.number_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_8.Location = new System.Drawing.Point(71, 112);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(43, 34);
            this.number_8.TabIndex = 11;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = true;
            this.number_8.Click += new System.EventHandler(this.Ekle);
            // 
            // number_7
            // 
            this.number_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_7.Location = new System.Drawing.Point(17, 112);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(48, 34);
            this.number_7.TabIndex = 10;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = true;
            this.number_7.Click += new System.EventHandler(this.Ekle);
            // 
            // carpma
            // 
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.carpma.Location = new System.Drawing.Point(167, 152);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(55, 34);
            this.carpma.TabIndex = 9;
            this.carpma.Text = "×";
            this.carpma.UseVisualStyleBackColor = true;
            this.carpma.Click += new System.EventHandler(this.Islem);
            // 
            // number_6
            // 
            this.number_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_6.Location = new System.Drawing.Point(120, 152);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(41, 34);
            this.number_6.TabIndex = 8;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = true;
            this.number_6.Click += new System.EventHandler(this.Ekle);
            // 
            // number_5
            // 
            this.number_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_5.Location = new System.Drawing.Point(71, 152);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(43, 34);
            this.number_5.TabIndex = 7;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.Ekle);
            // 
            // number_4
            // 
            this.number_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_4.Location = new System.Drawing.Point(17, 152);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(48, 34);
            this.number_4.TabIndex = 6;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.Ekle);
            // 
            // cikarma
            // 
            this.cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.cikarma.Location = new System.Drawing.Point(167, 192);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(55, 34);
            this.cikarma.TabIndex = 5;
            this.cikarma.Text = "-";
            this.cikarma.UseVisualStyleBackColor = true;
            this.cikarma.Click += new System.EventHandler(this.Islem);
            // 
            // number_3
            // 
            this.number_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_3.Location = new System.Drawing.Point(120, 192);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(41, 34);
            this.number_3.TabIndex = 4;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.Ekle);
            // 
            // number_2
            // 
            this.number_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_2.Location = new System.Drawing.Point(71, 192);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(43, 34);
            this.number_2.TabIndex = 3;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.Ekle);
            // 
            // number_1
            // 
            this.number_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.number_1.Location = new System.Drawing.Point(17, 192);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(48, 34);
            this.number_1.TabIndex = 2;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.Ekle);
            // 
            // toplama
            // 
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.toplama.Location = new System.Drawing.Point(167, 70);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(55, 34);
            this.toplama.TabIndex = 1;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.Islem);
            // 
            // number_0
            // 
            this.number_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_0.Location = new System.Drawing.Point(17, 232);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(144, 34);
            this.number_0.TabIndex = 0;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = true;
            this.number_0.Click += new System.EventHandler(this.Ekle);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hesapla);
            this.groupBox2.Location = new System.Drawing.Point(27, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // hesapla
            // 
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(17, 12);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(205, 41);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(309, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 409);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log Sistemi";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(7, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 352);
            this.listBox1.TabIndex = 0;
            // 
            // daymode
            // 
            this.daymode.AutoSize = true;
            this.daymode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.daymode.Location = new System.Drawing.Point(26, 42);
            this.daymode.Name = "daymode";
            this.daymode.Size = new System.Drawing.Size(128, 24);
            this.daymode.TabIndex = 2;
            this.daymode.TabStop = true;
            this.daymode.Text = "Gündüz Modu";
            this.daymode.UseVisualStyleBackColor = true;
            this.daymode.CheckedChanged += new System.EventHandler(this.daymode_CheckedChanged);
            // 
            // nightmode
            // 
            this.nightmode.AutoSize = true;
            this.nightmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nightmode.Location = new System.Drawing.Point(161, 42);
            this.nightmode.Name = "nightmode";
            this.nightmode.Size = new System.Drawing.Size(110, 24);
            this.nightmode.TabIndex = 3;
            this.nightmode.TabStop = true;
            this.nightmode.Text = "Gece Modu";
            this.nightmode.UseVisualStyleBackColor = true;
            this.nightmode.CheckedChanged += new System.EventHandler(this.nightmode_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap Makinesi";
            // 
            // virgul
            // 
            this.virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.virgul.Location = new System.Drawing.Point(167, 231);
            this.virgul.Name = "virgul";
            this.virgul.Size = new System.Drawing.Size(55, 34);
            this.virgul.TabIndex = 17;
            this.virgul.Text = ",";
            this.virgul.UseVisualStyleBackColor = true;
            this.virgul.Click += new System.EventHandler(this.Ekle);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nightmode);
            this.Controls.Add(this.daymode);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Ekle);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton daymode;
        private System.Windows.Forms.RadioButton nightmode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button number_9;
        private System.Windows.Forms.Button number_8;
        private System.Windows.Forms.Button number_7;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button number_6;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button cikarma;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.TextBox islem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button virgul;
    }
}

