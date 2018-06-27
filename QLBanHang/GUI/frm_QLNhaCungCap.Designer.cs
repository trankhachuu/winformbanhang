namespace QLBanHang.GUI
{
    partial class frm_QLNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLNhaCungCap));
            this.cb_resHang = new System.Windows.Forms.ComboBox();
            this.txt_KeySearchHang = new System.Windows.Forms.RichTextBox();
            this.btn_ThemHang = new System.Windows.Forms.Button();
            this.btn_SearchHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_resHang
            // 
            this.cb_resHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_resHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_resHang.ForeColor = System.Drawing.Color.DimGray;
            this.cb_resHang.FormattingEnabled = true;
            this.cb_resHang.ItemHeight = 24;
            this.cb_resHang.Location = new System.Drawing.Point(289, 0);
            this.cb_resHang.Name = "cb_resHang";
            this.cb_resHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_resHang.Size = new System.Drawing.Size(217, 32);
            this.cb_resHang.TabIndex = 4;
            // 
            // txt_KeySearchHang
            // 
            this.txt_KeySearchHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_KeySearchHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KeySearchHang.Location = new System.Drawing.Point(-2, 2);
            this.txt_KeySearchHang.MaxLength = 50;
            this.txt_KeySearchHang.Name = "txt_KeySearchHang";
            this.txt_KeySearchHang.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txt_KeySearchHang.Size = new System.Drawing.Size(248, 31);
            this.txt_KeySearchHang.TabIndex = 5;
            this.txt_KeySearchHang.Text = "";
            // 
            // btn_ThemHang
            // 
            this.btn_ThemHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_ThemHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThemHang.BackgroundImage")));
            this.btn_ThemHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThemHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemHang.Location = new System.Drawing.Point(512, -1);
            this.btn_ThemHang.Name = "btn_ThemHang";
            this.btn_ThemHang.Size = new System.Drawing.Size(121, 36);
            this.btn_ThemHang.TabIndex = 6;
            this.btn_ThemHang.Text = "Thêm";
            this.btn_ThemHang.UseVisualStyleBackColor = false;
            // 
            // btn_SearchHang
            // 
            this.btn_SearchHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_SearchHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SearchHang.BackgroundImage")));
            this.btn_SearchHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SearchHang.Location = new System.Drawing.Point(246, -1);
            this.btn_SearchHang.Name = "btn_SearchHang";
            this.btn_SearchHang.Size = new System.Drawing.Size(41, 36);
            this.btn_SearchHang.TabIndex = 3;
            this.btn_SearchHang.UseVisualStyleBackColor = false;
            // 
            // frm_QLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 261);
            this.Controls.Add(this.btn_ThemHang);
            this.Controls.Add(this.btn_SearchHang);
            this.Controls.Add(this.cb_resHang);
            this.Controls.Add(this.txt_KeySearchHang);
            this.Name = "frm_QLNhaCungCap";
            this.Text = "frm_QLNhaCungCap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ThemHang;
        private System.Windows.Forms.Button btn_SearchHang;
        private System.Windows.Forms.ComboBox cb_resHang;
        private System.Windows.Forms.RichTextBox txt_KeySearchHang;
    }
}