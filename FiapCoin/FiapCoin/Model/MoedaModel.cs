using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace APPCompassSP.Model
{
    public class MoedaModel : INotifyPropertyChanged
    {
        public MoedaModel()
        {

        }

        public MoedaModel(int _id, String _nome, double _valor, double _percentual )
        {
            this.IdMoeda = _id;
            this.NomeMoeda = _nome;
            this.Saldo = _valor;
            this.PercentualCarteira = _percentual;
        }


        private int idMoeda;
        public int IdMoeda
        {
            get { return idMoeda; }
            set
            {
                if (idMoeda != value)
                {
                    idMoeda = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String nomeMoeda;
        public String NomeMoeda
        {
            get { return nomeMoeda; }
            set
            {
                if (nomeMoeda != value)
                {
                    nomeMoeda = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private double saldo;
        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (saldo != value)
                {
                    saldo = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private double percentualCarteira;
        public double PercentualCarteira
        {
            get { return percentualCarteira; }
            set
            {
                if (percentualCarteira != value)
                {
                    percentualCarteira = value;
                    NotifyPropertyChanged();
                }
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
