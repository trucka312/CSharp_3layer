
namespace GUI
{
    partial class FormHangHoa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textma = new System.Windows.Forms.TextBox();
            this.textten = new System.Windows.Forms.TextBox();
            this.textchungloai = new System.Windows.Forms.TextBox();
            this.textdongia = new System.Windows.Forms.TextBox();
            this.textsoluong = new System.Windows.Forms.TextBox();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mahang:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "tenhang:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "chungloai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "dongia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "soluong:";
            // 
            // textma
            // 
            this.textma.Location = new System.Drawing.Point(135, 38);
            this.textma.Name = "textma";
            this.textma.Size = new System.Drawing.Size(356, 22);
            this.textma.TabIndex = 5;
            // 
            // textten
            // 
            this.textten.Location = new System.Drawing.Point(135, 78);
            this.textten.Name = "textten";
            this.textten.Size = new System.Drawing.Size(356, 22);
            this.textten.TabIndex = 6;
            // 
            // textchungloai
            // 
            this.textchungloai.Location = new System.Drawing.Point(135, 120);
            this.textchungloai.Name = "textchungloai";
            this.textchungloai.Size = new System.Drawing.Size(356, 22);
            this.textchungloai.TabIndex = 7;
            // 
            // textdongia
            // 
            this.textdongia.Location = new System.Drawing.Point(135, 163);
            this.textdongia.Name = "textdongia";
            this.textdongia.Size = new System.Drawing.Size(356, 22);
            this.textdongia.TabIndex = 8;
            // 
            // textsoluong
            // 
            this.textsoluong.Location = new System.Drawing.Point(135, 207);
            this.textsoluong.Name = "textsoluong";
            this.textsoluong.Size = new System.Drawing.Size(356, 22);
            this.textsoluong.TabIndex = 9;
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(603, 38);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(75, 23);
            this.buttonthem.TabIndex = 10;
            this.buttonthem.Text = "them";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(603, 78);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(75, 23);
            this.buttonsua.TabIndex = 11;
            this.buttonsua.Text = "sua";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(603, 120);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 12;
            this.buttonxoa.Text = "xoa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.textsoluong);
            this.Controls.Add(this.textdongia);
            this.Controls.Add(this.textchungloai);
            this.Controls.Add(this.textten);
            this.Controls.Add(this.textma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textma;
        private System.Windows.Forms.TextBox textten;
        private System.Windows.Forms.TextBox textchungloai;
        private System.Windows.Forms.TextBox textdongia;
        private System.Windows.Forms.TextBox textsoluong;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}