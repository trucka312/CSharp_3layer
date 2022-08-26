
namespace GUI
{
    partial class FormHoaDon
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
            this.textBoxma = new System.Windows.Forms.TextBox();
            this.textBoxngaymua = new System.Windows.Forms.TextBox();
            this.textBoxmakhach = new System.Windows.Forms.TextBox();
            this.textBoxmahang = new System.Windows.Forms.TextBox();
            this.textBoxsoluong = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mahd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ngaymua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "makhach:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "mahang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "soluong";
            // 
            // textBoxma
            // 
            this.textBoxma.Location = new System.Drawing.Point(114, 28);
            this.textBoxma.Name = "textBoxma";
            this.textBoxma.Size = new System.Drawing.Size(393, 22);
            this.textBoxma.TabIndex = 5;
            // 
            // textBoxngaymua
            // 
            this.textBoxngaymua.Location = new System.Drawing.Point(114, 66);
            this.textBoxngaymua.Name = "textBoxngaymua";
            this.textBoxngaymua.Size = new System.Drawing.Size(393, 22);
            this.textBoxngaymua.TabIndex = 6;
            // 
            // textBoxmakhach
            // 
            this.textBoxmakhach.Location = new System.Drawing.Point(114, 107);
            this.textBoxmakhach.Name = "textBoxmakhach";
            this.textBoxmakhach.Size = new System.Drawing.Size(393, 22);
            this.textBoxmakhach.TabIndex = 7;
            // 
            // textBoxmahang
            // 
            this.textBoxmahang.Location = new System.Drawing.Point(114, 144);
            this.textBoxmahang.Name = "textBoxmahang";
            this.textBoxmahang.Size = new System.Drawing.Size(393, 22);
            this.textBoxmahang.TabIndex = 8;
            // 
            // textBoxsoluong
            // 
            this.textBoxsoluong.Location = new System.Drawing.Point(114, 181);
            this.textBoxsoluong.Name = "textBoxsoluong";
            this.textBoxsoluong.Size = new System.Drawing.Size(393, 22);
            this.textBoxsoluong.TabIndex = 9;
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(611, 28);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(75, 23);
            this.buttonthem.TabIndex = 10;
            this.buttonthem.Text = "them";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(611, 66);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(75, 23);
            this.buttonsua.TabIndex = 11;
            this.buttonsua.Text = "Sua";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(611, 107);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 12;
            this.buttonxoa.Text = "Xoa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.textBoxsoluong);
            this.Controls.Add(this.textBoxmahang);
            this.Controls.Add(this.textBoxmakhach);
            this.Controls.Add(this.textBoxngaymua);
            this.Controls.Add(this.textBoxma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
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
        private System.Windows.Forms.TextBox textBoxma;
        private System.Windows.Forms.TextBox textBoxngaymua;
        private System.Windows.Forms.TextBox textBoxmakhach;
        private System.Windows.Forms.TextBox textBoxmahang;
        private System.Windows.Forms.TextBox textBoxsoluong;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}