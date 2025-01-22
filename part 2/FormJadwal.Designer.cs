namespace part_2
{
    partial class FormJadwal
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
            this.DgJadwal = new System.Windows.Forms.DataGridView();
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtSpe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtHar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSel = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgJadwal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // DgJadwal
            // 
            this.DgJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgJadwal.Location = new System.Drawing.Point(17, 119);
            this.DgJadwal.Name = "DgJadwal";
            this.DgJadwal.RowHeadersWidth = 62;
            this.DgJadwal.RowTemplate.Height = 28;
            this.DgJadwal.Size = new System.Drawing.Size(790, 368);
            this.DgJadwal.TabIndex = 2;
            this.DgJadwal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgJadwal_CellContentClick);
            // 
            // TxtDoc
            // 
            this.TxtDoc.Location = new System.Drawing.Point(142, 520);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(230, 26);
            this.TxtDoc.TabIndex = 4;
            // 
            // TxtSpe
            // 
            this.TxtSpe.Location = new System.Drawing.Point(142, 579);
            this.TxtSpe.Name = "TxtSpe";
            this.TxtSpe.Size = new System.Drawing.Size(230, 26);
            this.TxtSpe.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dokter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Spesialis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hari";
            // 
            // TxtHar
            // 
            this.TxtHar.Location = new System.Drawing.Point(142, 627);
            this.TxtHar.Name = "TxtHar";
            this.TxtHar.Size = new System.Drawing.Size(230, 26);
            this.TxtHar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jam Mulai";
            // 
            // TxtMul
            // 
            this.TxtMul.Location = new System.Drawing.Point(142, 674);
            this.TxtMul.Name = "TxtMul";
            this.TxtMul.Size = new System.Drawing.Size(230, 26);
            this.TxtMul.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Jam Selesai";
            // 
            // TxtSel
            // 
            this.TxtSel.Location = new System.Drawing.Point(577, 516);
            this.TxtSel.Name = "TxtSel";
            this.TxtSel.Size = new System.Drawing.Size(230, 26);
            this.TxtSel.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(133, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 26);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FormJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 843);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.TxtSel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtMul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtHar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSpe);
            this.Controls.Add(this.TxtDoc);
            this.Controls.Add(this.DgJadwal);
            this.Controls.Add(this.label1);
            this.Name = "FormJadwal";
            this.Text = "JADWAL";
            this.Load += new System.EventHandler(this.FormJadwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgJadwal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgJadwal;
        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtSpe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtHar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSel;
        private System.Windows.Forms.TextBox txtSearch;
    }
}