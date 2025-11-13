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
            _appDbContext.Zasilky.Add(zasilka);
            _appDbContext.SaveChanges();
        }
    }
}
