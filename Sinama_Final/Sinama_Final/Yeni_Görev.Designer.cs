namespace Sinama_Final
{
    partial class Yeni_Görev
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.cmb_Gorevli_kisi = new System.Windows.Forms.ComboBox();
            this.txt_gecen = new System.Windows.Forms.TextBox();
            this.txt_tahmin = new System.Windows.Forms.TextBox();
            this.txt_gorevbasligi = new System.Windows.Forms.TextBox();
            this.txt_Projeismi = new System.Windows.Forms.TextBox();
            this.txt_proje_durum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Image = global::Sinama_Final.Properties.Resources._checked;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.Location = new System.Drawing.Point(264, 496);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(971, 72);
            this.btn_kaydet.TabIndex = 22;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(623, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 65;
            this.dataGridView1.Size = new System.Drawing.Size(612, 333);
            this.dataGridView1.TabIndex = 21;
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(264, 251);
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Aciklama.Size = new System.Drawing.Size(328, 239);
            this.txt_Aciklama.TabIndex = 20;
            // 
            // cmb_Gorevli_kisi
            // 
            this.cmb_Gorevli_kisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Gorevli_kisi.FormattingEnabled = true;
            this.cmb_Gorevli_kisi.Location = new System.Drawing.Point(264, 194);
            this.cmb_Gorevli_kisi.Name = "cmb_Gorevli_kisi";
            this.cmb_Gorevli_kisi.Size = new System.Drawing.Size(328, 37);
            this.cmb_Gorevli_kisi.TabIndex = 19;
            this.cmb_Gorevli_kisi.SelectedIndexChanged += new System.EventHandler(this.cmb_Gorevli_kisi_SelectedIndexChanged_1);
            // 
            // txt_gecen
            // 
            this.txt_gecen.Enabled = false;
            this.txt_gecen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gecen.Location = new System.Drawing.Point(954, 77);
            this.txt_gecen.Name = "txt_gecen";
            this.txt_gecen.Size = new System.Drawing.Size(215, 31);
            this.txt_gecen.TabIndex = 17;
            // 
            // txt_tahmin
            // 
            this.txt_tahmin.Enabled = false;
            this.txt_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tahmin.Location = new System.Drawing.Point(674, 77);
            this.txt_tahmin.Name = "txt_tahmin";
            this.txt_tahmin.Size = new System.Drawing.Size(215, 31);
            this.txt_tahmin.TabIndex = 16;
            // 
            // txt_gorevbasligi
            // 
            this.txt_gorevbasligi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_gorevbasligi.Location = new System.Drawing.Point(264, 151);
            this.txt_gorevbasligi.Name = "txt_gorevbasligi";
            this.txt_gorevbasligi.Size = new System.Drawing.Size(328, 31);
            this.txt_gorevbasligi.TabIndex = 15;
            // 
            // txt_Projeismi
            // 
            this.txt_Projeismi.Enabled = false;
            this.txt_Projeismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Projeismi.Location = new System.Drawing.Point(264, 103);
            this.txt_Projeismi.Name = "txt_Projeismi";
            this.txt_Projeismi.Size = new System.Drawing.Size(328, 31);
            this.txt_Projeismi.TabIndex = 18;
            // 
            // txt_proje_durum
            // 
            this.txt_proje_durum.Enabled = false;
            this.txt_proje_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_proje_durum.Location = new System.Drawing.Point(264, 51);
            this.txt_proje_durum.Name = "txt_proje_durum";
            this.txt_proje_durum.Size = new System.Drawing.Size(328, 31);
            this.txt_proje_durum.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(137, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(111, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Görevli Kişi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(91, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Görev Başlığı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(985, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Geçen Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(128, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proje İsmi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(869, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "İş Takibi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(689, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Süre Tahmini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Proje Durumu :";
            // 
            // Yeni_Görev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinama_Final.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.ClientSize = new System.Drawing.Size(1324, 609);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.cmb_Gorevli_kisi);
            this.Controls.Add(this.txt_gecen);
            this.Controls.Add(this.txt_tahmin);
            this.Controls.Add(this.txt_gorevbasligi);
            this.Controls.Add(this.txt_Projeismi);
            this.Controls.Add(this.txt_proje_durum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Yeni_Görev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni_Görev";
            this.Load += new System.EventHandler(this.Yeni_Görev_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.ComboBox cmb_Gorevli_kisi;
        private System.Windows.Forms.TextBox txt_gecen;
        private System.Windows.Forms.TextBox txt_tahmin;
        private System.Windows.Forms.TextBox txt_gorevbasligi;
        private System.Windows.Forms.TextBox txt_Projeismi;
        private System.Windows.Forms.TextBox txt_proje_durum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}