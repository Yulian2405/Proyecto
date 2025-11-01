using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        CDclientes cd_clientes = new CDclientes();

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MtdMostrarClientesDGV();
        }

        private void LimpiarCampos()
        {
            txtCodigoCliente.Clear();
            txtNombre.Clear();
            txtNit.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cboxEstado.Text = " ";
            cboxDepartamento.SelectedIndex = -1;
            cboxTipoCliente.SelectedIndex = -1;
            cboxTipoCliente.SelectedIndex = -1;
            dgvClientes.ClearSelection();
        }

        public void MtdMostrarClientesDGV()
        {
            DataTable dtClientes = new DataTable();
            dgvClientes.DataSource = cd_clientes.MtdConsultarClientes();
        }

        private void txtDpi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpecAny12_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
        }

        private void buttonSpecAny11_Click(object sender, EventArgs e)
        {
            txtNit.Clear();
        }

        private void buttonSpecAny8_Click(object sender, EventArgs e)
        {
            txtTelefono.Clear();
        }

        private void buttonSpecAny10_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (
               string.IsNullOrEmpty(txtNombre.Text) ||
               string.IsNullOrEmpty(txtNit.Text) ||
               string.IsNullOrEmpty(txtDireccion.Text) ||
               string.IsNullOrEmpty(txtTelefono.Text) ||
               string.IsNullOrEmpty(cboxDepartamento.Text) ||
               string.IsNullOrEmpty(cboxTipoCliente.Text) ||
               string.IsNullOrEmpty(cboxEstado.Text)
               )
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Capturar datos del formulario
                string Nombre = txtNombre.Text;
                string NIT = txtNit.Text;
                string Direccion = txtDireccion.Text;
                int Telefono = Convert.ToInt32(txtTelefono.Text);
                string Departamento = cboxDepartamento.Text;
                string TipoCliente = cboxTipoCliente.Text;
                string Estado = cboxEstado.Text;

                // Enviar datos a la capa de datos
                try
                {
                    cd_clientes.MtdAgregarClientes(Nombre, NIT, Telefono, Direccion, Departamento, TipoCliente, Estado);
                    MessageBox.Show("Cliente agregado correctamente.", "Éxitooooo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MtdMostrarClientesDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];
                txtCodigoCliente.Text = row.Cells["CodigoCliente"].Value.ToString();
                txtNombre.Text = row.Cells["NIT"].Value.ToString();
                txtNit.Text= row.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                cboxDepartamento.Text = row.Cells["Departamento"].Value.ToString();
                cboxTipoCliente.Text = row.Cells["TipoCliente"].Value.ToString();
                cboxEstado.Text = row.Cells["Estado"].Value.ToString();
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtCodigoCliente.Text) ||
              string.IsNullOrEmpty(txtNombre.Text) ||
              string.IsNullOrEmpty(txtNit.Text) ||
              string.IsNullOrEmpty(txtDireccion.Text) ||
              string.IsNullOrEmpty(txtTelefono.Text) ||
              string.IsNullOrEmpty(cboxDepartamento.Text) ||
              string.IsNullOrEmpty(cboxTipoCliente.Text) ||
              string.IsNullOrEmpty(cboxEstado.Text)
              )
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Capturar datos del formulario
                int CodigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
                string Nombre = txtNombre.Text;
                string nit = txtNit.Text;
                string Direccion = txtDireccion.Text;
                int Telefono = Convert.ToInt32(txtTelefono.Text);
                string Departamento = cboxDepartamento.Text;
                string TipoCliente = cboxTipoCliente.Text;
                string Estado = cboxEstado.Text;

                // Enviar datos a la capa de datos
                try
                {
                    cd_clientes.MtdEditarClientes(CodigoCliente, Nombre, nit, Telefono, Direccion, Departamento, TipoCliente, Estado);
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxitooooo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MtdMostrarClientesDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);

            // Verificar si tiene ventas
            if (cd_clientes.MtdClienteTieneVentas(codigoCliente))
            {
                MessageBox.Show("No se puede eliminar este cliente porque tiene ventas asociadas.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar eliminación
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este cliente?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    cd_clientes.MtdEliminarClientes(codigoCliente);
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    MtdMostrarClientesDGV(); // refresca el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
