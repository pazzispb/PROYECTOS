using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CRUD_CEDULA_JSON
{
    public enum FormMode
    {
        Adding,
        Deleting,
        Updating,
        None //The form is totally unabled
    }
    public partial class Cedula : Form
    {
        FormMode mode = FormMode.None;
        int id; //Id del ciudadano
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
        void EstadoInicial()
        {
            LimpiarCampos();
            gbDatosCedula.Enabled = false;
            DeshabilitarBotones();
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnCrear.Enabled = true;
            mode = FormMode.None;
            ObtenerCiudadanos();
            cbEstadoCivil.SelectedIndex = 0;
            cbSangre.SelectedIndex = 0;
            id = 0;
        }
        void DeshabilitarBotones()
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCrear.Enabled = false;
        }
        private void Cedula_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            mode = FormMode.Adding;
            gbDatosCedula.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombres.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }
        void LimpiarCampos()
        {
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
            pbFoto.ImageLocation = null;

        }
        int SiguienteID()
        {
            return LeerJson().Max(x=> x.Id) + 1;
        }
        void ObtenerCiudadanos()
        {
            dgvCiudadanos.DataSource = null;
            dgvCiudadanos.DataSource = LeerJson();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case FormMode.Adding:
                        {
                            if (CamposVacios()) break;
                            var Objeto = new Ciudadano
                            {
                                Id = SiguienteID(),
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
                                CodigoPostal = int.Parse(txtColegioElectoral.Text),
                                FechaRegistro = DateTime.Now
                            };
                            var Lista = LeerJson();
                            Lista.Add(Objeto);
                            EscribirJson(Lista);
                            MessageBox.Show("Ciudadano registrado con éxito", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                            break;
                        }
                    case FormMode.Updating:
                        {
                            if (CamposVacios()) break;
                            var Objeto = new Ciudadano
                            {
                                Id = id,
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
                                CodigoPostal = int.Parse(txtColegioElectoral.Text),
                                FechaRegistro = DateTime.Now
                            };
                            var Lista = LeerJson();
                            Lista.Remove(Lista.FirstOrDefault(x=>x.Id == id));
                            Lista.Add(Objeto);
                            EscribirJson(Lista);
                            MessageBox.Show("Ciudadano modificado con éxito", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                            break;
                        }
                    case FormMode.Deleting:
                        {
                            var Lista = LeerJson();
                            Lista.Remove(Lista.FirstOrDefault(x => x.Id == id));
                            EscribirJson(Lista);
                            MessageBox.Show("Ciudadano eliminado con éxito", "NOTIFICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EstadoInicial();
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool CamposVacios()
        {
            foreach (Control c in gbDatosCedula.Controls)
            {
                if (c is TextBox || c is MaskedTextBox && c.Name != "mtxtCedulaAnterior")
                    if (String.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show("Hay campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
            }
            return false;
        }
        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Sexo = rdbMasculino.Checked ? 'M' : 'F';
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            btnCancelar.Enabled = true;
            mode = FormMode.Updating;
        }
        List<Ciudadano> LeerJson()
        {
            var json = String.Empty;
            var listaCiudadanos = new List<Ciudadano>();
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}//ciudadanos.json";
            if (File.Exists(path))
            {
                json = File.ReadAllText(path, Encoding.UTF8);
                listaCiudadanos = JsonConvert.DeserializeObject<List<Ciudadano>>(json);
            }
            return listaCiudadanos;
        }
        void EscribirJson(List<Ciudadano> listaCiudadanos)
        {
            var json = JsonConvert.SerializeObject(listaCiudadanos);
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}//ciudadanos.json";
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(json);
            sw.Close();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DeshabilitarBotones();
            btnCancelar.Enabled = true;
            mode = FormMode.Deleting;
        }

        private void dgvCiudadanos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(mode == FormMode.Updating || mode == FormMode.Deleting)
            {
                id = int.Parse(dgvCiudadanos.CurrentRow.Cells[0].Value.ToString());
                var ciudadano = LeerJson().FirstOrDefault(x=> x.Id == id);
                txtApellidos.Text = ciudadano.Apellidos;
                txtCodigoPostal.Text = ciudadano.CodigoPostal.ToString();
                txtColegioElectoral.Text = ciudadano.ColegioElectoral.ToString();
                txtDireccionResidencia.Text = ciudadano.DireccionResidencia;
                txtLugarNacimiento.Text = ciudadano.LugarNacimiento;
                txtMunicipio.Text = ciudadano.Municipio;
                txtNacionalidad.Text = ciudadano.Nacionalidad;
                txtNombres.Text = ciudadano.Nombres;
                txtRegistroNacimiento.Text = ciudadano.RegistroNacimiento;
                txtSector.Text = ciudadano.Sector;
                txtUbicacionColegio.Text = ciudadano.UbicacionColegio;
                mtxtCedula.Text = ciudadano.Cedula;
                mtxtCedulaAnterior.Text = ciudadano.CedulaAnterior;
                pbFoto.ImageLocation = ciudadano.URLFoto;
                if (ciudadano.Sexo == 'M') rdbMasculino.Checked = true;
                else rdbFemenino.Checked = true;
                dtpFechaNacimiento.Value = ciudadano.FechaNacimiento;
                dtpFechaExpiracion.Value = ciudadano.FechaExpiracion;
                cbEstadoCivil.SelectedIndex = cbEstadoCivil.Items.IndexOf(ciudadano.EstadoCivil);
                cbSangre.SelectedIndex = cbSangre.Items.IndexOf(ciudadano.Sangre);
                DeshabilitarBotones();
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                if (mode == FormMode.Updating) gbDatosCedula.Enabled = true;
            }
        }
    }
}