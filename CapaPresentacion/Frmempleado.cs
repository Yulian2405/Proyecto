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
using CapaLogica;
using ComponentFactory.Krypton.Toolkit;

namespace CapaPresentacion
{
    public partial class Frmempleado : KryptonForm
    {
        CDempleados cd_emplados = new CDempleados();
        CLEmpleados cl_empleados = new CLEmpleados();

        public Frmempleado()
        {
            InitializeComponent();
        }

        private void Frmempleado_Load(object sender, EventArgs e)
        {
            MtdLista();
            MtdConsultar();
        }
        private void MtdLista()
        {
            var Lista = cd_emplados.MtdLista();

            foreach (var Usuario in Lista)
            {
                cboxcodigousuario.Items.Add(Usuario);
            }

            cboxcodigousuario.DisplayMember = "Text";
            cboxcodigousuario.ValueMember = "Value";
        }
        private void MtdConsultar()
        {
            DataTable Dt = cd_emplados.MtdConsultar();
            dvgempleados.DataSource = Dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxcodigousuario.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txttelefono.Text) || string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(cboxcargo.Text) || string.IsNullOrEmpty(txtsalario.Text) || string.IsNullOrEmpty(cboxcargo.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    int CodigoUsuario = (int)((dynamic)cboxcodigousuario.SelectedItem).Value;
                    string Nombre = txtnombre.Text;
                    int Telefono = int.Parse(txttelefono.Text);
                    string Email = txtemail.Text;
                    string Cargo = cboxcargo.Text;
                    double Salariobase = double.Parse(txtsalario.Text);
                    DateTime Fechaingreso = dtpfecha.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cl_empleados.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT\\SQLEXPRESS";

                    cd_emplados.MtdAgregar(CodigoUsuario, Nombre, Telefono, Email, Cargo, Salariobase, Fechaingreso, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Agregado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultar();
                    MtdLimpiarCampos();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dvgempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxcodigousuario.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txttelefono.Text) || string.IsNullOrEmpty(txtemail.Text) ||
                string.IsNullOrEmpty(cboxcargo.Text) || string.IsNullOrEmpty(txtsalario.Text) || string.IsNullOrEmpty(cboxcargo.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Ente la llave primaria se coloca esto
                    int Codigoempleado = (int.Parse(txtccodigoempleado.Text));
                    int Codigousuario = (int)((dynamic)cboxcodigousuario.SelectedItem).Value;
                    string Nombre = txtnombre.Text;
                    int Telefono = int.Parse(txttelefono.Text);
                    string Email = txtemail.Text;
                    string Cargo = cboxcargo.Text;
                    double Salariobase = double.Parse(txtsalario.Text);
                    DateTime Fechaingreso = dtpfecha.Value;
                    string Estado = cboxEstado.Text;
                    DateTime FechaAuditoria = cl_empleados.MtdFechaHoy();
                    string UsuarioAuditoria = "DESKTOP-M60V2AT\\SQLEXPRESS";

                    cd_emplados.MtdActualizar(Codigoempleado, Codigousuario, Nombre, Telefono, Email, Cargo, Salariobase, Fechaingreso, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show(" Actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultar();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtccodigoempleado.Text))
            {
                MessageBox.Show("Favor seleccione para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int Codigoempleado = (int.Parse(txtccodigoempleado.Text));

                    cd_emplados.MtdEliminar(Codigoempleado);
                    MessageBox.Show(" eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultar();
                    MtdLimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
        private void MtdLimpiarCampos()
        {
            txtccodigoempleado.Text = "";
            cboxcodigousuario.SelectedIndex = -1;
            txtnombre.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
            cboxcargo.Text = "";
            txtsalario.Text = "";
            dtpfecha.Text = "";
            cboxEstado.Text = "";
        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonSplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void kryptonHeaderGroup2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboxcodigousuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboxcargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny10_Click(object sender, EventArgs e)
        {

        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny9_Click(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny8_Click(object sender, EventArgs e)
        {

        }

        private void txtccodigoempleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonHeaderGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dvgempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dvgempleados.SelectedRows[0];

            if (FilaSeleccionada.Index == dvgempleados.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                {
                    txtccodigoempleado.Text = dvgempleados.SelectedCells[0].Value.ToString();
                    txtnombre.Text = dvgempleados.SelectedCells[2].Value.ToString();
                    txttelefono.Text = dvgempleados.SelectedCells[3].Value.ToString();
                    txtemail.Text = dvgempleados.SelectedCells[4].Value.ToString();
                    cboxcargo.Text = dvgempleados.SelectedCells[5].Value.ToString();
                    txtsalario.Text = dvgempleados.SelectedCells[6].Value.ToString();
                    dtpfecha.Text = dvgempleados.SelectedCells[7].Value.ToString();
                    cboxcargo.Text = dvgempleados.SelectedCells[8].Value.ToString();


                    int Codigo = (int)dvgempleados.SelectedCells[1].Value;
                    foreach (var Codigosur in cboxcodigousuario.Items)
                    {
                        if (((dynamic)Codigosur).Value == Codigo)
                        {
                            cboxcodigousuario.SelectedItem = Codigosur;

                        }
                    }

                }
            }
        }
    }
}
