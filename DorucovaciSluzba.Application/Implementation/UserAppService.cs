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
    public class UserAppService : IUserAppService
    {
        AppDbContext _appDbContext;

        public UserAppService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Uzivatel> Select()
        {
            return _appDbContext.Uzivatele
                   .Include(u => u.Typ)
                   .ToList();
        }
    }
}
