namespace ExamenProgramacion
{
    partial class Form1
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbSegs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoraCompletadas = new System.Windows.Forms.TextBox();
            this.txtHoraTotales = new System.Windows.Forms.TextBox();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.cbMateriasInscritas = new System.Windows.Forms.ComboBox();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.cbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblHoraC = new System.Windows.Forms.Label();
            this.lblHorasT = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbUniversidad = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cblistas = new System.Windows.Forms.ComboBox();
            this.txtCONSULTA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPromediio = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbUniversidadMasEstudiantes = new System.Windows.Forms.RadioButton();
            this.rbNameyUniver = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(1111, 578);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 44);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // cbSegs
            // 
            this.cbSegs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSegs.FormattingEnabled = true;
            this.cbSegs.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSegs.Location = new System.Drawing.Point(159, 118);
            this.cbSegs.Name = "cbSegs";
            this.cbSegs.Size = new System.Drawing.Size(124, 24);
            this.cbSegs.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Segs:";
            // 
            // txtHoraCompletadas
            // 
            this.txtHoraCompletadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraCompletadas.Location = new System.Drawing.Point(1241, 118);
            this.txtHoraCompletadas.Name = "txtHoraCompletadas";
            this.txtHoraCompletadas.Size = new System.Drawing.Size(90, 22);
            this.txtHoraCompletadas.TabIndex = 52;
            // 
            // txtHoraTotales
            // 
            this.txtHoraTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraTotales.Location = new System.Drawing.Point(1241, 90);
            this.txtHoraTotales.Name = "txtHoraTotales";
            this.txtHoraTotales.Size = new System.Drawing.Size(90, 22);
            this.txtHoraTotales.TabIndex = 51;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProyecto.Location = new System.Drawing.Point(1241, 62);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(140, 22);
            this.txtNombreProyecto.TabIndex = 50;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(879, 152);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(71, 22);
            this.txtNotas.TabIndex = 48;
            // 
            // cbMateriasInscritas
            // 
            this.cbMateriasInscritas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriasInscritas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriasInscritas.FormattingEnabled = true;
            this.cbMateriasInscritas.Items.AddRange(new object[] {
            "Calculo",
            "Ingles",
            "Programacion"});
            this.cbMateriasInscritas.Location = new System.Drawing.Point(879, 122);
            this.cbMateriasInscritas.Name = "cbMateriasInscritas";
            this.cbMateriasInscritas.Size = new System.Drawing.Size(130, 24);
            this.cbMateriasInscritas.TabIndex = 47;
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "Ingenieria",
            "Medicina",
            "Arquitectura"});
            this.cbCarrera.Location = new System.Drawing.Point(879, 92);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(130, 24);
            this.cbCarrera.TabIndex = 46;
            // 
            // cbNivelAcademico
            // 
            this.cbNivelAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelAcademico.FormattingEnabled = true;
            this.cbNivelAcademico.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Avanzado"});
            this.cbNivelAcademico.Location = new System.Drawing.Point(539, 88);
            this.cbNivelAcademico.Name = "cbNivelAcademico";
            this.cbNivelAcademico.Size = new System.Drawing.Size(164, 24);
            this.cbNivelAcademico.TabIndex = 45;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(159, 90);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(62, 22);
            this.txtEdad.TabIndex = 43;
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreyApellido.Location = new System.Drawing.Point(159, 62);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(185, 22);
            this.txtNombreyApellido.TabIndex = 42;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(539, 60);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(164, 22);
            this.txtCarnet.TabIndex = 41;
            // 
            // lblHoraC
            // 
            this.lblHoraC.AutoSize = true;
            this.lblHoraC.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraC.Location = new System.Drawing.Point(1063, 124);
            this.lblHoraC.Name = "lblHoraC";
            this.lblHoraC.Size = new System.Drawing.Size(164, 22);
            this.lblHoraC.TabIndex = 40;
            this.lblHoraC.Text = "Horas Completadas:";
            // 
            // lblHorasT
            // 
            this.lblHorasT.AutoSize = true;
            this.lblHorasT.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasT.Location = new System.Drawing.Point(1102, 96);
            this.lblHorasT.Name = "lblHorasT";
            this.lblHorasT.Size = new System.Drawing.Size(124, 22);
            this.lblHorasT.TabIndex = 39;
            this.lblHorasT.Text = "Horas Totales:";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(1052, 68);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(182, 22);
            this.lblProyecto.TabIndex = 38;
            this.lblProyecto.Text = "Nombre Del Proyecto:";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(794, 156);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(62, 22);
            this.lblNotas.TabIndex = 36;
            this.lblNotas.Text = "Notas:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.Location = new System.Drawing.Point(713, 126);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(160, 22);
            this.lblMaterias.TabIndex = 35;
            this.lblMaterias.Text = "Materias Inscritas:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(783, 96);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(74, 22);
            this.lblCarrera.TabIndex = 34;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(82, 90);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 22);
            this.lblApellido.TabIndex = 32;
            this.lblApellido.Text = "Edad:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(365, 91);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(154, 22);
            this.lblNivel.TabIndex = 30;
            this.lblNivel.Text = "Nivel de Estudios:";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(399, 63);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(115, 22);
            this.lblCarnet.TabIndex = 29;
            this.lblCarnet.Text = "Nº de Carnet:";
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Location = new System.Drawing.Point(25, 264);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(1227, 287);
            this.dgvPersona.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 56;
            this.label2.Text = "Universidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "Nombre y Apellido";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(104, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 58;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbUniversidad
            // 
            this.cbUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUniversidad.FormattingEnabled = true;
            this.cbUniversidad.Items.AddRange(new object[] {
            "UNI",
            "UNAN",
            "UNICIT"});
            this.cbUniversidad.Location = new System.Drawing.Point(879, 61);
            this.cbUniversidad.Name = "cbUniversidad";
            this.cbUniversidad.Size = new System.Drawing.Size(130, 24);
            this.cbUniversidad.TabIndex = 59;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1094, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 19);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "LblFecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1037, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Fecha:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Aqua;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrar.Location = new System.Drawing.Point(263, 196);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(107, 44);
            this.btnMostrar.TabIndex = 62;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // cblistas
            // 
            this.cblistas.FormattingEnabled = true;
            this.cblistas.Items.AddRange(new object[] {
            "lista1",
            "lista2"});
            this.cblistas.Location = new System.Drawing.Point(403, 210);
            this.cblistas.Name = "cblistas";
            this.cblistas.Size = new System.Drawing.Size(147, 21);
            this.cblistas.TabIndex = 63;
            // 
            // txtCONSULTA
            // 
            this.txtCONSULTA.Location = new System.Drawing.Point(1314, 355);
            this.txtCONSULTA.Multiline = true;
            this.txtCONSULTA.Name = "txtCONSULTA";
            this.txtCONSULTA.Size = new System.Drawing.Size(306, 182);
            this.txtCONSULTA.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(827, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(736, 26);
            this.label5.TabIndex = 65;
            this.label5.Text = "Nota: si selecciona ingenieria rellenar nombre de proyecto, hora total y completa" +
    "da de lo contrario si selecciona otra carrera no rellenarla";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "¿Que desea Visualizar?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rbNameyUniver);
            this.groupBox1.Controls.Add(this.rbUniversidadMasEstudiantes);
            this.groupBox1.Controls.Add(this.rbPromediio);
            this.groupBox1.Location = new System.Drawing.Point(1276, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 100);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas";
            // 
            // rbPromediio
            // 
            this.rbPromediio.AutoSize = true;
            this.rbPromediio.Location = new System.Drawing.Point(6, 29);
            this.rbPromediio.Name = "rbPromediio";
            this.rbPromediio.Size = new System.Drawing.Size(137, 17);
            this.rbPromediio.TabIndex = 0;
            this.rbPromediio.TabStop = true;
            this.rbPromediio.Text = "Promedio de Estudiante";
            this.rbPromediio.UseVisualStyleBackColor = true;
            this.rbPromediio.CheckedChanged += new System.EventHandler(this.RbPromediio_CheckedChanged);
            // 
            // rbUniversidadMasEstudiantes
            // 
            this.rbUniversidadMasEstudiantes.AutoSize = true;
            this.rbUniversidadMasEstudiantes.Location = new System.Drawing.Point(149, 29);
            this.rbUniversidadMasEstudiantes.Name = "rbUniversidadMasEstudiantes";
            this.rbUniversidadMasEstudiantes.Size = new System.Drawing.Size(184, 17);
            this.rbUniversidadMasEstudiantes.TabIndex = 1;
            this.rbUniversidadMasEstudiantes.TabStop = true;
            this.rbUniversidadMasEstudiantes.Text = "Universidad con  mas estudiantes";
            this.rbUniversidadMasEstudiantes.UseVisualStyleBackColor = true;
            this.rbUniversidadMasEstudiantes.CheckedChanged += new System.EventHandler(this.RbUniversidadMasEstudiantes_CheckedChanged);
            // 
            // rbNameyUniver
            // 
            this.rbNameyUniver.AutoSize = true;
            this.rbNameyUniver.Location = new System.Drawing.Point(6, 52);
            this.rbNameyUniver.Name = "rbNameyUniver";
            this.rbNameyUniver.Size = new System.Drawing.Size(142, 17);
            this.rbNameyUniver.TabIndex = 2;
            this.rbNameyUniver.TabStop = true;
            this.rbNameyUniver.Text = "Estudiante y Universidad";
            this.rbNameyUniver.UseVisualStyleBackColor = true;
            this.rbNameyUniver.CheckedChanged += new System.EventHandler(this.RbNameyUniver_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(149, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aprovados";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCONSULTA);
            this.Controls.Add(this.cblistas);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUniversidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPersona);
            this.Controls.Add(this.cbSegs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoraCompletadas);
            this.Controls.Add(this.txtHoraTotales);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.cbMateriasInscritas);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.cbNivelAcademico);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreyApellido);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblHoraC);
            this.Controls.Add(this.lblHorasT);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbSegs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoraCompletadas;
        private System.Windows.Forms.TextBox txtHoraTotales;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.ComboBox cbMateriasInscritas;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.ComboBox cbNivelAcademico;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblHoraC;
        private System.Windows.Forms.Label lblHorasT;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbUniversidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cblistas;
        private System.Windows.Forms.TextBox txtCONSULTA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUniversidadMasEstudiantes;
        private System.Windows.Forms.RadioButton rbPromediio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbNameyUniver;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

