using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDPagoPlanilla
    {
        CD_Conexion conn= new CD_Conexion();
        public List<dynamic> MtdListaCodigoEmpleado()
        {
            List<dynamic> ListaEmpleados= new List<dynamic>();
            string QueryListaEmpleados = "SELECT Codigoempleado, Nombre FROM tbl_Empleado";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, conn.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaEmpleados.Add(new
                {
                    Value = reader["Codigoempleado"],
                    Text = $"{reader["Codigoempleado"]} - {reader["Nombre"]}"
                });
            }

            reader.Close();
            conn.MtdCerrarConexion();

            return ListaEmpleados;
        }

        public DataTable MtdConsultaDatosTablaPlanilla()
        {
            string QueryConsultaPlanillas = "Select * from tbl_Pagoplanilla;";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultaPlanillas, conn.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            conn.MtdCerrarConexion();
            return Dt;
        }

        public void Mtdagregar(int CodigoEmpleado, int Año, int Mes, decimal SalarioBase, decimal HorasExtras, decimal Bonos, decimal Descuentos, decimal PagoTotal,string Estado)
        {
            string Queryagregar = "Insert into tbl_Pagoplanilla (CodigoEmpleado, Año, Mes, SalarioBase, HorasExtras, Bonos,Descuentos, PagoTotal, Estado) values (@CodigoEmpleado, @Año, @Mes, @SalarioBase, @HorasExtras, @Bonos, @Descuentos, @PagoTotal, @Estado)";
            SqlCommand cmd = new SqlCommand(Queryagregar, conn.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@Año", Año);
            cmd.Parameters.AddWithValue("@Mes", Mes);
            cmd.Parameters.AddWithValue("@SalarioBase", SalarioBase);
            cmd.Parameters.AddWithValue("@HorasExtras", HorasExtras);
            cmd.Parameters.AddWithValue("@Bonos", Bonos);
            cmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            cmd.Parameters.AddWithValue("@PagoTotal", PagoTotal);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            conn.MtdCerrarConexion();
        }
        // Metodo que muestra en el combobox el Empleado selecciona en el DataGridView
        public List<dynamic> MtdConsultaEmpleadoDgv(int Codigoempleado)
        {
            List<dynamic> ListaDgv = new List<dynamic>();
            string QueryListaDgv = "Select  Codigoempleado, Nombre from tbl_Empleado where Codigoempleado=@Codigoempleado;";
            SqlCommand cmd = new SqlCommand(QueryListaDgv, conn.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaDgv.Add(new
                {
                    Value = Convert.ToInt32(reader["Codigoempleado"]),
                    Text = $"{reader["Codigoempleado"]} - {reader["Nombre"]}"
                });
            }

            conn.MtdCerrarConexion();
            return ListaDgv;
        }

        // Metodo que recupera el SalarioBase del emepleado seleccionado
        public double MtdConsultaSalarioBase(int Codigoempleado)
        {
            double SalarioBase = 0;

            string QueryConsultarSalarioBase = "Select SalarioBase from tbl_Empleado where Codigoempleado=@Codigoempleado;";
            SqlCommand CommandSalarioBase = new SqlCommand(QueryConsultarSalarioBase, conn.MtdAbrirConexion());
            CommandSalarioBase.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            SqlDataReader reader = CommandSalarioBase.ExecuteReader();

            if (reader.Read())
            {
                SalarioBase = double.Parse(reader["SalarioBase"].ToString());
            }
            else
            {
                SalarioBase = 0;
            }

            conn.MtdCerrarConexion();
            return SalarioBase;
        }
        public void MtdAgregarPagoPlanilla(int Codigoempleado, int Año, int Mes, decimal Salariobase, decimal Horasextras,decimal Bonos,decimal Descuentos, decimal Pagototal, string Estado)
        {
            string QueryAgregar = "Update tbl_empleados set Codigoempleado=@Codigoempleado, Año=@Año, Mes=@Mes, Salariobase=@Salariobase, Horasextras=@Horasextras, Bonos=@Bonos,Descuentos=@Descuentos,Pagototal=@Pagototal, Estado=@Estado  where Codigosucursal=@Codigosucursal;";
            SqlCommand Sqlcmd = new SqlCommand(QueryAgregar, conn.MtdAbrirConexion());
            Sqlcmd.Parameters.AddWithValue("@CodigoEmpleado", Codigoempleado);
            Sqlcmd.Parameters.AddWithValue("@Año", Año);
            Sqlcmd.Parameters.AddWithValue("@Mes", Mes);
            Sqlcmd.Parameters.AddWithValue("@Horasextras", Salariobase);
            Sqlcmd.Parameters.AddWithValue("@Bonos", Bonos);
            Sqlcmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            Sqlcmd.Parameters.AddWithValue("@Pagototal", Pagototal);
            Sqlcmd.Parameters.AddWithValue("@Estado", Estado);
            Sqlcmd.ExecuteNonQuery();
            conn.MtdCerrarConexion();

        }

        public void MtdEditarPlanilla(int Codigoplanilla, int Codigoempleado, int Año, int Mes, double Salariobase, double Horasextras, double Bonos, double Descuentos, double Pagototal, string Estado)

        {
            string QueryEditar = "UPDATE tbl_Planillas " +
                                 "SET CodigoEmpleado=@CodigoEmpleado, Año=@Año, Mes=@Mes, Salariobase=@Salariobase, " +
                                 "Horasextras=@Horasextras, Bonos=@Bonos, Descuentos=@Descuentos, Pagototal=@Pagototal, Estado=@Estado " +
                                 "WHERE Codigoplanilla=@Codigoplanilla;";

            SqlCommand Sqlcmd = new SqlCommand(QueryEditar, conn.MtdAbrirConexion());
            Sqlcmd.Parameters.AddWithValue("@Codigoplanilla", Codigoplanilla);
            Sqlcmd.Parameters.AddWithValue("@CodigoEmpleado", Codigoempleado);
            Sqlcmd.Parameters.AddWithValue("@Año", Año);
            Sqlcmd.Parameters.AddWithValue("@Mes", Mes);
            Sqlcmd.Parameters.AddWithValue("@Salariobase", Salariobase);
            Sqlcmd.Parameters.AddWithValue("@Horasextras", Horasextras);
            Sqlcmd.Parameters.AddWithValue("@Bonos", Bonos);
            Sqlcmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            Sqlcmd.Parameters.AddWithValue("@Pagototal", Pagototal);
            Sqlcmd.Parameters.AddWithValue("@Estado", Estado);
            Sqlcmd.ExecuteNonQuery();
            conn.MtdCerrarConexion();
        }


        public void MtdEliminarPlanilla(int CodigoPlanilla)
        {
            string QueryAgregar = "Delete tbl_Pagoplanilla where CodigoPlanilla=@CodigoPlanilla";
            SqlCommand Sqlcmd = new SqlCommand(QueryAgregar, conn.MtdAbrirConexion());
            Sqlcmd.Parameters.AddWithValue("@CodigoPlanilla", CodigoPlanilla);
            Sqlcmd.ExecuteNonQuery();
            conn.MtdCerrarConexion();
        }


    }
}
