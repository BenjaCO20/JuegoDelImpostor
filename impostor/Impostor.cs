using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace impostor
{
    public partial class Impostor : Form
    {
        private List<string> palabras;
        private List<string> palabrasDeRonda;
        private string palabraDeRonda;
        
        private decimal cantImpostores;
        private decimal cantJug;
        private 
        void Shuffle<T>(List<T> lista)
        {
            Random rnd = new Random();
            for (int i = lista.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (lista[i], lista[j]) = (lista[j], lista[i]);
            }
        }

        public Impostor(List<string> palabrasRecibidas, decimal cantImpostores, decimal cantJug)
        {
            InitializeComponent();
            palabras = palabrasRecibidas;
            Shuffle(palabras);

            this.cantImpostores = cantImpostores;
            this.cantJug = cantJug;

            this.palabrasDeRonda = new List<string>();
            

        }

        private void btnEmpezarRonda_Click(object sender, EventArgs e)
        {



            if (palabras.Count == 0 && btnEmpezarRonda.Text == "Terminar Ronda")

            {
                btnEmpezarRonda.Text = "Empezar Ronda";

                MessageBox.Show("No hay más palabras!."); 
            }

            else if (palabras.Count == 0)

            {
                MessageBox.Show("No hay más palabras!.");
            }


            else if(btnEmpezarRonda.Text == "Terminar Ronda")
            {
                palabrasDeRonda.Clear();
                btnEmpezarRonda.Text = "Empezar Ronda";
            }

            else
            {
             btnEmpezarRonda.Text = "Terminar Ronda";


             Random rnd0 = new Random();
             int index0 = rnd0.Next(palabras.Count);

             string palabra = palabras[index0];
             palabras.RemoveAt(index0);
            
             for(int i = 0;  i < this.cantJug; i++) 
             {
                 palabrasDeRonda.Add(palabra);
             }
            
             for (int i = 0; i < cantImpostores; i++)
             {
                 palabrasDeRonda.Add("Impostor");

             }
            
             Shuffle(palabrasDeRonda);

            }


               
        }

        //btn Mostrar palabra
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (btnEmpezarRonda.Text == "Empezar Ronda") 
            {
                MessageBox.Show("La ronda aun no ha comenzado");
                return;
            }


            else if (palabrasDeRonda.Count == 0)

            {
                MessageBox.Show("No hay más palabras!");
                return; 
            }
            



            else 
            {
            Random rnd1 = new Random();
            int index1 = rnd1.Next(palabrasDeRonda.Count);

            string palabraRonda = palabrasDeRonda[index1];
            palabrasDeRonda.RemoveAt(index1);

            txtPalabrasImpostor.Text = palabraRonda;
            }
                

           

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            txtPalabrasImpostor.Text = "";

        }

        private void Impostor_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPalabrasImpostor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
