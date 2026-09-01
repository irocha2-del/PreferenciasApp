namespace PreferenciasApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            chkLectura = new CheckBox();
            chkProgramacion = new CheckBox();
            chkArte = new CheckBox();
            chkMusica = new CheckBox();
            chkDeportes = new CheckBox();
            groupBox2 = new GroupBox();
            rbEnLinea = new RadioButton();
            rbHibrida = new RadioButton();
            rbPresencial = new RadioButton();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            label2 = new Label();
            txtResumen = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Estudiante";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(187, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkLectura);
            groupBox1.Controls.Add(chkProgramacion);
            groupBox1.Controls.Add(chkArte);
            groupBox1.Controls.Add(chkMusica);
            groupBox1.Controls.Add(chkDeportes);
            groupBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 217);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actividades favoritas (puedes elegir varias)";
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Location = new Point(6, 135);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(63, 17);
            chkLectura.TabIndex = 4;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkProgramacion
            // 
            chkProgramacion.AutoSize = true;
            chkProgramacion.Location = new Point(6, 110);
            chkProgramacion.Name = "chkProgramacion";
            chkProgramacion.Size = new Size(97, 17);
            chkProgramacion.TabIndex = 3;
            chkProgramacion.Text = "Programacion";
            chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(6, 85);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(47, 17);
            chkArte.TabIndex = 2;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(6, 60);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(62, 17);
            chkMusica.TabIndex = 1;
            chkMusica.Text = "Musica";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(6, 35);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(73, 17);
            chkDeportes.TabIndex = 0;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbEnLinea);
            groupBox2.Controls.Add(rbHibrida);
            groupBox2.Controls.Add(rbPresencial);
            groupBox2.Location = new Point(235, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 217);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modalidad preferida (elige una)";
            // 
            // rbEnLinea
            // 
            rbEnLinea.AutoSize = true;
            rbEnLinea.Location = new Point(11, 84);
            rbEnLinea.Name = "rbEnLinea";
            rbEnLinea.Size = new Size(69, 19);
            rbEnLinea.TabIndex = 2;
            rbEnLinea.TabStop = true;
            rbEnLinea.Text = "En Linea";
            rbEnLinea.UseVisualStyleBackColor = true;
            // 
            // rbHibrida
            // 
            rbHibrida.AutoSize = true;
            rbHibrida.Location = new Point(11, 59);
            rbHibrida.Name = "rbHibrida";
            rbHibrida.Size = new Size(64, 19);
            rbHibrida.TabIndex = 1;
            rbHibrida.TabStop = true;
            rbHibrida.Text = "Hibrida";
            rbHibrida.UseVisualStyleBackColor = true;
            // 
            // rbPresencial
            // 
            rbPresencial.AutoSize = true;
            rbPresencial.Location = new Point(11, 34);
            rbPresencial.Name = "rbPresencial";
            rbPresencial.Size = new Size(78, 19);
            rbPresencial.TabIndex = 0;
            rbPresencial.TabStop = true;
            rbPresencial.Text = "Presencial";
            rbPresencial.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(119, 302);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(117, 33);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar Resumen";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(248, 302);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 33);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 344);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 6;
            label2.Text = "RESUMEN:";
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(12, 373);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.ScrollBars = ScrollBars.Vertical;
            txtResumen.Size = new Size(397, 110);
            txtResumen.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(443, 529);
            Controls.Add(txtResumen);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Preferencias de Actividades";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private CheckBox chkLectura;
        private CheckBox chkProgramacion;
        private CheckBox chkArte;
        private CheckBox chkMusica;
        private CheckBox chkDeportes;
        private GroupBox groupBox2;
        private RadioButton rbEnLinea;
        private RadioButton rbHibrida;
        private RadioButton rbPresencial;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Label label2;
        private TextBox txtResumen;
    }
}
