namespace CRUD_CEDULA_JSON
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
            this.gbDatosCedula = new System.Windows.Forms.GroupBox();
            this.mtxtCedulaAnterior = new System.Windows.Forms.MaskedTextBox();
            this.lbCedulaAnterior = new System.Windows.Forms.Label();
            this.btnBuscarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbDatosCedula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1337, 48);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Registro de Ciudadano";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(136, 39);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(288, 30);
            this.txtNombres.TabIndex = 1;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCedula.Location = new System.Drawing.Point(187, 100);
            this.mtxtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCedula.Mask = "000-0000000-0";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.PromptChar = ' ';
            this.mtxtCedula.Size = new System.Drawing.Size(237, 30);
            this.mtxtCedula.TabIndex = 3;
            this.mtxtCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemenino.Location = new System.Drawing.Point(248, 203);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(108, 26);
            this.rdbFemenino.TabIndex = 8;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(549, 39);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(288, 30);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarNacimiento.Location = new System.Drawing.Point(575, 100);
            this.txtLugarNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(263, 30);
            this.txtLugarNacimiento.TabIndex = 4;
            // 
            // txtSector
            // 
            this.txtSector.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSector.Location = new System.Drawing.Point(97, 479);
            this.txtSector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSector.Name = "txtSector";
            this.txtSector.Size = new System.Drawing.Size(171, 30);
            this.txtSector.TabIndex = 16;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(588, 153);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(249, 30);
            this.txtNacionalidad.TabIndex = 6;
            // 
            // lbNombres
            // 
            this.lbNombres.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.Location = new System.Drawing.Point(24, 43);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(101, 22);
            this.lbNombres.TabIndex = 11;
            this.lbNombres.Text = "Nombres";
            this.lbNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApellidos
            // 
            this.lbApellidos.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(447, 43);
            this.lbApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(96, 22);
            this.lbApellidos.TabIndex = 12;
            this.lbApellidos.Text = "Apellidos";
            this.lbApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCedula
            // 
            this.lbCedula.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(24, 103);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(144, 22);
            this.lbCedula.TabIndex = 13;
            this.lbCedula.Text = "No. de cédula";
            this.lbCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSangre
            // 
            this.lbSangre.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSangre.Location = new System.Drawing.Point(447, 254);
            this.lbSangre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSangre.Name = "lbSangre";
            this.lbSangre.Size = new System.Drawing.Size(149, 22);
            this.lbSangre.TabIndex = 16;
            this.lbSangre.Text = "Tipo de sangre";
            this.lbSangre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNacionalidad
            // 
            this.lbNacionalidad.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNacionalidad.Location = new System.Drawing.Point(447, 156);
            this.lbNacionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNacionalidad.Name = "lbNacionalidad";
            this.lbNacionalidad.Size = new System.Drawing.Size(135, 22);
            this.lbNacionalidad.TabIndex = 15;
            this.lbNacionalidad.Text = "Nacionalidad";
            this.lbNacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNacimiento.Location = new System.Drawing.Point(24, 156);
            this.lbFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(204, 22);
            this.lbFechaNacimiento.TabIndex = 14;
            this.lbFechaNacimiento.Text = "Fecha de nacimiento";
            this.lbFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDatosCedula
            // 
            this.gbDatosCedula.Controls.Add(this.mtxtCedulaAnterior);
            this.gbDatosCedula.Controls.Add(this.lbCedulaAnterior);
            this.gbDatosCedula.Controls.Add(this.btnBuscarFoto);
            this.gbDatosCedula.Controls.Add(this.pbFoto);
            this.gbDatosCedula.Controls.Add(this.dtpFechaExpiracion);
            this.gbDatosCedula.Controls.Add(this.lbCodigoPostal);
            this.gbDatosCedula.Controls.Add(this.txtCodigoPostal);
            this.gbDatosCedula.Controls.Add(this.lbRegistroNacimiento);
            this.gbDatosCedula.Controls.Add(this.txtRegistroNacimiento);
            this.gbDatosCedula.Controls.Add(this.lbMunicipio);
            this.gbDatosCedula.Controls.Add(this.txtMunicipio);
            this.gbDatosCedula.Controls.Add(this.lbSector);
            this.gbDatosCedula.Controls.Add(this.lbDireccionResidencia);
            this.gbDatosCedula.Controls.Add(this.txtDireccionResidencia);
            this.gbDatosCedula.Controls.Add(this.lbColegioElectoral);
            this.gbDatosCedula.Controls.Add(this.txtColegioElectoral);
            this.gbDatosCedula.Controls.Add(this.lbUbicacionColegio);
            this.gbDatosCedula.Controls.Add(this.txtUbicacionColegio);
            this.gbDatosCedula.Controls.Add(this.lbFechaExpiracion);
            this.gbDatosCedula.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosCedula.Controls.Add(this.cbEstadoCivil);
            this.gbDatosCedula.Controls.Add(this.lbEstadoCivil);
            this.gbDatosCedula.Controls.Add(this.cbSangre);
            this.gbDatosCedula.Controls.Add(this.lbSexo);
            this.gbDatosCedula.Controls.Add(this.lbLugarNacimiento);
            this.gbDatosCedula.Controls.Add(this.rdbMasculino);
            this.gbDatosCedula.Controls.Add(this.lbSangre);
            this.gbDatosCedula.Controls.Add(this.mtxtCedula);
            this.gbDatosCedula.Controls.Add(this.lbNacionalidad);
            this.gbDatosCedula.Controls.Add(this.rdbFemenino);
            this.gbDatosCedula.Controls.Add(this.lbFechaNacimiento);
            this.gbDatosCedula.Controls.Add(this.txtSector);
            this.gbDatosCedula.Controls.Add(this.lbCedula);
            this.gbDatosCedula.Controls.Add(this.txtNombres);
            this.gbDatosCedula.Controls.Add(this.lbApellidos);
            this.gbDatosCedula.Controls.Add(this.txtApellidos);
            this.gbDatosCedula.Controls.Add(this.lbNombres);
            this.gbDatosCedula.Controls.Add(this.txtLugarNacimiento);
            this.gbDatosCedula.Controls.Add(this.txtNacionalidad);
            this.gbDatosCedula.Enabled = false;
            this.gbDatosCedula.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCedula.Location = new System.Drawing.Point(16, 52);
            this.gbDatosCedula.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosCedula.Name = "gbDatosCedula";
            this.gbDatosCedula.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosCedula.Size = new System.Drawing.Size(1300, 530);
            this.gbDatosCedula.TabIndex = 17;
            this.gbDatosCedula.TabStop = false;
            this.gbDatosCedula.Text = "Ingrese los datos de su cédula";
            // 
            // mtxtCedulaAnterior
            // 
            this.mtxtCedulaAnterior.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCedulaAnterior.Location = new System.Drawing.Point(1109, 482);
            this.mtxtCedulaAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtCedulaAnterior.Mask = "000-0000000-0";
            this.mtxtCedulaAnterior.Name = "mtxtCedulaAnterior";
            this.mtxtCedulaAnterior.PromptChar = ' ';
            this.mtxtCedulaAnterior.Size = new System.Drawing.Size(164, 30);
            this.mtxtCedulaAnterior.TabIndex = 19;
            this.mtxtCedulaAnterior.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbCedulaAnterior
            // 
            this.lbCedulaAnterior.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedulaAnterior.Location = new System.Drawing.Point(948, 486);
            this.lbCedulaAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedulaAnterior.Name = "lbCedulaAnterior";
            this.lbCedulaAnterior.Size = new System.Drawing.Size(155, 22);
            this.lbCedulaAnterior.TabIndex = 48;
            this.lbCedulaAnterior.Text = "Cédula anterior";
            this.lbCedulaAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscarFoto
            // 
            this.btnBuscarFoto.BackColor = System.Drawing.Color.Gray;
            this.btnBuscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarFoto.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFoto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFoto.Location = new System.Drawing.Point(893, 303);
            this.btnBuscarFoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFoto.Name = "btnBuscarFoto";
            this.btnBuscarFoto.Size = new System.Drawing.Size(381, 46);
            this.btnBuscarFoto.TabIndex = 20;
            this.btnBuscarFoto.Text = "Buscar foto";
            this.btnBuscarFoto.UseVisualStyleBackColor = false;
            this.btnBuscarFoto.Click += new System.EventHandler(this.btnBuscarFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(893, 30);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(369, 258);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 43;
            this.pbFoto.TabStop = false;
            // 
            // dtpFechaExpiracion
            // 
            this.dtpFechaExpiracion.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaExpiracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaExpiracion.Location = new System.Drawing.Point(697, 308);
            this.dtpFechaExpiracion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            this.dtpFechaExpiracion.Size = new System.Drawing.Size(140, 30);
            this.dtpFechaExpiracion.TabIndex = 13;
            // 
            // lbCodigoPostal
            // 
            this.lbCodigoPostal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoPostal.Location = new System.Drawing.Point(603, 482);
            this.lbCodigoPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigoPostal.Name = "lbCodigoPostal";
            this.lbCodigoPostal.Size = new System.Drawing.Size(136, 22);
            this.lbCodigoPostal.TabIndex = 41;
            this.lbCodigoPostal.Text = "Código postal";
            this.lbCodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(745, 479);
            this.txtCodigoPostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(167, 30);
            this.txtCodigoPostal.TabIndex = 18;
            // 
            // lbRegistroNacimiento
            // 
            this.lbRegistroNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroNacimiento.Location = new System.Drawing.Point(447, 193);
            this.lbRegistroNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegistroNacimiento.Name = "lbRegistroNacimiento";
            this.lbRegistroNacimiento.Size = new System.Drawing.Size(127, 47);
            this.lbRegistroNacimiento.TabIndex = 39;
            this.lbRegistroNacimiento.Text = "Registro de nacimiento";
            this.lbRegistroNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRegistroNacimiento
            // 
            this.txtRegistroNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroNacimiento.Location = new System.Drawing.Point(588, 202);
            this.txtRegistroNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegistroNacimiento.Name = "txtRegistroNacimiento";
            this.txtRegistroNacimiento.Size = new System.Drawing.Size(249, 30);
            this.txtRegistroNacimiento.TabIndex = 9;
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMunicipio.Location = new System.Drawing.Point(305, 482);
            this.lbMunicipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(104, 22);
            this.lbMunicipio.TabIndex = 37;
            this.lbMunicipio.Text = "Municipio";
            this.lbMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.Location = new System.Drawing.Point(415, 479);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(161, 30);
            this.txtMunicipio.TabIndex = 17;
            // 
            // lbSector
            // 
            this.lbSector.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSector.Location = new System.Drawing.Point(24, 482);
            this.lbSector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSector.Name = "lbSector";
            this.lbSector.Size = new System.Drawing.Size(68, 22);
            this.lbSector.TabIndex = 35;
            this.lbSector.Text = "Sector";
            this.lbSector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDireccionResidencia
            // 
            this.lbDireccionResidencia.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccionResidencia.Location = new System.Drawing.Point(24, 430);
            this.lbDireccionResidencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDireccionResidencia.Name = "lbDireccionResidencia";
            this.lbDireccionResidencia.Size = new System.Drawing.Size(229, 22);
            this.lbDireccionResidencia.TabIndex = 34;
            this.lbDireccionResidencia.Text = "Dirección de residencia";
            this.lbDireccionResidencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccionResidencia
            // 
            this.txtDireccionResidencia.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionResidencia.Location = new System.Drawing.Point(260, 426);
            this.txtDireccionResidencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionResidencia.Name = "txtDireccionResidencia";
            this.txtDireccionResidencia.Size = new System.Drawing.Size(1013, 30);
            this.txtDireccionResidencia.TabIndex = 15;
            // 
            // lbColegioElectoral
            // 
            this.lbColegioElectoral.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColegioElectoral.Location = new System.Drawing.Point(24, 311);
            this.lbColegioElectoral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbColegioElectoral.Name = "lbColegioElectoral";
            this.lbColegioElectoral.Size = new System.Drawing.Size(164, 22);
            this.lbColegioElectoral.TabIndex = 32;
            this.lbColegioElectoral.Text = "Colegio electoral";
            this.lbColegioElectoral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtColegioElectoral
            // 
            this.txtColegioElectoral.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColegioElectoral.Location = new System.Drawing.Point(201, 308);
            this.txtColegioElectoral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColegioElectoral.Name = "txtColegioElectoral";
            this.txtColegioElectoral.Size = new System.Drawing.Size(217, 30);
            this.txtColegioElectoral.TabIndex = 12;
            // 
            // lbUbicacionColegio
            // 
            this.lbUbicacionColegio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUbicacionColegio.Location = new System.Drawing.Point(24, 354);
            this.lbUbicacionColegio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUbicacionColegio.Name = "lbUbicacionColegio";
            this.lbUbicacionColegio.Size = new System.Drawing.Size(211, 44);
            this.lbUbicacionColegio.TabIndex = 30;
            this.lbUbicacionColegio.Text = "Ubicación del colegio electoral";
            this.lbUbicacionColegio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUbicacionColegio
            // 
            this.txtUbicacionColegio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionColegio.Location = new System.Drawing.Point(249, 362);
            this.txtUbicacionColegio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUbicacionColegio.Name = "txtUbicacionColegio";
            this.txtUbicacionColegio.Size = new System.Drawing.Size(1024, 30);
            this.txtUbicacionColegio.TabIndex = 14;
            // 
            // lbFechaExpiracion
            // 
            this.lbFechaExpiracion.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaExpiracion.Location = new System.Drawing.Point(447, 300);
            this.lbFechaExpiracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaExpiracion.Name = "lbFechaExpiracion";
            this.lbFechaExpiracion.Size = new System.Drawing.Size(239, 46);
            this.lbFechaExpiracion.TabIndex = 26;
            this.lbFechaExpiracion.Text = "Fecha de expiración del documento";
            this.lbFechaExpiracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(240, 153);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(184, 30);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCivil.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Unión libre"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(148, 249);
            this.cbEstadoCivil.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(257, 30);
            this.cbEstadoCivil.TabIndex = 10;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoCivil.Location = new System.Drawing.Point(24, 254);
            this.lbEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(116, 22);
            this.lbEstadoCivil.TabIndex = 23;
            this.lbEstadoCivil.Text = "Estado civil";
            this.lbEstadoCivil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSangre
            // 
            this.cbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbSangre.Location = new System.Drawing.Point(607, 249);
            this.cbSangre.Margin = new System.Windows.Forms.Padding(4);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(231, 30);
            this.cbSangre.TabIndex = 11;
            // 
            // lbSexo
            // 
            this.lbSexo.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(24, 206);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(53, 22);
            this.lbSexo.TabIndex = 21;
            this.lbSexo.Text = "Sexo";
            this.lbSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLugarNacimiento
            // 
            this.lbLugarNacimiento.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLugarNacimiento.Location = new System.Drawing.Point(447, 90);
            this.lbLugarNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLugarNacimiento.Name = "lbLugarNacimiento";
            this.lbLugarNacimiento.Size = new System.Drawing.Size(121, 49);
            this.lbLugarNacimiento.TabIndex = 18;
            this.lbLugarNacimiento.Text = "Lugar de nacimiento";
            this.lbLugarNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasculino.Location = new System.Drawing.Point(107, 203);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(110, 26);
            this.rdbMasculino.TabIndex = 7;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(131, 596);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(175, 49);
            this.btnCrear.TabIndex = 21;
            this.btnCrear.Text = "Crear registro";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(743, 596);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(202, 49);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCiudadanos
            // 
            this.dgvCiudadanos.AllowUserToAddRows = false;
            this.dgvCiudadanos.AllowUserToDeleteRows = false;
            this.dgvCiudadanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudadanos.Location = new System.Drawing.Point(16, 657);
            this.dgvCiudadanos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCiudadanos.Name = "dgvCiudadanos";
            this.dgvCiudadanos.ReadOnly = true;
            this.dgvCiudadanos.RowHeadersWidth = 51;
            this.dgvCiudadanos.Size = new System.Drawing.Size(1300, 175);
            this.dgvCiudadanos.TabIndex = 20;
            this.dgvCiudadanos.TabStop = false;
            this.dgvCiudadanos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCiudadanos_RowHeaderMouseClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(974, 596);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(188, 49);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(335, 596);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(175, 49);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(539, 596);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(175, 49);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Cedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 847);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvCiudadanos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gbDatosCedula);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Cedula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ciudadano";
            this.Load += new System.EventHandler(this.Cedula_Load);
            this.gbDatosCedula.ResumeLayout(false);
            this.gbDatosCedula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudadanos)).EndInit();
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
        private System.Windows.Forms.GroupBox gbDatosCedula;
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
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

