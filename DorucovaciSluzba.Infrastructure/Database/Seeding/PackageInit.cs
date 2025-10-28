using DorucovaciSluzba.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorucovaciSluzba.Infrastructure.Database.Seeding
{
    internal class PackageInit
    {
        public IList<Zasilka> GetPackages()
        {
            IList<Zasilka> packages = new List<Zasilka>();

            packages.Add(new Zasilka()
            {
                Id = 1,
                Cislo = "532-65-33",
                DatumOdeslani = new DateTime(2025, 10, 30),
                StavId = 2,
                DestinaceUlice = "Kvítková",
                DestinaceCP = "4653",
                DestinaceMesto = "Zlín",
                DestinacePsc = "760 01",
                OdesilatelId = 3,
                PrijemceId = 2,
                KuryrId = 4
            });

            return packages;
        }
    }
}
