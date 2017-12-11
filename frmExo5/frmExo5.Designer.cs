namespace frmExo5
{
    partial class frmExo5
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtChronoExo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtChrono = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chrono";
            // 
            // TxtChronoExo
            // 
            this.TxtChronoExo.Location = new System.Drawing.Point(216, 30);
            this.TxtChronoExo.Name = "TxtChronoExo";
            this.TxtChronoExo.ReadOnly = true;
            this.TxtChronoExo.Size = new System.Drawing.Size(204, 20);
            this.TxtChronoExo.TabIndex = 1;
            this.TxtChronoExo.TextChanged += new System.EventHandler(this.TxtChronoExo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Aléatoire";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(204, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtChrono
            // 
            this.txtChrono.Enabled = true;
            this.txtChrono.Tick += new System.EventHandler(this.txtChrono_Tick);
            // 
            // frmExo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 145);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtChronoExo);
            this.Controls.Add(this.label1);
            this.Name = "frmExo5";
            this.Text = "frmExo5";
            this.Load += new System.EventHandler(this.frmExo5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Timer txtChrono;
        internal System.Windows.Forms.TextBox TxtChronoExo;
        internal System.Windows.Forms.TextBox txtNombre;
    }
}