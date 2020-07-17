using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BeLife.Controlador.DAO;

namespace BeLife.Vista.Comandos
{

    public class CmdCargarGrillaContratosCliente : CmdCargarDataGrid, IComando
    {


        // Constructor.
        private CmdCargarGrillaContratosCliente(DataGridView myGrid, string textoFiltro)
            : base(myGrid, textoFiltro)
        { }


        // Metodo para crear objeto.
        public static CmdCargarGrillaContratosCliente Crear(DataGridView myGrid, string textoFiltro)
        {
            return new CmdCargarGrillaContratosCliente(myGrid, textoFiltro);
        }


        public void Ejecutar()
        {
            this.ObtenerDatos();
            this.asignarResultado();
            IList<int> exclusiones = new List<int> { 0, 4, 5, 6, 7 };
            this.OcultarColumnas(exclusiones);
        }


        // Metodo que carga el data grid de contratos de clientes.
        protected override void ObtenerDatos()
        {
            this.myGrid.DataSource = null;
            try
            {
                IDaoCliente myDao = DaoCliente.Crear();
                myGrid.DataSource = myDao.ObtenerListaContratossPorRut(this.textoFiltro);
            }
            catch (Exception ex)
            {
                this.MostrarMensajeDeError(ex);
            }
        }



    }
}
