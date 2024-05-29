using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Bus_Passengers_Test
{
    internal class Buss
    {
        public int Id { get; set; }
        public string BussName { get; set; }
        public int NumberOfseats { get; set; }
        public List<Passengers> PassengersList { get; set; }
    }
}
