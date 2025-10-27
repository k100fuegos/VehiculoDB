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
    public partial class frmPropietario : Form
    {

        private PropietarioDao propietarioDao = new PropietarioDao();

        public frmPropietario()
        {
            InitializeComponent();
        }

        private void ConfiguracionGrid()
        {
            dgvPropietario.AutoGenerateColumns = false;
            dgvPropietario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPropietario.MultiSelect = false;
            dgvPropietario.Columns.Clear();

            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NobreCol",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ApellidoCol",
                HeaderText = "Apellido",
                DataPropertyName = "Apellido",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DUICol",
                HeaderText = "DUI",
                DataPropertyName = "DUI",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TelefonoCol",
                HeaderText = "Telefono",
                DataPropertyName = "Telefono",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DireccionCol",
                HeaderText = "Dirección",
                DataPropertyName = "Direccion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

        }

        private void Cargar(string filtro = "")
        {
            dgvPropietario.DataSource = propietarioDao.GetAll();
            dgvPropietario.ClearSelection();
            dgvPropietario.CurrentCell = null;

        }


        private void frmPropietario_Load(object sender, EventArgs e)
        {
            ConfiguracionGrid();
            Cargar();
        }

        private void dgvPropietario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPropietarioInsert frmProInsert = new frmPropietarioInsert();
            if (frmProInsert.ShowDialog() == DialogResult.OK)
            {
                Cargar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int? GetIdSeleccionado()
        {
            if (dgvPropietario.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Propietarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dgvPropietario.CurrentRow.DataBoundItem is Propietario paPropietario)
                return paPropietario.IdPropietario;

            return null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();

            if (!id.HasValue)
            {
                MessageBox.Show("Debe seleccionar un registro");
                return;
            }
            else
            {
                MessageBox.Show("El id seleccionado es: " + id.Value);
            }

            frmPropietarioUpdate frm = new frmPropietarioUpdate(id.Value);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cargar();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();

            if (!id.HasValue)
            {
                MessageBox.Show("Debe seleccionar un registro");
                return;
            }
            else
            {
                var respuesta = MessageBox.Show("Realmente desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                try
                {
                    if (propietarioDao.Delete(id.Value))
                    {
                        Cargar();
                    }
                    else
                    {
                        MessageBox.Show("no se pudo eliminar el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("no se pudo eliminar el registro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inseperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
