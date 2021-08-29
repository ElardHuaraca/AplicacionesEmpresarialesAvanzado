
namespace Lab2
{
    partial class PrincipalMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcRegVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcRegCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporInvProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalirSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes,
            this.mnuSalir});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProcRegVenta,
            this.mnuProcRegCompra});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.procesoToolStripMenuItem.Text = "Proceso";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReporVentas,
            this.mnuReporCompras,
            this.mnuReporInvProductos,
            this.mnuReporProveedores,
            this.mnuReporUsuarios,
            this.mnuReporClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalirSistema});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(180, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(180, 22);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(180, 22);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(180, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(180, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(180, 22);
            this.mnuSalir.Text = "Salir";
            // 
            // mnuProcRegVenta
            // 
            this.mnuProcRegVenta.Name = "mnuProcRegVenta";
            this.mnuProcRegVenta.Size = new System.Drawing.Size(180, 22);
            this.mnuProcRegVenta.Text = "Registrar Venta";
            // 
            // mnuProcRegCompra
            // 
            this.mnuProcRegCompra.Name = "mnuProcRegCompra";
            this.mnuProcRegCompra.Size = new System.Drawing.Size(180, 22);
            this.mnuProcRegCompra.Text = "Registrar Compra";
            // 
            // mnuReporVentas
            // 
            this.mnuReporVentas.Name = "mnuReporVentas";
            this.mnuReporVentas.Size = new System.Drawing.Size(200, 22);
            this.mnuReporVentas.Text = "Reporte de ventas";
            // 
            // mnuReporCompras
            // 
            this.mnuReporCompras.Name = "mnuReporCompras";
            this.mnuReporCompras.Size = new System.Drawing.Size(200, 22);
            this.mnuReporCompras.Text = "Reporte de compras";
            // 
            // mnuReporInvProductos
            // 
            this.mnuReporInvProductos.Name = "mnuReporInvProductos";
            this.mnuReporInvProductos.Size = new System.Drawing.Size(200, 22);
            this.mnuReporInvProductos.Text = "Inventario de productos";
            // 
            // mnuReporProveedores
            // 
            this.mnuReporProveedores.Name = "mnuReporProveedores";
            this.mnuReporProveedores.Size = new System.Drawing.Size(200, 22);
            this.mnuReporProveedores.Text = "Reporte de proveedores";
            // 
            // mnuReporUsuarios
            // 
            this.mnuReporUsuarios.Name = "mnuReporUsuarios";
            this.mnuReporUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuReporUsuarios.Text = "Reporte de usuarios";
            // 
            // mnuReporClientes
            // 
            this.mnuReporClientes.Name = "mnuReporClientes";
            this.mnuReporClientes.Size = new System.Drawing.Size(200, 22);
            this.mnuReporClientes.Text = "Reporte de clientes";
            // 
            // mnuSalirSistema
            // 
            this.mnuSalirSistema.Name = "mnuSalirSistema";
            this.mnuSalirSistema.Size = new System.Drawing.Size(180, 22);
            this.mnuSalirSistema.Text = "Salir del sistema";
            this.mnuSalirSistema.Click += new System.EventHandler(this.mnuSalirSistema_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProcRegVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProcRegCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReporVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuReporCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuReporInvProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuReporProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuReporUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuReporClientes;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalirSistema;
    }
}