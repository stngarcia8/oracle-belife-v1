using System;
using BeLife.Controlador.DAO;
using BeLife.Controlador.Enumeraciones;
using BeLife.Modelo.Clases;

namespace BeLife.Controlador.Comandos
{
    public class CmdGrabarContrato : CmdGrabar, IComando
    {

        // Miembros.
        private readonly Contrato myContrato;


        // Constructor.
        private CmdGrabarContrato(Contrato myContrato, TipoGrabacion myTipo)
            : base(myTipo)
        {
            this.myContrato = myContrato;
        }


        // Metodo creador del objeto.
        public static CmdGrabarContrato Crear(Contrato myContrato, TipoGrabacion myTipo)
        {
            return new CmdGrabarContrato(myContrato, myTipo);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.GrabarElemento();
        }


        // Metodo para grabar el contrato.
        protected override void GrabarElemento()
        {
            try
            {
                IDaoContrato myDao = DaoContrato.Crear();
                int resultado = 0;
                if (this.accionGrabar == TipoGrabacion.Agregar) resultado = myDao.NuevoContrato(this.myContrato);
                if (this.accionGrabar == TipoGrabacion.Actualizar) resultado = myDao.ActualizarContrato(this.myContrato);
                this.AccionRealizada(resultado > 0 ? true : false);
                this.MensajeGrabacion = (resultado > 0 ?
                    "El contrato número " + myContrato.NumeroContrato + " fue " + this.myAccion + " correctamente." :
                    "No ha sido posible " + this.myAccion + " el contrato número " + myContrato.NumeroContrato + ", intente nuevamente.");
                this.fueAlmacenado = (resultado > 0 ? true : false);
            }
            catch (Exception ex)
            {
                this.MarcarError(ex);
                return;
            }
        }


    }
}
