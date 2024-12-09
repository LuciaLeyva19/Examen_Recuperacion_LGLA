using CriticografoMVVM_MALH.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Examen_Recuperacion_LGLA.VistaModelo
{
    public class VMFrecuenciaCardiaca : BaseViewModel
    {
        #region VARIABLES
        private int _latidosEn15Seg;
        private int _frecuenciaCardiaca;
        private string _estadoFrecuencia;
        #endregion

        #region CONSTRUCTOR
        public VMFrecuenciaCardiaca(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public int LatidosEn15Seg
        {
            get { return _latidosEn15Seg; }
            set
            {
                SetValue(ref _latidosEn15Seg, value);
                CalcularFrecuenciaCardiaca();
            }
        }

        public int FrecuenciaCardiaca
        {
            get { return _frecuenciaCardiaca; }
            set { SetValue(ref _frecuenciaCardiaca, value); }
        }

        public string EstadoFrecuencia
        {
            get { return _estadoFrecuencia; }
            set { SetValue(ref _estadoFrecuencia, value); }
        }
        #endregion

        #region PROCESOS
        private void CalcularFrecuenciaCardiaca()
        {
            FrecuenciaCardiaca = LatidosEn15Seg * 4;
            if (FrecuenciaCardiaca < 60)
                EstadoFrecuencia = "Frecuencia cardiaca baja";
            else if (FrecuenciaCardiaca > 100)
                EstadoFrecuencia = "Frecuencia cardiaca alta";
            else
                EstadoFrecuencia = "Frecuencia cardiaca normal";
        }
        #endregion

        #region COMANDOS
        public ICommand CalcularCommand => new Command(CalcularFrecuenciaCardiaca);
        #endregion
    }
}
