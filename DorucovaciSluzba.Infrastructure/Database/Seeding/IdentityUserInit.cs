using DorucovaciSluzba.Infrastructure.Identity;

namespace DorucovaciSluzba.Infrastructure.Database.Seeding
{
    internal class IdentityUserInit
    {
        public List<User> GetAllUsers()
        {
            return new List<User>
            {
                GetAdmin(),
                GetKuryr1(),
                GetKuryr2(),
                GetPodpora(),
                GetUzivatel1(),
                GetUzivatel2(),
                GetUzivatel3(),
                GetUzivatel4()
            };
        }

        public User GetAdmin()
        {
            return new User()
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Novák",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@dorucovacisluzba.cz",
                NormalizedEmail = "ADMIN@DORUCOVACISLUZBA.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==",
                SecurityStamp = "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c",
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            };
        }

        public User GetKuryr1()
        {
            return new User()
            {
                Id = 2,
                FirstName = "Petr",
                LastName = "Svoboda",
                UserName = "kuryr",
                NormalizedUserName = "KURYR",
                Email = "kuryr@dorucovacisluzba.cz",
                NormalizedEmail = "KURYR@DORUCOVACISLUZBA.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6",
                ConcurrencyStamp = "7a8d96fd-5918-441b-b800-cbafa99de97b",
                PhoneNumber = "700 123 456",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "700 123 456"
            };
        }

        public User GetKuryr2()
        {
            return new User()
            {
                Id = 3,
                FirstName = "Lukáš",
                LastName = "Černý",
                UserName = "kuryr2",
                NormalizedUserName = "KURYR2",
                Email = "kuryr2@dorucovacisluzba.cz",
                NormalizedEmail = "KURYR2@DORUCOVACISLUZBA.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "KURYR2XC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "d20c95cg-ehg5-6gg9-d0g8-hdfhb21hg90e",
                PhoneNumber = "702 456 789",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "702 456 789"
            };
        }

        public User GetPodpora()
        {
            return new User()
            {
                Id = 4,
                FirstName = "Marie",
                LastName = "Dvořáková",
                UserName = "podpora",
                NormalizedUserName = "PODPORA",
                Email = "podpora@dorucovacisluzba.cz",
                NormalizedEmail = "PODPORA@DORUCOVACISLUZBA.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "PODPORAXC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "c19b94bf-dgf4-5ff8-c9f7-gcfga10gf89d",
                PhoneNumber = "777 888 999",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "777 888 999"
            };
        }

        public User GetUzivatel1()
        {
            return new User()
            {
                Id = 5,
                FirstName = "Karel",
                LastName = "Procházka",
                UserName = "karel.prochazka",
                NormalizedUserName = "KAREL.PROCHAZKA",
                Email = "karel.prochazka@email.cz",
                NormalizedEmail = "KAREL.PROCHAZKA@EMAIL.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "UZIV1XC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "e31d05dh-fih6-7hh0-e1h9-ieiic32ih01f",
                PhoneNumber = "603 111 222",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "603 111 222",
                Ulice = "Hlavní",
                CP = "123",
                Mesto = "Praha",
                Psc = "110 00"
            };
        }

        public User GetUzivatel2()
        {
            return new User()
            {
                Id = 6,
                FirstName = "Eva",
                LastName = "Málková",
                UserName = "eva.malkova",
                NormalizedUserName = "EVA.MALKOVA",
                Email = "eva.malkova@email.cz",
                NormalizedEmail = "EVA.MALKOVA@EMAIL.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "UZIV2XC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "f42e16ei-gji7-8ii1-f2i0-jfjjd43ji12g",
                PhoneNumber = "604 333 444",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "604 333 444",
                Ulice = "Nádražní",
                CP = "456",
                Mesto = "Brno",
                Psc = "602 00"
            };
        }

        public User GetUzivatel3()
        {
            return new User()
            {
                Id = 7,
                FirstName = "Tomáš",
                LastName = "Veselý",
                UserName = "tomas.vesely",
                NormalizedUserName = "TOMAS.VESELY",
                Email = "tomas.vesely@email.cz",
                NormalizedEmail = "TOMAS.VESELY@EMAIL.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "UZIV3XC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "g53f27fj-hkj8-9jj2-g3j1-kgkkf54kj23h",
                PhoneNumber = "605 555 666",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "605 555 666",
                Ulice = "Zahradní",
                CP = "789",
                Mesto = "Ostrava",
                Psc = "700 30"
            };
        }

        public User GetUzivatel4()
        {
            return new User()
            {
                Id = 8,
                FirstName = "Jana",
                LastName = "Horáková",
                UserName = "jana.horakova",
                NormalizedUserName = "JANA.HORAKOVA",
                Email = "jana.horakova@email.cz",
                NormalizedEmail = "JANA.HORAKOVA@EMAIL.CZ",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==",
                SecurityStamp = "UZIV4XC646ZBNCDYSM3H5FRK5RWP2TN6",
                ConcurrencyStamp = "h64g38gk-ilk9-0kk3-h4k2-lhllg65lk34i",
                PhoneNumber = "606 777 888",
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                Telefon = "606 777 888",
                Ulice = "Školní",
                CP = "321",
                Mesto = "Plzeň",
                Psc = "301 00"
            };
        }
    }
}