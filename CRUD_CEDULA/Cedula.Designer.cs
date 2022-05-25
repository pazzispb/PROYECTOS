namespace CRUD_CEDULA
{
    partial class Cedula
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
            this.Titulo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.txtSector = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lbNombres = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbSangre = new System.Windows.Forms.Label();
            this.lbNacionalidad = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaExpiracion = new System.Windows.Forms.DateTimePicker();
            this.lbCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lbRegistroNacimiento = new System.Windows.Forms.Label();
            this.txtRegistroNacimiento = new System.Windows.Forms.TextBox();
            this.lbMunicipio = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lbSector = new System.Windows.Forms.Label();
            this.lbDireccionResidencia = new System.Windows.Forms.Label();
            this.txtDireccionResidencia = new System.Windows.Forms.TextBox();
            this.lbColegioElectoral = new System.Windows.Forms.Label();
            this.txtColegioElectoral = new System.Windows.Forms.TextBox();
            this.lbUbicacionColegio = new System.Windows.Forms.Label();
            this.txtUbicacionColegio = new System.Windows.Forms.TextBox();
            this.lbFechaExpiracion = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbLugarNacimiento = new System.Windows.Forms.Label();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCiudadanos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.mtxtCedulaAnterior = new System.Windows.Forms.MaskedTextBox();
            this.lbCedulaAnterior = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1003, 39);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Registro de Ciudadano";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(102, 32);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(217, 25);
            this.txtNombres.TabIndex = 1;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCedula.Location = new System.Drawing.Point(140, 81);
            this.mtxtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCedula.Mask = "000-0000000-0";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(179, 25);
            this.mtxtCedula.TabIndex = 3;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(186, 165);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(89, 22);
            this.rdbFemenino.TabIndex = 8;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(412, 32);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(217, 25);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarNacimiento.Location = new System.Drawing.Point(431, 81);
            this.txtLugarNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(198, 25);
            this.txtLugarNacimiento.TabIndex = 4;
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(73, 389);
            this.txtSector.Margin = new System.Windows.Forms.Padding(2);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(129, 25);
            this.txtSector.TabIndex = 16;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(441, 124);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(188, 25);
            this.txtNacionalidad.TabIndex = 6;
            // 
            // lbNombres
            // 
            this.lbNombres.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(18, 35);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(76, 18);
            this.lbNombres.TabIndex = 11;
            this.lbNombres.Text = "Nombres";
            this.lbNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApellidos
            // 
            this.lbApellidos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(335, 35);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(72, 18);
            this.lbApellidos.TabIndex = 12;
            this.lbApellidos.Text = "Apellidos";
            this.lbApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCedula
            // 
            this.lbCedula.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(18, 84);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(108, 18);
            this.lbCedula.TabIndex = 13;
            this.lbCedula.Text = "No. de cédula";
            this.lbCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSangre
            // 
            this.lbSangre.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSangre.Location = new System.Drawing.Point(335, 206);
            this.lbSangre.Name = "lbSangre";
            this.lbSangre.Size = new System.Drawing.Size(112, 18);
            this.lbSangre.TabIndex = 16;
            this.lbSangre.Text = "Tipo de sangre";
            this.lbSangre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNacionalidad
            // 
            this.lbNacionalidad.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNacionalidad.Location = new System.Drawing.Point(335, 127);
            this.lbNacionalidad.Name = "lbNacionalidad";
            this.lbNacionalidad.Size = new System.Drawing.Size(101, 18);
            this.lbNacionalidad.TabIndex = 15;
            this.lbNacionalidad.Text = "Nacionalidad";
            this.lbNacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNacimiento.Location = new System.Drawing.Point(18, 127);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(153, 18);
            this.lbFechaNacimiento.TabIndex = 14;
            this.lbFechaNacimiento.Text = "Fecha de nacimiento";
            this.lbFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxtCedulaAnterior);
            this.groupBox1.Controls.Add(this.lbCedulaAnterior);
            this.groupBox1.Controls.Add(this.btnBuscarFoto);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.dtpFechaExpiracion);
            this.groupBox1.Controls.Add(this.lbCodigoPostal);
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.lbRegistroNacimiento);
            this.groupBox1.Controls.Add(this.txtRegistroNacimiento);
            this.groupBox1.Controls.Add(this.lbMunicipio);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.lbSector);
            this.groupBox1.Controls.Add(this.lbDireccionResidencia);
            this.groupBox1.Controls.Add(this.txtDireccionResidencia);
            this.groupBox1.Controls.Add(this.lbColegioElectoral);
            this.groupBox1.Controls.Add(this.txtColegioElectoral);
            this.groupBox1.Controls.Add(this.lbUbicacionColegio);
            this.groupBox1.Controls.Add(this.txtUbicacionColegio);
            this.groupBox1.Controls.Add(this.lbFechaExpiracion);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.cbEstadoCivil);
            this.groupBox1.Controls.Add(this.lbEstadoCivil);
            this.groupBox1.Controls.Add(this.cbSangre);
            this.groupBox1.Controls.Add(this.lbSexo);
            this.groupBox1.Controls.Add(this.lbLugarNacimiento);
            this.groupBox1.Controls.Add(this.rdbMasculino);
            this.groupBox1.Controls.Add(this.lbSangre);
            this.groupBox1.Controls.Add(this.mtxtCedula);
            this.groupBox1.Controls.Add(this.lbNacionalidad);
            this.groupBox1.Controls.Add(this.rdbFemenino);
            this.groupBox1.Controls.Add(this.lbFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtSector);
            this.groupBox1.Controls.Add(this.lbCedula);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lbApellidos);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.lbNombres);
            this.groupBox1.Controls.Add(this.txtLugarNacimiento);
            this.groupBox1.Controls.Add(this.txtNacionalidad);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 431);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos de su cédula";
            // 
            // dtpFechaExpiracion
            // 
            this.dtpFechaExpiracion.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaExpiracion.Location = new System.Drawing.Point(523, 250);
            this.dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            this.dtpFechaExpiracion.Size = new System.Drawing.Size(106, 25);
            this.dtpFechaExpiracion.TabIndex = 13;
            // 
            // lbCodigoPostal
            // 
            this.lbCodigoPostal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoPostal.Location = new System.Drawing.Point(452, 392);
            this.lbCodigoPostal.Name = "lbCodigoPostal";
            this.lbCodigoPostal.Size = new System.Drawing.Size(102, 18);
            this.lbCodigoPostal.TabIndex = 41;
            this.lbCodigoPostal.Text = "Código postal";
            this.lbCodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(559, 389);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(126, 25);
            this.txtCodigoPostal.TabIndex = 18;
            // 
            // lbRegistroNacimiento
            // 
            this.lbRegistroNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroNacimiento.Location = new System.Drawing.Point(335, 157);
            this.lbRegistroNacimiento.Name = "lbRegistroNacimiento";
            this.lbRegistroNacimiento.Size = new System.Drawing.Size(95, 38);
            this.lbRegistroNacimiento.TabIndex = 39;
            this.lbRegistroNacimiento.Text = "Registro de nacimiento";
            this.lbRegistroNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistroNacimiento
            // 
            this.txtRegistroNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroNacimiento.Location = new System.Drawing.Point(441, 164);
            this.txtRegistroNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistroNacimiento.Name = "txtRegistroNacimiento";
            this.txtRegistroNacimiento.Size = new System.Drawing.Size(188, 25);
            this.txtRegistroNacimiento.TabIndex = 9;
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMunicipio.Location = new System.Drawing.Point(229, 392);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(78, 18);
            this.lbMunicipio.TabIndex = 37;
            this.lbMunicipio.Text = "Municipio";
            this.lbMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(311, 389);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(2);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(122, 25);
            this.txtMunicipio.TabIndex = 17;
            // 
            // lbSector
            // 
            this.lbSector.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSector.Location = new System.Drawing.Point(18, 392);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(51, 18);
            this.lbSector.TabIndex = 35;
            this.lbSector.Text = "Sector";
            this.lbSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDireccionResidencia
            // 
            this.lbDireccionResidencia.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccionResidencia.Location = new System.Drawing.Point(18, 349);
            this.lbDireccionResidencia.Name = "lbDireccionResidencia";
            this.lbDireccionResidencia.Size = new System.Drawing.Size(172, 18);
            this.lbDireccionResidencia.TabIndex = 34;
            this.lbDireccionResidencia.Text = "Dirección de residencia";
            this.lbDireccionResidencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccionResidencia
            // 
            this.txtDireccionResidencia.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionResidencia.Location = new System.Drawing.Point(195, 346);
            this.txtDireccionResidencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionResidencia.Name = "txtDireccionResidencia";
            this.txtDireccionResidencia.Size = new System.Drawing.Size(761, 25);
            this.txtDireccionResidencia.TabIndex = 15;
            // 
            // lbColegioElectoral
            // 
            this.lbColegioElectoral.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColegioElectoral.Location = new System.Drawing.Point(18, 253);
            this.lbColegioElectoral.Name = "lbColegioElectoral";
            this.lbColegioElectoral.Size = new System.Drawing.Size(123, 18);
            this.lbColegioElectoral.TabIndex = 32;
            this.lbColegioElectoral.Text = "Colegio electoral";
            this.lbColegioElectoral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtColegioElectoral
            // 
            this.txtColegioElectoral.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColegioElectoral.Location = new System.Drawing.Point(151, 250);
            this.txtColegioElectoral.Margin = new System.Windows.Forms.Padding(2);
            this.txtColegioElectoral.Name = "txtColegioElectoral";
            this.txtColegioElectoral.Size = new System.Drawing.Size(164, 25);
            this.txtColegioElectoral.TabIndex = 12;
            // 
            // lbUbicacionColegio
            // 
            this.lbUbicacionColegio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacionColegio.Location = new System.Drawing.Point(18, 288);
            this.lbUbicacionColegio.Name = "lbUbicacionColegio";
            this.lbUbicacionColegio.Size = new System.Drawing.Size(158, 36);
            this.lbUbicacionColegio.TabIndex = 30;
            this.lbUbicacionColegio.Text = "Ubicación del colegio electoral";
            this.lbUbicacionColegio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUbicacionColegio
            // 
            this.txtUbicacionColegio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionColegio.Location = new System.Drawing.Point(187, 294);
            this.txtUbicacionColegio.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbicacionColegio.Name = "txtUbicacionColegio";
            this.txtUbicacionColegio.Size = new System.Drawing.Size(769, 25);
            this.txtUbicacionColegio.TabIndex = 14;
            // 
            // lbFechaExpiracion
            // 
            this.lbFechaExpiracion.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaExpiracion.Location = new System.Drawing.Point(335, 244);
            this.lbFechaExpiracion.Name = "lbFechaExpiracion";
            this.lbFechaExpiracion.Size = new System.Drawing.Size(179, 37);
            this.lbFechaExpiracion.TabIndex = 26;
            this.lbFechaExpiracion.Text = "Fecha de expiración del documento";
            this.lbFechaExpiracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(180, 124);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(139, 25);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Unión libre"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(111, 202);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(194, 26);
            this.cbEstadoCivil.TabIndex = 10;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoCivil.Location = new System.Drawing.Point(18, 206);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(87, 18);
            this.lbEstadoCivil.TabIndex = 23;
            this.lbEstadoCivil.Text = "Estado civil";
            this.lbEstadoCivil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSangre
            // 
            this.cbSangre.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbSangre.Location = new System.Drawing.Point(455, 202);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(174, 26);
            this.cbSangre.TabIndex = 11;
            // 
            // lbSexo
            // 
            this.lbSexo.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(18, 167);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(40, 18);
            this.lbSexo.TabIndex = 21;
            this.lbSexo.Text = "Sexo";
            this.lbSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLugarNacimiento
            // 
            this.lbLugarNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLugarNacimiento.Location = new System.Drawing.Point(335, 73);
            this.lbLugarNacimiento.Name = "lbLugarNacimiento";
            this.lbLugarNacimiento.Size = new System.Drawing.Size(91, 40);
            this.lbLugarNacimiento.TabIndex = 18;
            this.lbLugarNacimiento.Text = "Lugar de nacimiento";
            this.lbLugarNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(80, 165);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(91, 22);
            this.rdbMasculino.TabIndex = 7;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(33, 484);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(271, 40);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(365, 484);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(271, 40);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvCiudadanos
            // 
            this.dgvCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudadanos.Location = new System.Drawing.Point(12, 534);
            this.dgvCiudadanos.Name = "dgvCiudadanos";
            this.dgvCiudadanos.Size = new System.Drawing.Size(975, 142);
            this.dgvCiudadanos.TabIndex = 20;
            this.dgvCiudadanos.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(697, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(271, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(670, 24);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(277, 210);
            this.pbFoto.TabIndex = 43;
            this.pbFoto.TabStop = false;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.BackColor = System.Drawing.Color.Gray;
            this.btnBuscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFoto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFoto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFoto.Location = new System.Drawing.Point(670, 246);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(286, 37);
            this.btnBuscarFoto.TabIndex = 20;
            this.btnBuscarFoto.Text = "Buscar foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = false;
            // 
            // mtxtCedulaAnterior
            // 
            this.mtxtCedulaAnterior.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCedulaAnterior.Location = new System.Drawing.Point(832, 392);
            this.mtxtCedulaAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCedulaAnterior.Mask = "000-0000000-0";
            this.mtxtCedulaAnterior.Name = "mtxtCedulaAnterior";
            this.mtxtCedulaAnterior.Size = new System.Drawing.Size(124, 25);
            this.mtxtCedulaAnterior.TabIndex = 19;
            // 
            // lbCedulaAnterior
            // 
            this.lbCedulaAnterior.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedulaAnterior.Location = new System.Drawing.Point(711, 395);
            this.lbCedulaAnterior.Name = "lbCedulaAnterior";
            this.lbCedulaAnterior.Size = new System.Drawing.Size(116, 18);
            this.lbCedulaAnterior.TabIndex = 48;
            this.lbCedulaAnterior.Text = "Cédula anterior";
            this.lbCedulaAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 688);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCiudadanos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Cedula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ciudadano";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.TextBox txtSector;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbSangre;
        private System.Windows.Forms.Label lbNacionalidad;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLugarNacimiento;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.ComboBox cbSangre;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.Label lbFechaExpiracion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lbUbicacionColegio;
        private System.Windows.Forms.TextBox txtUbicacionColegio;
        private System.Windows.Forms.Label lbColegioElectoral;
        private System.Windows.Forms.TextBox txtColegioElectoral;
        private System.Windows.Forms.Label lbDireccionResidencia;
        private System.Windows.Forms.TextBox txtDireccionResidencia;
        private System.Windows.Forms.Label lbSector;
        private System.Windows.Forms.Label lbMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label lbRegistroNacimiento;
        private System.Windows.Forms.TextBox txtRegistroNacimiento;
        private System.Windows.Forms.Label lbCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.DateTimePicker dtpFechaExpiracion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCiudadanos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.MaskedTextBox mtxtCedulaAnterior;
        private System.Windows.Forms.Label lbCedulaAnterior;
    }
}

