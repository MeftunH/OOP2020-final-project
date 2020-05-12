namespace NDPProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PICBOX = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Puan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_Sure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBOX_Organik = new System.Windows.Forms.ListBox();
            this.PBAR_Organik = new System.Windows.Forms.ProgressBar();
            this.LBOX_Kagit = new System.Windows.Forms.ListBox();
            this.PBAR_Kagit = new System.Windows.Forms.ProgressBar();
            this.LBOX_Cam = new System.Windows.Forms.ListBox();
            this.PBAR_Cam = new System.Windows.Forms.ProgressBar();
            this.LBOX_Metal = new System.Windows.Forms.ListBox();
            this.PBAR_Metal = new System.Windows.Forms.ProgressBar();
            this.BTN_YeniOyun = new System.Windows.Forms.Button();
            this.BTN_Cikis = new System.Windows.Forms.Button();
            this.BTN_KagitAt = new System.Windows.Forms.Button();
            this.BTN_OrganikAtikAt = new System.Windows.Forms.Button();
            this.BTN_MetalAt = new System.Windows.Forms.Button();
            this.BTN_CamAt = new System.Windows.Forms.Button();
            this.BTN_OrganikAtikBosalt = new System.Windows.Forms.Button();
            this.BTN_CamBosalt = new System.Windows.Forms.Button();
            this.BTN_MetalBosalt = new System.Windows.Forms.Button();
            this.BTN_KagitKutusuBosalt = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // PICBOX
            // 
            this.PICBOX.BackColor = System.Drawing.SystemColors.Control;
            this.PICBOX.Location = new System.Drawing.Point(16, 15);
            this.PICBOX.Margin = new System.Windows.Forms.Padding(4);
            this.PICBOX.Name = "PICBOX";
            this.PICBOX.Size = new System.Drawing.Size(271, 252);
            this.PICBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX.TabIndex = 0;
            this.PICBOX.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(311, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Puan
            // 
            this.LBL_Puan.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LBL_Puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Puan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Puan.Location = new System.Drawing.Point(32, 543);
            this.LBL_Puan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Puan.Name = "LBL_Puan";
            this.LBL_Puan.Size = new System.Drawing.Size(241, 75);
            this.LBL_Puan.TabIndex = 22;
            this.LBL_Puan.Text = "0";
            this.LBL_Puan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(32, 504);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "PUAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Sure
            // 
            this.LBL_Sure.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.LBL_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBL_Sure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LBL_Sure.Location = new System.Drawing.Point(32, 404);
            this.LBL_Sure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Sure.Name = "LBL_Sure";
            this.LBL_Sure.Size = new System.Drawing.Size(241, 75);
            this.LBL_Sure.TabIndex = 20;
            this.LBL_Sure.Text = "60";
            this.LBL_Sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(32, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "SÜRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBOX_Organik
            // 
            this.LBOX_Organik.FormattingEnabled = true;
            this.LBOX_Organik.ItemHeight = 16;
            this.LBOX_Organik.Location = new System.Drawing.Point(466, 112);
            this.LBOX_Organik.Margin = new System.Windows.Forms.Padding(4);
            this.LBOX_Organik.Name = "LBOX_Organik";
            this.LBOX_Organik.Size = new System.Drawing.Size(156, 196);
            this.LBOX_Organik.TabIndex = 2;
            // 
            // PBAR_Organik
            // 
            this.PBAR_Organik.Location = new System.Drawing.Point(466, 316);
            this.PBAR_Organik.Margin = new System.Windows.Forms.Padding(4);
            this.PBAR_Organik.Name = "PBAR_Organik";
            this.PBAR_Organik.Size = new System.Drawing.Size(156, 32);
            this.PBAR_Organik.TabIndex = 4;
            // 
            // LBOX_Kagit
            // 
            this.LBOX_Kagit.FormattingEnabled = true;
            this.LBOX_Kagit.ItemHeight = 16;
            this.LBOX_Kagit.Location = new System.Drawing.Point(311, 112);
            this.LBOX_Kagit.Margin = new System.Windows.Forms.Padding(4);
            this.LBOX_Kagit.Name = "LBOX_Kagit";
            this.LBOX_Kagit.Size = new System.Drawing.Size(147, 196);
            this.LBOX_Kagit.TabIndex = 8;
            // 
            // PBAR_Kagit
            // 
            this.PBAR_Kagit.Location = new System.Drawing.Point(311, 316);
            this.PBAR_Kagit.Margin = new System.Windows.Forms.Padding(4);
            this.PBAR_Kagit.Name = "PBAR_Kagit";
            this.PBAR_Kagit.Size = new System.Drawing.Size(147, 32);
            this.PBAR_Kagit.TabIndex = 9;
            // 
            // LBOX_Cam
            // 
            this.LBOX_Cam.FormattingEnabled = true;
            this.LBOX_Cam.ItemHeight = 16;
            this.LBOX_Cam.Location = new System.Drawing.Point(466, 454);
            this.LBOX_Cam.Margin = new System.Windows.Forms.Padding(4);
            this.LBOX_Cam.Name = "LBOX_Cam";
            this.LBOX_Cam.Size = new System.Drawing.Size(156, 180);
            this.LBOX_Cam.TabIndex = 12;
            // 
            // PBAR_Cam
            // 
            this.PBAR_Cam.Location = new System.Drawing.Point(466, 642);
            this.PBAR_Cam.Margin = new System.Windows.Forms.Padding(4);
            this.PBAR_Cam.Name = "PBAR_Cam";
            this.PBAR_Cam.Size = new System.Drawing.Size(156, 32);
            this.PBAR_Cam.TabIndex = 13;
            // 
            // LBOX_Metal
            // 
            this.LBOX_Metal.FormattingEnabled = true;
            this.LBOX_Metal.ItemHeight = 16;
            this.LBOX_Metal.Location = new System.Drawing.Point(311, 454);
            this.LBOX_Metal.Margin = new System.Windows.Forms.Padding(4);
            this.LBOX_Metal.Name = "LBOX_Metal";
            this.LBOX_Metal.Size = new System.Drawing.Size(147, 180);
            this.LBOX_Metal.TabIndex = 16;
            // 
            // PBAR_Metal
            // 
            this.PBAR_Metal.Location = new System.Drawing.Point(311, 641);
            this.PBAR_Metal.Margin = new System.Windows.Forms.Padding(4);
            this.PBAR_Metal.Name = "PBAR_Metal";
            this.PBAR_Metal.Size = new System.Drawing.Size(147, 32);
            this.PBAR_Metal.TabIndex = 17;
            // 
            // BTN_YeniOyun
            // 
            this.BTN_YeniOyun.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_YeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_YeniOyun.Location = new System.Drawing.Point(16, 280);
            this.BTN_YeniOyun.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_YeniOyun.Name = "BTN_YeniOyun";
            this.BTN_YeniOyun.Size = new System.Drawing.Size(271, 68);
            this.BTN_YeniOyun.TabIndex = 24;
            this.BTN_YeniOyun.Text = "YENİ OYUN";
            this.BTN_YeniOyun.UseVisualStyleBackColor = false;
            this.BTN_YeniOyun.Click += new System.EventHandler(this.BTN_YeniOyun_Click);
            // 
            // BTN_Cikis
            // 
            this.BTN_Cikis.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Cikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Cikis.Location = new System.Drawing.Point(16, 641);
            this.BTN_Cikis.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Cikis.Name = "BTN_Cikis";
            this.BTN_Cikis.Size = new System.Drawing.Size(271, 68);
            this.BTN_Cikis.TabIndex = 25;
            this.BTN_Cikis.Text = "ÇIKIŞ";
            this.BTN_Cikis.UseVisualStyleBackColor = false;
            this.BTN_Cikis.Click += new System.EventHandler(this.BTN_Cikis_Click);
            // 
            // BTN_KagitAt
            // 
            this.BTN_KagitAt.Enabled = false;
            this.BTN_KagitAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_KagitAt.Location = new System.Drawing.Point(311, 58);
            this.BTN_KagitAt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_KagitAt.Name = "BTN_KagitAt";
            this.BTN_KagitAt.Size = new System.Drawing.Size(147, 46);
            this.BTN_KagitAt.TabIndex = 26;
            this.BTN_KagitAt.Text = "KAĞIT";
            this.BTN_KagitAt.UseVisualStyleBackColor = true;
            this.BTN_KagitAt.Click += new System.EventHandler(this.BTN_KagitAt_Click);
            // 
            // BTN_OrganikAtikAt
            // 
            this.BTN_OrganikAtikAt.Enabled = false;
            this.BTN_OrganikAtikAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_OrganikAtikAt.Location = new System.Drawing.Point(466, 58);
            this.BTN_OrganikAtikAt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_OrganikAtikAt.Name = "BTN_OrganikAtikAt";
            this.BTN_OrganikAtikAt.Size = new System.Drawing.Size(156, 46);
            this.BTN_OrganikAtikAt.TabIndex = 27;
            this.BTN_OrganikAtikAt.Text = "ORGANİK ATIK";
            this.BTN_OrganikAtikAt.UseVisualStyleBackColor = true;
            this.BTN_OrganikAtikAt.Click += new System.EventHandler(this.BTN_OrganikAtikAt_Click);
            // 
            // BTN_MetalAt
            // 
            this.BTN_MetalAt.Enabled = false;
            this.BTN_MetalAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_MetalAt.Location = new System.Drawing.Point(311, 400);
            this.BTN_MetalAt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_MetalAt.Name = "BTN_MetalAt";
            this.BTN_MetalAt.Size = new System.Drawing.Size(147, 46);
            this.BTN_MetalAt.TabIndex = 28;
            this.BTN_MetalAt.Text = "METAL";
            this.BTN_MetalAt.UseVisualStyleBackColor = true;
            this.BTN_MetalAt.Click += new System.EventHandler(this.BTN_MetalAt_Click);
            // 
            // BTN_CamAt
            // 
            this.BTN_CamAt.Enabled = false;
            this.BTN_CamAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_CamAt.Location = new System.Drawing.Point(466, 400);
            this.BTN_CamAt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CamAt.Name = "BTN_CamAt";
            this.BTN_CamAt.Size = new System.Drawing.Size(156, 46);
            this.BTN_CamAt.TabIndex = 29;
            this.BTN_CamAt.Text = "CAM";
            this.BTN_CamAt.UseVisualStyleBackColor = true;
            this.BTN_CamAt.Click += new System.EventHandler(this.BTN_CamAt_Click);
            // 
            // BTN_OrganikAtikBosalt
            // 
            this.BTN_OrganikAtikBosalt.Enabled = false;
            this.BTN_OrganikAtikBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_OrganikAtikBosalt.Location = new System.Drawing.Point(466, 356);
            this.BTN_OrganikAtikBosalt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_OrganikAtikBosalt.Name = "BTN_OrganikAtikBosalt";
            this.BTN_OrganikAtikBosalt.Size = new System.Drawing.Size(156, 36);
            this.BTN_OrganikAtikBosalt.TabIndex = 31;
            this.BTN_OrganikAtikBosalt.Text = "BOŞALT";
            this.BTN_OrganikAtikBosalt.UseVisualStyleBackColor = true;
            this.BTN_OrganikAtikBosalt.Click += new System.EventHandler(this.BTN_OrganikAtikBosalt_Click);
            // 
            // BTN_CamBosalt
            // 
            this.BTN_CamBosalt.Enabled = false;
            this.BTN_CamBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_CamBosalt.Location = new System.Drawing.Point(466, 682);
            this.BTN_CamBosalt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_CamBosalt.Name = "BTN_CamBosalt";
            this.BTN_CamBosalt.Size = new System.Drawing.Size(156, 36);
            this.BTN_CamBosalt.TabIndex = 33;
            this.BTN_CamBosalt.Text = "BOŞALT";
            this.BTN_CamBosalt.UseVisualStyleBackColor = true;
            this.BTN_CamBosalt.Click += new System.EventHandler(this.BTN_CamBosalt_Click);
            // 
            // BTN_MetalBosalt
            // 
            this.BTN_MetalBosalt.Enabled = false;
            this.BTN_MetalBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_MetalBosalt.Location = new System.Drawing.Point(311, 681);
            this.BTN_MetalBosalt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_MetalBosalt.Name = "BTN_MetalBosalt";
            this.BTN_MetalBosalt.Size = new System.Drawing.Size(147, 36);
            this.BTN_MetalBosalt.TabIndex = 34;
            this.BTN_MetalBosalt.Text = "BOŞALT";
            this.BTN_MetalBosalt.UseVisualStyleBackColor = true;
            this.BTN_MetalBosalt.Click += new System.EventHandler(this.BTN_MetalBosalt_Click);
            // 
            // BTN_KagitKutusuBosalt
            // 
            this.BTN_KagitKutusuBosalt.Enabled = false;
            this.BTN_KagitKutusuBosalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_KagitKutusuBosalt.Location = new System.Drawing.Point(311, 356);
            this.BTN_KagitKutusuBosalt.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_KagitKutusuBosalt.Name = "BTN_KagitKutusuBosalt";
            this.BTN_KagitKutusuBosalt.Size = new System.Drawing.Size(147, 36);
            this.BTN_KagitKutusuBosalt.TabIndex = 35;
            this.BTN_KagitKutusuBosalt.Text = "BOŞALT";
            this.BTN_KagitKutusuBosalt.UseVisualStyleBackColor = true;
            this.BTN_KagitKutusuBosalt.Click += new System.EventHandler(this.BTN_KagitKutusuBosalt_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 733);
            this.Controls.Add(this.BTN_KagitKutusuBosalt);
            this.Controls.Add(this.BTN_MetalBosalt);
            this.Controls.Add(this.BTN_CamBosalt);
            this.Controls.Add(this.BTN_OrganikAtikBosalt);
            this.Controls.Add(this.BTN_CamAt);
            this.Controls.Add(this.BTN_MetalAt);
            this.Controls.Add(this.BTN_OrganikAtikAt);
            this.Controls.Add(this.BTN_KagitAt);
            this.Controls.Add(this.BTN_Cikis);
            this.Controls.Add(this.BTN_YeniOyun);
            this.Controls.Add(this.LBL_Puan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_Sure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PBAR_Cam);
            this.Controls.Add(this.LBOX_Cam);
            this.Controls.Add(this.PBAR_Metal);
            this.Controls.Add(this.LBOX_Metal);
            this.Controls.Add(this.PBAR_Organik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBOX_Organik);
            this.Controls.Add(this.PICBOX);
            this.Controls.Add(this.LBOX_Kagit);
            this.Controls.Add(this.PBAR_Kagit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.AtikToplama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PICBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Puan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_Sure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBOX_Organik;
        private System.Windows.Forms.ProgressBar PBAR_Organik;
        private System.Windows.Forms.ListBox LBOX_Kagit;
        private System.Windows.Forms.ProgressBar PBAR_Kagit;
        private System.Windows.Forms.ListBox LBOX_Cam;
        private System.Windows.Forms.ProgressBar PBAR_Cam;
        private System.Windows.Forms.ListBox LBOX_Metal;
        private System.Windows.Forms.ProgressBar PBAR_Metal;
        private System.Windows.Forms.Button BTN_YeniOyun;
        private System.Windows.Forms.Button BTN_Cikis;
        private System.Windows.Forms.Button BTN_KagitAt;
        private System.Windows.Forms.Button BTN_OrganikAtikAt;
        private System.Windows.Forms.Button BTN_MetalAt;
        private System.Windows.Forms.Button BTN_CamAt;
        private System.Windows.Forms.Button BTN_OrganikAtikBosalt;
        private System.Windows.Forms.Button BTN_CamBosalt;
        private System.Windows.Forms.Button BTN_MetalBosalt;
        private System.Windows.Forms.Button BTN_KagitKutusuBosalt;
        private System.Windows.Forms.Timer Timer;
    }
}

