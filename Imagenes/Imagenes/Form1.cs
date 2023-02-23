using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagenes
{
    public partial class Estaciones_del_año : Form
    {
        public Estaciones_del_año()
        {
            InitializeComponent();
        }

        private void pcbInicio_Click(object sender, EventArgs e)
        {

        }

        private void ptbOtoño_Click(object sender, EventArgs e)
        {

        }

        private void ptbInvierno_Click(object sender, EventArgs e)
        {

        }

        private void btnMiFoto_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Mi foto";
            ptbInvierno.Visible = false;
            ptbMiFoto.Visible = true;
            ptbOtoño.Visible = false;
            pcbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.btnInicio.Focus();
            }
        }

        public void btnPrimavera_Click(object sender, EventArgs e)
        {

            lblPrincipal.Text = "Primavera";
            ptbInvierno.Visible = false;
            ptbMiFoto.Visible = false;
            ptbOtoño.Visible = false;
            pcbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = true;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = true;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Estaciones del año";
            ptbInvierno.Visible = false;
            ptbMiFoto.Visible = false;
            ptbOtoño.Visible = false;
            pcbInicio.Visible = true;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = true;

        }

        private void btnVerano_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Verano";
            ptbInvierno.Visible = false;
            ptbMiFoto.Visible = false;
            ptbOtoño.Visible = false;
            pcbInicio.Visible = false;
            ptbVerano.Visible = true;
            ptbPrimavera.Visible = false;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
        }

        private void btnInvierno_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Invierno";
            ptbInvierno.Visible = true;
            ptbMiFoto.Visible = false;
            ptbOtoño.Visible = false;
            pcbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
        }

        private void btnOtoño_Click(object sender, EventArgs e)
        {
            lblPrincipal.Text = "Otoño";
            ptbInvierno.Visible = false;
            ptbMiFoto.Visible = false;
            ptbOtoño.Visible = true;
            pcbInicio.Visible = false;
            ptbVerano.Visible = false;
            ptbPrimavera.Visible = false;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
        }
        

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (lblPrincipal.Text == "Estaciones del año")
            {
                lblPrincipal.Text = "Primavera";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = true;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = true;
            }
            else
                if (lblPrincipal.Text =="Primavera") {
                lblPrincipal.Text = "Verano";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = true;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else 
                if (lblPrincipal.Text== "Verano")
            {
                lblPrincipal.Text = "Invierno";
                ptbInvierno.Visible = true;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else
                if (lblPrincipal.Text == "Invierno")
            {
                lblPrincipal.Text = "Otoño";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = true;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else 
                if (lblPrincipal.Text == "Otoño")
            {
                lblPrincipal.Text = "Mi foto";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = true;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = false;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (lblPrincipal.Text == "Mi foto")
            {
                lblPrincipal.Text = "Otoño";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = true;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else 
                if (lblPrincipal.Text == "Otoño")
            {
                lblPrincipal.Text = "Invierno";
                ptbInvierno.Visible = true;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else
                if (lblPrincipal.Text == "Invierno")
            {
                lblPrincipal.Text = "Verano";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = true;
                ptbPrimavera.Visible = false;
                btnAnterior.Enabled = true;
                btnSiguiente.Enabled = true;
            }
            else
                if (lblPrincipal.Text == "Verano")
            {
                lblPrincipal.Text = "Primavera";
                ptbInvierno.Visible = false;
                ptbMiFoto.Visible = false;
                ptbOtoño.Visible = false;
                pcbInicio.Visible = false;
                ptbVerano.Visible = false;
                ptbPrimavera.Visible = true;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = true;
            }

        }
    }
}
