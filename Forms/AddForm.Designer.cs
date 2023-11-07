namespace Cinema.Forms
{
    partial class AddForm
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
            lblName = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            lblCategory = new Label();
            txtClassification = new TextBox();
            lblClassification = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            dgvPeliculas = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(78, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(200, 65);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(281, 27);
            txtName.TabIndex = 1;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(200, 161);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(281, 27);
            txtCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(78, 165);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Genero";
            // 
            // txtClassification
            // 
            txtClassification.Location = new Point(200, 265);
            txtClassification.Margin = new Padding(3, 4, 3, 4);
            txtClassification.Name = "txtClassification";
            txtClassification.Size = new Size(281, 27);
            txtClassification.TabIndex = 5;
            // 
            // lblClassification
            // 
            lblClassification.AutoSize = true;
            lblClassification.Location = new Point(78, 269);
            lblClassification.Name = "lblClassification";
            lblClassification.Size = new Size(92, 20);
            lblClassification.TabIndex = 4;
            lblClassification.Text = "Clasificación";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(200, 384);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(281, 27);
            txtPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(78, 388);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Precio";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(131, 487);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Secundario;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(395, 486);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToOrderColumns = true;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Enabled = false;
            dgvPeliculas.Location = new Point(559, 65);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.RowTemplate.Height = 29;
            dgvPeliculas.Size = new Size(409, 452);
            dgvPeliculas.TabIndex = 10;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(255, 489);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 600);
            Controls.Add(btnClose);
            Controls.Add(dgvPeliculas);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtClassification);
            Controls.Add(lblClassification);
            Controls.Add(txtCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddForm";
            Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtCategory;
        private Label lblCategory;
        private TextBox txtClassification;
        private Label lblClassification;
        private TextBox txtPrice;
        private Label lblPrice;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnClose;
        public DataGridView dgvPeliculas;
    }
}