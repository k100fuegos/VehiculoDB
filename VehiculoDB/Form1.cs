using VehiculoDB.Core.Lib;
using VehiculoDB.Formularios.NewFolder.FormsPropietario;

namespace VehiculoDB
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Cnn Cnn = new Cnn();

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Cnn.OpenDb();
            MessageBox.Show("Conexion Abierta");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cnn.OpenDb();
            MessageBox.Show("Conexion Cerrada");
        }

        private void btnPropietaios_Click(object sender, EventArgs e)
        {
            frmPropietario form = new frmPropietario();
            form.Show();
        }
    }
}
