namespace Sinama_Final
{
    partial class Sec
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
            this.btn_kisi = new System.Windows.Forms.Button();
            this.btn_yeniGorev = new System.Windows.Forms.Button();
            this.btn_mevcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kisi
            // 
            this.btn_kisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kisi.Image = global::Sinama_Final.Properties.Resources.checking_attendance;
            this.btn_kisi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kisi.Location = new System.Drawing.Point(211, 37);
            this.btn_kisi.Name = "btn_kisi";
            this.btn_kisi.Size = new System.Drawing.Size(161, 145);
            this.btn_kisi.TabIndex = 1;
            this.btn_kisi.Text = "Proje Kişi Düzenleme";
            this.btn_kisi.UseMnemonic = false;
            this.btn_kisi.UseVisualStyleBackColor = true;
            this.btn_kisi.Click += new System.EventHandler(this.btn_kisi_Click_1);
            // 
            // btn_yeniGorev
            // 
            this.btn_yeniGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeniGorev.Image = global::Sinama_Final.Properties.Resources.note_32;
            this.btn_yeniGorev.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_yeniGorev.Location = new System.Drawing.Point(393, 37);
            this.btn_yeniGorev.Name = "btn_yeniGorev";
            this.btn_yeniGorev.Size = new System.Drawing.Size(198, 145);
            this.btn_yeniGorev.TabIndex = 2;
            this.btn_yeniGorev.Text = "Yeni Görev Ekle";
            this.btn_yeniGorev.UseVisualStyleBackColor = true;
            this.btn_yeniGorev.Click += new System.EventHandler(this.btn_yeniGorev_Click_1);
            // 
            // btn_mevcut
            // 
            this.btn_mevcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mevcut.Image = global::Sinama_Final.Properties.Resources.contract;
            this.btn_mevcut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mevcut.Location = new System.Drawing.Point(16, 37);
            this.btn_mevcut.Name = "btn_mevcut";
            this.btn_mevcut.Size = new System.Drawing.Size(175, 145);
            this.btn_mevcut.TabIndex = 3;
            this.btn_mevcut.Text = "Mevcut Proje";
            this.btn_mevcut.UseVisualStyleBackColor = true;
            this.btn_mevcut.Click += new System.EventHandler(this.btn_mevcut_Click_1);
            // 
            // Sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinama_Final.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.ClientSize = new System.Drawing.Size(617, 223);
            this.Controls.Add(this.btn_kisi);
            this.Controls.Add(this.btn_yeniGorev);
            this.Controls.Add(this.btn_mevcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sec";
            this.Load += new System.EventHandler(this.Sec_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kisi;
        private System.Windows.Forms.Button btn_yeniGorev;
        private System.Windows.Forms.Button btn_mevcut;
    }
}