using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
namespace Presentacion
{
    public partial class fmrNuevaCategoria : Form
    {
        private nCategoria gcate = new nCategoria();
        private nProducto gprodu = new nProducto();
        public string nom_cate { get; set; }
        public int id_cate;
        public fmrNuevaCategoria()
        {
            InitializeComponent();
            Mostrar();
        }
        public void Mostrar()
        {
            int i = 1;
            DataTable table = new DataTable();
            table.Columns.Add("Indice", typeof(int));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Categoria", typeof(string));
            table.Columns.Add("Número de Productos", typeof(int));
            foreach (eCategoria value in gcate.ListarTodo())
            {
                table.Rows.Add(i,value.idcategoria, value.categoria,gprodu.BuscarCategoria(value.categoria).Count());
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.ClearSelection();
            dataGridView1.Columns[1].Visible = false;
            if(dataGridView1.Rows.Count>0)
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow !=null)
            {
                id_cate = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                nom_cate = dataGridView1.CurrentRow.Cells[2].Value.ToString();                
                txtcategoria.Text = nom_cate;
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            txtcategoria.Clear();
        }
        private void fmrNuevaCategoria_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtcategoria.Clear();
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text != "")
            {
                if (gcate.ListarTodo().Exists(delegate (eCategoria value)
                {
                    return value.categoria == txtcategoria.Text;
                })!=true)
                {
                    gcate.Insertar(txtcategoria.Text);
                    Mostrar();
                    txtcategoria.Clear();
                    txtcategoria.Focus();
                }
                else
                    MessageBox.Show("Ingrese otro nombre, la categoria ya existe");
            }
            else
                MessageBox.Show("Ingrese un nombre para la nueva categoria");
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text != "")
            {
                gcate.Eliminar(id_cate);
                Mostrar();
                txtcategoria.Text = "";
                txtcategoria.Focus();
            }
            else
                MessageBox.Show("Seleccione una categoria para eliminar");
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text != "")
            {
                gcate.Modificar(id_cate, txtcategoria.Text);
                Mostrar();
                txtcategoria.Text = "";
                txtcategoria.Focus();
            }
            else
                MessageBox.Show("Seleccione una categoria para modificar");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtcategoria.Clear();
            txtcategoria.Focus();
        }
        private void txtcategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcategoria.Text != "")
                {
                    gcate.Insertar(txtcategoria.Text);
                    Mostrar();
                    txtcategoria.Clear();
                    txtcategoria.Focus();
                }
                else
                    MessageBox.Show("Ingrese un nombre para la nueva categoria");
            }
        }
    }
}
