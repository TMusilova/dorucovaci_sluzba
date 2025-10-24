using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorucovaciSluzba.Domain.Entities
{
    public class TypUzivatel : Entity<int>
    {
        public string Typ { get; set; } = "uzivatel";
    }
}
