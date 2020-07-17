using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BeLife.Controlador.Enumeraciones;
using BeLife.Modelo.Clases;
using BeLife.Vista.Comandos;

namespace BeLife.Vista.Formularios
{
    public partial class ListarContratosForm : Form
    {

        private IList<DetalleGrid> myDetalle;

        // Propiedades.
        #region "Propiedades."

        public string NumeroContrato { get; set; }
        public bool IsSearch { get; set; }

        #endregion



        // Manejo del formulario.
        #region "Manejo del formulario."

        public ListarContratosForm()
        {
            InitializeComponent();
        }


        private void ListarContratosForm_Load(object sender, EventArgs e)
        {
            this.agregarButton.Visible = !this.IsSearch;
            this.editarButton.Visible = !this.IsSearch;
            this.filtrosComboBox.SelectedIndex = 0;
            this.valorFiltroTextBox.Text = string.Empty;
            this.listadoDataGridView.DataSource = null;
            this.aceptarButton.Visible = this.IsSearch;
        }

        #endregion



        // Actualizar listado.
        #region "Actualizar listado."

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CargarContratos();
        }


        private void actualizarToolStripButton_Click(object sender, EventArgs e)
        {
            this.CargarContratos();
        }

        #endregion



        // Manejo de los filtros.
        #region "Manejo de los filtros."

        private void filtrosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filtrosComboBox.SelectedIndex == 0) this.controlesFiltro(string.Empty, false, 0, string.Empty);
            if (this.filtrosComboBox.SelectedIndex == 1) this.controlesFiltro("Nro.Contrato:", true, 14, "Ingrese numero de contrato.");
            if (this.filtrosComboBox.SelectedIndex == 2) this.controlesFiltro("Rut cliente:", true, 10, "Ingrese rut del cliente a buscar, formato rut separado por guion mas el digito verificador.");
            if (this.filtrosComboBox.SelectedIndex == 3) this.controlesFiltro("Nro.Poliza:", true, 15, "Ingrese numero de poliza a buscar.");
        }


        private void buscarButton_Click(object sender, EventArgs e)
        {
            this.CargarContratos();
        }

        #endregion



        // Manejo de los botones de accion.
        #region "Manejo de los botones de accion."

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            this.ObtenerNumeroDeContrato();
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.NumeroContrato = string.Empty;
            this.Close();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            this.AbrirMaestroContratosModoChild(EstadoFormulario.Crear, string.Empty);
        }

        private void editarButton_Click(object sender, EventArgs e)
        {
            this.ObtenerNumeroDeContrato();
            if (string.IsNullOrEmpty(this.NumeroContrato)) return;
            this.AbrirMaestroContratosModoChild(EstadoFormulario.Buscar, this.NumeroContrato);
        }

        #endregion



        // Manejo de la grilla de datos.
        #region "Manejo de la grilla de datos."

        private void listadoDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.IsSearch)
            {
                this.ObtenerNumeroDeContrato();
                this.Close();
            }
        }


        private void listadoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (this.IsSearch) this.ObtenerNumeroDeContrato();
            if (this.listadoDataGridView.Rows.Count > 0) this.MostrarDetalleDeContrato();
        }

        #endregion




        // Metodos del formulario.
        #region "Metodos del formulario."

        private void controlesFiltro(string etiqueta, bool esVisible, int largoCampo, string descripcion)
        {
            this.valorFiltroLabel.Visible = esVisible;
            this.valorFiltroTextBox.MaxLength = largoCampo;
            this.valorFiltroTextBox.AccessibleDescription = etiqueta;
            this.valorFiltroTextBox.AccessibleName = descripcion;
            this.valorFiltroLabel.Text = etiqueta;
            this.valorFiltroTextBox.Visible = esVisible;
            this.valorFiltroTextBox.Text = string.Empty;
        }


        private void CargarContratos()
        {
            TipoFiltro myTipo = TipoFiltro.Todo;
            string valorFiltro = string.Empty;
            if (this.filtrosComboBox.SelectedIndex == 0) myTipo = TipoFiltro.Todo;
            if (this.filtrosComboBox.SelectedIndex == 1)
            {
                myTipo = TipoFiltro.NumeroContrato;
                valorFiltro = this.valorFiltroTextBox.Text.Trim().ToUpper();
            }
            if (this.filtrosComboBox.SelectedIndex == 2)
            {
                if (!this.ValidaRut()) return;
                myTipo = TipoFiltro.Rut;
                valorFiltro = this.valorFiltroTextBox.Text.ToUpper().Trim();
            }
            if (this.filtrosComboBox.SelectedIndex == 3)
            {
                myTipo = TipoFiltro.NumeroPoliza;
                valorFiltro = this.valorFiltroTextBox.Text.ToUpper().Trim();
            }
            var myCommand = CmdCargarGrillaContratos.crear(this.listadoDataGridView, myTipo, valorFiltro);
            myCommand.Ejecutar();
            this.textoToolStripStatusLabel.Text = myCommand.TextoResultado.ToString();
            this.AsignarNombresDeColumnas();
            if (this.listadoDataGridView.Rows.Count > 0)
            {
                this.listadoDataGridView.Rows[0].Selected = true;
                this.MostrarDetalleDeContrato();
                this.listadoDataGridView.Focus();
            }
        }


        private void AsignarNombresDeColumnas()
        {
            if (this.listadoDataGridView.Rows.Count == 0)
            {
                this.detalleDataGridView.DataSource = null;
                return;
            }
            this.myDetalle = new List<DetalleGrid>();
            if (this.listadoDataGridView.Rows.Count == 0) return;
            for (int i = 0; i < this.listadoDataGridView.Columns.Count; i++)
            {
                this.myDetalle.Add(DetalleGrid.Crear(this.listadoDataGridView.Columns[i].Name, string.Empty));
            }
            this.detalleDataGridView.DataSource = myDetalle;
        }


        // Validar rut para realizar busqueda.
        private bool ValidaRut()
        {
            var myCommand = ComandoValidarEntradas.crear();
            myCommand.ValidarVacio(this.valorFiltroTextBox, "rut cliente");
            myCommand.ValidarRut(this.valorFiltroTextBox);
            return !myCommand.FalloValidacion;
        }


        // Metodo que obtiene el numero de contrato seleccionado.
        private void ObtenerNumeroDeContrato()
        {
            if (this.listadoDataGridView.Rows.Count == 0)
            {
                this.NumeroContrato = string.Empty;
                return;
            }
            DataGridViewRow myRow = this.listadoDataGridView.CurrentRow;
            if (myRow == null)
            {
                this.NumeroContrato = string.Empty;
                return;
            }
            this.NumeroContrato = myRow.Cells[0].Value.ToString();
        }


        private void MostrarDetalleDeContrato()
        {
            DataGridViewRow myRow = this.listadoDataGridView.CurrentRow;
            if (myRow == null) return;
            if (this.myDetalle == null) return;
            this.detalleDataGridView.DataSource = null;
            int i = 0;
            foreach (DetalleGrid myDetails in myDetalle)
            {
                if (myRow.Cells[i].Value == null) myDetails.Valor = string.Empty;
                else myDetails.Valor = myRow.Cells[i].Value.ToString();
                i++;
            }
            this.detalleDataGridView.DataSource = this.myDetalle;
        }


        private void AbrirMaestroContratosModoChild(EstadoFormulario estado, string NumeroContratoQueBuscar)
        {
            MaestroContratosForm myForm = new MaestroContratosForm();
            myForm.NumeroContratoExterno = NumeroContratoQueBuscar;
            myForm.EstadoForm = estado;
            myForm.IsChildForm = true;
            CmdAbrirFormulario myCommand = CmdAbrirFormulario.Crear(myForm);
            myCommand.Ejecutar();
            if (myForm.HayCambios) this.CargarContratos();
        }

        #endregion

    }
}
