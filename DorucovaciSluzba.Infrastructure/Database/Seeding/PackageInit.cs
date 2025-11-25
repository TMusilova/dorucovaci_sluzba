using DorucovaciSluzba.Domain.Entities;

namespace DorucovaciSluzba.Infrastructure.Database.Seeding
{
    internal class PackageInit
    {
        public List<Zasilka> GetPackages()
        {
            return new List<Zasilka>
            {
                // Karel → Eva (kurýr Petr)
                new Zasilka
                {
                    Id = 1,
                    Cislo = "123-45-67",
                    DatumOdeslani = new DateTime(2025, 11, 20, 10, 30, 0),
                    StavId = 3, // Doručeno
                    DestinaceUlice = "Nádražní",
                    DestinaceCP = "456",
                    DestinaceMesto = "Brno",
                    DestinacePsc = "602 00",
                    OdesilatelId = 5, // Karel
                    PrijemceId = 6,   // Eva
                    KuryrId = 2       // Petr
                },
                
                // Eva → Tomáš (kurýr Lukáš, v přepravě)
                new Zasilka
                {
                    Id = 2,
                    Cislo = "234-56-78",
                    DatumOdeslani = new DateTime(2025, 11, 23, 14, 15, 0),
                    StavId = 2, // V přepravě
                    DestinaceUlice = "Zahradní",
                    DestinaceCP = "789",
                    DestinaceMesto = "Ostrava",
                    DestinacePsc = "700 30",
                    OdesilatelId = 6, // Eva
                    PrijemceId = 7,   // Tomáš
                    KuryrId = 3       // Lukáš
                },
                
                // Tomáš → Jana (zatím bez kurýra)
                new Zasilka
                {
                    Id = 3,
                    Cislo = "345-67-89",
                    DatumOdeslani = new DateTime(2025, 11, 24, 9, 0, 0),
                    StavId = 1, // Objednávka vytvořena
                    DestinaceUlice = "Školní",
                    DestinaceCP = "321",
                    DestinaceMesto = "Plzeň",
                    DestinacePsc = "301 00",
                    OdesilatelId = 7, // Tomáš
                    PrijemceId = 8,   // Jana
                    KuryrId = null
                },
                
                // Jana → Karel (kurýr Petr)
                new Zasilka
                {
                    Id = 4,
                    Cislo = "456-78-90",
                    DatumOdeslani = new DateTime(2025, 11, 22, 16, 45, 0),
                    StavId = 2, // V přepravě
                    DestinaceUlice = "Hlavní",
                    DestinaceCP = "123",
                    DestinaceMesto = "Praha",
                    DestinacePsc = "110 00",
                    OdesilatelId = 8, // Jana
                    PrijemceId = 5,   // Karel
                    KuryrId = 2       // Petr
                },
                
                // Karel → Tomáš (kurýr Lukáš, doručeno)
                new Zasilka
                {
                    Id = 5,
                    Cislo = "567-89-01",
                    DatumOdeslani = new DateTime(2025, 11, 18, 11, 20, 0),
                    StavId = 3, // Doručeno
                    DestinaceUlice = "Zahradní",
                    DestinaceCP = "789",
                    DestinaceMesto = "Ostrava",
                    DestinacePsc = "700 30",
                    OdesilatelId = 5, // Karel
                    PrijemceId = 7,   // Tomáš
                    KuryrId = 3       // Lukáš
                },
                
                // Eva → Karel (reklamováno)
                new Zasilka
                {
                    Id = 6,
                    Cislo = "678-90-12",
                    DatumOdeslani = new DateTime(2025, 11, 15, 8, 30, 0),
                    StavId = 4, // Reklamováno
                    DestinaceUlice = "Hlavní",
                    DestinaceCP = "123",
                    DestinaceMesto = "Praha",
                    DestinacePsc = "110 00",
                    OdesilatelId = 6, // Eva
                    PrijemceId = 5,   // Karel
                    KuryrId = 2       // Petr
                }
            };
        }
    }
}