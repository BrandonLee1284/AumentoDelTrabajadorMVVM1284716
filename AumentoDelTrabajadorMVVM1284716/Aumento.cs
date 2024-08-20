using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoDelTrabajadorMVVM1284716
{
    public class Aumento : INotifyPropertyChanged
    {
        private double _sueldo;
        private double _nuevoSueldo;

        public double Sueldo
        {
            get => _sueldo;
            set
            {
                if (_sueldo != value)
                {
                    _sueldo = value;
                    OnPropertyChanged(nameof(Sueldo));
                    OnPropertyChanged(nameof(NuevoSueldo));
                }
            }
        }

        public double NuevoSueldo
        {
            get
            {
                if (Sueldo < 1000)
                {
                    return Sueldo * 1.15;
                }
                else
                {
                    return Sueldo * 1.12;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
