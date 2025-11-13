using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DorucovaciSluzba.Domain.Entities;

namespace DorucovaciSluzba.Application.Abstraction
{
    public interface IUserAppService
    {
        IList<Uzivatel> Select();
    }
}
