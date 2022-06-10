using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_GASTOS
{
    public partial class ConceptManagement : Form
    {
        FormMode mode = FormMode.None;
        public ConceptManagement()
        {
            InitializeComponent();
            SetInitialState();
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
        void ClearFields()
        {
            txtName.Clear();
            txtDescription.Clear();
            lbID.Text = "-";
            chbIsVisible.Checked = false;
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
            GetConcepts();
        }

        void GetConcepts()
        {
            //Add implementation with JSON
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mode = FormMode.None;
            SetInitialState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvConcept.Rows.Count > 0)
            {
                mode = FormMode.Deleting;
                MessageBox.Show("Seleccione una entrada a eliminar dentro de la tabla.");
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("No hay registros para eliminar");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvConcept.Rows.Count > 0)
            {
                mode = FormMode.Updating;
                MessageBox.Show("Seleccione una entrada a modificar dentro de la tabla.");
                UnableButtons();
                btnCancel.Enabled = true;
            }
            else MessageBox.Show("No hay registros para modificar");
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
    }
}
