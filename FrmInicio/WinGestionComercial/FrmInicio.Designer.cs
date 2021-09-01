namespace WinGestionComercial
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lnkGoogle = new System.Windows.Forms.LinkLabel();
            this.mcHoy = new System.Windows.Forms.MonthCalendar();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesParaHoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCalendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.probarLaConexiónALaBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 276);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(700, 23);
            this.btnAcercaDe.TabIndex = 0;
            this.btnAcercaDe.Text = "Acerca De...";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(103, 192);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(138, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario de la Aplicación";
            this.txtUsuario.UseVisualStyleBackColor = true;
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lnkGoogle);
            this.splitContainer1.Panel1.Controls.Add(this.mcHoy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbLogo);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitulo);
            this.splitContainer1.Panel2.Controls.Add(this.txtUsuario);
            this.splitContainer1.Size = new System.Drawing.Size(700, 252);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // lnkGoogle
            // 
            this.lnkGoogle.AutoSize = true;
            this.lnkGoogle.Location = new System.Drawing.Point(110, 192);
            this.lnkGoogle.Name = "lnkGoogle";
            this.lnkGoogle.Size = new System.Drawing.Size(59, 13);
            this.lnkGoogle.TabIndex = 1;
            this.lnkGoogle.TabStop = true;
            this.lnkGoogle.Text = "Ir a Google";
            this.lnkGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoogle_LinkClicked);
            // 
            // mcHoy
            // 
            this.mcHoy.Dock = System.Windows.Forms.DockStyle.Top;
            this.mcHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcHoy.Location = new System.Drawing.Point(0, 0);
            this.mcHoy.Name = "mcHoy";
            this.mcHoy.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::WinGestionComercial.Properties.Resources.Chrysanthemum;
            this.pbLogo.Location = new System.Drawing.Point(60, 72);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(225, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(76, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(192, 26);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gestión Comercial";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.utilidadesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesParaHoyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tiposDeToolStripMenuItem,
            this.usuarioDeLaAplicaciónToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // accionesParaHoyToolStripMenuItem
            // 
            this.accionesParaHoyToolStripMenuItem.Name = "accionesParaHoyToolStripMenuItem";
            this.accionesParaHoyToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.accionesParaHoyToolStripMenuItem.Text = "Acciones para hoy";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem1.Text = "Clientes";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tiposDeToolStripMenuItem
            // 
            this.tiposDeToolStripMenuItem.Name = "tiposDeToolStripMenuItem";
            this.tiposDeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.tiposDeToolStripMenuItem.Text = "Tipos de Acción";
            this.tiposDeToolStripMenuItem.Click += new System.EventHandler(this.tiposDeToolStripMenuItem_Click);
            // 
            // usuarioDeLaAplicaciónToolStripMenuItem
            // 
            this.usuarioDeLaAplicaciónToolStripMenuItem.Name = "usuarioDeLaAplicaciónToolStripMenuItem";
            this.usuarioDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.usuarioDeLaAplicaciónToolStripMenuItem.Text = "Usuario de la Aplicación";
            this.usuarioDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.usuarioDeLaAplicaciónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // utilidadesToolStripMenuItem
            // 
            this.utilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarCalendarioToolStripMenuItem,
            this.otrasToolStripMenuItem});
            this.utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            this.utilidadesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.utilidadesToolStripMenuItem.Text = "Utilidades";
            // 
            // mostrarCalendarioToolStripMenuItem
            // 
            this.mostrarCalendarioToolStripMenuItem.Checked = true;
            this.mostrarCalendarioToolStripMenuItem.CheckOnClick = true;
            this.mostrarCalendarioToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarCalendarioToolStripMenuItem.Name = "mostrarCalendarioToolStripMenuItem";
            this.mostrarCalendarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mostrarCalendarioToolStripMenuItem.Text = "Mostrar Calendario";
            this.mostrarCalendarioToolStripMenuItem.CheckedChanged += new System.EventHandler(this.mostrarCalendarioToolStripMenuItem_CheckedChanged);
            // 
            // otrasToolStripMenuItem
            // 
            this.otrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probarLaConexiónALaBaseDeDatosToolStripMenuItem,
            this.ficheroDeClientesToolStripMenuItem});
            this.otrasToolStripMenuItem.Name = "otrasToolStripMenuItem";
            this.otrasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.otrasToolStripMenuItem.Text = "Otras";
            // 
            // probarLaConexiónALaBaseDeDatosToolStripMenuItem
            // 
            this.probarLaConexiónALaBaseDeDatosToolStripMenuItem.Name = "probarLaConexiónALaBaseDeDatosToolStripMenuItem";
            this.probarLaConexiónALaBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.probarLaConexiónALaBaseDeDatosToolStripMenuItem.Text = "Probar la conexión a la Base de Datos";
            this.probarLaConexiónALaBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.probarLaConexiónALaBaseDeDatosToolStripMenuItem_Click);
            // 
            // ficheroDeClientesToolStripMenuItem
            // 
            this.ficheroDeClientesToolStripMenuItem.Name = "ficheroDeClientesToolStripMenuItem";
            this.ficheroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.ficheroDeClientesToolStripMenuItem.Text = "Fichero de Clientes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 299);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.Text = "Gestión Comercial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button txtUsuario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MonthCalendar mcHoy;
        private System.Windows.Forms.LinkLabel lnkGoogle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesParaHoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioDeLaAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCalendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem probarLaConexiónALaBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

