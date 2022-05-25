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
                ColegioElectoral = int.Parse(txtColegioElectoral.Text),
                UbicacionColegio = txtUbicacionColegio.Text,
                DireccionResidencia = txtDireccionResidencia.Text,
                Sector = txtSector.Text,
                Municipio = txtMunicipio.Text,
                RegistroNacimiento = txtRegistroNacimiento.Text,
                CodigoPostal = int.Parse(txtCodigoPostal.Text),
                FechaRegistro = DateTime.Now
            };
            Lista.Add(Objeto);
            LimpiarCampos();
            ObtenerCiudadanos();
        }
    }
}
