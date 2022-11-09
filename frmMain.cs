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
        public int NumeroRepuesto;
        public float PrecioRepuesto;
        public string MarcaRepuesto;
        public string OrigenRepuesto;
        

        public struct DatosRepuestos
        {
            public string MarcaRepuesto;
            public string OrigenRepuesto;
        }
        public string[] vecRepuestos = new string[3];
        public int indice = 0;
        

        public frmMain()
        {
            InitializeComponent();
        }

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
            Repuestos.Text = Convert.ToString(vecRepuestos);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            //lstMarca.Items.Clear();
            //for (int indice = 0; indice < vecRepuestos.Length; indice++)
            //{
            //  lstMarca.Items.Add(vecRepuestos[indice]);
            //    MessageBox.Show("Se registró");
            //}

            //if (indice > vecRepuestos.Length)
            //{
            //    MessageBox.Show("Registro lleno");
            //}

            //while(indice <= vecRepuestos.Length)
            //{
            //    vecRepuestos[indice] = lstMarca.Text;
            //    indice++;
            //    MessageBox.Show("Registrado");
            //    lstMarca.Items.Clear();


            //    if (indice > vecRepuestos.Length)
            //    {
            //        MessageBox.Show("Registro lleno");
            //    }
            
            
        }
    }
}
