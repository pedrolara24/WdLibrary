using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wLibreria2
/*
 * <summary>
 * Biblioteca
 * Emmanuel cañas,Jhohan Esteban,Kevin Rojas
 * 26/04/2022
 * */
{
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
            CmbNombreLibro.Items.Add("Don Quijote De La Mancha");
            CmbNombreLibro.Items.Add("Cien Años De Soledad");
            CmbNombreLibro.Items.Add("La Biblia");
            CmbNombreLibro.Items.Add("El Codigó Da Vinci");
            CmbNombreLibro.Items.Add("El Señor de los Anillos");
            CmbSexo.Items.Add("Masculino");
            CmbSexo.Items.Add("Femenino");
            CmbSexo.Items.Add("Otro");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            DialogResult Resultado = MessageBox.Show("¿Deseas abandonar nuestro programa UnU ?", "Confirmacion",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        private void frmCasadeCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Deseas abandonar nuestro programa UnU ?", "Confirmacion",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


        private void GrpValor_Enter(object sender, EventArgs e)

        {
            if (rbtPrestamo.Checked == true)
            {
                GrpValor.Enabled = false;
                if (rbtVenta.Checked == true)
                {
                    GrpValor.Enabled = true;
                }
            }
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHijo formhijo = new FrmHijo();
            formhijo.MdiParent = this;
            formhijo.Show();
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            {
                #region[Limpiar El Formulario]
                try
                {
                    txtNombre.Text = "";
                    txt1.Text = "";
                    txtCedula.Text = "";
                    txtDireccion.Text = "";
                    txtEdad.Text = "";
                    txtEmail.Text = "";
                    txtIVA.Text = "";
                    txtTelefono.Text = "";
                    txtValorLibro.Text = "";
                    txtValorPagar.Text = "";
                    TxtApellido.Text = "";
                    rbtPrestamo.Enabled = true;
                    rbtVenta.Enabled = true;
                    GrpValor.Enabled = true;
                    GrpLibros.Enabled = true;
                    #endregion
                }

                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message, "error");
                }
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            {
                #region[Guardar]
                try
                {
                    txtNombre.Text = "";
                    txt1.Text = "";
                    txtCedula.Text = "";
                    txtDireccion.Text = "";
                    txtEdad.Text = "";
                    txtEmail.Text = "";
                    txtIVA.Text = "";
                    txtTelefono.Text = "";
                    txtValorLibro.Text = "";
                    txtValorPagar.Text = "";
                    TxtApellido.Text = "";
                    rbtPrestamo.Enabled = true;
                    rbtVenta.Enabled = true;
                    GrpValor.Enabled = true;
                    GrpLibros.Enabled = true;
                    #endregion
                }

                catch (Exception Err)
                {
                    MessageBox.Show(Err.Message, "error");
                }
            }
        }

        private void txtValorPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double iva = 0;
            double juan = 0;
            iva = Convert.ToDouble(txtValorLibro.Text) * 0.19;
            juan = iva + Convert.ToDouble(txtValorLibro.Text);
            txtValorPagar.Text = Convert.ToString(juan);
            txtIVA.Text = Convert.ToString(iva);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveFileDialog.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = SaveFileDialog.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);
                    foreach (string linea in txt1.Lines)
                    {
                        wrtGuardar.WriteLine(linea);
                    }
                    wrtGuardar.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}





