namespace WinGestionComercial
{
    partial class FrmUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.lblExperienciaComercial = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rBMujer = new System.Windows.Forms.RadioButton();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.ltsExperiencia = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 64);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido :";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 106);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(38, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad :";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(12, 321);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(71, 13);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios :";
            // 
            // lblExperienciaComercial
            // 
            this.lblExperienciaComercial.AutoSize = true;
            this.lblExperienciaComercial.Location = new System.Drawing.Point(307, 29);
            this.lblExperienciaComercial.Name = "lblExperienciaComercial";
            this.lblExperienciaComercial.Size = new System.Drawing.Size(117, 13);
            this.lblExperienciaComercial.TabIndex = 4;
            this.lblExperienciaComercial.Text = "Experiencia Comercial :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(68, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(141, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(57, 106);
            this.nudEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(36, 20);
            this.nudEdad.TabIndex = 7;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbHombre.Checked = true;
            this.rbHombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbHombre.Location = new System.Drawing.Point(15, 176);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 8;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rBMujer
            // 
            this.rBMujer.AutoSize = true;
            this.rBMujer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rBMujer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rBMujer.Location = new System.Drawing.Point(129, 176);
            this.rBMujer.Name = "rBMujer";
            this.rBMujer.Size = new System.Drawing.Size(51, 17);
            this.rBMujer.TabIndex = 9;
            this.rBMujer.Text = "Mujer";
            this.rBMujer.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(89, 321);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(335, 121);
            this.txtComentario.TabIndex = 10;
            // 
            // ltsExperiencia
            // 
            this.ltsExperiencia.FormattingEnabled = true;
            this.ltsExperiencia.Items.AddRange(new object[] {
            "Menos de 6 meses",
            "Entre 6 meses y 1 año",
            "Mas de 1 año",
            "Entre mas de 2 a 5 años"});
            this.ltsExperiencia.Location = new System.Drawing.Point(310, 61);
            this.ltsExperiencia.Name = "ltsExperiencia";
            this.ltsExperiencia.Size = new System.Drawing.Size(125, 56);
            this.ltsExperiencia.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(337, 133);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 454);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ltsExperiencia);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.rBMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblExperienciaComercial);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.Text = "Ficha del Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label lblExperienciaComercial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rBMujer;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.ListBox ltsExperiencia;
        private System.Windows.Forms.Button btnGuardar;
    }
}