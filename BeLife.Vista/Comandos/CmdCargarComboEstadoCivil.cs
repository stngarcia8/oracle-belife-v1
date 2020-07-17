using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BeLife.Controlador.DAO;
using BeLife.Modelo.Dto;

namespace BeLife.Vista.Comandos
{
    public class CmdCargarComboEstadoCivil : CmdCargarComboBox, IComando
    {


        public IList<DtoEstadoCivil> EstadoCivilList { get; set; }

        // Constructor.
        private CmdCargarComboEstadoCivil(ComboBox myComboBox)
            : base(myComboBox)
        { }


        // Metodo creador del objeto.
        public static CmdCargarComboEstadoCivil crear(ComboBox myComboBox)
        {
            return new CmdCargarComboEstadoCivil(myComboBox);
        }


        // Metodo que ejecuta el comando.
        public void Ejecutar()
        {
            this.myComboBox.BeginUpdate();
            this.ObtenerDatos();
            this.PrepararControl("DESCRIPCION", "IDESTADOCIVIL");
        }


        // Metodo que carga la lista de estados civiles.
        protected override void ObtenerDatos()
        {
            try
            {
                IDaoEstadoCivil myDao = DaoEstadoCivil.crear();
                this.EstadoCivilList = myDao.ObtenerListaEstadoCivil();
                this.InsertarValorInicial();
                this.myComboBox.DataSource = this.EstadoCivilList;
            }
            catch (Exception ex)
            {
                this.MostrarMensajeDeError(ex);
            }
        }


        private void InsertarValorInicial()
        {
            DtoEstadoCivil myDto = new DtoEstadoCivil();
            myDto.IdEstadoCivil = 0;
            myDto.Descripcion = "Seleccione estado civil";
            this.EstadoCivilList.Insert(0, myDto);
        }


    }
}
