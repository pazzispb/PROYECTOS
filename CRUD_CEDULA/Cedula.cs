using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_CEDULA
{
    public partial class Cedula : Form
    {
        List<Ciudadano> Lista = new List<Ciudadano>();
        public Cedula()
        {
            InitializeComponent();
        }
        char Sexo = 'M';
        string URLImagen = "";
        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Explorador = new OpenFileDialog();
            Explorador.Filter = "Archivos de Imagenes(*.jpg; *.jpeg; *.gif; *.bmp) | *.jpg; *.jpeg; *.gif; *.bmp";
            if(Explorador.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = new Bitmap(Explorador.FileName);
                URLImagen = Explorador.FileName;
            }
        }
        private void Cedula_Load(object sender, EventArgs e)
        {
            cbEstadoCivil.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            gbDatosCedula.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCrear.Enabled = false;
            txtNombres.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        void LimpiarCampos()
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            gbDatosCedula.Enabled = false;
            btnCrear.Enabled = true;
            txtApellidos.Clear();
            txtCodigoPostal.Clear();
            txtColegioElectoral.Clear();
            txtDireccionResidencia.Clear();
            txtLugarNacimiento.Clear();
            txtMunicipio.Clear();
            txtNacionalidad.Clear();
            txtNombres.Clear();
            txtRegistroNacimiento.Clear();
            txtSector.Clear();
            txtUbicacionColegio.Clear();
            mtxtCedula.Clear();
            mtxtCedulaAnterior.Clear();
            pbFoto.Image = null;
        }
        void ObtenerCiudadanos()
        {
            dgvCiudadanos.DataSource = null;
            dgvCiudadanos.DataSource = Lista;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int CodigoPostal = 0, ColegioElectoral = 0;
            if (!ValidarCampos().Item1)
            {
                CodigoPostal = int.Parse(txtCodigoPostal.Text);
            }
            if (!ValidarCampos().Item2)
            {
                ColegioElectoral = int.Parse(txtColegioElectoral.Text);
            }
            var Objeto = new Ciudadano
            {
                Cedula = mtxtCedula.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                LugarNacimiento = txtLugarNacimiento.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Nacionalidad = txtNacionalidad.Text,
                Sexo = Sexo,
                Sangre = cbSangre.Text,
                EstadoCivil = cbEstadoCivil.Text,
                FechaExpiracion = dtpFechaExpiracion.Value,
                URLFoto = URLImagen,
                CedulaAnterior = mtxtCedulaAnterior.Text,
                ColegioElectoral = ColegioElectoral,
                UbicacionColegio = txtUbicacionColegio.Text,
                DireccionResidencia = txtDireccionResidencia.Text,
                Sector = txtSector.Text,
                Municipio = txtMunicipio.Text,
                RegistroNacimiento = txtRegistroNacimiento.Text,
                CodigoPostal = CodigoPostal,
                FechaRegistro = DateTime.Now
            };
            Lista.Add(Objeto);
            LimpiarCampos();
            ObtenerCiudadanos();
            MessageBox.Show("Ciudadano registrado con éxito","NOTIFICACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        (bool,bool) ValidarCampos() //revisa si los campos de Codigo Postal y Colegio Electoral estan vacios
        {
            return (string.IsNullOrWhiteSpace(txtCodigoPostal.Text),string.IsNullOrWhiteSpace(txtColegioElectoral.Text));
        }
        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = rdbMasculino.Checked ? 'M' : 'F';
        }
    }
}
