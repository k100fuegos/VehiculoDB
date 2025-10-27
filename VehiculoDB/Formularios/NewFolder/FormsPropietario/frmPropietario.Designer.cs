namespace VehiculoDB.Formularios.NewFolder.FormsPropietario
{
    partial class frmPropietario
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
            dgvPropietario = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnCerrar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // dgvPropietario
            // 
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Location = new Point(12, 12);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.ReadOnly = true;
            dgvPropietario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPropietario.Size = new Size(788, 478);
            dgvPropietario.TabIndex = 0;
            dgvPropietario.CellContentClick += dgvPropietario_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(854, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(253, 82);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(854, 144);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(253, 82);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(854, 408);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(253, 82);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(854, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(253, 82);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmPropietario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 526);
            Controls.Add(btnEliminar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPropietario);
            Name = "frmPropietario";
            Text = "Propietario";
            Load += frmPropietario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPropietario;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnCerrar;
        private Button btnEliminar;
    }
}