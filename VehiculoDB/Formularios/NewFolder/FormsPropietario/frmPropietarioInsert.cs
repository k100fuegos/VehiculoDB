using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiculoDB.Core.Clases;
using VehiculoDB.Core.Dao;

namespace VehiculoDB.Formularios.NewFolder.FormsPropietario
{
    public partial class frmPropietarioInsert : Form
    {
        public frmPropietarioInsert()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PropietarioDao propietarioDao = new PropietarioDao();
            Propietario propietario = new Propietario()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                DUI = mtxtDUI.Text.Trim(),
                Telefono = mtxtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim()
            };

            try
            {
                var id = propietarioDao.Insert(propietario);

                if (id > 0)
                {
                    MessageBox.Show("Propietario ingrezado con exito",
                                    "Mensaje de Exito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                                   
                    MessageBox.Show("Propietario no fue ingrezado",
                                    "Mensaje de Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                    );
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Error inseperado: " + ex.Message,
                                    "Mensaje de Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inseperado: " + ex.Message,
                                    "Mensaje de Alerta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                    );
            }

        }
    }
}
