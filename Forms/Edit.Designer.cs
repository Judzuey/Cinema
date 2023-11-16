namespace Cinema.Forms
{
    partial class Edit
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
            btnCancel = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtClassification = new TextBox();
            lblClassification = new Label();
            txtCategory = new TextBox();
            lblCategory = new Label();
            txtName = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(446, 488);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 31);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(192, 488);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 31);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Guardar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(192, 382);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(395, 27);
            txtPrice.TabIndex = 19;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(70, 386);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(50, 20);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Precio";
            // 
            // txtClassification
            // 
            txtClassification.Location = new Point(192, 263);
            txtClassification.Margin = new Padding(3, 4, 3, 4);
            txtClassification.Name = "txtClassification";
            txtClassification.Size = new Size(395, 27);
            txtClassification.TabIndex = 17;
            // 
            // lblClassification
            // 
            lblClassification.AutoSize = true;
            lblClassification.Location = new Point(70, 267);
            lblClassification.Name = "lblClassification";
            lblClassification.Size = new Size(92, 20);
            lblClassification.TabIndex = 16;
            lblClassification.Text = "Clasificación";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(192, 159);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(395, 27);
            txtCategory.TabIndex = 15;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(70, 163);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 20);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Genero";
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 63);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(395, 27);
            txtName.TabIndex = 13;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 12;
            lblName.Text = "Nombre";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 564);
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
            Name = "Edit";
            Text = "Edit";
            Shown += Edit_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtClassification;
        private Label lblClassification;
        private TextBox txtCategory;
        private Label lblCategory;
        private TextBox txtName;
        private Label lblName;
    }
}