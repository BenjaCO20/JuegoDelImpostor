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
    public partial class ImpostorLauncher : Form

    {
        private List<string> palabras = new List<string>();
        private decimal impostores;
        private decimal jugadores;

        public ImpostorLauncher()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.impostores = cantImpostor.Value;
            this.jugadores = cantJug.Value;

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Impostor))
                {
                    MessageBox.Show("Esta ventana ya esta abierta, porfavor termine de trabajar alli.");
                    return;
                }

            }
            decimal cantidadCorrecta = cantJug.Value * 5;
            if (cantImpostor.Value == 0 && palabras.Count <= 5 && cantJug.Value == 0)

            {
                MessageBox.Show("Porfavor, seleccione una cantidad de impostores y jugadores mayor a 0 " +
                    "y una cantidad de palabras correcta");

            }

            else if (cantImpostor.Value == 0)
            { MessageBox.Show("Porfavor, seleccione una cantidad de impostores mayor a 0"); }
            else if (cantJug.Value == 0)
            { MessageBox.Show("Porfavor, seleccione una cantidad de jugadores mayor a 0"); }

            else if (palabras.Count <= 5)
            { MessageBox.Show("Porfavor, ingrese una cantidad de palabras correcta"); }


            else {
                Impostor ventana = new Impostor(palabras,impostores,jugadores);
                ventana.Show();
                    }

                
        }

        private void ImpostorPrincpal_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPalabras_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Impostor))
                {
                    MessageBox.Show("Esta ventana ya esta abierta, porfavor termine de trabajar alli.");
                    return;
                }
            }



            string palabra = txtPalabras.Text;

            if (string.IsNullOrEmpty(palabra) == false )
            { 
                palabra = palabra.Trim();       
                palabras.Add(palabra); 
            
            }
            
            this.txtPalabras.Text = "";

            



        }

        private void btnAgregarPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAgregarPalabra_Click (sender, e);
        }

        private void lblCantJug_Click(object sender, EventArgs e)
        {

        }
    }
}
