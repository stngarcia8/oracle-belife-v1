using System;
using System.Collections.Generic;
using System.Linq;
using BeLife.Controlador.DAO;
using BeLife.Modelo.Dto;

namespace BeLife.Controlador.Comandos
{
    public class CmdBuscarCliente : CmdBuscar, IComando
    {

        // Propiedades.
        public DtoCliente MyCliente { get; set; }

        // Constructor.
        private CmdBuscarCliente(string rutCliente)
            : base(rutCliente)
        {
            this.MyCliente = null;
        }


        // Metodo creador del comando.
        public static CmdBuscarCliente Crear(string rutCliente)
        {
            return new CmdBuscarCliente(rutCliente);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.fueEncontrado = this.ObtenerDatos();
        }


        // Metodo que busca al cliente.
        protected override bool ObtenerDatos()
        {
            try
            {
                IDaoCliente myDao = DaoCliente.Crear();
                List<DtoCliente> myList = myDao.ObtenerListaClientesPorRut(this.textoQueBuscar);
                this.MyCliente = myList.FirstOrDefault<DtoCliente>();
                this.MensajeBusqueda = (this.MyCliente != null ?
                    "Cliente " + MyCliente.Nombre + " " + MyCliente.Apellido + " existe en la base de datos." :
                    "Cliente que intenta buscar no esta registrado en la base de datos.");
                return (this.MyCliente != null ? true : false);
            }
            catch (Exception ex)
            {
                this.MarcarError(ex);
                return false;
            }
        }

    }
}
