namespace WindowsFormsApplication1
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
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.lbl_WebNguon = new System.Windows.Forms.Label();
            this.lbl_Webtimkiem = new System.Windows.Forms.Label();
            this.txt_WebTK = new System.Windows.Forms.TextBox();
            this.txt_TuKhoa = new System.Windows.Forms.TextBox();
            this.cbl_webnguon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_KQDiaChi = new System.Windows.Forms.TextBox();
            this.txt_KQViTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(504, 110);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 0;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_WebNguon
            // 
            this.lbl_WebNguon.AutoSize = true;
            this.lbl_WebNguon.Location = new System.Drawing.Point(13, 23);
            this.lbl_WebNguon.Name = "lbl_WebNguon";
            this.lbl_WebNguon.Size = new System.Drawing.Size(65, 13);
            this.lbl_WebNguon.TabIndex = 1;
            this.lbl_WebNguon.Text = "Web Nguồn";
            // 
            // lbl_Webtimkiem
            // 
            this.lbl_Webtimkiem.AutoSize = true;
            this.lbl_Webtimkiem.Location = new System.Drawing.Point(13, 76);
            this.lbl_Webtimkiem.Name = "lbl_Webtimkiem";
            this.lbl_Webtimkiem.Size = new System.Drawing.Size(76, 13);
            this.lbl_Webtimkiem.TabIndex = 2;
            this.lbl_Webtimkiem.Text = "Web Tìm Kiếm";
            // 
            // txt_WebTK
            // 
            this.txt_WebTK.Location = new System.Drawing.Point(108, 69);
            this.txt_WebTK.Name = "txt_WebTK";
            this.txt_WebTK.Size = new System.Drawing.Size(360, 20);
            this.txt_WebTK.TabIndex = 3;
            // 
            // txt_TuKhoa
            // 
            this.txt_TuKhoa.Location = new System.Drawing.Point(108, 113);
            this.txt_TuKhoa.Name = "txt_TuKhoa";
            this.txt_TuKhoa.Size = new System.Drawing.Size(360, 20);
            this.txt_TuKhoa.TabIndex = 4;
            // 
            // cbl_webnguon
            // 
            this.cbl_webnguon.FormattingEnabled = true;
            this.cbl_webnguon.Items.AddRange(new object[] {
            "https://www.google.com.vn",
            "https://www.google.com"});
            this.cbl_webnguon.Location = new System.Drawing.Point(108, 23);
            this.cbl_webnguon.Name = "cbl_webnguon";
            this.cbl_webnguon.Size = new System.Drawing.Size(360, 21);
            this.cbl_webnguon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ khóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_KQDiaChi);
            this.groupBox1.Controls.Add(this.txt_KQViTri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ket Qủa";
            // 
            // txt_KQDiaChi
            // 
            this.txt_KQDiaChi.Location = new System.Drawing.Point(92, 93);
            this.txt_KQDiaChi.Name = "txt_KQDiaChi";
            this.txt_KQDiaChi.Size = new System.Drawing.Size(360, 20);
            this.txt_KQDiaChi.TabIndex = 3;
            // 
            // txt_KQViTri
            // 
            this.txt_KQViTri.Location = new System.Drawing.Point(92, 39);
            this.txt_KQViTri.Name = "txt_KQViTri";
            this.txt_KQViTri.Size = new System.Drawing.Size(360, 20);
            this.txt_KQViTri.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vị Trí";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 367);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbl_webnguon);
            this.Controls.Add(this.txt_TuKhoa);
            this.Controls.Add(this.txt_WebTK);
            this.Controls.Add(this.lbl_Webtimkiem);
            this.Controls.Add(this.lbl_WebNguon);
            this.Controls.Add(this.btn_timkiem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label lbl_WebNguon;
        private System.Windows.Forms.Label lbl_Webtimkiem;
        private System.Windows.Forms.TextBox txt_WebTK;
        private System.Windows.Forms.TextBox txt_TuKhoa;
        private System.Windows.Forms.ComboBox cbl_webnguon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_KQDiaChi;
        private System.Windows.Forms.TextBox txt_KQViTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

