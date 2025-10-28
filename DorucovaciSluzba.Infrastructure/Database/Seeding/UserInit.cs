using DorucovaciSluzba.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorucovaciSluzba.Infrastructure.Database.Seeding
{
    internal class UserInit
    {
        public IList<Uzivatel> GetUsers()
        {
            IList<Uzivatel> users = new List<Uzivatel>();

            users.Add(new Uzivatel()
            {
                Id = 1,
                Jmeno = "Web",
                Prijmeni = "Admin",
                Email = "admin@web.cz",
                Heslo = "admin",
                TypId = 1
            });

            users.Add(new Uzivatel()
            {
                Id = 2,
                Jmeno = "Petr",
                Prijmeni = "Novák",
                Email = "novak@web.cz",
                Heslo = "test",
                DatumNarozeni = new DateTime(1995, 11, 23),
                Telefon = "700 600 500",
                Ulice = "Kvítková",
                CP = "4653",
                Mesto = "Zlín",
                Psc = "760 01",
                TypId = 2
            });

            users.Add(new Uzivatel()
            {
                Id = 3,
                Jmeno = "Prokop",
                Prijmeni = "Buben",
                Email = "buben@web.cz",
                Heslo = "test",
                DatumNarozeni = new DateTime(1998, 2, 16),
                Telefon = "700 600 400",
                Ulice = "Družstevní",
                CP = "4872",
                Mesto = "Zlín",
                Psc = "760 01",
                TypId = 2
            });

            users.Add(new Uzivatel()
            {
                Id = 4,
                Jmeno = "Petr",
                Prijmeni = "Novotný",
                Email = "novotny@web.cz",
                Heslo = "test",
                Telefon = "300 600 500",
                TypId = 3
            });

            return users;
        }
    }
}
