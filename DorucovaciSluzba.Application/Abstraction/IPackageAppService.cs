using DorucovaciSluzba.Domain.Entities;

namespace DorucovaciSluzba.Application.Abstraction
{
    public interface IPackageAppService
    {
        IList<Zasilka> Select();
        void Create(Zasilka zasilka);
        bool Delete(int zasilkaId);

        Zasilka? FindByCisloAndEmail(string cislo, string email);
        Zasilka? GetById(int id);
        void Update(Zasilka zasilka);

        IList<StavZasilka> GetAllStates();
    }
}
