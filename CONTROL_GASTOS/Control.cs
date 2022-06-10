using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROL_GASTOS.Models;

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
        FormMode mode = FormMode.None;
        public Control()
        {
            InitializeComponent();
            SetInitialState();
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
        int GetNextID()
        {
            return 1;
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
            gbData.Enabled = false;
            UnableButtons();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            GetExpenses();
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
                        break;
                    }
                case FormMode.Deleting:
                    {
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
    }
}
