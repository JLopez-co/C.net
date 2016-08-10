using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina{
    class Empleado{
        public Empleado() {
            NombreCompleto = "";
            Documento = "";
            SueldoDiario = 0m;
            Cargo = "";
        }
        private string nombreCompleto;
        private string documento;
        private decimal sueldoDiario;
        private string cargo;

        public string NombreCompleto{
            get{
                return nombreCompleto;
            }

            set{
                nombreCompleto = value;
            }
        }

        public string Documento{
            get{
                return documento;
            }

            set {
                documento = value;
            }
        }

        public decimal SueldoDiario{
            get{
                return sueldoDiario;
            }

            set{
                sueldoDiario = value;
            }
        }

        public string Cargo{
            get{
                return cargo;
            }

            set {
                cargo = value;
            }
        }

        public decimal CalcularSalario (int dias) {
            return SueldoDiario * dias;
        }

    }
}
