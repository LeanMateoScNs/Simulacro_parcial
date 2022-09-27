using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecetasSLN.datos;
using RecetasSLN.dominio;


namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        Receta receta = new Receta();
        public FrmConsultarRecetas()
        {
            InitializeComponent();
        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            cargarCbo(CboIngrediente,"id_ingrediente", "n_ingrediente", "sp_return_ingredientes");
            cargarCbo(CboTipoIngrediente,"id_tipo", "tipo", "sp_return_tipo_receta");
            lblReceta.Text = "Receta #: " + HelpDatabaseDao.obtenerInstancia().proximo_id("sp_sig_nro_receta");
            lblTipoingrediente.Text = "Total de ingredientes: 0";
        }
        private void cargarCbo(ComboBox cbo, string value, string display, string procedure)
        {
            cbo.DataSource = HelpDatabaseDao.obtenerInstancia().Tabladb(procedure);
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            HelpDatabaseDao.obtenerInstancia().close();
        }
        private bool validar_carga()
        {
            if (txtNombre == null)
            {
                MessageBox.Show("ingrese el nombre de la receta");
                return false;
            }
            else if (txtCheff.Text == null)
            {
                MessageBox.Show("ingrese el nombre del cheff");
                return false;
            }
            return true;
        }
        private bool validar_ingrediente()
        {
            if(nudCantidad.Value == 0)
            {
                MessageBox.Show("Debe ingresar la cantidad ");
                return false;
            }
            return true;
        }
        private void Agregar_grilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i<receta.RetornarLista().Count; ++i)
            {
                dgv.Rows.Add(receta.RetornarLista()[i].ingrediente, receta.RetornarLista()[i].cantidad);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar_ingrediente())
            {
                Ingredientes i = new Ingredientes();
                i.id_ingrediente = CboIngrediente.SelectedIndex + 1;
                i.ingrediente = CboIngrediente.Text;
                i.cantidad = Convert.ToInt32(nudCantidad.Value);
                if (receta.buscar_list(i))
                {
                    receta.actualizar_lista(i);

                }
                else
                {
                    receta.cargar_lista(i);
                }
                Agregar_grilla(dgvIngredientes);
                txtCantIngredientes.Text = "Total de ingredientes :" + receta.RetornarLista().Count;
            }

        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            receta.eliminar(dgvIngredientes.CurrentRow.Index);
            dgvIngredientes.Rows.Remove(dgvIngredientes.CurrentRow);
            lblReceta.Text = "Total de ingredientes:" + receta.RetornarLista().Count;
        }

        private void vaciar()
        {
            txtCheff.Clear();
            txtNombre.Clear();
            CboIngrediente.SelectedIndex = 0;
            CboTipoIngrediente.SelectedIndex = 0;
            nudCantidad.Value = 0;
            dgvIngredientes.Rows.Clear();
            receta.vaciar_lista();
            lblTipoingrediente.Text = "Total de ingredientes: 0";
            lblReceta.Text = "Receta #: " + HelpDatabaseDao.obtenerInstancia().proximo_id("sp_sig_nro_receta");

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            vaciar();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (validar_carga())
            {
                receta.nombre_receta = txtNombre.Text;
                receta.cheff = txtCheff.Text; ;
                receta.id_receta = HelpDatabaseDao.obtenerInstancia().proximo_id("sp_sig_nro_receta");
                receta.tipo_receta = CboTipoIngrediente.SelectedIndex + 1;
                HelpDatabaseDao.obtenerInstancia().insertar_transaccion(receta);
                MessageBox.Show("Se inserto con exito");
                vaciar();
                
            }
        }
    }
}
