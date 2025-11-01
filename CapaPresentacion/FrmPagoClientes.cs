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
    public partial class FrmPagoClientes : Form
    {
        CDpagosclientes objPagos = new CDpagosclientes();
        public FrmPagoClientes()
        {
            InitializeComponent();
        }

        private void FrmPagoClientes_Load(object sender, EventArgs e)
        {
            MtdCargarPagosClientes();
            MtdCargarEnvios();
        }

        private void MtdCargarPagosClientes()
        {
            DataTable dt = objPagos.MtdConsultarCompras();
            dgvPagosClientes.DataSource = dt;
        }

        private void MtdCargarEnvios()
        {
            cboxCodigoEnvio.DataSource = objPagos.MtdConsultarEnvios();
            cboxCodigoEnvio.DisplayMember = "Text";
            cboxCodigoEnvio.ValueMember = "Value";
            cboxCodigoEnvio.SelectedIndex = -1;
        }
        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            txtReferenciaPago.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                objPagos.MtdAgregarPagoClientes(
                    int.Parse(txtCodigoPago.Text),
                    Convert.ToInt32(cboxCodigoEnvio.SelectedValue),
                    dtpFechaPago.Value,
                    decimal.Parse(txtMonto.Text),
                    cboxMetodoPago.Text,
                    txtReferenciaPago.Text,
                    cboxEstado.Text
                );

                MessageBox.Show("Pago agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdCargarPagosClientes();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el pago: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                objPagos.MtdEditarPagosClientes(
                    int.Parse(txtCodigoPago.Text),
                    Convert.ToInt32(cboxCodigoEnvio.SelectedValue),
                    dtpFechaPago.Value,
                    decimal.Parse(txtMonto.Text),
                    cboxMetodoPago.Text,
                    txtReferenciaPago.Text,
                    cboxEstado.Text
                );

                MessageBox.Show("Pago actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdCargarPagosClientes();
                MtdLimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el pago: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoPago = int.Parse(txtCodigoPago.Text);

                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar este pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    objPagos.MtdEliminarPagosClientes(codigoPago);
                    MessageBox.Show("Pago eliminado correctamente 🗑️", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdCargarPagosClientes();
                    MtdLimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el pago: " + ex.Message);
            }
        }

        private void dgvPagosClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvPagosClientes.Rows[e.RowIndex];

                txtCodigoPago.Text = fila.Cells["CodigoPago"].Value.ToString();
                cboxCodigoEnvio.SelectedValue = fila.Cells["CodigoEnvio"].Value;
                dtpFechaPago.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                txtMonto.Text = fila.Cells["Monto"].Value.ToString();
                cboxMetodoPago.Text = fila.Cells["MetodoPago"].Value.ToString();
                txtReferenciaPago.Text = fila.Cells["ReferenciaPago"].Value.ToString();
                cboxEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MtdLimpiarCampos()
        {
            txtCodigoPago.Clear();
            txtMonto.Clear();
            txtReferenciaPago.Clear();


            if (cboxCodigoEnvio.Items.Count > 0)
                cboxCodigoEnvio.SelectedIndex = -1;

            if (cboxMetodoPago.Items.Count > 0)
                cboxMetodoPago.SelectedIndex = -1;

            if (cboxEstado.Items.Count > 0)
                cboxEstado.SelectedIndex = -1;


            dtpFechaPago.Value = DateTime.Now;

        }
    }
}
