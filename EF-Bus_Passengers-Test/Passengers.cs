using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Bus_Passengers_Test
{
    internal class Passengers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BussId { get; set; }

        public Buss Buss { get; set; }

    }
}
