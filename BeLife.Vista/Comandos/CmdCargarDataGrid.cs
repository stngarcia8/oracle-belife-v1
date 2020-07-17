using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BeLife.Controlador.Enumeraciones;

namespace BeLife.Vista.Comandos
{
    public abstract class CmdCargarDataGrid
    {

        // Miembros privados.
        protected string textoFiltro;
        protected DataGridView myGrid;
        protected TipoFiltro myFiltro;


        // Propiedades.
        public string TextoResultado { get; set; }


        // Constructores.
        protected CmdCargarDataGrid(DataGridView myGrid, TipoFiltro myFiltro, string textoFiltro)
        {
            this.myGrid = myGrid;
            this.myFiltro = myFiltro;
            this.textoFiltro = textoFiltro;
        }


        protected CmdCargarDataGrid(DataGridView myGrid, string textoFiltro)
        {
            this.myGrid = myGrid;
            this.textoFiltro = textoFiltro;
        }


        // Metodo abstracto para cargar los datos a la grilla.
        protected abstract void ObtenerDatos();


        // Metodo que muestra el error ocurrido en tiempo de carga de los datos.
        protected void MostrarMensajeDeError(Exception ex)
        {
            MessageBox.Show(ex.Source.ToString() + " - " + ex.Message.ToString(), "Ha ocurrido un problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Asigna el resultado de la carga de datos en la grilla.
        protected void asignarResultado()
        {
            if (myGrid.Rows.Count > 0) this.TextoResultado = this.TextoResultado = myGrid.Rows.Count.ToString() + " clientes encontrados.";
            else this.TextoResultado = "No hay clientes disponibles.";
        }


        // Metodo para configurar las columnas de la grilla de contratos.
        protected void OcultarColumnas(IList<int> exclusiones)
        {
            foreach (DataGridViewColumn myColumn in this.myGrid.Columns)
            {
                myColumn.Visible = false;
                if (exclusiones.Contains(myColumn.Index))
                {
                    myColumn.Visible = true;
                    myColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }




    }
}
