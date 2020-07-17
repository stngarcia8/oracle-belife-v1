using System;
using System.Windows.Forms;
using BeLife.Controlador.Enumeraciones;
using BeLife.Vista.Comandos;

namespace BeLife.Vista.Formularios
{
    public partial class ListarClientesForm : Form
    {

        // Propiedades.
        #region "Propiedades."

        public string RutCliente { get; set; }
        public bool IsSearch { get; set; }

        #endregion



        // Manejo del formulario.
        #region "Manejo del formulario."

        public ListarClientesForm()
        {
            InitializeComponent();
        }


        private void ListarClientesForm_Load(object sender, EventArgs e)
        {
            this.agregarButton.Visible = !this.IsSearch;
            this.editarButton.Visible = !this.IsSearch;
            this.filtrosComboBox.SelectedIndex = 0;
            this.listadoDataGridView.DataSource = null;
            this.aceptarButton.Visible = this.IsSearch;
        }

        #endregion



        // Actualizar listado.
        #region "Actualizar listado."

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CargarClientes();
        }


        private void actualizarToolStripButton_Click(object sender, EventArgs e)
        {
            this.CargarClientes();
        }

        #endregion



        // Manejo de los filtros.
        #region "Manejo de los filtros."

        private void filtrosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filtrosComboBox.SelectedIndex == 0) this.controlesSinFiltro();
            if (this.filtrosComboBox.SelectedIndex == 1) this.controlesFiltroPorRut();
            if (this.filtrosComboBox.SelectedIndex == 2) this.controlesFiltroPorEstadoCivil();
            if (this.filtrosComboBox.SelectedIndex == 3) this.controlesFiltroPorSexo();
        }


        private void buscarButton_Click(object sender, EventArgs e)
        {
            this.CargarClientes();
        }

        #endregion



        // Manejo de los botones de accion.
        #region "Manejo de los botones de accion."

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            this.obtenerRutCliente();
            this.Close();
        }


        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.RutCliente = string.Empty;
            this.Close();
        }

        #endregion



        // Manejo de la grilla de datos.
        #region "Manejo de la grilla de datos."

        private void listadoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.IsSearch) this.obtenerRutCliente();
        }


        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.IsSearch)
            {
                this.obtenerRutCliente();
                this.Close();
            }
        }

        #endregion



        // Metodos del formulario.
        #region "Metodos del formulario."

        private void controlesSinFiltro()
        {
            this.valorFiltroComboBox.Visible = false;
            this.valorFiltroLabel.Visible = false;
            this.valorFiltroTextBox.Visible = false;
        }


        private void controlesFiltroPorRut()
        {
            this.valorFiltroComboBox.Visible = false;
            this.valorFiltroLabel.Visible = true;
            this.valorFiltroLabel.Text = "Rut:";
            this.valorFiltroTextBox.Visible = true;
            this.valorFiltroTextBox.Text = string.Empty;
        }


        private void controlesFiltroPorEstadoCivil()
        {
            var myCommand = CmdCargarComboEstadoCivil.crear(this.valorFiltroComboBox);
            myCommand.Ejecutar();
            this.valorFiltroLabel.Text = "E.Civil:";
            this.valorFiltroComboBox.AccessibleName = "Seleccione estado civil.";
            this.activarFiltrosComboBox();
        }


        private void controlesFiltroPorSexo()
        {
            var myCommand = CmdCargarComboSexo.crear(this.valorFiltroComboBox);
            myCommand.Ejecutar();
            this.valorFiltroLabel.Text = "Sexo:";
            this.valorFiltroComboBox.AccessibleName = "Seleccione sexo.";
            this.activarFiltrosComboBox();
        }


        private void activarFiltrosComboBox()
        {
            this.valorFiltroComboBox.Visible = true;
            this.valorFiltroLabel.Visible = true;
            this.valorFiltroTextBox.Visible = false;
            this.valorFiltroTextBox.Text = string.Empty;
        }


        // Metodo para cargar los clientes.
        private void CargarClientes()
        {
            TipoFiltro myTipo = TipoFiltro.Todo;
            string valorFiltro = string.Empty;
            if (this.filtrosComboBox.SelectedIndex == 0) myTipo = TipoFiltro.Todo;
            if (this.filtrosComboBox.SelectedIndex == 1)
            {
                if (!this.ValidaRut()) return;
                myTipo = TipoFiltro.Rut;
                valorFiltro = this.valorFiltroTextBox.Text;
            }
            if (this.filtrosComboBox.SelectedIndex == 2)
            {
                myTipo = TipoFiltro.EstadoCivil;
                valorFiltro = this.valorFiltroComboBox.SelectedValue.ToString();
            }
            if (this.filtrosComboBox.SelectedIndex == 3)
            {
                myTipo = TipoFiltro.Sexo;
                valorFiltro = this.valorFiltroComboBox.SelectedValue.ToString();
            }
            CmdCargarGrillaClientes myCommand = CmdCargarGrillaClientes.Crear(this.listadoDataGridView, myTipo, valorFiltro);
            myCommand.Ejecutar();
            this.textoToolStripStatusLabel.Text = myCommand.TextoResultado.ToString();
            if (this.listadoDataGridView.Rows.Count > 0)
            {
                this.listadoDataGridView.Rows[0].Selected = true;
                this.listadoDataGridView.Focus();
            }
        }


        // Validar rut para realizar busqueda.
        private bool ValidaRut()
        {
            var myCommand = ComandoValidarEntradas.crear();
            myCommand.ValidarVacio(this.valorFiltroTextBox, "rut cliente");
            myCommand.ValidarRut(this.valorFiltroTextBox);
            return !myCommand.FalloValidacion;
        }


        // Metodo que obtiene el rut del cliente que esta seleccionado en la grilla de datos.))
        private void obtenerRutCliente()
        {
            if (this.listadoDataGridView.Rows.Count == 0)
            {
                this.RutCliente = string.Empty;
                return;
            }
            DataGridViewRow myRow = this.listadoDataGridView.CurrentRow;
            if (myRow == null)
            {
                this.RutCliente = string.Empty;
                return;
            }
            this.RutCliente = myRow.Cells[0].Value.ToString();
        }




        #endregion

        private void agregarButton_Click(object sender, EventArgs e)
        {
            this.AbrirMaestroClientesModoChild(EstadoFormulario.Crear, string.Empty);
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            this.obtenerRutCliente();
            if (string.IsNullOrEmpty(this.RutCliente))
            {
                return;
            }
            this.AbrirMaestroClientesModoChild(EstadoFormulario.Editar, this.RutCliente);
        }


        private void AbrirMaestroClientesModoChild(EstadoFormulario estado, string rutQueBuscar)
        {
            MaestroClientesForm myForm = new MaestroClientesForm();
            myForm.RutExterno = rutQueBuscar;
            myForm.EstadoForm = estado;
            myForm.IsChildForm = true;
            CmdAbrirFormulario myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
            if (myForm.HayCambios) this.CargarClientes();
        }






    }
}
