using System;
using System.Windows.Forms;
using BeLife.Controlador.Enumeraciones;
using BeLife.Vista.Comandos;

namespace BeLife.Vista.Formularios
{
    public partial class belifeForm : Form
    {


        // Manejo del formulario.
        #region "Manejo del formulario."

        public belifeForm()
        {
            InitializeComponent();
        }


        private void belifeForm_Load(object sender, EventArgs e)
        {
            this.Text = "Seguros BeLife.";
        }


        private void belifeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de salir de la aplicación?", "Atención.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (result.Equals(DialogResult.Yes) ? false : true);
        }

        #endregion



        // Manejo de las opciones.
        #region "Manejo de las opciones."

        private void maestroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirMaestroClientes();
        }


        private void maestroClientesToolStripButton_Click(object sender, EventArgs e)
        {
            this.AbrirMaestroClientes();
        }


        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirListadoDeClientes();
        }


        private void listadoClientesToolStripButton_Click(object sender, EventArgs e)
        {
            this.AbrirListadoDeClientes();
        }


        private void maestroContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirMaestroContratos();
        }


        private void maestroContratosToolStripButton_Click(object sender, EventArgs e)
        {
            this.AbrirMaestroContratos();
        }


        private void listadoContratosToolStripButton_Click(object sender, EventArgs e)
        {
            this.AbrirListadoDeContratos();
        }


        private void listadoContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirListadoDeContratos();
        }


        private void opcionesSalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion




        // Manejo de la barra de estado.
        #region "Manejo de la barra de estado."

        private void beLifeToolStripStatusLabel_DoubleClick(object sender, EventArgs e)
        {
            var myCommand = CmdAbrirFormulario.Crear(new acercaDeForm());
            myCommand.Ejecutar();
        }

        #endregion



        // Metodos del formulario.
        #region "Metodos del formulario."

        private void AbrirMaestroClientes()
        {
            MaestroClientesForm myForm = new MaestroClientesForm();
            myForm.RutExterno = string.Empty;
            myForm.IsChildForm = false;
            myForm.EstadoForm = EstadoFormulario.Buscar;
            var myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
        }


        private void AbrirListadoDeClientes()
        {
            ListarClientesForm myForm = new ListarClientesForm();
            myForm.IsSearch = false;
            CmdAbrirFormulario myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
        }


        private void AbrirMaestroContratos()
        {
            MaestroContratosForm myForm = new MaestroContratosForm();
            myForm.NumeroContratoExterno = string.Empty;
            myForm.IsChildForm = false;
            myForm.EstadoForm = EstadoFormulario.Buscar;
            var myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
        }


        private void AbrirListadoDeContratos()
        {
            ListarContratosForm myForm = new ListarContratosForm();
            myForm.IsSearch = false;
            var myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
        }







        #endregion







    }
}
