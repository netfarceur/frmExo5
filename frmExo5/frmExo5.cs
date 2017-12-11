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
    public partial class frmExo5 : Form
    { /// <summary> 
      /// générateur de nombre aléatoire  
      /// </summary> 
        private System.Random aleat; // variable de niveau  classe

        ///<summary> 
        /// nombre aléatoire tiré 
        /// </summary> 
        private Double nombre;
        internal Int32 chrono = 0;
        //  Et il sera instancié par le constructeur de la classe frmExo5 : 

        /// <summary> 
        /// Constructeur par défaut : génère un nombre aléatoire

        /// et affiche les valeurs courantes (stockées dans Donnees)

        /// </summary>
        /// 
        public frmExo5()
        {
            InitializeComponent();





            //   InitializeComponent();
            this.aleat = new System.Random(); // instancie un objet générateur aléatoire


            this.affiche();  // calcul nouvelles valeurs et affichages 
        }

        /// <summary> 
        /// Déclenchement timer : affiche les valeurs courantes  

        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void timer_Tick(object sender, EventArgs e)
        {
            this.affiche(); // calcul nouvelles valeurs et affichages 

        }

        ///Reste à définir la procédure d’affichage :  <summary> 
        /// calcul nouvelles valeurs  
        /// puis les affiche sur ce form 
        /// </summary> 
        private void affiche()
        {
            // génère un nombre entre 0 et 1 et l'affiche en textbox 

            this.nombre = this.aleat.NextDouble();
            this.txtNombre.Text = this.nombre.ToString();
            // incrémente chrono et l'affiche en textbox 
            
        }


        private void frmExo5_Load(object sender, EventArgs e)
        {

        }

        private void txtChrono_Tick(object sender, EventArgs e)
        {

        }

        internal void TxtChronoExo_TextChanged(object sender, EventArgs e)
        {
            this.chrono++;
            this.TxtChronoExo.Text = this.chrono.ToString();
        }
    }
}
