using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmMain : Form
    {
        public struct struRepuestos
        {
            public string Marca;
            public string origen;
            public int Numero;
            public float Precio;
            public string Descripcion;
        }
        struRepuestos[] vec = new struRepuestos[100];
     
        public frmMain()
        {
            InitializeComponent();
        }
        int contador = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            rtbRepuestos.Text = "";

            for (int indice = 0; indice < vec.Length; indice++)
            {
                if (vec[indice].Marca == lstMarca.Text)
                {
                    if (optImportado.Checked)
                    {
                        if (vec[indice].origen == "I")
                        {
                            rtbRepuestos.Text = rtbRepuestos.Text + "Numero: " + vec[indice].Numero.ToString() + " " + "Precio: " + vec[indice].Precio.ToString() + " " + "Descripcion" + " " + vec[indice].Descripcion.ToString() + "\n";

                        }
                    }
                    if (optNacional.Checked)
                    {
                        if (vec[indice].origen == "N")
                        {
                            rtbRepuestos.Text = rtbRepuestos.Text + "Numero: " + vec[indice].Numero.ToString() + " " + "Precio: " + vec[indice].Precio.ToString() + " " + "Descripcion" + " " + vec[indice].Descripcion.ToString() + "\n";

                        }
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (contador < vec.Length)
            {
                vec[contador].Marca = lstMarca.Text;
                vec[contador].origen = lstOrigen.Text;
                vec[contador].Numero = Convert.ToInt32(txtNumero.Text);
                vec[contador].Precio = float.Parse(txtPrecio.Text);
                vec[contador].Descripcion = rtbDescripcion.Text;

                contador++;
                Limpiador();


            }

        }
        public void Limpiador()
        {
            lstMarca.SelectedIndex = -1;
            lstOrigen.SelectedIndex = -1;
            txtNumero.Text = "";
            txtPrecio.Text = "";
            rtbDescripcion.Text = "";
            lstMarca.Focus();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; 
            }
        }
    }
    
}
