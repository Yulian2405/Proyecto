using CapaDatos;
using CapaLogica;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace CapaPresentacion
{
    public partial class FrmPagoPlanilla : KryptonForm
    {   CDPagoPlanilla cd_Pagoplanilla = new CDPagoPlanilla();
        CLPagoPlanilla cl_Pagoplanilla = new CLPagoPlanilla();
        public FrmPagoPlanilla()
        {
            InitializeComponent();
        }
        private void MtdConsultar()
        {
            DataTable DT = cd_Pagoplanilla.MtdConsultaDatosTablaPlanilla();
            dgvPagoPlanilla.DataSource = DT;


        }
        public void MtdMostrarPlanillasDGV()
        {
            DataTable dtPlanillas = new DataTable();
            dgvPagoPlanilla.DataSource = cd_Pagoplanilla.MtdConsultaDatosTablaPlanilla();
        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPagoPlanilla_Load(object sender, EventArgs e)
        {
            MtdMostrarListaEmpleados();
            MtdConsultar();

        }


        private void MtdMostrarListaEmpleados()
        {
            var ListaEmpleado = cd_Pagoplanilla.MtdListaCodigoEmpleado();
            cboxCodigoEmpleado.Items.Clear();

            foreach (var Empleados in ListaEmpleado)
            {
                cboxCodigoEmpleado.Items.Add(Empleados);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        private void cboxCodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que haya selección
            if (cboxCodigoEmpleado.SelectedItem == null)
                return;

            // Salario Base Empleado
            var SelectedEmpleado = (dynamic)cboxCodigoEmpleado.SelectedItem;
            int codigoTipoPago = (int)SelectedEmpleado.GetType().GetProperty("Value").GetValue(SelectedEmpleado, null);
            double SalarioBase = cd_Pagoplanilla.MtdConsultaSalarioBase(codigoTipoPago);
            txtSalarioBase.Text = SalarioBase.ToString("c");

            // Bono Empleado
            double Bono = cl_Pagoplanilla.MtdBonoEmpleado(SalarioBase);
            txtBonos.Text = Bono.ToString("c");

            // Descuentos Empleado
            double Igss = cl_Pagoplanilla.MtdIgssEmpleado(SalarioBase);
            double Isr = cl_Pagoplanilla.MtdISREmpleado(SalarioBase);
            double Descuentos = Igss + Isr;
            txtDescuentos.Text = Descuentos.ToString("c");

            // Pago Final Empleado
            double PagoFinal = cl_Pagoplanilla.MtdPagoFinalEmpleado(SalarioBase, Bono, Igss, Isr);
            txtPagoTotal.Text = PagoFinal.ToString("c");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) ||
                string.IsNullOrEmpty(txtAño.Text) ||
                string.IsNullOrEmpty(txtMes.Text) ||
                string.IsNullOrEmpty(txtSalarioBase.Text) ||
                string.IsNullOrEmpty(txtHorasExtras.Text) ||
                string.IsNullOrEmpty(txtBonos.Text) ||
                string.IsNullOrEmpty(txtDescuentos.Text) ||
                string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Capturar datos del formulario
                int CodigoEmpleado = int.Parse(cboxCodigoEmpleado.SelectedItem.ToString());
                int Año = int.Parse(txtAño.Text);
                int Mes = int.Parse(txtMes.Text);
                decimal SalarioBase = decimal.Parse(txtSalarioBase.Text);
                decimal HorasExtras = decimal.Parse(txtHorasExtras.Text);
                decimal Bonos = decimal.Parse(txtBonos.Text);
                decimal Descuentos = decimal.Parse(txtDescuentos.Text);
                string Estado = cboxEstado.Text;

                // Calcular automáticamente el PagoTotal
                decimal PagoTotal = SalarioBase + HorasExtras + Bonos - Descuentos;
                txtPagoTotal.Text = PagoTotal.ToString("F2"); // Mostrarlo en el textbox con 2 decimales

                // Llamar al método para agregar a la base de datos
                cd_Pagoplanilla.Mtdagregar(CodigoEmpleado, Año, Mes, SalarioBase, HorasExtras, Bonos, Descuentos, PagoTotal, Estado);

                MessageBox.Show("Registro agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar y limpiar la pantalla
                MtdConsultar();
                MtdLimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Revise que los campos numéricos estén correctamente llenos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MtdLimpiarCampos()
        {
            txtCodigoPlanilla.Text = "";
            cboxCodigoEmpleado.SelectedIndex = -1;
            txtAño.Text = "";
            txtMes.Text = "";
            txtSalarioBase.Text = "";
            txtHorasExtras.Text = "";
            txtBonos.Text = "";
            txtDescuentos.Text = "";
            txtPagoTotal.Text = "";
            cboxEstado.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(txtSalarioBase.Text) ||
                string.IsNullOrEmpty(txtBonos.Text) || string.IsNullOrEmpty(txtDescuentos.Text) ||
                string.IsNullOrEmpty(txtPagoTotal.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    // Codigo Planilla
                    int CodigoPlanilla = int.Parse(txtCodigoPlanilla.Text);

                    // Codigo Empleado
                    var SelectedEmpleado = (dynamic)cboxCodigoEmpleado.SelectedItem;
                    int CodigoEmpleado = (int)SelectedEmpleado.GetType().GetProperty("Value").GetValue(SelectedEmpleado, null);

                    // Año y Mes
                    int Año = int.Parse(txtAño.Text);
                    int Mes = int.Parse(txtMes.Text);

                    // Horas Extras
                    double HorasExtras = double.Parse(txtHorasExtras.Text);

                    // Salario Base
                    double SalarioBase = double.Parse(txtSalarioBase.Text);

                    // Bonos y Descuentos
                    double Bonos = double.Parse(txtBonos.Text);
                    double Descuentos = double.Parse(txtDescuentos.Text);

                    // Pago Total
                    double PagoTotal = double.Parse(txtPagoTotal.Text);

                    // Estado
                    string Estado = cboxEstado.Text;

                    // Enviar datos al método de la capa de datos
                    cd_Pagoplanilla.MtdEditarPlanilla(CodigoPlanilla, CodigoEmpleado, Año, Mes, SalarioBase, HorasExtras, Bonos, Descuentos, PagoTotal, Estado);

                    MessageBox.Show("Planilla actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdMostrarPlanillasDGV();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR CRITICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void dgvPagoPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvPagoPlanilla.SelectedRows[0];


            if (FilaSeleccionada.Index == dgvPagoPlanilla.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila valida, por favor,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                // Codigo Planilla
                txtCodigoPlanilla.Text = dgvPagoPlanilla.SelectedCells[0].Value?.ToString() ?? "";

                // Codigo Empleado Foreign Key
                int CodigoEmpleadoSeleccionado = 0;
                if (int.TryParse(dgvPagoPlanilla.CurrentRow.Cells[1].Value?.ToString(), out int tempCodigoEmpleado))
                {
                    CodigoEmpleadoSeleccionado = tempCodigoEmpleado;
                }
                dynamic Empleado = cd_Pagoplanilla.MtdConsultaEmpleadoDgv(CodigoEmpleadoSeleccionado)[0];
                cboxCodigoEmpleado.Text = Empleado.GetType().GetProperty("Text").GetValue(Empleado, null)?.ToString() ?? "";

                // Año y Mes
                txtAño.Text = FilaSeleccionada.Cells[2].Value?.ToString() ?? "";
                txtMes.Text = FilaSeleccionada.Cells[3].Value?.ToString() ?? "";

                // SalarioBase
                if (double.TryParse(dgvPagoPlanilla.CurrentRow.Cells[3].Value?.ToString(), out double salarioBase))
                    txtSalarioBase.Text = salarioBase.ToString("c");
                else
                    txtSalarioBase.Text = "0.00";

                // HorasExtras
                txtHorasExtras.Text = FilaSeleccionada.Cells[5].Value?.ToString() ?? "";

                // Bonos
                if (double.TryParse(dgvPagoPlanilla.CurrentRow.Cells[4].Value?.ToString(), out double bonos))
                    txtBonos.Text = bonos.ToString("c");
                else
                    txtBonos.Text = "0.00";

                // Descuentos
                if (double.TryParse(dgvPagoPlanilla.CurrentRow.Cells[5].Value?.ToString(), out double descuentos))
                    txtDescuentos.Text = descuentos.ToString("c");
                else
                    txtDescuentos.Text = "0.00";

                // PagoTotal
                if (double.TryParse(dgvPagoPlanilla.CurrentRow.Cells[6].Value?.ToString(), out double pagoTotal))
                    txtPagoTotal.Text = pagoTotal.ToString("c");
                else
                    txtPagoTotal.Text = "0.00";

                // Estado
                cboxEstado.Text = FilaSeleccionada.Cells[9].Value?.ToString() ?? "";
            }

        }





    }
    }
    
    
   

