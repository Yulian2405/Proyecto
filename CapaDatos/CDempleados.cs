using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDempleados
    {
        CD_Conexion cd_conexion = new CD_Conexion();

        public List<dynamic> MtdLista()  
        {
            List<dynamic> Lista = new List<dynamic>();
            string QueryLista = "Select Codigousuario, Nombre from tbl_Usuarios";
            SqlCommand cmd = new SqlCommand(QueryLista, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Lista.Add(new
                {
                    Value = reader["Codigousuario"],
                    Text = $"{reader["Codigousuario"]} - {reader["Nombre"]}"
                });
            }

            cd_conexion.MtdCerrarConexion();
            return Lista;
        }
        public DataTable MtdConsultar()
        {
            string QueryConsultar = "Select * from tbl_Empleado";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultar, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }


        public void MtdAgregar(int Codigousuario, string Nombre, int Telefono, string Email,string Cargo, double Salariobase, DateTime Fechaingreso, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregar = "INSERT INTO tbl_Empleado( Codigousuario, Nombre, Telefono, Email, Cargo, Salariobase,Fechaingreso,Estado, UsuarioAuditoria, FechaAuditoria) VALUES (@Codigousuario, @Nombre, @Telefono, @Email, @Cargo, @Salariobase,@Fechaingreso,@Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigousuario", Codigousuario);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salariobase", Salariobase);
            cmd.Parameters.AddWithValue("@Fechaingreso", Fechaingreso);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizar(int Codigoempleado, int Codigousuario, string Nombre, int Telefono, string Email, string Cargo, double Salariobase, DateTime Fechaingreso, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizar = "Update tbl_Empleado set Codigousuario=@Codigousuario, Nombre=@Nombre, Telefono=@Telefono, Email=@Email, Cargo=@Cargo,Salariobase=@Salariobase,Fechaingreso=@Fechaingreso, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where Codigoempleado=@Codigoempleado ";
            SqlCommand cmd = new SqlCommand(QueryActualizar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            cmd.Parameters.AddWithValue("@Codigousuario", Codigousuario);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salariobase", Salariobase);
            cmd.Parameters.AddWithValue("@Fechaingreso", Fechaingreso);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminar(int Codigoempleado)
        {
            string QueryEliminar = "Delete tbl_Empleado where Codigoempleado=@Codigoempleado";
            SqlCommand cmd = new SqlCommand(QueryEliminar, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Codigoempleado", Codigoempleado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
