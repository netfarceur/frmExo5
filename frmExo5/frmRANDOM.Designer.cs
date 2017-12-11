namespace frmExo5
{
    partial class frmRANDOM
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
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnCloseRandom = new System.Windows.Forms.Button();
            this.lblRandom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(28, 85);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 0;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            // 
            // btnCloseRandom
            // 
            this.btnCloseRandom.Location = new System.Drawing.Point(228, 85);
            this.btnCloseRandom.Name = "btnCloseRandom";
            this.btnCloseRandom.Size = new System.Drawing.Size(75, 23);
            this.btnCloseRandom.TabIndex = 1;
            this.btnCloseRandom.Text = "Fermer";
            this.btnCloseRandom.UseVisualStyleBackColor = true;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(25, 27);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(103, 15);
            this.lblRandom.TabIndex = 2;
            this.lblRandom.Text = "Nombre Aléatoire";
            this.lblRandom.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 3;
            // 
            // frmRANDOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 120);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.btnCloseRandom);
            this.Controls.Add(this.btnActualiser);
            this.Name = "frmRANDOM";
            this.Text = "frmRANDOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnCloseRandom;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.TextBox textBox1;
    }
}