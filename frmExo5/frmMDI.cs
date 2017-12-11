using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmExo5
{

    public partial class frmMDI : Form
    {
        // Amélioration 1: 3 variables de niveau classe (accessibles dans toute la classe)


        private frmExo5 frmPrinc; // déclare une instance du form ppal

        private frmChrono frmC; // déclare une instance du form Chrono

        private frmRANDOM frmR;// déclare une instance du form Nombre

        public frmMDI()
        {
            InitializeComponent();
          //  frmExo5 frmPrinc;  // déclare une instance du form principal

            this.frmPrinc = new frmExo5(); // instancie le form principal

            this.frmPrinc.MdiParent = this; // précise le conteneurMDI du form principal

            this.frmPrinc.Show(); // affiche le form (dans son formconteneur)

        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.frmR==null)
            { 
            this.frmR = new frmRANDOM(); // instancie le form  
            this.frmR.MdiParent = this;
            this.frmR.Show(); // affiche le form dans son conteneur
            }
            else // le form secondaire est affiché 
            {
                this.frmR.Activate(); // réactive le form (lui donne le focus)


            }
        }

        private void frmExo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmExo5 frmC; // déclare une instance du form  
           // frmC = new frmExo5(); // instancie le form  
           // frmC.MdiParent = this;
           // frmC.Show(); // affiche le form dans son conteneur

            /// <summary>  
            /// menu Fenêtres / Chrono ==> instancier un form f rmChrono ou le réactiver
            ///<</summary>        
            // instancie le form - amélioration 1 
            if (this.frmC == null) // le form n’est pas/plus affiché


            {
                this.frmC = new frmChrono(); // instancie le form 

                this.frmC.MdiParent = this;

                this.frmC.Show(); // affiche le form

            }
            else // le form secondaire est affiché 
            {
                this.frmC.Activate(); // réactive le form (lui donne le focus)


            }
            // recopie la valeur courante 
            this.frmC.TxtChrono = this.frmPrinc.txtChrono;









            //    frmChrono frmC; // déclare une instance du form  
            //    frmC = new frmChrono(); // instancie le form  
            //    frmC.MdiParent = this;
            //    frmC.Show(); // affiche le form dans son conteneur

        }

       
    }
}
