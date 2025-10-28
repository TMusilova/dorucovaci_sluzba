using DorucovaciSluzba.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorucovaciSluzba.Infrastructure.Database.Seeding
{
    internal class StateInit
    {
        public IList<StavZasilka> GetStates()
        {
            IList<StavZasilka> states = new List<StavZasilka>();

            states.Add(new StavZasilka()
            {
                Id = 1,
                Stav = "Objednávka vytvořena"
            });

            states.Add(new StavZasilka()
            {
                Id = 2,
                Stav = "Zásilka je v přepravě"
            });

            states.Add(new StavZasilka()
            {
                Id = 3,
                Stav = "Doručeno"
            });

            states.Add(new StavZasilka()
            {
                Id = 4,
                Stav = "Reklamováno"
            });

            return states;
        }
    }
}
