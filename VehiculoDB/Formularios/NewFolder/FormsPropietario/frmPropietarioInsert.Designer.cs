namespace VehiculoDB.Formularios.NewFolder.FormsPropietario
{
    partial class frmPropietarioInsert
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btnCerrar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            mtxtDUI = new MaskedTextBox();
            mtxtTelefono = new MaskedTextBox();
            txtDireccion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 27);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 95);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 162);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 2;
            label3.Text = "DUI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 226);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 286);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 4;
            label5.Text = "Direccion:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(79, 387);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(198, 63);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(330, 387);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(198, 63);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(199, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(329, 32);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14F);
            txtApellido.Location = new Point(199, 92);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(329, 32);
            txtApellido.TabIndex = 8;
            // 
            // mtxtDUI
            // 
            mtxtDUI.Font = new Font("Segoe UI", 14F);
            mtxtDUI.Location = new Point(199, 159);
            mtxtDUI.Mask = "00000000-0";
            mtxtDUI.Name = "mtxtDUI";
            mtxtDUI.Size = new Size(329, 32);
            mtxtDUI.TabIndex = 9;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Font = new Font("Segoe UI", 14F);
            mtxtTelefono.Location = new Point(199, 223);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(329, 32);
            mtxtTelefono.TabIndex = 10;
            mtxtTelefono.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14F);
            txtDireccion.Location = new Point(199, 283);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(329, 32);
            txtDireccion.TabIndex = 11;
            // 
            // frmPropietarioInsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 487);
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
            Name = "frmPropietarioInsert";
            Text = "frmPropietarioInsert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btnCerrar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private MaskedTextBox mtxtDUI;
        private MaskedTextBox mtxtTelefono;
        private TextBox txtDireccion;
    }
}