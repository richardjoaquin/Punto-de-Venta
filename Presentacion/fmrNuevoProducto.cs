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
    public partial class fmrNuevoProducto : Form
    {
        private nProducto gprodu = new nProducto();
        private nCategoria gcate = new nCategoria();
        private eProducto produ = null;
        public fmrNuevoProducto()
        {
            InitializeComponent();
            cboxcategoria.DisplayMember = "categoria";
            cboxcategoria.DataSource = gcate.ListarTodo();
            Mostrar();
        }
        public void Mostrar()
        {
            int i = 1;
            DataTable table = new DataTable();
            table.Columns.Add(" ", typeof(int));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Producto", typeof(string));
            table.Columns.Add("Código", typeof(int));
            table.Columns.Add("Precio de Venta", typeof(double));
            table.Columns.Add("Precio de Compra", typeof(double));
            table.Columns.Add("Stock", typeof(int));
            table.Columns.Add("Stock Mínimo", typeof(int));
            table.Columns.Add("Categoria", typeof(string));
            foreach (eProducto value in gprodu.ListarTodo())
            {
                table.Rows.Add(i,value.idproducto,value.nombre,value.codigobarras,value.precio,value.precio_compra,value.stock,value.min_stock,value.cate.categoria);
                i++;
            }
            dataGridView1.DataSource = table;
            dataGridView1.ClearSelection();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "C2";
            if (dataGridView1.Rows.Count > 0)
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                produ = new eProducto();
                if (produ != null)
                {
                    produ.codigobarras = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    produ.nombre = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    produ.precio = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    produ.stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    produ.cate = gcate.Buscar_por_Categoria(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    produ.idproducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    produ.min_stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    produ.precio_compra = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    txtcodigobarras.Text = produ.codigobarras;
                    txtnombre.Text = produ.nombre;
                    txtprecio_venta.Text = produ.precio.ToString();
                    txtstock.Text = produ.stock.ToString();
                    txtminimo_stock.Text = produ.min_stock.ToString();
                    txtprecio_compra.Text = produ.precio_compra.ToString();
                    cboxcategoria.Text = produ.cate.categoria;
                }
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            txtcodigobarras.Clear();
            txtminimo_stock.Clear();
            txtnombre.Clear();
            txtprecio_compra.Clear();
            txtprecio_venta.Clear();
            txtstock.Clear();
            cboxcategoria.Text = "";
        }
        private void fmrNuevoProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtcodigobarras.Clear();
            txtminimo_stock.Clear();
            txtnombre.Clear();
            txtprecio_compra.Clear();
            txtprecio_venta.Clear();
            txtstock.Clear();
            cboxcategoria.Text = "";
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
            {
                if (gprodu.ListarTodo().Exists(delegate (eProducto value)
                {
                    return value.nombre == txtnombre.Text || value.codigobarras == txtcodigobarras.Text;
                }
                )!=true)
                { int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("EL NOMBRE O CODIGO DE BARRAS DEL PRODUCTO YA EXISTE");
            }
            else
                MessageBox.Show("COMPLETE TODOS LOS DATOS");
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
            {
                gprodu.Eliminar(produ.idproducto);
                Mostrar();
                txtcodigobarras.Clear();
                txtminimo_stock.Clear();
                txtnombre.Clear();
                txtprecio_compra.Clear();
                txtprecio_venta.Clear();
                txtstock.Clear();
                cboxcategoria.Text = "";
                txtnombre.Focus();
            }
            else
                MessageBox.Show("Seleccione un producto para eliminar");
        }
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
            {
                gprodu.Modificar(produ.idproducto, txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria, Convert.ToInt32(txtminimo_stock.Text), Convert.ToDouble(txtprecio_compra.Text));
                Mostrar();
                txtcodigobarras.Clear();
                txtminimo_stock.Clear();
                txtnombre.Clear();
                txtprecio_compra.Clear();
                txtprecio_venta.Clear();
                txtstock.Clear();
                cboxcategoria.Text = "";
                txtnombre.Focus();
            }
            else
                MessageBox.Show("Seleccione un producto para modificar");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtcodigobarras.Clear();
            txtminimo_stock.Clear();
            txtnombre.Clear();
            txtprecio_compra.Clear();
            txtprecio_venta.Clear();
            txtstock.Clear();
            cboxcategoria.Text = "";
            txtnombre.Focus();
        }
        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void txtcodigobarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void txtprecio_venta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void txtprecio_compra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void txtstock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void txtminimo_stock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void cboxcategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (txtcodigobarras.Text != "" && txtminimo_stock.Text != "" && txtnombre.Text != "" && txtprecio_compra.Text != "" && txtprecio_venta.Text != "" && txtstock.Text != "" && cboxcategoria.Text != "")
                {
                    int id_cate = gcate.Buscar_por_Categoria(cboxcategoria.Text).idcategoria;
                    int min_Stock = Convert.ToInt32(txtminimo_stock.Text);
                    gprodu.Insertar(txtcodigobarras.Text, txtnombre.Text, Convert.ToDouble(txtprecio_venta.Text), Convert.ToInt32(txtstock.Text), id_cate, min_Stock, Convert.ToDouble(txtprecio_compra.Text));
                    Mostrar();
                    txtcodigobarras.Clear();
                    txtminimo_stock.Clear();
                    txtnombre.Clear();
                    txtprecio_compra.Clear();
                    txtprecio_venta.Clear();
                    txtstock.Clear();
                    cboxcategoria.Text = "";
                    txtnombre.Focus();
                }
                else
                    MessageBox.Show("Complete todos los datos");
            }
        }
        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtminimo_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtprecio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtprecio_venta.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                    e.Handled = true;
                if (e.KeyChar == '\b')
                    e.Handled = false;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))        
                    e.Handled = true;
                if (e.KeyChar =='.' || e.KeyChar =='\b')
                    e.Handled = false;  
            }
        }
        private void txtprecio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
