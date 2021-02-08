namespace Sinama_Final
{
    partial class Yeni_Projem
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
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_gecen = new System.Windows.Forms.Label();
            this.lbl_tahmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.btn_yeniMusteri = new System.Windows.Forms.Button();
            this.cmb_musteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_projeisim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Image = global::Sinama_Final.Properties.Resources._checked;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(186, 292);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(426, 72);
            this.btn_kaydet.TabIndex = 21;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click_1);
            // 
            // lbl_gecen
            // 
            this.lbl_gecen.AutoSize = true;
            this.lbl_gecen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gecen.Location = new System.Drawing.Point(514, 27);
            this.lbl_gecen.Name = "lbl_gecen";
            this.lbl_gecen.Size = new System.Drawing.Size(18, 20);
            this.lbl_gecen.TabIndex = 19;
            this.lbl_gecen.Text = "0";
            // 
            // lbl_tahmin
            // 
            this.lbl_tahmin.AutoSize = true;
            this.lbl_tahmin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tahmin.Location = new System.Drawing.Point(279, 27);
            this.lbl_tahmin.Name = "lbl_tahmin";
            this.lbl_tahmin.Size = new System.Drawing.Size(18, 20);
            this.lbl_tahmin.TabIndex = 20;
            this.lbl_tahmin.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HelveticaNeueLT Pro 27 UltLtCn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(414, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Geçen Süre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Pro 27 UltLtCn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(178, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Süre Tahmini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Açıklama :";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(186, 163);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(426, 114);
            this.txt_Aciklama.TabIndex = 15;
            // 
            // btn_yeniMusteri
            // 
            this.btn_yeniMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeniMusteri.Image = global::Sinama_Final.Properties.Resources.cvv;
            this.btn_yeniMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yeniMusteri.Location = new System.Drawing.Point(392, 101);
            this.btn_yeniMusteri.Name = "btn_yeniMusteri";
            this.btn_yeniMusteri.Size = new System.Drawing.Size(220, 36);
            this.btn_yeniMusteri.TabIndex = 14;
            this.btn_yeniMusteri.Text = "Yeni Müşteri Kartı";
            this.btn_yeniMusteri.UseVisualStyleBackColor = true;
            this.btn_yeniMusteri.Click += new System.EventHandler(this.btn_yeniMusteri_Click_1);
            // 
            // cmb_musteri
            // 
            this.cmb_musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_musteri.FormattingEnabled = true;
            this.cmb_musteri.Location = new System.Drawing.Point(186, 104);
            this.cmb_musteri.Name = "cmb_musteri";
            this.cmb_musteri.Size = new System.Drawing.Size(185, 33);
            this.cmb_musteri.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Müşteri : ";
            // 
            // txt_projeisim
            // 
            this.txt_projeisim.Location = new System.Drawing.Point(186, 59);
            this.txt_projeisim.Multiline = true;
            this.txt_projeisim.Name = "txt_projeisim";
            this.txt_projeisim.Size = new System.Drawing.Size(426, 31);
            this.txt_projeisim.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proje İsmi :";
            // 
            // Yeni_Projem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinama_Final.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(665, 407);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.lbl_gecen);
            this.Controls.Add(this.lbl_tahmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.btn_yeniMusteri);
            this.Controls.Add(this.cmb_musteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_projeisim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Yeni_Projem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni_Projem";
            this.Load += new System.EventHandler(this.Yeni_Projem_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_gecen;
        private System.Windows.Forms.Label lbl_tahmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Button btn_yeniMusteri;
        private System.Windows.Forms.ComboBox cmb_musteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_projeisim;
        private System.Windows.Forms.Label label1;
    }
}