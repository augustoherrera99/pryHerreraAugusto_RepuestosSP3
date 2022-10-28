using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryHerreraAugusto_RepuestosSP3.frmAutopartes;

namespace pryHerreraAugusto_RepuestosSP3
{
    public partial class frmAutopartes : Form
    {
        public frmAutopartes()
        {
            InitializeComponent();
        }

        public struct REGISTRO
        {
            public string Marca;
            public int NroRepuesto;
            public float Precio;
            public string Origen;
            public string Descripcion;
        }

        REGISTRO[] Registro;
        public int MAX = 100;
        public int Cantidad = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtNroRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente valores númericos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente valores númericos.","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAutopartes_Load(object sender, EventArgs e)
        {
            Registro = new REGISTRO[MAX];
            Cantidad = 0;

            limpiarControles();
            cmbMarca2.SelectedIndex = -1;
            optImportado2.Checked = false;
            optNacional2.Checked = false;
            lstBusqueda.SelectedIndex = -1;
        }

        private void limpiarControles()
        {
            cmbMarca.SelectedIndex = -1;
            txtNroRepuesto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            optImportado.Checked = false;
            optNacional.Checked = false;
        }
        
        private bool verificarDatos()
        {
            bool resultado = false;

            if (cmbMarca.SelectedIndex != -1 && txtNroRepuesto.Text != "" && txtPrecio.Text != "" && (optImportado.Checked == true || optNacional.Checked == true))
            {
                if (!buscarDatos(int.Parse(txtNroRepuesto.Text)))
                {
                    resultado = true;
                }
                else
                {
                    MessageBox.Show("Número de registro ya ingresado. Intente con otro.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        private bool buscarDatos(int numero)
        {
            bool existe = false;
            int pos = 0;

            while (pos < Cantidad)
            {
                if (numero == Registro[pos].NroRepuesto)
                {
                    existe = true;
                    break;
                }
                pos++;
            }
            return existe;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                Registro[Cantidad].Marca = cmbMarca.Text;
                Registro[Cantidad].NroRepuesto = int.Parse(txtNroRepuesto.Text);
                Registro[Cantidad].Precio = float.Parse(txtPrecio.Text);
                Registro[Cantidad].Descripcion = txtDescripcion.Text;
                if (optImportado.Checked == true)
                {
                    Registro[Cantidad].Origen = "Importado";
                }
                else
                {
                    Registro[Cantidad].Origen = "Nacional";
                }
                Cantidad++;

                MessageBox.Show("¡Registro exitoso!\n\nLe quedan " + (MAX - Cantidad) + " registros disponibles.", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MAX == Cantidad)
                {
                    MessageBox.Show("Se completó la capacidad de carga de datos",
                    "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false;
                }
                limpiarControles();
                mrcConsulta.Enabled = true;
                btnConsultar.Enabled = true;
                btnBorrar.Enabled = true;
                btnBorrarRegistros.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verificarDatosConsulta()
        {
            bool resultado = false;

            if (cmbMarca2.Text != "" || optImportado2.Checked == true || optNacional2.Checked == true)
            {
                resultado = true;
            }
            else
            {
                MessageBox.Show("Debe elegir por lo menos una opción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (verificarDatosConsulta())
            {
                lstBusqueda.Items.Clear();
                bool existeRegistro = false;

                if (cmbMarca2.Text != "")
                {
                    if (optImportado2.Checked == true)
                    {
                        for (int i = 0; i < Cantidad; i++)
                        {
                            if (cmbMarca2.Text == Registro[i].Marca && Registro[i].Origen == "Importado")
                            {
                                existeRegistro = true;
                                lstBusqueda.Items.Add("Nro. Repuesto: " + Registro[i].NroRepuesto.ToString());
                                lstBusqueda.Items.Add("Descripción: " + Registro[i].Descripcion.ToString());
                                lstBusqueda.Items.Add("Precio: " + "$" + Registro[i].Precio.ToString());
                                lstBusqueda.Items.Add("");
                            }
                        }
                    }
                    else if (optNacional2.Checked == true)
                    {
                        for (int i = 0; i < Cantidad; i++)
                        {
                            if (cmbMarca2.Text == Registro[i].Marca && Registro[i].Origen == "Nacional")
                            {
                                existeRegistro = true;
                                lstBusqueda.Items.Add("Nro. Repuesto: " + Registro[i].NroRepuesto.ToString());
                                lstBusqueda.Items.Add("Descripción: " + Registro[i].Descripcion.ToString());
                                lstBusqueda.Items.Add("Precio: " + "$" + Registro[i].Precio.ToString());
                                lstBusqueda.Items.Add("");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Cantidad; i++)
                        {
                            if (cmbMarca2.Text == Registro[i].Marca)
                            {
                                existeRegistro = true;
                                lstBusqueda.Items.Add("Nro. Repuesto: " + Registro[i].NroRepuesto.ToString());
                                lstBusqueda.Items.Add("Descripción: " + Registro[i].Descripcion.ToString());
                                lstBusqueda.Items.Add("Precio: " + "$" + Registro[i].Precio.ToString());
                                lstBusqueda.Items.Add("");
                            }
                        }
                    }

           
                }
                else if (optImportado2.Checked == true)
                {
                    for (int i = 0; i < Cantidad; i++)
                    {
                        if (Registro[i].Origen == "Importado")
                        {
                            existeRegistro = true;
                            lstBusqueda.Items.Add("Nro. Repuesto: " + Registro[i].NroRepuesto.ToString());
                            lstBusqueda.Items.Add("Descripción: " + Registro[i].Descripcion.ToString());
                            lstBusqueda.Items.Add("Precio: " + "$" + Registro[i].Precio.ToString());
                            lstBusqueda.Items.Add("");
                        }
                    }
                }
                else if (optNacional2.Checked == true)
                {
                    for (int i = 0; i < Cantidad; i++)
                    {
                        if (Registro[i].Origen == "Nacional")
                        {
                            existeRegistro = true;
                            lstBusqueda.Items.Add("Nro. Repuesto: " + Registro[i].NroRepuesto.ToString());
                            lstBusqueda.Items.Add("Descripción: " + Registro[i].Descripcion.ToString());
                            lstBusqueda.Items.Add("Precio: " + "$" + Registro[i].Precio.ToString());
                            lstBusqueda.Items.Add("");
                        }
                    }
                }
                if (cmbMarca2.Text != "" || optImportado2.Checked == true || optNacional2.Checked == true)
                {
                    if (existeRegistro == false)
                    {
                        lstBusqueda.Items.Add("No hay registros existentes.");
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cmbMarca2.SelectedIndex = -1;
            optImportado2.Checked = false;
            optNacional2.Checked = false;
            lstBusqueda.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
            cmbMarca2.SelectedIndex = -1;
            optImportado2.Checked = false;
            optNacional2.Checked = false;
            lstBusqueda.Items.Clear();
            mrcConsulta.Enabled = false;
            btnBorrarRegistros.Enabled = false;
            btnConsultar.Enabled = false;
            btnBorrar.Enabled = false;
            cmbMarca.Focus();
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNroRepuesto_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtNroRepuesto_TextChanged(object sender, EventArgs e)
        {
            if (txtNroRepuesto.TextLength == 6)
            {
                MessageBox.Show("Máximo 6 dígitos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.TextLength == 50)
            {
                MessageBox.Show("Máximo 50 carácteres.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void btnBorrarRegistros_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar los " + Cantidad + " registros ingresados hasta el momento?" ,"¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    Array.Clear(Registro, 0, MAX);
                    Cantidad = 0;
                    limpiarControles();
                    MessageBox.Show("Se ha eliminado la totalidad de los registros.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.No:
                    break;
            }

        }
    }
}
