namespace tas
{
    partial class frmtas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtas));
            this.btntas = new System.Windows.Forms.Button();
            this.lblhelp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcdtas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcdtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntas
            // 
            this.btntas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntas.Location = new System.Drawing.Point(79, 154);
            this.btntas.Name = "btntas";
            this.btntas.Size = new System.Drawing.Size(112, 23);
            this.btntas.TabIndex = 2;
            this.btntas.Text = "شانستو امتحان کن";
            this.btntas.UseVisualStyleBackColor = true;
            this.btntas.Click += new System.EventHandler(this.btntas_Click);
            this.btntas.MouseEnter += new System.EventHandler(this.btntas_MouseEnter);
            this.btntas.MouseLeave += new System.EventHandler(this.btntas_MouseLeave);
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblhelp.ForeColor = System.Drawing.Color.White;
            this.lblhelp.Location = new System.Drawing.Point(60, 219);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(13, 17);
            this.lblhelp.TabIndex = 1;
            this.lblhelp.Text = "-";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tas.Properties.Resources.Annotation_2024_09_29_151508;
            this.pictureBox2.Location = new System.Drawing.Point(260, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcdtas
            // 
            this.pcdtas.Image = ((System.Drawing.Image)(resources.GetObject("pcdtas.Image")));
            this.pcdtas.Location = new System.Drawing.Point(79, 26);
            this.pcdtas.Name = "pcdtas";
            this.pcdtas.Size = new System.Drawing.Size(112, 100);
            this.pcdtas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcdtas.TabIndex = 3;
            this.pcdtas.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::tas.Properties.Resources.Annotation_2024_09_29_140536;
            this.pictureBox1.Location = new System.Drawing.Point(260, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pcdtas);
            this.Controls.Add(this.btntas);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تاس";
            this.Load += new System.EventHandler(this.frmtas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcdtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntas;
        private System.Windows.Forms.Label lblhelp;
        private System.Windows.Forms.PictureBox pcdtas;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

