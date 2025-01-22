namespace part_2
{
    partial class AdminForm
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
            this.name = new System.Windows.Forms.Label();
            this.BtnJad = new System.Windows.Forms.Button();
            this.BtnRaw = new System.Windows.Forms.Button();
            this.BtnBat = new System.Windows.Forms.Button();
            this.BtnLogt = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.txtJam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(35, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(93, 32);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // BtnJad
            // 
            this.BtnJad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnJad.ForeColor = System.Drawing.Color.Black;
            this.BtnJad.Location = new System.Drawing.Point(169, 97);
            this.BtnJad.Name = "BtnJad";
            this.BtnJad.Size = new System.Drawing.Size(259, 78);
            this.BtnJad.TabIndex = 1;
            this.BtnJad.Text = "JADWAL";
            this.BtnJad.UseVisualStyleBackColor = false;
            this.BtnJad.Click += new System.EventHandler(this.BtnJad_Click);
            // 
            // BtnRaw
            // 
            this.BtnRaw.BackColor = System.Drawing.Color.Plum;
            this.BtnRaw.Location = new System.Drawing.Point(169, 207);
            this.BtnRaw.Name = "BtnRaw";
            this.BtnRaw.Size = new System.Drawing.Size(259, 78);
            this.BtnRaw.TabIndex = 2;
            this.BtnRaw.Text = "RAWAT INAP";
            this.BtnRaw.UseVisualStyleBackColor = false;
            this.BtnRaw.Click += new System.EventHandler(this.BtnRaw_Click);
            // 
            // BtnBat
            // 
            this.BtnBat.BackColor = System.Drawing.Color.Green;
            this.BtnBat.Location = new System.Drawing.Point(169, 318);
            this.BtnBat.Name = "BtnBat";
            this.BtnBat.Size = new System.Drawing.Size(259, 78);
            this.BtnBat.TabIndex = 3;
            this.BtnBat.Text = "OBAT";
            this.BtnBat.UseVisualStyleBackColor = false;
            // 
            // BtnLogt
            // 
            this.BtnLogt.BackColor = System.Drawing.Color.SlateGray;
            this.BtnLogt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLogt.Location = new System.Drawing.Point(457, 447);
            this.BtnLogt.Name = "BtnLogt";
            this.BtnLogt.Size = new System.Drawing.Size(108, 43);
            this.BtnLogt.TabIndex = 4;
            this.BtnLogt.Text = "Log out";
            this.BtnLogt.UseVisualStyleBackColor = false;
            this.BtnLogt.Click += new System.EventHandler(this.button4_Click);
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // txtJam
            // 
            this.txtJam.AutoSize = true;
            this.txtJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJam.Location = new System.Drawing.Point(329, 34);
            this.txtJam.Name = "txtJam";
            this.txtJam.Size = new System.Drawing.Size(53, 25);
            this.txtJam.TabIndex = 5;
            this.txtJam.Text = "Jam";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 540);
            this.Controls.Add(this.txtJam);
            this.Controls.Add(this.BtnLogt);
            this.Controls.Add(this.BtnBat);
            this.Controls.Add(this.BtnRaw);
            this.Controls.Add(this.BtnJad);
            this.Controls.Add(this.name);
            this.Name = "AdminForm";
            this.Text = "ADMIN";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button BtnJad;
        private System.Windows.Forms.Button BtnRaw;
        private System.Windows.Forms.Button BtnBat;
        private System.Windows.Forms.Button BtnLogt;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label txtJam;
    }
}