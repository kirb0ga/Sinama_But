namespace Sinama_Final
{
    partial class Proje_Kisi_Ekle
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
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.list_gorevli = new System.Windows.Forms.ListBox();
            this.list_Tumkisiler = new System.Windows.Forms.ListBox();
            this.txt_kisiara = new System.Windows.Forms.TextBox();
            this.txt_proje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Image = global::Sinama_Final.Properties.Resources._checked;
            this.btn_Kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kaydet.Location = new System.Drawing.Point(44, 491);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(678, 60);
            this.btn_Kaydet.TabIndex = 12;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click_1);
            // 
            // list_gorevli
            // 
            this.list_gorevli.AllowDrop = true;
            this.list_gorevli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_gorevli.FormattingEnabled = true;
            this.list_gorevli.ItemHeight = 24;
            this.list_gorevli.Location = new System.Drawing.Point(425, 193);
            this.list_gorevli.Name = "list_gorevli";
            this.list_gorevli.Size = new System.Drawing.Size(297, 292);
            this.list_gorevli.TabIndex = 10;
            this.list_gorevli.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_gorevli_DragDrop_1);
            this.list_gorevli.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_gorevli_DragEnter_1);
            this.list_gorevli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_gorevli_MouseDown_1);
            // 
            // list_Tumkisiler
            // 
            this.list_Tumkisiler.AllowDrop = true;
            this.list_Tumkisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_Tumkisiler.FormattingEnabled = true;
            this.list_Tumkisiler.ItemHeight = 24;
            this.list_Tumkisiler.Location = new System.Drawing.Point(44, 193);
            this.list_Tumkisiler.Name = "list_Tumkisiler";
            this.list_Tumkisiler.Size = new System.Drawing.Size(297, 292);
            this.list_Tumkisiler.TabIndex = 11;
            this.list_Tumkisiler.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_Tumkisiler_DragDrop_1);
            this.list_Tumkisiler.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_Tumkisiler_DragEnter_1);
            this.list_Tumkisiler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Tumkisiler_MouseDown_1);
            // 
            // txt_kisiara
            // 
            this.txt_kisiara.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kisiara.Location = new System.Drawing.Point(111, 116);
            this.txt_kisiara.Name = "txt_kisiara";
            this.txt_kisiara.Size = new System.Drawing.Size(230, 35);
            this.txt_kisiara.TabIndex = 8;
            this.txt_kisiara.TextChanged += new System.EventHandler(this.txt_kisiara_TextChanged_1);
            // 
            // txt_proje
            // 
            this.txt_proje.Enabled = false;
            this.txt_proje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_proje.Location = new System.Drawing.Point(225, 31);
            this.txt_proje.Multiline = true;
            this.txt_proje.Name = "txt_proje";
            this.txt_proje.Size = new System.Drawing.Size(497, 36);
            this.txt_proje.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(114, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tüm Kişi Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(527, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Görevli Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seçilen Proje";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sinama_Final.Properties.Resources.checking_attendance;
            this.pictureBox2.Location = new System.Drawing.Point(474, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sinama_Final.Properties.Resources.person;
            this.pictureBox3.Location = new System.Drawing.Point(60, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinama_Final.Properties.Resources.tasks;
            this.pictureBox1.Location = new System.Drawing.Point(76, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Proje_Kisi_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinama_Final.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.ClientSize = new System.Drawing.Size(777, 589);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.list_gorevli);
            this.Controls.Add(this.list_Tumkisiler);
            this.Controls.Add(this.txt_kisiara);
            this.Controls.Add(this.txt_proje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Proje_Kisi_Ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje_Kisi_Ekle";
            this.Load += new System.EventHandler(this.Proje_Kisi_Ekle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ListBox list_gorevli;
        private System.Windows.Forms.ListBox list_Tumkisiler;
        private System.Windows.Forms.TextBox txt_kisiara;
        private System.Windows.Forms.TextBox txt_proje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}