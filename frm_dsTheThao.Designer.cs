namespace Bai4
{
    partial class frm_dsTheThao
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
            this.components = new System.ComponentModel.Container();
            this.lbl_0 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_time2 = new System.Windows.Forms.Label();
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_time2 = new System.Windows.Forms.TextBox();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.btn_chuenTatCaTrai = new System.Windows.Forms.Button();
            this.btn_chuyenTaiCaPhai = new System.Windows.Forms.Button();
            this.btn_chuyentrai = new System.Windows.Forms.Button();
            this.btn_chuyenPhai1 = new System.Windows.Forms.Button();
            this.lst_right = new System.Windows.Forms.ListBox();
            this.lst_left = new System.Windows.Forms.ListBox();
            this.lbl_dsCacMon = new System.Windows.Forms.Label();
            this.lbl_dsDaChon = new System.Windows.Forms.Label();
            this.pnl_tt = new System.Windows.Forms.Panel();
            this.lbl_line3 = new System.Windows.Forms.Label();
            this.lbl_line2 = new System.Windows.Forms.Label();
            this.lbl_line1 = new System.Windows.Forms.Label();
            this.lbl_line4 = new System.Windows.Forms.Label();
            this.lbl_ketQua = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_nhap = new System.Windows.Forms.Button();
            this.pnl_tt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_0
            // 
            this.lbl_0.AutoSize = true;
            this.lbl_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_0.Location = new System.Drawing.Point(185, 29);
            this.lbl_0.Name = "lbl_0";
            this.lbl_0.Size = new System.Drawing.Size(273, 30);
            this.lbl_0.TabIndex = 0;
            this.lbl_0.Text = "Danh Sách Thể Thao";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_name.Location = new System.Drawing.Point(64, 80);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(109, 20);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Chọn họ tên: ";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_time.Location = new System.Drawing.Point(64, 119);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(56, 20);
            this.lbl_time.TabIndex = 2;
            this.lbl_time.Text = "Time: ";
            // 
            // lbl_time2
            // 
            this.lbl_time2.AutoSize = true;
            this.lbl_time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_time2.Location = new System.Drawing.Point(385, 121);
            this.lbl_time2.Name = "lbl_time2";
            this.lbl_time2.Size = new System.Drawing.Size(56, 20);
            this.lbl_time2.TabIndex = 3;
            this.lbl_time2.Text = "Time: ";
            // 
            // cbo_name
            // 
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Location = new System.Drawing.Point(211, 80);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(202, 24);
            this.cbo_name.TabIndex = 4;
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.Color.White;
            this.txt_time.Location = new System.Drawing.Point(151, 119);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(196, 22);
            this.txt_time.TabIndex = 5;
            // 
            // txt_time2
            // 
            this.txt_time2.BackColor = System.Drawing.Color.White;
            this.txt_time2.Location = new System.Drawing.Point(470, 119);
            this.txt_time2.Name = "txt_time2";
            this.txt_time2.ReadOnly = true;
            this.txt_time2.Size = new System.Drawing.Size(131, 22);
            this.txt_time2.TabIndex = 6;
            // 
            // tmr_time
            // 
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // btn_chuenTatCaTrai
            // 
            this.btn_chuenTatCaTrai.Location = new System.Drawing.Point(303, 324);
            this.btn_chuenTatCaTrai.Name = "btn_chuenTatCaTrai";
            this.btn_chuenTatCaTrai.Size = new System.Drawing.Size(65, 31);
            this.btn_chuenTatCaTrai.TabIndex = 12;
            this.btn_chuenTatCaTrai.Text = "<<";
            this.btn_chuenTatCaTrai.UseVisualStyleBackColor = true;
            this.btn_chuenTatCaTrai.Click += new System.EventHandler(this.btn_chuenTatCaTrai_Click);
            // 
            // btn_chuyenTaiCaPhai
            // 
            this.btn_chuyenTaiCaPhai.Location = new System.Drawing.Point(303, 287);
            this.btn_chuyenTaiCaPhai.Name = "btn_chuyenTaiCaPhai";
            this.btn_chuyenTaiCaPhai.Size = new System.Drawing.Size(65, 31);
            this.btn_chuyenTaiCaPhai.TabIndex = 11;
            this.btn_chuyenTaiCaPhai.Text = ">>";
            this.btn_chuyenTaiCaPhai.UseVisualStyleBackColor = true;
            this.btn_chuyenTaiCaPhai.Click += new System.EventHandler(this.btn_chuyenTaiCaPhai_Click);
            // 
            // btn_chuyentrai
            // 
            this.btn_chuyentrai.Location = new System.Drawing.Point(303, 244);
            this.btn_chuyentrai.Name = "btn_chuyentrai";
            this.btn_chuyentrai.Size = new System.Drawing.Size(65, 31);
            this.btn_chuyentrai.TabIndex = 10;
            this.btn_chuyentrai.Text = "<";
            this.btn_chuyentrai.UseVisualStyleBackColor = true;
            this.btn_chuyentrai.Click += new System.EventHandler(this.btn_chuyentrai_Click);
            // 
            // btn_chuyenPhai1
            // 
            this.btn_chuyenPhai1.Location = new System.Drawing.Point(303, 207);
            this.btn_chuyenPhai1.Name = "btn_chuyenPhai1";
            this.btn_chuyenPhai1.Size = new System.Drawing.Size(65, 31);
            this.btn_chuyenPhai1.TabIndex = 9;
            this.btn_chuyenPhai1.Text = ">";
            this.btn_chuyenPhai1.UseVisualStyleBackColor = true;
            this.btn_chuyenPhai1.Click += new System.EventHandler(this.btn_chuyenPhai1_Click);
            // 
            // lst_right
            // 
            this.lst_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lst_right.FormattingEnabled = true;
            this.lst_right.ItemHeight = 20;
            this.lst_right.Location = new System.Drawing.Point(389, 207);
            this.lst_right.Margin = new System.Windows.Forms.Padding(4);
            this.lst_right.Name = "lst_right";
            this.lst_right.Size = new System.Drawing.Size(212, 144);
            this.lst_right.TabIndex = 8;
            // 
            // lst_left
            // 
            this.lst_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lst_left.FormattingEnabled = true;
            this.lst_left.ItemHeight = 20;
            this.lst_left.Location = new System.Drawing.Point(68, 207);
            this.lst_left.Margin = new System.Windows.Forms.Padding(4);
            this.lst_left.Name = "lst_left";
            this.lst_left.Size = new System.Drawing.Size(208, 144);
            this.lst_left.TabIndex = 7;
            // 
            // lbl_dsCacMon
            // 
            this.lbl_dsCacMon.AutoSize = true;
            this.lbl_dsCacMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_dsCacMon.Location = new System.Drawing.Point(64, 163);
            this.lbl_dsCacMon.Name = "lbl_dsCacMon";
            this.lbl_dsCacMon.Size = new System.Drawing.Size(164, 20);
            this.lbl_dsCacMon.TabIndex = 13;
            this.lbl_dsCacMon.Text = "Danh sách các môn:";
            // 
            // lbl_dsDaChon
            // 
            this.lbl_dsDaChon.AutoSize = true;
            this.lbl_dsDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_dsDaChon.Location = new System.Drawing.Point(385, 163);
            this.lbl_dsDaChon.Name = "lbl_dsDaChon";
            this.lbl_dsDaChon.Size = new System.Drawing.Size(159, 20);
            this.lbl_dsDaChon.TabIndex = 13;
            this.lbl_dsDaChon.Text = "Danh sách đã chọn:";
            // 
            // pnl_tt
            // 
            this.pnl_tt.BackColor = System.Drawing.Color.White;
            this.pnl_tt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_tt.Controls.Add(this.lbl_line4);
            this.pnl_tt.Controls.Add(this.lbl_line3);
            this.pnl_tt.Controls.Add(this.lbl_line2);
            this.pnl_tt.Controls.Add(this.lbl_line1);
            this.pnl_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnl_tt.ForeColor = System.Drawing.Color.Blue;
            this.pnl_tt.Location = new System.Drawing.Point(68, 412);
            this.pnl_tt.Name = "pnl_tt";
            this.pnl_tt.Size = new System.Drawing.Size(285, 161);
            this.pnl_tt.TabIndex = 23;
            // 
            // lbl_line3
            // 
            this.lbl_line3.AutoSize = true;
            this.lbl_line3.Location = new System.Drawing.Point(6, 55);
            this.lbl_line3.Name = "lbl_line3";
            this.lbl_line3.Size = new System.Drawing.Size(14, 20);
            this.lbl_line3.TabIndex = 2;
            this.lbl_line3.Text = " ";
            this.lbl_line3.Click += new System.EventHandler(this.lbl_line3_Click);
            // 
            // lbl_line2
            // 
            this.lbl_line2.AutoSize = true;
            this.lbl_line2.Location = new System.Drawing.Point(6, 25);
            this.lbl_line2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_line2.Name = "lbl_line2";
            this.lbl_line2.Size = new System.Drawing.Size(14, 20);
            this.lbl_line2.TabIndex = 1;
            this.lbl_line2.Text = " ";
            // 
            // lbl_line1
            // 
            this.lbl_line1.AutoSize = true;
            this.lbl_line1.Location = new System.Drawing.Point(6, 4);
            this.lbl_line1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbl_line1.Name = "lbl_line1";
            this.lbl_line1.Size = new System.Drawing.Size(14, 20);
            this.lbl_line1.TabIndex = 0;
            this.lbl_line1.Text = " ";
            // 
            // lbl_line4
            // 
            this.lbl_line4.Location = new System.Drawing.Point(6, 75);
            this.lbl_line4.Name = "lbl_line4";
            this.lbl_line4.Size = new System.Drawing.Size(271, 82);
            this.lbl_line4.TabIndex = 3;
            this.lbl_line4.Text = " ";
            // 
            // lbl_ketQua
            // 
            this.lbl_ketQua.AutoSize = true;
            this.lbl_ketQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_ketQua.Location = new System.Drawing.Point(64, 379);
            this.lbl_ketQua.Name = "lbl_ketQua";
            this.lbl_ketQua.Size = new System.Drawing.Size(71, 20);
            this.lbl_ketQua.TabIndex = 24;
            this.lbl_ketQua.Text = "Kết quả:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Location = new System.Drawing.Point(452, 514);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 30);
            this.btn_thoat.TabIndex = 27;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_reset.Location = new System.Drawing.Point(452, 464);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 30);
            this.btn_reset.TabIndex = 26;
            this.btn_reset.Text = "Làm Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_nhap
            // 
            this.btn_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nhap.Location = new System.Drawing.Point(452, 410);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(111, 30);
            this.btn_nhap.TabIndex = 25;
            this.btn_nhap.Text = "Tính";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // frm_dsTheThao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 595);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.lbl_ketQua);
            this.Controls.Add(this.pnl_tt);
            this.Controls.Add(this.lbl_dsDaChon);
            this.Controls.Add(this.lbl_dsCacMon);
            this.Controls.Add(this.btn_chuenTatCaTrai);
            this.Controls.Add(this.btn_chuyenTaiCaPhai);
            this.Controls.Add(this.btn_chuyentrai);
            this.Controls.Add(this.btn_chuyenPhai1);
            this.Controls.Add(this.lst_right);
            this.Controls.Add(this.lst_left);
            this.Controls.Add(this.txt_time2);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.cbo_name);
            this.Controls.Add(this.lbl_time2);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_dsTheThao";
            this.Text = "Dang sách thể thao";
            this.Load += new System.EventHandler(this.frm_dsTheThao_Load);
            this.pnl_tt.ResumeLayout(false);
            this.pnl_tt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_0;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_time2;
        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_time2;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.Button btn_chuenTatCaTrai;
        private System.Windows.Forms.Button btn_chuyenTaiCaPhai;
        private System.Windows.Forms.Button btn_chuyentrai;
        private System.Windows.Forms.Button btn_chuyenPhai1;
        private System.Windows.Forms.ListBox lst_right;
        private System.Windows.Forms.ListBox lst_left;
        private System.Windows.Forms.Label lbl_dsCacMon;
        private System.Windows.Forms.Label lbl_dsDaChon;
        private System.Windows.Forms.Panel pnl_tt;
        private System.Windows.Forms.Label lbl_line4;
        private System.Windows.Forms.Label lbl_line3;
        private System.Windows.Forms.Label lbl_line2;
        private System.Windows.Forms.Label lbl_line1;
        private System.Windows.Forms.Label lbl_ketQua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_nhap;
    }
}

