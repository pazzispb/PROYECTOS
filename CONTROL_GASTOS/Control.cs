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
using CONTROL_GASTOS.Models;
using Newtonsoft.Json;

namespace CONTROL_GASTOS
{
    public enum FormMode
    {
        Adding,
        Deleting,
        Updating,
        None //The form is totally unabled
    }
    public partial class Control : Form
    {
        int id = 0;//Expense to be deleted or modified
        FormMode mode = FormMode.None;
        public Control()
        {
            InitializeComponent();
            SetInitialState();
        }
        int GetNextID()
        {
            //var conceptList = ReadJson();
            //return conceptList.Count() + 1;
            return 1;
        }
        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            var obj = new CategoryManagement();
            obj.ShowDialog();
        }

        private void btnConceptManagement_Click(object sender, EventArgs e)
        {
            var obj = new ConceptManagement();
            obj.ShowDialog();
        }
        void UnableButtons()
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = FormMode.Adding;
            gbData.Enabled = true;
            UnableButtons();
            lbID.Text = GetNextID().ToString();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }
        void ClearFields()
        {
            txtAmount.Clear();
            lbID.Text = "-";
            if(cmbCategory.Items.Count>0) cmbCategory.SelectedIndex = 0;
            if (cmbConcept.Items.Count > 0) cmbConcept.SelectedIndex = 0;
            dtpDate.Value = DateTime.Now;
        }
        void SetInitialState()
        {
            ClearFields();
            GetConcepts();
            GetCategories();
            gbData.Enabled = false;
            UnableButtons();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            GetExpenses();
            id = 0;
        }
        void GetExpenses()
        {
            //Add implementation with JSON
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            if (dgvExpenses.Rows.Count > 0)
            {
                mode = FormMode.Updating;
                MessageBox.Show("Seleccione una entrada a modificar dentro de la tabla.");
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("No hay registros para modificar");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.Rows.Count > 0)
            {
                mode = FormMode.Deleting;
                MessageBox.Show("Seleccione una entrada a eliminar dentro de la tabla.");
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("No hay registros para eliminar");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = FormMode.None;
            SetInitialState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case FormMode.Adding:
                    {
                        SetInitialState();
                        break;
                    }
                case FormMode.Deleting:
                    {
                        SetInitialState();
                        break;
                    }
                case FormMode.Updating:
                    {
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Opción Inválida");
                        break;
                    }
            }
        }
        private void cmbConcept_Click(object sender, EventArgs e)
        {
            GetConcepts();
        }
        void GetConcepts()
        {
            var json = string.Empty;
            var conceptList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\concepts.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }
            cmbConcept.DataSource = null;
            cmbConcept.DataSource = conceptList.FindAll(x => x.IsEnabled == true);
            cmbConcept.DisplayMember = "Name";
            cmbConcept.ValueMember = "Id";
        }
        void GetCategories()
        {
            var json = string.Empty;
            var conceptList = new List<Concept>();
            var pathFile = $"{AppDomain.CurrentDomain.BaseDirectory}\\categories.json";
            if (File.Exists(pathFile))
            {
                json = File.ReadAllText(pathFile, Encoding.UTF8);
                conceptList = JsonConvert.DeserializeObject<List<Concept>>(json);
            }
            cmbConcept.DataSource = null;
            cmbConcept.DataSource = conceptList;
            cmbConcept.DisplayMember = "Name";
            cmbConcept.ValueMember = "Id";
        }
    }
}
