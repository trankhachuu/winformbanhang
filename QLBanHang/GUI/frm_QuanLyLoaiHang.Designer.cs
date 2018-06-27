namespace QLBanHang.GUI
{
    partial class frm_QuanLyLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyLoaiHang));
            this.txt_seachLoaiHang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.cbo_resloaihang = new System.Windows.Forms.ComboBox();
            this.btn_sualoaiHang = new System.Windows.Forms.Button();
            this.btn_xoaLoaiHang = new System.Windows.Forms.Button();
            this.btn_thoatLoaiHang = new System.Windows.Forms.Button();
            this.btn_ThemLoaiHang = new System.Windows.Forms.Button();
            this.btn_SearchLoaiHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_seachLoaiHang
            // 
            this.txt_seachLoaiHang.Location = new System.Drawing.Point(12, 8);
            this.txt_seachLoaiHang.Name = "txt_seachLoaiHang";
            this.txt_seachLoaiHang.Size = new System.Drawing.Size(192, 20);
            this.txt_seachLoaiHang.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 181);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mô Tả";
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(113, 50);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(183, 20);
            this.txt_tenloai.TabIndex = 9;
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(113, 84);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(183, 20);
            this.txt_mota.TabIndex = 10;
            // 
            // cbo_resloaihang
            // 
            this.cbo_resloaihang.FormattingEnabled = true;
            this.cbo_resloaihang.Location = new System.Drawing.Point(308, 8);
            this.cbo_resloaihang.Name = "cbo_resloaihang";
            this.cbo_resloaihang.Size = new System.Drawing.Size(172, 21);
            this.cbo_resloaihang.TabIndex = 13;
            // 
            // btn_sualoaiHang
            // 
            this.btn_sualoaiHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_sualoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sualoaiHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sualoaiHang.Location = new System.Drawing.Point(499, 44);
            this.btn_sualoaiHang.Name = "btn_sualoaiHang";
            this.btn_sualoaiHang.Size = new System.Drawing.Size(113, 30);
            this.btn_sualoaiHang.TabIndex = 14;
            this.btn_sualoaiHang.Text = "Sửa";
            this.btn_sualoaiHang.UseVisualStyleBackColor = false;
            // 
            // btn_xoaLoaiHang
            // 
            this.btn_xoaLoaiHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_xoaLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoaLoaiHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_xoaLoaiHang.Location = new System.Drawing.Point(499, 84);
            this.btn_xoaLoaiHang.Name = "btn_xoaLoaiHang";
            this.btn_xoaLoaiHang.Size = new System.Drawing.Size(113, 30);
            this.btn_xoaLoaiHang.TabIndex = 15;
            this.btn_xoaLoaiHang.Text = "Xoá";
            this.btn_xoaLoaiHang.UseVisualStyleBackColor = false;
            // 
            // btn_thoatLoaiHang
            // 
            this.btn_thoatLoaiHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_thoatLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_thoatLoaiHang.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_thoatLoaiHang.Location = new System.Drawing.Point(499, 125);
            this.btn_thoatLoaiHang.Name = "btn_thoatLoaiHang";
            this.btn_thoatLoaiHang.Size = new System.Drawing.Size(113, 30);
            this.btn_thoatLoaiHang.TabIndex = 16;
            this.btn_thoatLoaiHang.Text = "Thoát";
            this.btn_thoatLoaiHang.UseVisualStyleBackColor = false;
            // 
            // btn_ThemLoaiHang
            // 
            this.btn_ThemLoaiHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemLoaiHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThemLoaiHang.BackgroundImage")));
            this.btn_ThemLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThemLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLoaiHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemLoaiHang.Location = new System.Drawing.Point(499, 3);
            this.btn_ThemLoaiHang.Name = "btn_ThemLoaiHang";
            this.btn_ThemLoaiHang.Size = new System.Drawing.Size(113, 32);
            this.btn_ThemLoaiHang.TabIndex = 12;
            this.btn_ThemLoaiHang.Text = "Thêm";
            this.btn_ThemLoaiHang.UseVisualStyleBackColor = false;
            // 
            // btn_SearchLoaiHang
            // 
            this.btn_SearchLoaiHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SearchLoaiHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SearchLoaiHang.BackgroundImage")));
            this.btn_SearchLoaiHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SearchLoaiHang.Location = new System.Drawing.Point(228, 2);
            this.btn_SearchLoaiHang.Name = "btn_SearchLoaiHang";
            this.btn_SearchLoaiHang.Size = new System.Drawing.Size(34, 30);
            this.btn_SearchLoaiHang.TabIndex = 11;
            this.btn_SearchLoaiHang.UseVisualStyleBackColor = false;
            // 
            // frm_QuanLyLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(873, 380);
            this.Controls.Add(this.btn_thoatLoaiHang);
            this.Controls.Add(this.btn_xoaLoaiHang);
            this.Controls.Add(this.btn_sualoaiHang);
            this.Controls.Add(this.cbo_resloaihang);
            this.Controls.Add(this.btn_ThemLoaiHang);
            this.Controls.Add(this.btn_SearchLoaiHang);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_tenloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_seachLoaiHang);
            this.Name = "frm_QuanLyLoaiHang";
            this.Text = "Sửa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_seachLoaiHang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Button btn_SearchLoaiHang;
        private System.Windows.Forms.Button btn_ThemLoaiHang;
        private System.Windows.Forms.ComboBox cbo_resloaihang;
        private System.Windows.Forms.Button btn_sualoaiHang;
        private System.Windows.Forms.Button btn_xoaLoaiHang;
        private System.Windows.Forms.Button btn_thoatLoaiHang;
    }
}