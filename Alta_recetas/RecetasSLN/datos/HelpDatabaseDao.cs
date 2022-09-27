using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class HelpDatabaseDao : HelpDatabase
    {
        private static HelpDatabaseDao instance;
        SqlDataReader dr;
        private int id;

        public static HelpDatabaseDao obtenerInstancia()
        {
            if (instance == null)
            {
                instance = new HelpDatabaseDao();
            }
            return instance;
        }

        public SqlCommand Command
        {
            get { return cmd; }
            set { cmd = value; }
        }
        public SqlDataReader Dr
        {
            get { return dr; }
            set { dr = value; }
        }

        public SqlDataReader leerDB(string procedure)
        {
            open();
            cmd.CommandText = procedure;
            dr = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            return dr;
        }

        public DataTable Tabladb(string procedure)
        {
            DataTable table = new DataTable();
            open();
            cmd.CommandText = procedure;
            table.Load(cmd.ExecuteReader());
            cmd.Parameters.Clear();
            return table;

        }
        public void updateDB(string procedure)
        {
            open();
            cmd.CommandText = procedure;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            close();
        }
        public int proximo_id(string procedure)
        {
            open();
            cmd.CommandText = procedure;
            SqlParameter para = new SqlParameter("@next", SqlDbType.Int);
            para.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(para);
            cmd.ExecuteNonQuery();
            id = Convert.ToInt32(para.Value);
            cmd.Parameters.Clear();
            close();
            return id;
        }
        public void insertar_transaccion(Receta f)
        {
            List<Ingredientes> l;
            l = f.RetornarLista();
            SqlTransaction tr = null;
            try
            {
                open();
                tr = conn.BeginTransaction();
                Command.Transaction = tr;
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("@tipo_receta", f.tipo_receta);
                Command.Parameters.AddWithValue("@nombre", f.nombre_receta);
                Command.Parameters.AddWithValue("@cheff", f.cheff);
                Command.CommandText = "sp_insert_receta";
                cmd.ExecuteNonQuery();
                Command.Parameters.Clear(); 
                for(int i = 0; i<l.Count; i++)
                {
                    Command.Transaction = tr;
                    Command.Parameters.AddWithValue("@id_receta", f.id_receta);
                    Command.Parameters.AddWithValue("@id_ingrediente", l[i].id_ingrediente);
                    Command.Parameters.AddWithValue("@cantidad", l[i].cantidad);
                    Command.CommandText = "sp_insert_detalles";
                    cmd.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
                tr.Commit();
            }
            catch (Exception)
            {
                tr.Rollback();
                MessageBox.Show("Error");
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    close();
                }
            }
            
        }

    }
}
