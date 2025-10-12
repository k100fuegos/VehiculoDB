using VehiculoDB.Core.Lib;

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
    }
}
