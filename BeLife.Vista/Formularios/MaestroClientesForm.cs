using System;
using System.Windows.Forms;
using BeLife.Controlador.Comandos;
using BeLife.Controlador.Enumeraciones;
using BeLife.Modelo.Clases;
using BeLife.Modelo.Dto;
using BeLife.Vista.Comandos;

namespace BeLife.Vista.Formularios
{


    public partial class MaestroClientesForm : Form
    {

        // Miembros.
        #region "Miembros."

        private TipoGrabacion accionGrabar;

        #endregion



        // Propiedades 
        #region "Propiedades."

        public string RutExterno { get; set; }
        public bool IsChildForm { get; set; }
        public bool HayCambios { get; set; }
        public EstadoFormulario EstadoForm { get; set; }

        #endregion



        #region "Manejo del formulario."

        private void MaestroClientesForm_Activated(object sender, EventArgs e)
        {
            this.rutTextBox.Focus();
            if (this.IsChildForm && !string.IsNullOrEmpty(this.RutExterno))
            {
                this.rutTextBox.Text = this.RutExterno;
                this.BuscarInformacionDeCliente();
                return;
            }
        }


        public MaestroClientesForm()
        {
            InitializeComponent();
        }


        private void MaestroClientesForm_Load(object sender, EventArgs e)
        {
            this.cargarCombos();
            this.nacimientoDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            this.rutTextBox.Text = string.Empty;
            this.formularioTabControl.SelectedTab = this.datosClienteTabPage;
            this.activarControles();
        }


        #endregion



        // Manejo de los menus de opciones.
        #region "Manejo de los menus de opciones."

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.NuevoCliente();
        }


        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EditarCliente();
        }


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.EliminarCliente();
        }


        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion



        // Manejo de la toolbar.
        #region"Manejo de la toolbar."

        private void nuevoToolStripButton_Click(object sender, EventArgs e)
        {
            this.NuevoCliente();
        }


        private void editarToolStripButton_Click(object sender, EventArgs e)
        {
            this.EditarCliente();
        }


        private void eliminarToolStripButton_Click(object sender, EventArgs e)
        {
            this.EliminarCliente();
        }

        #endregion



        // Manejo de los botones.
        #region "Manejo de los botones."

        private void grabarButton_Click(object sender, EventArgs e)
        {
            this.HayCambios = false;
            if (!this.validarControles()) return;
            if (!this.GrabarCliente()) return;
            if (this.IsChildForm)
            {
                this.HayCambios = true;
                this.Close();
                return;
            }
            this.EstadoForm = EstadoFormulario.Buscar;
            this.activarControles();
        }


        private void cancelarButton_Click(object sender, EventArgs e)
        {
            if (this.IsChildForm)
            {
                this.HayCambios = false;
                this.Close();
                return;
            }
            this.rutTextBox.Text = string.Empty;
            this.EstadoForm = EstadoFormulario.Buscar;
            this.activarControles();
        }


        private void rutButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rutTextBox.Text))
            {
                this.abrirListaDeClientes(true);
                if (string.IsNullOrEmpty(this.rutTextBox.Text)) return;
            }
            if (!this.ValidaRut()) return;
            this.BuscarInformacionDeCliente();
        }

        #endregion



        // Metodos del formulario.
        #region "Metodos del formulario."

        private void NuevoCliente()
        {
            this.EstadoForm = EstadoFormulario.Crear;
            this.accionGrabar = TipoGrabacion.Agregar;
            this.activarControles();
        }


        private void EditarCliente()
        {
            this.EstadoForm = EstadoFormulario.Editar;
            this.accionGrabar = TipoGrabacion.Actualizar;
            this.activarControles();
        }

        private void cargarCombos()
        {
            var myCommandEstadoCivil = CmdCargarComboEstadoCivil.crear(this.estadoCivilComboBox);
            myCommandEstadoCivil.Ejecutar();
            var myCommandSexo = CmdCargarComboSexo.crear(this.sexoComboBox);
            myCommandSexo.Ejecutar();
        }


        // Metodo para activar o desactivar controles segun modo del formulario.
        private void activarControles()
        {
            if (this.EstadoForm == EstadoFormulario.Buscar) this.controlesModoBusqueda();
            if (this.EstadoForm == EstadoFormulario.Crear) this.controlesModoCrear();
            if (this.EstadoForm == EstadoFormulario.Editar) this.controlesModoEditar();
        }


        private void controlesModoBusqueda()
        {
            this.accionGrabar = TipoGrabacion.Nada;
            this.habilitarControles(false);
            this.LimpiarControles();
            this.HabilitarMenus(false);
            this.rutTextBox.Enabled = true;
            this.nuevoToolStripMenuItem.Enabled = true;
            this.nuevoToolStripButton.Enabled = true;
            this.grabarButton.Visible = false;
            this.cancelarButton.Visible = false;
            this.textoSoolStripStatusLabel.Text = "Buscando cliente.";
            this.rutTextBox.Focus();
        }


        private void controlesModoCrear()
        {
            this.habilitarControles(true);
            this.LimpiarControles();
            this.HabilitarMenus(false);
            this.grabarButton.Visible = true;
            this.grabarButton.Enabled = false;
            this.cancelarButton.Visible = true;
            this.textoSoolStripStatusLabel.Text = "Creando nuevo usuario.";
            this.rutTextBox.Focus();
        }


        private void controlesModoEditar()
        {
            this.habilitarControles(true);
            this.HabilitarMenus(false);
            this.rutTextBox.Enabled = false;
            this.grabarButton.Visible = true;
            this.grabarButton.Enabled = true;
            this.cancelarButton.Visible = true;
            this.formularioTabControl.SelectedTab = this.datosClienteTabPage;
            this.textoSoolStripStatusLabel.Text = "Editando información de cliente " + this.nombreTextBox.Text + " " + this.apellidoTextBox.Text;
            this.nombreTextBox.Focus();
        }


        private void LimpiarControles()
        {
            this.rutTextBox.Text = string.Empty;
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.nacimientoDateTimePicker.Value = DateTime.Now;
            this.sexoComboBox.SelectedIndex = 0;
            this.estadoCivilComboBox.SelectedIndex = 0;
            this.contratosDataGridView.DataSource = null;
        }


        private void habilitarControles(bool estado)
        {
            this.rutTextBox.Enabled = estado;
            this.nombreTextBox.Enabled = estado;
            this.apellidoTextBox.Enabled = estado;
            this.nacimientoDateTimePicker.Enabled = estado;
            this.sexoComboBox.Enabled = estado;
            this.estadoCivilComboBox.Enabled = estado;
            this.formularioTabControl.SelectedTab = this.datosClienteTabPage;
        }


        private void HabilitarMenus(bool estado)
        {
            this.nuevoToolStripMenuItem.Enabled = estado;
            this.editarToolStripMenuItem.Enabled = estado;
            this.eliminarToolStripMenuItem.Enabled = estado;
            this.nuevoToolStripButton.Enabled = estado;
            this.editarToolStripButton.Enabled = estado;
            this.eliminarToolStripButton.Enabled = estado;
        }


        private void abrirListaDeClientes(bool esUnaBusqueda)
        {
            ListarClientesForm myForm = new ListarClientesForm();
            myForm.IsSearch = esUnaBusqueda;
            CmdAbrirFormulario myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
            if (esUnaBusqueda) this.rutTextBox.Text = myForm.RutCliente;
        }


        private bool validarControles()
        {
            var myCommand = ComandoValidarEntradas.crear();
            myCommand.ValidarVacio(this.rutTextBox, "rut");
            if (!myCommand.FalloValidacion) myCommand.ValidarRut(this.rutTextBox);
            if (!myCommand.FalloValidacion) myCommand.ValidarVacio(this.nombreTextBox, "nombre cliente");
            if (!myCommand.FalloValidacion) myCommand.ValidarVacio(this.apellidoTextBox, "apellido cliente");
            if (!myCommand.FalloValidacion) myCommand.ValidarEdad(this.nacimientoDateTimePicker);
            if (!myCommand.FalloValidacion) myCommand.ValidarSeleccionComboBox(this.sexoComboBox, "sexo");
            if (!myCommand.FalloValidacion) myCommand.ValidarSeleccionComboBox(this.estadoCivilComboBox, "estado civil");
            return !myCommand.FalloValidacion;
        }


        private bool GrabarCliente()
        {
            if (this.accionGrabar == TipoGrabacion.Nada) return false;
            Cliente myCliente = Cliente.Crear();
            myCliente.Rut = this.rutTextBox.Text.ToString().Trim().ToUpper();
            myCliente.Nombre = this.nombreTextBox.Text.ToString().Trim().ToUpper();
            myCliente.Apellido = this.apellidoTextBox.Text.ToString().Trim().ToUpper();
            myCliente.Nacimiento = this.nacimientoDateTimePicker.Value;
            myCliente.IdSexo = int.Parse(this.sexoComboBox.SelectedValue.ToString());
            myCliente.IdEstadoCivil = int.Parse(this.estadoCivilComboBox.SelectedValue.ToString());
            var myCommand = CmdGrabarCliente.Crear(myCliente, this.accionGrabar);
            myCommand.Ejecutar();
            if (myCommand.OcurrioError)
            {
                MessageBox.Show(myCommand.MensajeError.ToString(), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(myCommand.MensajeGrabacion.ToString(), "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return myCommand.fueAlmacenado;
        }


        private bool ValidaRut()
        {
            var myCommand = ComandoValidarEntradas.crear();
            myCommand.ValidarVacio(this.rutTextBox, "rut cliente");
            myCommand.ValidarRut(this.rutTextBox);
            return !myCommand.FalloValidacion;
        }


        private void BuscarInformacionDeCliente()
        {
            var myCommand = CmdBuscarCliente.Crear(this.rutTextBox.Text.ToString().Trim().ToUpper());
            myCommand.Ejecutar();
            if (this.EstadoForm == EstadoFormulario.Crear)
            {
                if (myCommand.fueEncontrado)
                {
                    MessageBox.Show("El rut ingresado ya existe en la base de datos.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.grabarButton.Enabled = false;
                    this.rutTextBox.Focus();
                    return;
                }
                else
                {
                    this.grabarButton.Enabled = true;
                    return;
                }
            }
            if (!myCommand.fueEncontrado)
            {
                MessageBox.Show("El rut ingresado no existe.", "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.asignarValorEnControles(myCommand.MyCliente);
            this.CargarContratosDelCliente();
            this.habilitarMenusDeEdicion();
        }


        private void asignarValorEnControles(DtoCliente myCliente)
        {
            this.nombreTextBox.Text = myCliente.Nombre;
            this.apellidoTextBox.Text = myCliente.Apellido;
            this.nacimientoDateTimePicker.Value = myCliente.Fecha;
            this.sexoComboBox.Text = myCliente.Sexo;
            this.estadoCivilComboBox.Text = myCliente.EstadoCivil;
        }


        private void CargarContratosDelCliente()
        {
            CmdCargarGrillaContratosCliente myCommand = CmdCargarGrillaContratosCliente.Crear(this.contratosDataGridView, this.rutTextBox.Text);
            myCommand.Ejecutar();
            this.cantidadContratosLabel.Text = myCommand.TextoResultado;
        }


        private void habilitarMenusDeEdicion()
        {
            this.HabilitarMenus(true);
            this.nuevoToolStripMenuItem.Enabled = false;
            this.nuevoToolStripButton.Enabled = false;
        }


        // Metodo para eliminar cliente.
        private void EliminarCliente()
        {
            if (this.contratosDataGridView.Rows.Count > 0)
            {
                MessageBox.Show("No puede eliminar el cliente " + this.nombreTextBox.Text + " " + this.apellidoTextBox.Text + ", debido a que el cliente posee " + this.contratosDataGridView.Rows.Count.ToString() + " contratos registrados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult myResult = MessageBox.Show("¿Esta seguro de eliminar el cliente " + this.nombreTextBox.Text + " " + this.apellidoTextBox.Text + "?", "Atención.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.No) return;
            this.HayCambios = false;
            this.RutExterno = string.Empty;
            Cliente myCliente = Cliente.Crear();
            myCliente.Rut = this.rutTextBox.Text.ToString().Trim().ToUpper();
            myCliente.Nombre = this.nombreTextBox.Text.ToString().Trim().ToUpper();
            myCliente.Apellido = this.apellidoTextBox.Text.ToString().Trim().ToUpper();
            var myCommand = CmdGrabarCliente.Crear(myCliente, TipoGrabacion.Eliminar);
            myCommand.Ejecutar();
            if (myCommand.OcurrioError)
            {
                MessageBox.Show(myCommand.MensajeError.ToString(), "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(myCommand.MensajeGrabacion.ToString(), "Atención.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (this.IsChildForm)
            {
                this.HayCambios = true;
                this.Close();
                return;
            }
            this.EstadoForm = EstadoFormulario.Buscar;
            this.activarControles();
        }




        #endregion


    }
}
