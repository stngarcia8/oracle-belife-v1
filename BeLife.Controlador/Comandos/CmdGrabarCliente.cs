using System;
using BeLife.Controlador.DAO;
using BeLife.Controlador.Enumeraciones;
using BeLife.Modelo.Clases;

namespace BeLife.Controlador.Comandos
{
    public class CmdGrabarCliente : CmdGrabar, IComando
    {

        // Miembros.
        private readonly Cliente myCliente;


        // Constructor.
        private CmdGrabarCliente(Cliente myCliente, TipoGrabacion myTipo)
            : base(myTipo)
        {
            this.myCliente = myCliente;
        }


        // Metodo contructor del objeto.
        public static CmdGrabarCliente Crear(Cliente myCliente, TipoGrabacion myTipo)
        {
            return new CmdGrabarCliente(myCliente, myTipo);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.GrabarElemento();
        }


        // Metodo para grabar el cliente.
        protected override void GrabarElemento()
        {
            try
            {
                int resultado = 0;
                IDaoCliente myDao = DaoCliente.Crear();
                if (this.accionGrabar == TipoGrabacion.Agregar) resultado = myDao.NuevoCliente(this.myCliente);
                if (this.accionGrabar == TipoGrabacion.Actualizar) resultado = myDao.ActualizarCliente(this.myCliente);
                if (this.accionGrabar == TipoGrabacion.Eliminar) resultado = myDao.eliminarCliente(this.myCliente.Rut);
                this.AccionRealizada(resultado > 0 ? true : false);
                this.MensajeGrabacion = (resultado > 0 ?
                    "El cliente " + this.myCliente.Nombre + " " + this.myCliente.Apellido + " ha sido " + this.myAccion + "." :
                    "No ha sido posible " + this.myAccion + " el cliente " + myCliente.Nombre + " " + this.myCliente.Apellido + ", intente nuevamente.");
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
