
namespace AdministracionDeNotas
{
    partial class AdministradorDeNotas
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
            this.gbAlumno = new System.Windows.Forms.GroupBox();
            this.numTipoAlumno = new System.Windows.Forms.NumericUpDown();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblTipoAlumno = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEvaluarPromedio = new System.Windows.Forms.Button();
            this.gbCalculoPromedios = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPromedios = new System.Windows.Forms.GroupBox();
            this.txtPromedioP = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.gbAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTipoAlumno)).BeginInit();
            this.gbCalculoPromedios.SuspendLayout();
            this.gbPromedios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlumno
            // 
            this.gbAlumno.Controls.Add(this.numTipoAlumno);
            this.gbAlumno.Controls.Add(this.cbSeccion);
            this.gbAlumno.Controls.Add(this.txtArea);
            this.gbAlumno.Controls.Add(this.txtApellido);
            this.gbAlumno.Controls.Add(this.txtNombre);
            this.gbAlumno.Controls.Add(this.lblSeccion);
            this.gbAlumno.Controls.Add(this.lblTipoAlumno);
            this.gbAlumno.Controls.Add(this.lblArea);
            this.gbAlumno.Controls.Add(this.lblApellido);
            this.gbAlumno.Controls.Add(this.lblNombre);
            this.gbAlumno.Location = new System.Drawing.Point(13, 13);
            this.gbAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.gbAlumno.Name = "gbAlumno";
            this.gbAlumno.Padding = new System.Windows.Forms.Padding(4);
            this.gbAlumno.Size = new System.Drawing.Size(406, 206);
            this.gbAlumno.TabIndex = 0;
            this.gbAlumno.TabStop = false;
            this.gbAlumno.Text = "Alumno:";
            // 
            // numTipoAlumno
            // 
            this.numTipoAlumno.Location = new System.Drawing.Point(139, 152);
            this.numTipoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.numTipoAlumno.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTipoAlumno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTipoAlumno.Name = "numTipoAlumno";
            this.numTipoAlumno.Size = new System.Drawing.Size(53, 24);
            this.numTipoAlumno.TabIndex = 9;
            this.numTipoAlumno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSeccion
            // 
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSeccion.Location = new System.Drawing.Point(139, 122);
            this.cbSeccion.Margin = new System.Windows.Forms.Padding(4);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(99, 26);
            this.cbSeccion.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(139, 89);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(232, 24);
            this.txtArea.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(139, 57);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(232, 24);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 24);
            this.txtNombre.TabIndex = 5;
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(11, 125);
            this.lblSeccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(66, 18);
            this.lblSeccion.TabIndex = 4;
            this.lblSeccion.Text = "Seccion:";
            // 
            // lblTipoAlumno
            // 
            this.lblTipoAlumno.AutoSize = true;
            this.lblTipoAlumno.Location = new System.Drawing.Point(11, 155);
            this.lblTipoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAlumno.Name = "lblTipoAlumno";
            this.lblTipoAlumno.Size = new System.Drawing.Size(115, 18);
            this.lblTipoAlumno.TabIndex = 3;
            this.lblTipoAlumno.Text = "Tipo de Alumno:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(11, 95);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 18);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 63);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 31);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnEvaluarPromedio
            // 
            this.btnEvaluarPromedio.Location = new System.Drawing.Point(54, 227);
            this.btnEvaluarPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.btnEvaluarPromedio.Name = "btnEvaluarPromedio";
            this.btnEvaluarPromedio.Size = new System.Drawing.Size(293, 31);
            this.btnEvaluarPromedio.TabIndex = 1;
            this.btnEvaluarPromedio.Text = "Evaluar Promedio";
            this.btnEvaluarPromedio.UseVisualStyleBackColor = true;
            this.btnEvaluarPromedio.Click += new System.EventHandler(this.btnEvaluarPromedio_Click);
            // 
            // gbCalculoPromedios
            // 
            this.gbCalculoPromedios.Controls.Add(this.btnSalir);
            this.gbCalculoPromedios.Controls.Add(this.gbPromedios);
            this.gbCalculoPromedios.Controls.Add(this.btnCalcular);
            this.gbCalculoPromedios.Controls.Add(this.txtNota4);
            this.gbCalculoPromedios.Controls.Add(this.txtNota3);
            this.gbCalculoPromedios.Controls.Add(this.txtNota2);
            this.gbCalculoPromedios.Controls.Add(this.txtNota1);
            this.gbCalculoPromedios.Controls.Add(this.lblNota4);
            this.gbCalculoPromedios.Controls.Add(this.lblNota3);
            this.gbCalculoPromedios.Controls.Add(this.lblNota2);
            this.gbCalculoPromedios.Controls.Add(this.lblNota1);
            this.gbCalculoPromedios.Location = new System.Drawing.Point(13, 266);
            this.gbCalculoPromedios.Margin = new System.Windows.Forms.Padding(4);
            this.gbCalculoPromedios.Name = "gbCalculoPromedios";
            this.gbCalculoPromedios.Padding = new System.Windows.Forms.Padding(4);
            this.gbCalculoPromedios.Size = new System.Drawing.Size(406, 223);
            this.gbCalculoPromedios.TabIndex = 2;
            this.gbCalculoPromedios.TabStop = false;
            this.gbCalculoPromedios.Text = "Calculo Promedios:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(297, 190);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 29);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbPromedios
            // 
            this.gbPromedios.Controls.Add(this.txtPromedioP);
            this.gbPromedios.Controls.Add(this.txtPromedio);
            this.gbPromedios.Controls.Add(this.lblResultado);
            this.gbPromedios.Controls.Add(this.label1);
            this.gbPromedios.Controls.Add(this.lblPromedio);
            this.gbPromedios.Location = new System.Drawing.Point(161, 24);
            this.gbPromedios.Margin = new System.Windows.Forms.Padding(4);
            this.gbPromedios.Name = "gbPromedios";
            this.gbPromedios.Padding = new System.Windows.Forms.Padding(4);
            this.gbPromedios.Size = new System.Drawing.Size(233, 158);
            this.gbPromedios.TabIndex = 14;
            this.gbPromedios.TabStop = false;
            this.gbPromedios.Text = "Promedios:";
            // 
            // txtPromedioP
            // 
            this.txtPromedioP.Location = new System.Drawing.Point(113, 61);
            this.txtPromedioP.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromedioP.Name = "txtPromedioP";
            this.txtPromedioP.Size = new System.Drawing.Size(81, 24);
            this.txtPromedioP.TabIndex = 4;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(113, 31);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(81, 24);
            this.txtPromedio.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultado.Location = new System.Drawing.Point(8, 100);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 18);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "lblResultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio %:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(10, 31);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(77, 18);
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 193);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 28);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(93, 161);
            this.txtNota4.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(48, 24);
            this.txtNota4.TabIndex = 12;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(93, 118);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(48, 24);
            this.txtNota3.TabIndex = 11;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(93, 75);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(48, 24);
            this.txtNota2.TabIndex = 10;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(93, 34);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(48, 24);
            this.txtNota1.TabIndex = 9;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(26, 164);
            this.lblNota4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(56, 18);
            this.lblNota4.TabIndex = 8;
            this.lblNota4.Text = "Nota 4:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(26, 121);
            this.lblNota3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(56, 18);
            this.lblNota3.TabIndex = 7;
            this.lblNota3.Text = "Nota 3:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(26, 78);
            this.lblNota2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(56, 18);
            this.lblNota2.TabIndex = 6;
            this.lblNota2.Text = "Nota 2:";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(26, 37);
            this.lblNota1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(56, 18);
            this.lblNota1.TabIndex = 5;
            this.lblNota1.Text = "Nota 1:";
            // 
            // AdministradorDeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 498);
            this.Controls.Add(this.gbCalculoPromedios);
            this.Controls.Add(this.btnEvaluarPromedio);
            this.Controls.Add(this.gbAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministradorDeNotas";
            this.Text = "Administración de Notas";
            this.Load += new System.EventHandler(this.AdministradorDeNotas_Load);
            this.gbAlumno.ResumeLayout(false);
            this.gbAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTipoAlumno)).EndInit();
            this.gbCalculoPromedios.ResumeLayout(false);
            this.gbCalculoPromedios.PerformLayout();
            this.gbPromedios.ResumeLayout(false);
            this.gbPromedios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlumno;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblTipoAlumno;
        private System.Windows.Forms.NumericUpDown numTipoAlumno;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEvaluarPromedio;
        private System.Windows.Forms.GroupBox gbCalculoPromedios;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.GroupBox gbPromedios;
        private System.Windows.Forms.TextBox txtPromedioP;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}

