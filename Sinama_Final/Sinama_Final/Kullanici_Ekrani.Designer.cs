namespace Sinama_Final
{
    partial class Kullanici_Ekrani
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_Done = new System.Windows.Forms.ListBox();
            this.list_Inprog = new System.Windows.Forms.ListBox();
            this.list_toDo = new System.Windows.Forms.ListBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_projem = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.btn_YeniProje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("HelveticaNeueLT Pro 97 BlkCn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(1124, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Done";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Pro 97 BlkCn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(749, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "In Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Pro 97 BlkCn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(408, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "To Do";
            // 
            // list_Done
            // 
            this.list_Done.AllowDrop = true;
            this.list_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.list_Done.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Done.FormattingEnabled = true;
            this.list_Done.ItemHeight = 22;
            this.list_Done.Location = new System.Drawing.Point(1026, 56);
            this.list_Done.Name = "list_Done";
            this.list_Done.Size = new System.Drawing.Size(271, 554);
            this.list_Done.TabIndex = 16;
            this.list_Done.DragDrop += new System.Windows.Forms.DragEventHandler(this.list_Done_DragDrop_1);
            this.list_Done.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_Done_DragEnter_1);
            this.list_Done.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Done_MouseDown_1);
            // 
            // list_Inprog
            // 
            this.list_Inprog.AllowDrop = true;
            this.list_Inprog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.list_Inprog.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Inprog.FormattingEnabled = true;
            this.list_Inprog.ItemHeight = 22;
            this.list_Inprog.Location = new System.Drawing.Point(677, 56);
            this.list_Inprog.Name = "list_Inprog";
            this.list_Inprog.Size = new System.Drawing.Size(271, 554);
            this.list_Inprog.TabIndex = 15;
            this.list_Inprog.DragEnter += new System.Windows.Forms.DragEventHandler(this.list_Inprog_DragEnter_1);
            this.list_Inprog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_Inprog_MouseDown_1);
            this.list_Inprog.MouseEnter += new System.EventHandler(this.list_Inprog_MouseEnter_1);
            // 
            // list_toDo
            // 
            this.list_toDo.AllowDrop = true;
            this.list_toDo.Font = new System.Drawing.Font("HelveticaNeueLT Pro 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_toDo.FormattingEnabled = true;
            this.list_toDo.ItemHeight = 22;
            this.list_toDo.Location = new System.Drawing.Point(309, 56);
            this.list_toDo.Name = "list_toDo";
            this.list_toDo.Size = new System.Drawing.Size(264, 554);
            this.list_toDo.TabIndex = 11;
            this.list_toDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_toDo_MouseDown_1);
            this.list_toDo.MouseEnter += new System.EventHandler(this.list_toDo_MouseEnter_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sinama_Final.Properties.Resources._checked;
            this.pictureBox4.Location = new System.Drawing.Point(1086, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Sinama_Final.Properties.Resources._new;
            this.pictureBox3.Location = new System.Drawing.Point(711, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sinama_Final.Properties.Resources.note_32;
            this.pictureBox2.Location = new System.Drawing.Point(370, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Sinama_Final.Properties.Resources.indir;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lst_projem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Musteri);
            this.groupBox1.Controls.Add(this.btn_YeniProje);
            this.groupBox1.Location = new System.Drawing.Point(-3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 628);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sinama_Final.Properties.Resources.contract;
            this.pictureBox1.Location = new System.Drawing.Point(15, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Pro 97 BlkCn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(67, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projelerim";
            // 
            // lst_projem
            // 
            this.lst_projem.BackColor = System.Drawing.Color.White;
            this.lst_projem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_projem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lst_projem.FormattingEnabled = true;
            this.lst_projem.ItemHeight = 20;
            this.lst_projem.Location = new System.Drawing.Point(6, 272);
            this.lst_projem.Name = "lst_projem";
            this.lst_projem.Size = new System.Drawing.Size(243, 344);
            this.lst_projem.TabIndex = 3;
            this.lst_projem.SelectedIndexChanged += new System.EventHandler(this.lst_projem_SelectedIndexChanged_1);
            this.lst_projem.DoubleClick += new System.EventHandler(this.lst_projem_DoubleClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Pro 95 Blk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoşgeldin";
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Musteri.Image = global::Sinama_Final.Properties.Resources.cvv;
            this.btn_Musteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Musteri.Location = new System.Drawing.Point(6, 157);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(243, 71);
            this.btn_Musteri.TabIndex = 1;
            this.btn_Musteri.Text = "Müşteri Kartı";
            this.btn_Musteri.UseVisualStyleBackColor = true;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Musteri_Click_1);
            // 
            // btn_YeniProje
            // 
            this.btn_YeniProje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YeniProje.Image = global::Sinama_Final.Properties.Resources._32;
            this.btn_YeniProje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_YeniProje.Location = new System.Drawing.Point(6, 76);
            this.btn_YeniProje.Name = "btn_YeniProje";
            this.btn_YeniProje.Size = new System.Drawing.Size(243, 75);
            this.btn_YeniProje.TabIndex = 0;
            this.btn_YeniProje.Text = "Yeni Proje";
            this.btn_YeniProje.UseVisualStyleBackColor = true;
            this.btn_YeniProje.Click += new System.EventHandler(this.btn_YeniProje_Click_1);
            // 
            // Kullanici_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinama_Final.Properties.Resources.elegant_white_background_with_shiny_lines_1017_17580;
            this.ClientSize = new System.Drawing.Size(1344, 625);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.list_Done);
            this.Controls.Add(this.list_Inprog);
            this.Controls.Add(this.list_toDo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Kullanici_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici_Ekrani";
            this.Load += new System.EventHandler(this.Kullanici_Ekrani_Load_1);
            this.MouseEnter += new System.EventHandler(this.Kullanici_Ekrani_MouseEnter_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox list_Done;
        private System.Windows.Forms.ListBox list_Inprog;
        private System.Windows.Forms.ListBox list_toDo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_projem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.Button btn_YeniProje;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}