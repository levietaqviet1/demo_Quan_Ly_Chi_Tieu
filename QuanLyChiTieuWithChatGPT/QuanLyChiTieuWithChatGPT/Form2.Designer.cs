namespace QuanLyChiTieuWithChatGPT
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiChiTieu = new System.Windows.Forms.ComboBox();
            this.numSoTIen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayCHi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTIen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại Chi Tiêu";
            // 
            // cboLoaiChiTieu
            // 
            this.cboLoaiChiTieu.FormattingEnabled = true;
            this.cboLoaiChiTieu.Location = new System.Drawing.Point(206, 49);
            this.cboLoaiChiTieu.Name = "cboLoaiChiTieu";
            this.cboLoaiChiTieu.Size = new System.Drawing.Size(151, 28);
            this.cboLoaiChiTieu.TabIndex = 1;
            // 
            // numSoTIen
            // 
            this.numSoTIen.Location = new System.Drawing.Point(207, 100);
            this.numSoTIen.Name = "numSoTIen";
            this.numSoTIen.Size = new System.Drawing.Size(150, 27);
            this.numSoTIen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Tiền";
            // 
            // dtNgayCHi
            // 
            this.dtNgayCHi.Location = new System.Drawing.Point(206, 177);
            this.dtNgayCHi.Name = "dtNgayCHi";
            this.dtNgayCHi.Size = new System.Drawing.Size(250, 27);
            this.dtNgayCHi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngay Chi";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(206, 237);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(257, 121);
            this.txtMoTa.TabIndex = 6;
            this.txtMoTa.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mô Tả";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(596, 49);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(24, 20);
            this.lbInfo.TabIndex = 9;
            this.lbInfo.Text = "Hi";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(539, 102);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 51;
            this.dgView.RowTemplate.Height = 29;
            this.dgView.Size = new System.Drawing.Size(600, 296);
            this.dgView.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtNgayCHi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numSoTIen);
            this.Controls.Add(this.cboLoaiChiTieu);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoTIen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboLoaiChiTieu;
        private NumericUpDown numSoTIen;
        private Label label2;
        private DateTimePicker dtNgayCHi;
        private Label label3;
        private RichTextBox txtMoTa;
        private Label label4;
        private Button btnSave;
        private Label lbInfo;
        private DataGridView dgView;
    }
}