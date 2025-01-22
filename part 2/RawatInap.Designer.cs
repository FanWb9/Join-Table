namespace part_2
{
    partial class RawatInap
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
            this.DgRaw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tgIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TgOut = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNmK = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.txtHr = new System.Windows.Forms.TextBox();
            this.btnInser = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnSav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // DgRaw
            // 
            this.DgRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgRaw.Location = new System.Drawing.Point(28, 47);
            this.DgRaw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgRaw.Name = "DgRaw";
            this.DgRaw.RowHeadersWidth = 62;
            this.DgRaw.RowTemplate.Height = 28;
            this.DgRaw.Size = new System.Drawing.Size(543, 291);
            this.DgRaw.TabIndex = 0;
            this.DgRaw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRaw_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtSear
            // 
            this.txtSear.Location = new System.Drawing.Point(87, 20);
            this.txtSear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSear.Name = "txtSear";
            this.txtSear.Size = new System.Drawing.Size(147, 20);
            this.txtSear.TabIndex = 2;
            this.txtSear.TextChanged += new System.EventHandler(this.txtSear_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 354);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipe Kamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 391);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Kamar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 462);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Harga";
            // 
            // tgIn
            // 
            this.tgIn.Location = new System.Drawing.Point(343, 350);
            this.tgIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tgIn.Name = "tgIn";
            this.tgIn.Size = new System.Drawing.Size(135, 20);
            this.tgIn.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tanggal Masuk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 391);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tanggal Keluar";
            // 
            // TgOut
            // 
            this.TgOut.Location = new System.Drawing.Point(343, 391);
            this.TgOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TgOut.Name = "TgOut";
            this.TgOut.Size = new System.Drawing.Size(135, 20);
            this.TgOut.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 352);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtNmK
            // 
            this.txtNmK.Location = new System.Drawing.Point(120, 389);
            this.txtNmK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNmK.Name = "txtNmK";
            this.txtNmK.Size = new System.Drawing.Size(125, 20);
            this.txtNmK.TabIndex = 12;
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(120, 424);
            this.txtTk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(125, 20);
            this.txtTk.TabIndex = 13;
            // 
            // txtHr
            // 
            this.txtHr.Location = new System.Drawing.Point(120, 458);
            this.txtHr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHr.Name = "txtHr";
            this.txtHr.Size = new System.Drawing.Size(125, 20);
            this.txtHr.TabIndex = 14;
            // 
            // btnInser
            // 
            this.btnInser.BackColor = System.Drawing.Color.Turquoise;
            this.btnInser.Location = new System.Drawing.Point(280, 434);
            this.btnInser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(69, 25);
            this.btnInser.TabIndex = 15;
            this.btnInser.Text = "Insert";
            this.btnInser.UseVisualStyleBackColor = false;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Turquoise;
            this.btnUp.Location = new System.Drawing.Point(367, 434);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(69, 25);
            this.btnUp.TabIndex = 16;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Turquoise;
            this.btnDel.Location = new System.Drawing.Point(457, 434);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(69, 25);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCan.Location = new System.Drawing.Point(316, 474);
            this.btnCan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(69, 25);
            this.btnCan.TabIndex = 18;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnSav
            // 
            this.btnSav.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSav.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSav.Location = new System.Drawing.Point(408, 474);
            this.btnSav.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSav.Name = "btnSav";
            this.btnSav.Size = new System.Drawing.Size(69, 25);
            this.btnSav.TabIndex = 19;
            this.btnSav.Text = "Save";
            this.btnSav.UseVisualStyleBackColor = false;
            this.btnSav.Click += new System.EventHandler(this.btnSav_Click);
            // 
            // RawatInap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 536);
            this.Controls.Add(this.btnSav);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnInser);
            this.Controls.Add(this.txtHr);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.txtNmK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.TgOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tgIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgRaw);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RawatInap";
            this.Text = "RawatInap";
            this.Load += new System.EventHandler(this.RawatInap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgRaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgRaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tgIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TgOut;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNmK;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.TextBox txtHr;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnSav;
    }
}