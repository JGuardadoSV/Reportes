using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportes
{
    // Parametros 
    //Origen de datos
    public class Ventas
    {
        public int id { get; set; }
        public int numeroFactura { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public decimal monto { get; set; }


        public List<Ventas> listado ()
        {
            return new List<Ventas>
            {
                new Ventas{id=1,numeroFactura=1,fecha=DateTime.Parse("2021-06-01"),cliente="Juan",monto=200M},
                new Ventas{id=1,numeroFactura=1,fecha=DateTime.Parse("2021-06-01"),cliente="Juan",monto=200M},
                new Ventas{id=1,numeroFactura=1,fecha=DateTime.Parse("2021-06-01"),cliente="Juan",monto=200M},
                new Ventas{id=2,numeroFactura=2,fecha=DateTime.Parse("2021-06-02"),cliente="Juan",monto=100M},
                new Ventas{id=2,numeroFactura=2,fecha=DateTime.Parse("2021-06-02"),cliente="Juan",monto=100M},
                new Ventas{id=2,numeroFactura=2,fecha=DateTime.Parse("2021-06-02"),cliente="Juan",monto=100M},
                new Ventas{id=2,numeroFactura=2,fecha=DateTime.Parse("2021-06-02"),cliente="Juan",monto=100M},
                new Ventas{id=3,numeroFactura=3,fecha=DateTime.Parse("2021-06-03"),cliente="Juan",monto=300M}
            };

        }
    }
}
