namespace frmExo5
{
    partial class frmChrono
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
            this.Chrono = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnActuChrono = new System.Windows.Forms.Button();
            this.btnCloseChrono = new System.Windows.Forms.Button();
            this.TxtChrono = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Chrono
            // 
            this.Chrono.AutoSize = true;
            this.Chrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chrono.Location = new System.Drawing.Point(41, 28);
            this.Chrono.Name = "Chrono";
            this.Chrono.Size = new System.Drawing.Size(67, 20);
            this.Chrono.TabIndex = 0;
            this.Chrono.Text = "Chrono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnActuChrono
            // 
            this.btnActuChrono.Location = new System.Drawing.Point(44, 72);
            this.btnActuChrono.Name = "btnActuChrono";
            this.btnActuChrono.Size = new System.Drawing.Size(75, 23);
            this.btnActuChrono.TabIndex = 2;
            this.btnActuChrono.Text = "Actualiser";
            this.btnActuChrono.UseVisualStyleBackColor = true;
            // 
            // btnCloseChrono
            // 
            this.btnCloseChrono.Location = new System.Drawing.Point(303, 71);
            this.btnCloseChrono.Name = "btnCloseChrono";
            this.btnCloseChrono.Size = new System.Drawing.Size(75, 23);
            this.btnCloseChrono.TabIndex = 3;
            this.btnCloseChrono.Text = "Fermer";
            this.btnCloseChrono.UseVisualStyleBackColor = true;
            this.btnCloseChrono.Click += new System.EventHandler(this.btnCloseChrono_Click);
            // 
            // TxtChrono
            // 
            this.TxtChrono.Tick += new System.EventHandler(this.TxtChrono_Tick);
            // 
            // frmChrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 140);
            this.Controls.Add(this.btnCloseChrono);
            this.Controls.Add(this.btnActuChrono);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Chrono);
            this.Name = "frmChrono";
            this.Text = "frmChrono";
            this.Load += new System.EventHandler(this.frmChrono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chrono;
        private System.Windows.Forms.Button btnCloseChrono;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Timer TxtChrono;
        internal System.Windows.Forms.Button btnActuChrono;
    }
}