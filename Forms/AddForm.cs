﻿using Cinema.Clases;

namespace Cinema.Forms
{
    public partial class AddForm : Form
    {
        internal List<Pelicula> Peliculas { get; set; } = new();

        /// <summary>
        /// Indica si se completo el proceso de agregado
        /// </summary>
        public bool Success { get; set; } = false;

        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Secundario(object sender, EventArgs e)
        {
            Pelicula p = new()
            {
                Nombre = txtName.Text,
                Genero = txtCategory.Text,
                Clasificacion = txtClassification.Text,
                Precio = float.Parse(txtPrice.Text)
            };

            Peliculas.Add(p);

            dgvPeliculas.DataSource = Peliculas;
            dgvPeliculas.AutoGenerateColumns = true;
            dgvPeliculas.Enabled = false;

            erpValidar.Clear();
            if (!Validate())
            {
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Segur@ que quieres Cancelar?", @"Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                this.Focus();
            }
            Success = false;
        }
        private void Limpiar()
        {
            txtName.Clear();
            txtCategory.Clear();
            txtClassification.Clear();
            txtPrice.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Success = true;
            this.Close();
        }

        private bool Varlidar()
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                erpValidar.SetError(txtName, "required");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtCategory.Text))
            {
                erpValidar.SetError(txtCategory, "required");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtClassification.Text))
            {
                erpValidar.SetError(txtClassification, "required");
                validate = false;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                erpValidar.SetError(txtName, "required");
                validate = false;
            }

            return validate;
        }
    }
}
