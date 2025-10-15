namespace VehiculoDB
{
    partial class frmPrincipal
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
            btnAbrir = new Button();
            btnCerrar = new Button();
            btnPropietaios = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(510, 70);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir BD";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(510, 156);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar BD";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnPropietaios
            // 
            btnPropietaios.Location = new Point(91, 109);
            btnPropietaios.Name = "btnPropietaios";
            btnPropietaios.Size = new Size(187, 131);
            btnPropietaios.TabIndex = 2;
            btnPropietaios.Text = "Propietarios";
            btnPropietaios.UseVisualStyleBackColor = true;
            btnPropietaios.Click += btnPropietaios_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPropietaios);
            Controls.Add(btnCerrar);
            Controls.Add(btnAbrir);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrir;
        private Button btnCerrar;
        private Button btnPropietaios;
    }
}
