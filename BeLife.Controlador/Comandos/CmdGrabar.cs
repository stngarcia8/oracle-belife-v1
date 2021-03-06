﻿using System;
using BeLife.Controlador.Enumeraciones;

namespace BeLife.Controlador.Comandos
{
    public abstract class CmdGrabar
    {

        // Miembros.
        protected readonly TipoGrabacion accionGrabar;
        protected string myAccion;


        // Propiedades.
        public bool fueAlmacenado { get; set; }
        public string MensajeGrabacion { get; set; }
        public string MensajeError { get; set; }
        public bool OcurrioError { get; set; }



        // Constructor.
        protected CmdGrabar(TipoGrabacion myTipo)
        {
            this.accionGrabar = myTipo;
            this.fueAlmacenado = false;
            this.MensajeGrabacion = string.Empty;
            this.MensajeError = string.Empty;
            this.OcurrioError = false;
            this.myAccion = string.Empty;
        }


        // Metodo abstracto para grabar el elemento.
        protected abstract void GrabarElemento();


        // Definir accion realizada.
        protected void AccionRealizada(bool estado)
        {
            if (this.accionGrabar == TipoGrabacion.Agregar) this.AccionAgregar(estado);
            if (this.accionGrabar == TipoGrabacion.Actualizar) this.AccionActualizar(estado);
            if (this.accionGrabar == TipoGrabacion.Eliminar) this.AccionEliminar(estado);
        }


        private void AccionAgregar(bool estado)
        {
            this.myAccion= (estado?"creado":"crear");
        }


        private void AccionActualizar(bool estado)
        {
            this.myAccion= (estado ? "actualizado" : "actualizar");
        }


        private void AccionEliminar(bool estado)
        {
            this.myAccion= (estado ? "eliminado" : "eliminar");
        }


        // Metodo que asigna los errores a las variables indicadoras de problemas.
        protected void MarcarError(Exception ex)
        {
            this.MensajeError = ex.Source.ToString() + " - " + ex.Message.ToString();
            this.OcurrioError = true;
            this.fueAlmacenado = false;
        }

    }
}
