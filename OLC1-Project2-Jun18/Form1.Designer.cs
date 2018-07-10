namespace OLC1_Project2_Jun18
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarTodoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.arbolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.astMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sintacticoAbstractoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.reformatearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ejecutarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoMenuItem,
            this.compilarMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoMenuItem
            // 
            this.archivoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirMenuItem,
            this.nuevoMenuItem,
            this.toolStripSeparator1,
            this.guardarMenuItem,
            this.guardarTodoMenuItem,
            this.toolStripSeparator2,
            this.cerrarMenuItem,
            this.cerrarTodoMenuItem,
            this.toolStripSeparator3,
            this.salirMenuItem});
            this.archivoMenuItem.Name = "archivoMenuItem";
            this.archivoMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoMenuItem.Text = "Archivo";
            // 
            // abrirMenuItem
            // 
            this.abrirMenuItem.Name = "abrirMenuItem";
            this.abrirMenuItem.Size = new System.Drawing.Size(146, 22);
            this.abrirMenuItem.Text = "Abrir";
            this.abrirMenuItem.Click += new System.EventHandler(this.abrirMenuItem_Click);
            // 
            // nuevoMenuItem
            // 
            this.nuevoMenuItem.Name = "nuevoMenuItem";
            this.nuevoMenuItem.Size = new System.Drawing.Size(146, 22);
            this.nuevoMenuItem.Text = "Nuevo";
            this.nuevoMenuItem.Click += new System.EventHandler(this.nuevoMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // guardarMenuItem
            // 
            this.guardarMenuItem.Name = "guardarMenuItem";
            this.guardarMenuItem.Size = new System.Drawing.Size(146, 22);
            this.guardarMenuItem.Text = "Guardar";
            this.guardarMenuItem.Click += new System.EventHandler(this.guardarMenuItem_Click);
            // 
            // guardarTodoMenuItem
            // 
            this.guardarTodoMenuItem.Name = "guardarTodoMenuItem";
            this.guardarTodoMenuItem.Size = new System.Drawing.Size(146, 22);
            this.guardarTodoMenuItem.Text = "Guardar Todo";
            this.guardarTodoMenuItem.Click += new System.EventHandler(this.guardarTodoMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // cerrarMenuItem
            // 
            this.cerrarMenuItem.Name = "cerrarMenuItem";
            this.cerrarMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cerrarMenuItem.Text = "Cerrar";
            this.cerrarMenuItem.Click += new System.EventHandler(this.cerrarMenuItem_Click);
            // 
            // cerrarTodoMenuItem
            // 
            this.cerrarTodoMenuItem.Name = "cerrarTodoMenuItem";
            this.cerrarTodoMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cerrarTodoMenuItem.Text = "Cerrar Todo";
            this.cerrarTodoMenuItem.Click += new System.EventHandler(this.cerrarTodoMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salirMenuItem.Text = "Salir";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // compilarMenuItem
            // 
            this.compilarMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilarToolStripMenuItem1,
            this.toolStripSeparator4,
            this.arbolMenuItem,
            this.toolStripSeparator5,
            this.reformatearMenuItem,
            this.toolStripSeparator6,
            this.ejecutarMenuItem});
            this.compilarMenuItem.Name = "compilarMenuItem";
            this.compilarMenuItem.Size = new System.Drawing.Size(59, 20);
            this.compilarMenuItem.Text = "Analisis";
            // 
            // compilarToolStripMenuItem1
            // 
            this.compilarToolStripMenuItem1.Name = "compilarToolStripMenuItem1";
            this.compilarToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.compilarToolStripMenuItem1.Text = "Compilar";
            this.compilarToolStripMenuItem1.Click += new System.EventHandler(this.compilarToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // arbolMenuItem
            // 
            this.arbolMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.astMenuItem,
            this.sintacticoAbstractoMenuItem});
            this.arbolMenuItem.Name = "arbolMenuItem";
            this.arbolMenuItem.Size = new System.Drawing.Size(181, 22);
            this.arbolMenuItem.Text = "Arbol";
            // 
            // astMenuItem
            // 
            this.astMenuItem.Name = "astMenuItem";
            this.astMenuItem.Size = new System.Drawing.Size(180, 22);
            this.astMenuItem.Text = "AST";
            this.astMenuItem.Click += new System.EventHandler(this.astMenuItem_Click);
            // 
            // sintacticoAbstractoMenuItem
            // 
            this.sintacticoAbstractoMenuItem.Name = "sintacticoAbstractoMenuItem";
            this.sintacticoAbstractoMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sintacticoAbstractoMenuItem.Text = "Sintactico Abstracto";
            this.sintacticoAbstractoMenuItem.Click += new System.EventHandler(this.sintacticoAbstractoMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // reformatearMenuItem
            // 
            this.reformatearMenuItem.Name = "reformatearMenuItem";
            this.reformatearMenuItem.Size = new System.Drawing.Size(181, 22);
            this.reformatearMenuItem.Text = "Reformatear Codigo";
            this.reformatearMenuItem.Click += new System.EventHandler(this.reformatearMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(178, 6);
            // 
            // ejecutarMenuItem
            // 
            this.ejecutarMenuItem.Name = "ejecutarMenuItem";
            this.ejecutarMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ejecutarMenuItem.Text = "Ejecutar";
            this.ejecutarMenuItem.Click += new System.EventHandler(this.ejecutarMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 437);
            this.tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem archivoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarTodoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilarMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolMenuItem;
        private System.Windows.Forms.ToolStripMenuItem astMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sintacticoAbstractoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem compilarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem reformatearMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ejecutarMenuItem;
    }
}

