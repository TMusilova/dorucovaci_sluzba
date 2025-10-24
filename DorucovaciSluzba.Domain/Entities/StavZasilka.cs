using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorucovaciSluzba.Domain.Entities
{
    public class StavZasilka : Entity<int>
    {
        public string Stav { get; set; } = "Objednávka vytvořena";
    }
}
