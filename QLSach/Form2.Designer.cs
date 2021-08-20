
namespace QLSach
{
    partial class Form2
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
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupboxTInhTrang = new System.Windows.Forms.GroupBox();
            this.rbHet = new System.Windows.Forms.RadioButton();
            this.rbCon = new System.Windows.Forms.RadioButton();
            this.lbTG = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbbTG = new System.Windows.Forms.ComboBox();
            this.lbNXB = new System.Windows.Forms.Label();
            this.groupboxTInhTrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(12, 67);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(68, 20);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "MaSach";
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Location = new System.Drawing.Point(11, 122);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(73, 20);
            this.lbTenSach.TabIndex = 1;
            this.lbTenSach.Text = "TenSach";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 26);
            this.textBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(421, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(356, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // groupboxTInhTrang
            // 
            this.groupboxTInhTrang.Controls.Add(this.rbHet);
            this.groupboxTInhTrang.Controls.Add(this.rbCon);
            this.groupboxTInhTrang.Location = new System.Drawing.Point(421, 122);
            this.groupboxTInhTrang.Name = "groupboxTInhTrang";
            this.groupboxTInhTrang.Size = new System.Drawing.Size(356, 140);
            this.groupboxTInhTrang.TabIndex = 5;
            this.groupboxTInhTrang.TabStop = false;
            this.groupboxTInhTrang.Text = "Tinh Trang";
            // 
            // rbHet
            // 
            this.rbHet.AutoSize = true;
            this.rbHet.Location = new System.Drawing.Point(192, 63);
            this.rbHet.Name = "rbHet";
            this.rbHet.Size = new System.Drawing.Size(100, 24);
            this.rbHet.TabIndex = 6;
            this.rbHet.TabStop = true;
            this.rbHet.Text = "Het hang";
            this.rbHet.UseVisualStyleBackColor = true;
            // 
            // rbCon
            // 
            this.rbCon.AutoSize = true;
            this.rbCon.Location = new System.Drawing.Point(6, 63);
            this.rbCon.Name = "rbCon";
            this.rbCon.Size = new System.Drawing.Size(103, 24);
            this.rbCon.TabIndex = 0;
            this.rbCon.TabStop = true;
            this.rbCon.Text = "Con hang";
            this.rbCon.UseVisualStyleBackColor = true;
            // 
            // lbTG
            // 
            this.lbTG.AutoSize = true;
            this.lbTG.Location = new System.Drawing.Point(12, 177);
            this.lbTG.Name = "lbTG";
            this.lbTG.Size = new System.Drawing.Size(60, 20);
            this.lbTG.TabIndex = 6;
            this.lbTG.Text = "TacGia";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(91, 294);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(110, 49);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 49);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbbTG
            // 
            this.cbbTG.FormattingEnabled = true;
            this.cbbTG.Location = new System.Drawing.Point(91, 174);
            this.cbbTG.Name = "cbbTG";
            this.cbbTG.Size = new System.Drawing.Size(228, 28);
            this.cbbTG.TabIndex = 9;
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Location = new System.Drawing.Point(423, 26);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(116, 20);
            this.lbNXB.TabIndex = 10;
            this.lbNXB.Text = "Ngay Xuat Ban";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.cbbTG);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbTG);
            this.Controls.Add(this.groupboxTInhTrang);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTenSach);
            this.Controls.Add(this.lbMaSach);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupboxTInhTrang.ResumeLayout(false);
            this.groupboxTInhTrang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupboxTInhTrang;
        private System.Windows.Forms.RadioButton rbCon;
        private System.Windows.Forms.Label lbTG;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbbTG;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.RadioButton rbHet;
    }
}