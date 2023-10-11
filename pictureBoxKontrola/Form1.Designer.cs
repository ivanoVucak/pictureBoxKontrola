namespace pictureBoxKontrola
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
            this.slika1Pb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prikazBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slika1Pb)).BeginInit();
            this.SuspendLayout();
            // 
            // slika1Pb
            // 
            this.slika1Pb.Image = global::pictureBoxKontrola.Properties.Resources.preuzmi;
            this.slika1Pb.Location = new System.Drawing.Point(32, 56);
            this.slika1Pb.Name = "slika1Pb";
            this.slika1Pb.Size = new System.Drawing.Size(326, 254);
            this.slika1Pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slika1Pb.TabIndex = 0;
            this.slika1Pb.TabStop = false;
            this.slika1Pb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fotografija naše učionice:";
            // 
            // prikazBtn
            // 
            this.prikazBtn.Location = new System.Drawing.Point(52, 334);
            this.prikazBtn.Name = "prikazBtn";
            this.prikazBtn.Size = new System.Drawing.Size(75, 23);
            this.prikazBtn.TabIndex = 2;
            this.prikazBtn.Text = "Prikaži sliku";
            this.prikazBtn.UseVisualStyleBackColor = true;
            this.prikazBtn.Click += new System.EventHandler(this.prikazBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 367);
            this.Controls.Add(this.prikazBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slika1Pb);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.slika1Pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slika1Pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prikazBtn;
    }
}

