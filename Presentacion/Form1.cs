using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            panelContenedor.Visible = false;
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnminizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public void AbrirFormulario(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form form = formhija as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(form);
            this.panelContenedor.Tag = form;
            form.Show();
        }
        /////////////////////PAGINA PRINCIPAL//////////////////////////
        private void btnPaginaPrincipal_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = false;
        }
        //////////////////////VENTA///////////////////////////
        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrVenta());
        }
        /////////////////////CLIENTE//////////////////////////
        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            else
            {
                if (SubmenuProducto.Visible == true)
                {
                    SubmenuProducto.Visible = false;
                    panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                    panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                    panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                    panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                    btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                    btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                    btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                    btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
                }
                if (SubmenuFacturacion.Visible == true)
                {
                    SubmenuFacturacion.Visible = false;
                    panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                    btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
                }
                SubmenuCliente.Visible = true;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y + 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y + 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y + 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y + 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y + 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y + 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y + 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y + 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y + 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y + 86);
            }
        }
        private void btnnuevocliente_Click(object sender, EventArgs e)
        {
            SubmenuCliente.Visible = false;
            panelContenedor.Visible = true;
            panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
            panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
            panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
            panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
            panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
            btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
            btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
            btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
            btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
            btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            AbrirFormulario(new fmrNuevoCliente());
        }
        private void btnrevisarcuenta_Click(object sender, EventArgs e)
        {
            SubmenuCliente.Visible = false;
            panelContenedor.Visible = true;
            panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
            panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
            panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
            panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
            panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
            btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
            btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
            btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
            btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
            btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            AbrirFormulario(new fmrRevisarCuenta());
        }
        /////////////////////PRODUCTO/////////////////////////
        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            else
            {
                if (SubmenuCliente.Visible == true)
                {
                    SubmenuCliente.Visible = false;
                    panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                    panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                    panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                    panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                    panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                    btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                    btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                    btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                    btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                    btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
                }
                if (SubmenuFacturacion.Visible == true)
                {
                    SubmenuFacturacion.Visible = false;
                    panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                    btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
                }
                SubmenuProducto.Visible = true;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y + 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y + 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y + 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y + 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y + 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y + 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y + 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y + 131);
            }
        }
        private void btnnuevoroducto_Click(object sender, EventArgs e)
        {
            SubmenuProducto.Visible = false;
            panelContenedor.Visible = true;
            panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
            panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
            panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
            panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
            btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
            btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
            btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
            btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            AbrirFormulario(new fmrNuevoProducto());
        }         
        private void btnnuevacategoria_Click(object sender, EventArgs e)
        {
            SubmenuProducto.Visible = false;
            panelContenedor.Visible = true;
            panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
            panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
            panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
            panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
            btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
            btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
            btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
            btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            AbrirFormulario(new fmrNuevaCategoria());
        }
        private void btnverproducto_Click(object sender, EventArgs e)
        {
            SubmenuProducto.Visible = false;
            panelContenedor.Visible = true;
            panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
            panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
            panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
            panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
            btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
            btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
            btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
            btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            AbrirFormulario(new fmrVerProductos());
        }
        /////////////////////INVENTARIO/////////////////////////
        private void btnStock_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrListadeCompras());
        }
        /////////////////////COMPRAS/////////////////////////
        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrCompras());
        }
        /////////////////////FACTURACION/////////////////////////
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            if(SubmenuFacturacion.Visible==true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            else
            {
                if (SubmenuProducto.Visible == true)
                {
                    SubmenuProducto.Visible = false;
                    panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                    panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                    panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                    panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                    btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                    btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                    btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                    btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
                }
                if (SubmenuCliente.Visible == true)
                {
                    SubmenuCliente.Visible = false;
                    panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                    panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                    panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                    panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                    panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                    btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                    btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                    btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                    btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                    btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
                }
                SubmenuFacturacion.Visible = true;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y + 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y + 40);
            }
        }
        private void btnrevisarventas_Click(object sender, EventArgs e)
        {
            SubmenuFacturacion.Visible = false;
            panelContenedor.Visible = true;
            panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
            btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            AbrirFormulario(new fmrRevisarVentas());
        }

        ///////////////Ver más PRODUCTOS - PRINCIPAL/////////////////////
        private void btnseleccProductos_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrVerProductos());
        }
        ///////////////Ver más VENTAS - PRINCIPAL///////////////////////
        private void btnseleccVentas_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrVenta());
        }
        ///////////////Ver más COMPRAS - PRINCIPAL///////////////////////
        private void btnseleccCompras_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrCompras());
        }
        ///////////////Ver más CLIENTES - PRINCIPAL//////////////////////
        private void btnseleccClientes_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrRevisarCuenta());
        }
        ///////////////Ver más LISTA DE COMPRAS - PRINCIPAL//////////////
        private void btnseleccLista_Compras_Click(object sender, EventArgs e)
        {
            if (SubmenuProducto.Visible == true)
            {
                SubmenuProducto.Visible = false;
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 131);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 131);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 131);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 131);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 131);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 131);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 131);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 131);
            }
            if (SubmenuCliente.Visible == true)
            {
                SubmenuCliente.Visible = false;
                panel6.Location = new Point(panel6.Location.X, panel6.Location.Y - 86);
                panel7.Location = new Point(panel7.Location.X, panel7.Location.Y - 86);
                panel8.Location = new Point(panel8.Location.X, panel8.Location.Y - 86);
                panel9.Location = new Point(panel9.Location.X, panel9.Location.Y - 86);
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 86);
                btnProducto.Location = new Point(btnProducto.Location.X, btnProducto.Location.Y - 86);
                btnStock.Location = new Point(btnStock.Location.X, btnStock.Location.Y - 86);
                btnCompra.Location = new Point(btnCompra.Location.X, btnCompra.Location.Y - 86);
                btnFacturacion.Location = new Point(btnFacturacion.Location.X, btnFacturacion.Location.Y - 86);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 86);
            }
            if (SubmenuFacturacion.Visible == true)
            {
                SubmenuFacturacion.Visible = false;
                panel10.Location = new Point(panel10.Location.X, panel10.Location.Y - 40);
                btnAjustes.Location = new Point(btnAjustes.Location.X, btnAjustes.Location.Y - 40);
            }
            panelContenedor.Visible = true;
            AbrirFormulario(new fmrListadeCompras());
        }
    }
}
