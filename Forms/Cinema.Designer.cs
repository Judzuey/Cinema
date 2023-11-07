namespace Cinema
{
    partial class Cinema
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnEdit = new Button();
            dgvList = new DataGridView();
            btnDelete = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Principal;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(51, 208);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(187, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(317, 42);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(343, 433);
            dgvList.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(51, 294);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(51, 381);
            btnView.Name = "btnView";
            btnView.Size = new Size(187, 29);
            btnView.TabIndex = 7;
            btnView.Text = "Ver";
            btnView.UseVisualStyleBackColor = true;
            // 
            // Cinema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 516);
            Controls.Add(btnView);
            Controls.Add(btnDelete);
            Controls.Add(dgvList);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Cinema";
            Text = "Cinema";
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnEdit;
        private DataGridView dgvList;
        private Button btnDelete;
        private Button btnView;
    }
}