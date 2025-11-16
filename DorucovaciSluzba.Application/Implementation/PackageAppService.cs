using DorucovaciSluzba.Application.Abstraction;
using DorucovaciSluzba.Domain.Entities;
using DorucovaciSluzba.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorucovaciSluzba.Application.Implementation
{
    public class PackageAppService : IPackageAppService
    {
        AppDbContext _appDbContext;

        public PackageAppService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Zasilka> Select()
        {
            return _appDbContext.Zasilky
                    .Include(z => z.Odesilatel)
                    .Include(z => z.Prijemce)
                    .Include(z => z.Kuryr)
                    .Include(z => z.Stav)
                    .ToList();
        }

        public void Create(Zasilka zasilka)
        {
            // Vygeneruj unikátní číslo zásilky
            zasilka.Cislo = GenerujCisloZasilky();
            zasilka.DatumOdeslani = DateTime.Now;
            zasilka.StavId = 1;

            _appDbContext.Zasilky.Add(zasilka);
            _appDbContext.SaveChanges();
        }

        private string GenerujCisloZasilky()
        {
            const int maxPokusu = 500;
            var random = new Random();

            for (int pokus = 0; pokus < maxPokusu; pokus++)
            {
                // Generuje číslo ve formátu xxx-xx-xx
                string cislo = $"{random.Next(0, 1000):D3}-{random.Next(0, 100):D2}-{random.Next(0, 100):D2}";

                // Kontrola, jestli číslo neexistuje v databázi
                if (!_appDbContext.Zasilky.Any(z => z.Cislo == cislo))
                {
                    return cislo; // Unikátní číslo nalezeno
                }
            }

            throw new Exception($"Nepodařilo se vygenerovat unikátní číslo zásilky po {maxPokusu} pokusech.");
        }
        public bool Delete(int zasilkaId)
        {
            var zasilka = _appDbContext.Zasilky.Find(zasilkaId);
            if (zasilka == null)
            {
                return false; // Zásilka neexistuje
            }
            _appDbContext.Zasilky.Remove(zasilka);
            _appDbContext.SaveChanges();
            return true;
        }

        public Zasilka? FindByCisloAndEmail(string cislo, string email)
        {
            return _appDbContext.Zasilky
                .Include(z => z.Odesilatel)
                .Include(z => z.Prijemce)
                .Include(z => z.Kuryr)
                .Include(z => z.Stav)
                .FirstOrDefault(z =>
                    z.Cislo == cislo &&
                    (z.Odesilatel!.Email.ToLower() == email.ToLower() ||
                     z.Prijemce!.Email.ToLower() == email.ToLower())
                );
        }

        public Zasilka? GetById(int id)
        {
            return _appDbContext.Zasilky
                .Include(z => z.Odesilatel)
                .Include(z => z.Prijemce)
                .Include(z => z.Kuryr)
                .Include(z => z.Stav)
                .FirstOrDefault(z => z.Id == id);
        }

        public void Update(Zasilka zasilka)
        {
            var existujiciZasilka = _appDbContext.Zasilky.Find(zasilka.Id);

            if (existujiciZasilka == null)
            {
                throw new Exception("Zásilka nebyla nalezena.");
            }

            existujiciZasilka.StavId = zasilka.StavId;
            existujiciZasilka.KuryrId = zasilka.KuryrId;

            _appDbContext.SaveChanges();
        }

        public IList<Uzivatel> GetAllCouriers()
        {
            return _appDbContext.Uzivatele
                .Where(u => u.TypId == 3) // TypId 3 = Kurýr
                .OrderBy(u => u.Prijmeni)
                .ThenBy(u => u.Jmeno)
                .ToList();
        }

        public IList<StavZasilka> GetAllStates()
        {
            return _appDbContext.StavyZasilek
                .OrderBy(s => s.Id)
                .ToList();
        }
    }
}
