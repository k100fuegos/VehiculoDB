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
    public partial class frmPropietarioUpdate : Form
    {

        PropietarioDao propietarioDao = new PropietarioDao();
        private int _id;

        public frmPropietarioUpdate(int idPropietario)
        {
            InitializeComponent();
            _id = idPropietario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario()
            {
                IdPropietario = _id,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                DUI = mtxtDUI.Text.Trim(),
                Telefono = mtxtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim()
            };

            try
            {
                if (propietarioDao.Update(propietario))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                } 
                else
                {
                    MessageBox.Show("No se pudo realizar el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insepérado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPropietarioUpdate_Load(object sender, EventArgs e)
        {
            var p = propietarioDao.GetById(_id);
            if (p == null)
            {
                MessageBox.Show("No se pudo encontrar el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            mtxtDUI.Text = p.DUI;
            mtxtTelefono.Text = p.Telefono ?? "";
            txtDireccion.Text = p.Direccion ?? "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
