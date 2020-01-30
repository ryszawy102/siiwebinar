using Database.Models;

namespace Database.Seeds
{
    internal static class OfficeSeeds
    {
        internal static Office[] GetOfficeSeeds()
        {
            var offices = new[]
            {
                new Office
                {
                    OfficeId = 1,
                    OfficeName = "Sii Warszawa",
                    OfficeStreet = "al. Niepodległości 69",
                    OfficePostCode = "02-626",
                    OfficeCity = "Warszawa",
                    OfficeReceptionTelephone = "+48 22 486 37 37",
                    OfficeEmail = "informacja@sii.pl",
                    OpenYear = 2006
                },
                new Office
                {
                    OfficeId = 2,
                    OfficeName = "Sii Gdańsk",
                    OfficeStreet = "al. Grunwaldzka 472e",
                    OfficePostCode = "80-309",
                    OfficeCity = "Gdańsk",
                    OfficeReceptionTelephone = "+48 58 32 17 800",
                    OfficeEmail = "informacja-gdansk@sii.pl",
                    OpenYear = 2008
                },
                new Office
                {
                    OfficeId = 3,
                    OfficeName = "Sii Wrocław",
                    OfficeStreet = "ul. Gwiaździsta 66",
                    OfficePostCode = "53-413",
                    OfficeCity = "Wrocław",
                    OfficeReceptionTelephone = "+48 71 75 82 290",
                    OfficeEmail = "informacja-wroclaw@sii.pl",
                    OpenYear = 2009
                },
                new Office
                {
                    OfficeId = 4,
                    OfficeName = "Sii Poznań",
                    OfficeStreet = "ul. Królowej Jadwigi 43",
                    OfficePostCode = "61-872",
                    OfficeCity = "Poznań",
                    OfficeReceptionTelephone = "+48 61 639 76 80",
                    OfficeEmail = "informacja-poznan@sii.pl",
                    OpenYear = 2010
                },
                new Office
                {
                    OfficeId = 5,
                    OfficeName = "Sii Kraków",
                    OfficeStreet = "ul. Wielicka 28",
                    OfficePostCode = "30-522",
                    OfficeCity = "Kraków",
                    OfficeReceptionTelephone = "+48 12 390 61 70",
                    OfficeEmail = "informacja-krakow@sii.pl",
                    OpenYear = 2011
                },
                new Office
                {
                    OfficeId = 6,
                    OfficeName = "Sii Łódź",
                    OfficeStreet = "ul. Kopcińskiego 79",
                    OfficePostCode = "90-033",
                    OfficeCity = "Łódź",
                    OfficeReceptionTelephone = "+48 42 239 29 60",
                    OfficeEmail = "informacja-lodz@sii.pl",
                    OpenYear = 2011
                },
                new Office
                {
                    OfficeId = 7,
                    OfficeName = "Sii Lublin",
                    OfficeStreet = "ul. Szeligowskiego 6B",
                    OfficePostCode = "20-883",
                    OfficeCity = "Lublin",
                    OfficeReceptionTelephone = "+48 81 45 46 888",
                    OfficeEmail = "informacja-lublin@sii.pl",
                    OpenYear = 2012
                },
                new Office
                {
                    OfficeId = 8,
                    OfficeName = "Sii Katowice",
                    OfficeStreet = "ul. Ściegiennego 3",
                    OfficePostCode = "40-114",
                    OfficeCity = "Katowice",
                    OfficeReceptionTelephone = "+48 32 661 41 91",
                    OfficeEmail = "informacja-katowice@sii.pl",
                    OpenYear = 2018
                },
                new Office
                {
                    OfficeId = 9,
                    OfficeName = "Sii Rzeszów",
                    OfficeStreet = "ul. Rejtana 20",
                    OfficePostCode = "35-310",
                    OfficeCity = "Rzeszów",
                    OfficeReceptionTelephone = "+48 17 283 83 15",
                    OfficeEmail = "informacja-rzeszow@sii.pl",
                    OpenYear = 2018
                },
                new Office
                {
                    OfficeId = 10,
                    OfficeName = "Sii Częstochowa",
                    OfficeStreet = "ul. Jasnogórska 79",
                    OfficePostCode = "42-217",
                    OfficeCity = "Częstochowa",
                    OfficeReceptionTelephone = null,
                    OfficeEmail = "informacja-czestochowa@sii.pl",
                    OpenYear = 2018
                },
                new Office
                {
                    OfficeId = 11,
                    OfficeName = "Sii Piła",
                    OfficeStreet = "Kasztanowa Office, ul. Kossaka 20",
                    OfficePostCode = "64-920",
                    OfficeCity = "Piła",
                    OfficeReceptionTelephone = null,
                    OfficeEmail = "informacja-pila@sii.pl",
                    OpenYear = 2018
                },
                new Office
                {
                    OfficeId = 12,
                    OfficeName = "Sii Bydgoszcz",
                    OfficeStreet = "Plac Kościeleckich 3",
                    OfficePostCode = "85-033",
                    OfficeCity = "Bydgoszcz",
                    OfficeReceptionTelephone = "+48 52 523 92 67",
                    OfficeEmail = "informacja-bydgoszcz@sii.pl",
                    OpenYear = 2018
                },
                new Office
                {
                    OfficeId = 13,
                    OfficeName = "Sii Gliwice",
                    OfficeStreet = "Zygmunta Starego 24B",
                    OfficePostCode = "44-100",
                    OfficeCity = "Gliwice",
                    OfficeReceptionTelephone = null,
                    OfficeEmail = "informacja-gliwice@sii.pl",
                    OpenYear = 2019
                },
                new Office
                {
                    OfficeId = 14,
                    OfficeName = "Sii Białystok",
                    OfficeStreet = "Józefa Marjańskiego 3",
                    OfficePostCode = "15-402",
                    OfficeCity = "Białystok",
                    OfficeReceptionTelephone = null,
                    OfficeEmail = "informacja-bialystok@sii.pl",
                    OpenYear = 2019
                }
            };
            return offices;
        }
    }
}