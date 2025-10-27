namespace VehiculoDB.Formularios.NewFolder.FormsPropietario
{
    partial class frmPropietarioUpdate
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
            txtDireccion = new TextBox();
            mtxtTelefono = new MaskedTextBox();
            mtxtDUI = new MaskedTextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCerrar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14F);
            txtDireccion.Location = new Point(199, 284);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(329, 32);
            txtDireccion.TabIndex = 23;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Font = new Font("Segoe UI", 14F);
            mtxtTelefono.Location = new Point(199, 224);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(329, 32);
            mtxtTelefono.TabIndex = 22;
            // 
            // mtxtDUI
            // 
            mtxtDUI.Font = new Font("Segoe UI", 14F);
            mtxtDUI.Location = new Point(199, 160);
            mtxtDUI.Mask = "00000000-0";
            mtxtDUI.Name = "mtxtDUI";
            mtxtDUI.Size = new Size(329, 32);
            mtxtDUI.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14F);
            txtApellido.Location = new Point(199, 93);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(329, 32);
            txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(199, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 32);
            txtNombre.TabIndex = 19;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(330, 388);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(198, 63);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(79, 388);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(198, 63);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 287);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 16;
            label5.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 227);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 15;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 163);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 14;
            label3.Text = "DUI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 13;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 28);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // frmPropietarioUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 486);
            Controls.Add(txtDireccion);
            Controls.Add(mtxtTelefono);
            Controls.Add(mtxtDUI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPropietarioUpdate";
            Text = "frmPropietarioUpdate";
            Load += frmPropietarioUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDireccion;
        private MaskedTextBox mtxtTelefono;
        private MaskedTextBox mtxtDUI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnCerrar;
        private Button btnAgregar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}