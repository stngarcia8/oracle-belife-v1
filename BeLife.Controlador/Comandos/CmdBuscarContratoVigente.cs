using System;
using System.Collections.Generic;
using System.Linq;
using BeLife.Controlador.DAO;
using BeLife.Modelo.Dto;

namespace BeLife.Controlador.Comandos
{
    public class CmdBuscarContratoVigente : CmdBuscar, IComando
    {

        // Propiedades.
        public DtoContrato MyContrato { get; set; }

        // Constructor.
        private CmdBuscarContratoVigente(string rutCliente, string idPlan)
            : base(rutCliente, idPlan)
        {
            MyContrato = null;
        }


        // Metodo creador del comando.
        public static CmdBuscarContratoVigente Crear(string rutCliente, string idPlan)
        {
            return new CmdBuscarContratoVigente(rutCliente, idPlan);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.fueEncontrado = this.ObtenerDatos();
        }


        // Metodo que busca la informacion del contrato.
        protected override bool ObtenerDatos()
        {
            try
            {
                IDaoContrato myDao = DaoContrato.Crear();
                List<DtoContrato> myList = myDao.VerificarVigenciaDeContratoDeCliente(this.textoQueBuscar, textoQueBuscar2);
                this.MyContrato = myList.FirstOrDefault<DtoContrato>();
                this.MensajeBusqueda = (this.MyContrato != null ?
                    "El cliente " + MyContrato.Cliente + " ya posee un contrato con el plan " + MyContrato.Nombre_plan + ", este se encuentra vigente hasta el " + MyContrato.Termino_vigencia + "." :
                    "El cliente no posee un contrato asociado vigente con el plan seleccionado.");
                return (this.MyContrato != null ? true : false);
            }
            catch (Exception ex)
            {
                this.MarcarError(ex);
                return false;
            }
        }

    }
}
