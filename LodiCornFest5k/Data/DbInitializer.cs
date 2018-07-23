using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using LodiCornFest5k.Models;
using Microsoft.EntityFrameworkCore;

namespace LodiCornFest5k.Data
{
    public static class DbInitializer
    {
        private static readonly string RaceName2016 = "2016 Lodi Cornfest 5K";
        private static readonly string RaceName2017 = "2017 Lodi Cornfest 5K";
        private static readonly string RaceName2018 = "2018 Lodi Cornfest 5K";

        private static readonly string AgeGroupName14AndUnder = "14 & Under";
        private static readonly string AgeGroupName15to18 = "15-18";
        private static readonly string AgeGroupName19to24 = "19-24";
        private static readonly string AgeGroupName25to29 = "25-29";
        private static readonly string AgeGroupName30to39 = "30-39";
        private static readonly string AgeGroupName40to49 = "40-49";
        private static readonly string AgeGroupName50to59 = "50-59";
        private static readonly string AgeGroupName60Plus = "60+";

        public static async Task Initialize(RaceContext context)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
            
            var runners = new ConcurrentBag<Runner>()
            {
                new Runner { FirstName = "Max", LastName = "Gucker", Gender = Gender.Male},
                new Runner { FirstName = "Chuck", LastName = "Engle", Gender = Gender.Male},
                new Runner { FirstName = "Kyle", LastName = "Chudzinski", Gender = Gender.Male},
                new Runner { FirstName = "Macy", LastName = "McAdams", Gender = Gender.Female},
                new Runner { FirstName = "Andrew", LastName = "Hibler", Gender = Gender.Male},
                new Runner { FirstName = "Alex", LastName = "Derhammer", Gender = Gender.Male},
                new Runner { FirstName = "Zane", LastName = "Evans", Gender = Gender.Male},
                new Runner { FirstName = "Brett", LastName = "Gucker", Gender = Gender.Male},
                new Runner { FirstName = "Luke", LastName = "Malena", Gender = Gender.Male},
                new Runner { FirstName = "Riley", LastName = "Freeland", Gender = Gender.Female},
                new Runner { FirstName = "Ladd", LastName = "Clifford", Gender = Gender.Male},
                new Runner { FirstName = "Andy", LastName = "Davis", Gender = Gender.Male},
                new Runner { FirstName = "Zach", LastName = "Johnston", Gender = Gender.Male},
                new Runner { FirstName = "Joseph", LastName = "Bruening", Gender = Gender.Male},
                new Runner { FirstName = "Michaela", LastName = "Davis", Gender = Gender.Female},
                new Runner { FirstName = "Maria", LastName = "Porras", Gender = Gender.Female},
                new Runner { FirstName = "Makaela", LastName = "Salyer", Gender = Gender.Female},
                new Runner { FirstName = "Greg", LastName = "Hill", Gender = Gender.Male},
                new Runner { FirstName = "Bailey", LastName = "Freeland", Gender = Gender.Female},
                new Runner { FirstName = "Jenna", LastName = "Oliver", Gender = Gender.Female},
                new Runner { FirstName = "Cooper", LastName = "Hartsel", Gender = Gender.Male},
                new Runner { FirstName = "Joey", LastName = "Kurtz", Gender = Gender.Male},
                new Runner { FirstName = "Nolan", LastName = "Freeland", Gender = Gender.Male},
                new Runner { FirstName = "Sophia", LastName = "Spencer", Gender = Gender.Female},
                new Runner { FirstName = "David", LastName = "Huff", Gender = Gender.Male},
                new Runner { FirstName = "Tyler", LastName = "Palmer", Gender = Gender.Male},
                new Runner { FirstName = "Paige", LastName = "Munchick", Gender = Gender.Female},
                new Runner { FirstName = "Dave", LastName = "Freeland", Gender = Gender.Male},
                new Runner { FirstName = "Keith", LastName = "Johnston", Gender = Gender.Male},
                new Runner { FirstName = "Harold", LastName = "Dravenstott", Gender = Gender.Male},
                new Runner { FirstName = "Scott", LastName = "Stoner", Gender = Gender.Male},
                new Runner { FirstName = "Jennifer", LastName = "Ridgway", Gender = Gender.Female},
                new Runner { FirstName = "Brad", LastName = "Oliver", Gender = Gender.Male},
                new Runner { FirstName = "TJ", LastName = "Corbett", Gender = Gender.Male},
                new Runner { FirstName = "Raymond", LastName = "Miller", Gender = Gender.Male},
                new Runner { FirstName = "Asa", LastName = "Gynn", Gender = Gender.Male},
                new Runner { FirstName = "William", LastName = "Foster", Gender = Gender.Male},
                new Runner { FirstName = "Eric", LastName = "Thomas", Gender = Gender.Male},
                new Runner { FirstName = "Liv", LastName = "Wells", Gender = Gender.Female},
                new Runner { FirstName = "Katie", LastName = "Canfield", Gender = Gender.Female},
                new Runner { FirstName = "Emma", LastName = "Hibler", Gender = Gender.Female},
                new Runner { FirstName = "Clay", LastName = "Gucker", Gender = Gender.Male},
                new Runner { FirstName = "Andrew", LastName = "Vasel", Gender = Gender.Male},
                new Runner { FirstName = "Kevin", LastName = "Seager", Gender = Gender.Male},
                new Runner { FirstName = "Clara", LastName = "Neville", Gender = Gender.Female},
                new Runner { FirstName = "Vanessa", LastName = "Monhemius", Gender = Gender.Female},
                new Runner { FirstName = "John", LastName = "Monhemius", Gender = Gender.Male},
                new Runner { FirstName = "Daniel", LastName = "Vereb", Gender = Gender.Male},
                new Runner { FirstName = "Randi", LastName = "Vahl", Gender = Gender.Female},
                new Runner { FirstName = "Madeline", LastName = "Bohan", Gender = Gender.Female},
                new Runner { FirstName = "Shaun", LastName = "Vahl", Gender = Gender.Male},
                new Runner { FirstName = "Sandra", LastName = "Foster", Gender = Gender.Female},
                new Runner { FirstName = "Melody", LastName = "Seager", Gender = Gender.Female},
                new Runner { FirstName = "Jessica", LastName = "Hill", Gender = Gender.Female},
                new Runner { FirstName = "Becky", LastName = "McAdams", Gender = Gender.Female},
                new Runner { FirstName = "Jennifer", LastName = "Foster", Gender = Gender.Female},
                new Runner { FirstName = "Charlie", LastName = "Reed", Gender = Gender.Male},
                new Runner { FirstName = "Kevin", LastName = "Chudzinski", Gender = Gender.Male},
                new Runner { FirstName = "Riley", LastName = "Evans", Gender = Gender.Female},
                new Runner { FirstName = "Madison", LastName = "Snyder", Gender = Gender.Female},
                new Runner { FirstName = "Debby", LastName = "Klinect", Gender = Gender.Female},
                new Runner { FirstName = "Abigail", LastName = "Sparks", Gender = Gender.Female},
                new Runner { FirstName = "Lydia", LastName = "Fike", Gender = Gender.Female},
                new Runner { FirstName = "David", LastName = "Sears", Gender = Gender.Male},
                new Runner { FirstName = "Earl", LastName = "Kanzeg", Gender = Gender.Male},
                new Runner { FirstName = "Elizabeth", LastName = "Kanzeg", Gender = Gender.Female},
                new Runner { FirstName = "Teresa", LastName = "Strine", Gender = Gender.Female},
                new Runner { FirstName = "Cassie", LastName = "Chance", Gender = Gender.Female},
                new Runner { FirstName = "James", LastName = "Mathatas", Gender = Gender.Male},
                new Runner { FirstName = "Christy", LastName = "Mathatas", Gender = Gender.Female},
                new Runner { FirstName = "Caity", LastName = "Steiner", Gender = Gender.Female},
                new Runner { FirstName = "Brooke", LastName = "Gucker", Gender = Gender.Female},
                new Runner { FirstName = "Heidi", LastName = "Hartzler", Gender = Gender.Female},
                new Runner { FirstName = "Brian", LastName = "Hartzler", Gender = Gender.Male},
                new Runner { FirstName = "Brian", LastName = "Kulchar", Gender = Gender.Male},
                new Runner { FirstName = "Tiffany", LastName = "Kosman", Gender = Gender.Female},
                new Runner { FirstName = "Connie", LastName = "Emerson", Gender = Gender.Female},
                new Runner { FirstName = "Lucas", LastName = "Clark", Gender = Gender.Male},
                new Runner { FirstName = "Kris", LastName = "Kopchak", Gender = Gender.Male},
                new Runner { FirstName = "Noah", LastName = "Navratil", Gender = Gender.Male},
                new Runner { FirstName = "Benjamin", LastName = "Melkey", Gender = Gender.Male},
                new Runner { FirstName = "Jeral", LastName = "Imhoff", Gender = Gender.Male},
                new Runner { FirstName = "Dillon", LastName = "West", Gender = Gender.Male},
                new Runner { FirstName = "Sam", LastName = "Brandt", Gender = Gender.Male},
                new Runner { FirstName = "Estevan", LastName = "Ortega", Gender = Gender.Male},
                new Runner { FirstName = "Braden", LastName = "Young", Gender = Gender.Male},
                new Runner { FirstName = "Greg", LastName = "Szklarz", Gender = Gender.Male},
                new Runner { FirstName = "Nick", LastName = "Zeigler", Gender = Gender.Male},
                new Runner { FirstName = "Tommie", LastName = "Kurtz", Gender = Gender.Female},
                new Runner { FirstName = "Jack", LastName = "Szklarz", Gender = Gender.Male},
                new Runner { FirstName = "Emma", LastName = "Nagel", Gender = Gender.Female},
                new Runner { FirstName = "Joshua", LastName = "Rittgers", Gender = Gender.Male},
                new Runner { FirstName = "Hayden", LastName = "Jarvis", Gender = Gender.Male},
                new Runner { FirstName = "Mollie", LastName = "Jarvis", Gender = Gender.Female},
                new Runner { FirstName = "Steven", LastName = "Bett", Gender = Gender.Male},
                new Runner { FirstName = "Stephanie", LastName = "Foster", Gender = Gender.Female},
                new Runner { FirstName = "Brett", LastName = "Deyung", Gender = Gender.Male},
                new Runner { FirstName = "Carrie", LastName = "Stoner", Gender = Gender.Female},
                new Runner { FirstName = "Alyssa", LastName = "Stoner", Gender = Gender.Female},
                new Runner { FirstName = "Bob", LastName = "Chittenden", Gender = Gender.Male},
                new Runner { FirstName = "McKenna", LastName = "Kulas", Gender = Gender.Female},
                new Runner { FirstName = "David", LastName = "Rittgers", Gender = Gender.Male},
                new Runner { FirstName = "Vladimir", LastName = "Herdman", Gender = Gender.Male},
                new Runner { FirstName = "Carrie", LastName = "Hartsel", Gender = Gender.Female},
                new Runner { FirstName = "Garrett", LastName = "Silva", Gender = Gender.Male},
                new Runner { FirstName = "Mariya", LastName = "Silva", Gender = Gender.Female},
                new Runner { FirstName = "Keith", LastName = "Winkler", Gender = Gender.Male},
                new Runner { FirstName = "Jack", LastName = "Reed", Gender = Gender.Male},
                new Runner { FirstName = "Noah", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "Sam", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "Tony", LastName = "Kall", Gender = Gender.Male},
                new Runner { FirstName = "Matt", LastName = "Chidsey", Gender = Gender.Male},
                new Runner { FirstName = "Kris", LastName = "Kapchak", Gender = Gender.Male},
                new Runner { FirstName = "Ben", LastName = "House", Gender = Gender.Male},
                new Runner { FirstName = "Tristan", LastName = "Vaughan", Gender = Gender.Male},
                new Runner { FirstName = "Caleb", LastName = "Hostetler", Gender = Gender.Male},
                new Runner { FirstName = "Matt", LastName = "Butt", Gender = Gender.Male},
                new Runner { FirstName = "Edward", LastName = "Hawkins", Gender = Gender.Male},
                new Runner { FirstName = "Christopher", LastName = "Dostal", Gender = Gender.Male},
                new Runner { FirstName = "Robert", LastName = "Sayer", Gender = Gender.Male},
                new Runner { FirstName = "Danny", LastName = "Price", Gender = Gender.Male},
                new Runner { FirstName = "Ben", LastName = "Nagy", Gender = Gender.Male},
                new Runner { FirstName = "Caleigh", LastName = "Stefanko", Gender = Gender.Female},
                new Runner { FirstName = "Xander", LastName = "Beltz", Gender = Gender.Male},
                new Runner { FirstName = "Drew", LastName = "West", Gender = Gender.Male},
                new Runner { FirstName = "Anna", LastName = "Winnicki", Gender = Gender.Female},
                new Runner { FirstName = "Colton", LastName = "Carpenter", Gender = Gender.Male},
                new Runner { FirstName = "Matthew", LastName = "Pettry", Gender = Gender.Male},
                new Runner { FirstName = "Don", LastName = "House", Gender = Gender.Male},
                new Runner { FirstName = "Luke", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "Liz", LastName = "Stanley", Gender = Gender.Female},
                new Runner { FirstName = "Giovanna", LastName = "Moroschan", Gender = Gender.Male},
                new Runner { FirstName = "Jeff", LastName = "Heilman", Gender = Gender.Male},
                new Runner { FirstName = "Kayla", LastName = "Moroschan", Gender = Gender.Female},
                new Runner { FirstName = "Michelle", LastName = "Yoder", Gender = Gender.Female},
                new Runner { FirstName = "Gia", LastName = "Catalano", Gender = Gender.Female},
                new Runner { FirstName = "Carson", LastName = "Nagy", Gender = Gender.Male},
                new Runner { FirstName = "Shannon", LastName = "Malikowski", Gender = Gender.Female},
                new Runner { FirstName = "Faith", LastName = "Theobald", Gender = Gender.Female},
                new Runner { FirstName = "Bill", LastName = "Brandt", Gender = Gender.Male},
                new Runner { FirstName = "Jennifer", LastName = "Meyers", Gender = Gender.Female},
                new Runner { FirstName = "Darin", LastName = "Clapp", Gender = Gender.Male},
                new Runner { FirstName = "Eileen", LastName = "Robison", Gender = Gender.Female},
                new Runner { FirstName = "Megan", LastName = "Brandt", Gender = Gender.Female},
                new Runner { FirstName = "Amy", LastName = "Winnicki", Gender = Gender.Female},
                new Runner { FirstName = "Maria", LastName = "Clapp", Gender = Gender.Female},
                new Runner { FirstName = "Maddie", LastName = "Brandt", Gender = Gender.Female},
                new Runner { FirstName = "Donald", LastName = "Spencer", Gender = Gender.Male},
                new Runner { FirstName = "Kelsey", LastName = "Dake", Gender = Gender.Female},
                new Runner { FirstName = "Jessica", LastName = "Flynn", Gender = Gender.Female},
                new Runner { FirstName = "Mike", LastName = "Hewit", Gender = Gender.Male},
                new Runner { FirstName = "Ethan", LastName = "Flynn", Gender = Gender.Male},
                new Runner { FirstName = "Zech", LastName = "Paul", Gender = Gender.Male},
                new Runner { FirstName = "Emma", LastName = "Reed", Gender = Gender.Female},
                new Runner { FirstName = "Lisa", LastName = "Reinhart", Gender = Gender.Female},
                new Runner { FirstName = "Amy", LastName = "Donnelly", Gender = Gender.Female},
                new Runner { FirstName = "Mike", LastName = "Bangert", Gender = Gender.Male},
                new Runner { FirstName = "Philip", LastName = "Syverson", Gender = Gender.Male},
                new Runner { FirstName = "Victoria", LastName = "Porter", Gender = Gender.Female},
                new Runner { FirstName = "Graydon", LastName = "Flynn", Gender = Gender.Male},
                new Runner { FirstName = "Abbie", LastName = "Eichel", Gender = Gender.Female},
                new Runner { FirstName = "Licia", LastName = "Pappas", Gender = Gender.Female}
            };

            var races = new ConcurrentBag<Race>
            {
                new Race { Name = RaceName2016, Date = new DateTime(2016, 7, 23) },
                new Race { Name = RaceName2017, Date = new DateTime(2017, 7, 22) },
                new Race { Name = RaceName2018, Date = new DateTime(2018, 7, 21) }
            };

            await context.Runners.AddRangeAsync(runners);
            await context.Races.AddRangeAsync(races);
            await context.SaveChangesAsync();

            #region Runners

            var NoahAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Noah" && x.LastName == "Affolder");
            var SamAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Sam" && x.LastName == "Affolder");
            var LukeAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Luke" && x.LastName == "Affolder");
            var MikeBangert = await context.Runners.SingleAsync(x => x.FirstName == "Mike" && x.LastName == "Bangert");
            var XanderBeltz = await context.Runners.SingleAsync(x => x.FirstName == "Xander" && x.LastName == "Beltz");
            var StevenBett = await context.Runners.SingleAsync(x => x.FirstName == "Steven" && x.LastName == "Bett");
            var MadelineBohan = await context.Runners.SingleAsync(x => x.FirstName == "Madeline" && x.LastName == "Bohan");
            var SamBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Sam" && x.LastName == "Brandt");
            var BillBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Bill" && x.LastName == "Brandt");
            var MeganBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Megan" && x.LastName == "Brandt");
            var MaddieBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Maddie" && x.LastName == "Brandt");
            var JosephBruening = await context.Runners.SingleAsync(x => x.FirstName == "Joseph" && x.LastName == "Bruening");
            var MattButt = await context.Runners.SingleAsync(x => x.FirstName == "Matt" && x.LastName == "Butt");
            var KatieCanfield = await context.Runners.SingleAsync(x => x.FirstName == "Katie" && x.LastName == "Canfield");
            var ColtonCarpenter = await context.Runners.SingleAsync(x => x.FirstName == "Colton" && x.LastName == "Carpenter");
            var GiaCatalano = await context.Runners.SingleAsync(x => x.FirstName == "Gia" && x.LastName == "Catalano");
            var CassieChance = await context.Runners.SingleAsync(x => x.FirstName == "Cassie" && x.LastName == "Chance");
            var MattChidsey = await context.Runners.SingleAsync(x => x.FirstName == "Matt" && x.LastName == "Chidsey");
            var BobChittenden = await context.Runners.SingleAsync(x => x.FirstName == "Bob" && x.LastName == "Chittenden");
            var KyleChudzinski = await context.Runners.SingleAsync(x => x.FirstName == "Kyle" && x.LastName == "Chudzinski");
            var KevinChudzinski = await context.Runners.SingleAsync(x => x.FirstName == "Kevin" && x.LastName == "Chudzinski");
            var DarinClapp = await context.Runners.SingleAsync(x => x.FirstName == "Darin" && x.LastName == "Clapp");
            var MariaClapp = await context.Runners.SingleAsync(x => x.FirstName == "Maria" && x.LastName == "Clapp");
            var LucasClark = await context.Runners.SingleAsync(x => x.FirstName == "Lucas" && x.LastName == "Clark");
            var LaddClifford = await context.Runners.SingleAsync(x => x.FirstName == "Ladd" && x.LastName == "Clifford");
            var TJCorbett = await context.Runners.SingleAsync(x => x.FirstName == "TJ" && x.LastName == "Corbett");
            var KelseyDake = await context.Runners.SingleAsync(x => x.FirstName == "Kelsey" && x.LastName == "Dake");
            var AndyDavis = await context.Runners.SingleAsync(x => x.FirstName == "Andy" && x.LastName == "Davis");
            var MichaelaDavis = await context.Runners.SingleAsync(x => x.FirstName == "Michaela" && x.LastName == "Davis");
            var AlexDerhammer = await context.Runners.SingleAsync(x => x.FirstName == "Alex" && x.LastName == "Derhammer");
            var BrettDeyung = await context.Runners.SingleAsync(x => x.FirstName == "Brett" && x.LastName == "Deyung");
            var AmyDonnelly = await context.Runners.SingleAsync(x => x.FirstName == "Amy" && x.LastName == "Donnelly");
            var ChristopherDostal = await context.Runners.SingleAsync(x => x.FirstName == "Christopher" && x.LastName == "Dostal");
            var HaroldDravenstott = await context.Runners.SingleAsync(x => x.FirstName == "Harold" && x.LastName == "Dravenstott");
            var AbbieEichel = await context.Runners.SingleAsync(x => x.FirstName == "Abbie" && x.LastName == "Eichel");
            var ConnieEmerson = await context.Runners.SingleAsync(x => x.FirstName == "Connie" && x.LastName == "Emerson");
            var ChuckEngle = await context.Runners.SingleAsync(x => x.FirstName == "Chuck" && x.LastName == "Engle");
            var ZaneEvans = await context.Runners.SingleAsync(x => x.FirstName == "Zane" && x.LastName == "Evans");
            var RileyEvans = await context.Runners.SingleAsync(x => x.FirstName == "Riley" && x.LastName == "Evans");
            var LydiaFike = await context.Runners.SingleAsync(x => x.FirstName == "Lydia" && x.LastName == "Fike");
            var JessicaFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Jessica" && x.LastName == "Flynn");
            var EthanFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Ethan" && x.LastName == "Flynn");
            var GraydonFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Graydon" && x.LastName == "Flynn");
            var WilliamFoster = await context.Runners.SingleAsync(x => x.FirstName == "William" && x.LastName == "Foster");
            var SandraFoster = await context.Runners.SingleAsync(x => x.FirstName == "Sandra" && x.LastName == "Foster");
            var JenniferFoster = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "Foster");
            var StephanieFoster = await context.Runners.SingleAsync(x => x.FirstName == "Stephanie" && x.LastName == "Foster");
            var RileyFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Riley" && x.LastName == "Freeland");
            var BaileyFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Bailey" && x.LastName == "Freeland");
            var NolanFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Nolan" && x.LastName == "Freeland");
            var DaveFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Dave" && x.LastName == "Freeland");
            var MaxGucker = await context.Runners.SingleAsync(x => x.FirstName == "Max" && x.LastName == "Gucker");
            var BrettGucker = await context.Runners.SingleAsync(x => x.FirstName == "Brett" && x.LastName == "Gucker");
            var ClayGucker = await context.Runners.SingleAsync(x => x.FirstName == "Clay" && x.LastName == "Gucker");
            var BrookeGucker = await context.Runners.SingleAsync(x => x.FirstName == "Brooke" && x.LastName == "Gucker");
            var AsaGynn = await context.Runners.SingleAsync(x => x.FirstName == "Asa" && x.LastName == "Gynn");
            var CooperHartsel = await context.Runners.SingleAsync(x => x.FirstName == "Cooper" && x.LastName == "Hartsel");
            var CarrieHartsel = await context.Runners.SingleAsync(x => x.FirstName == "Carrie" && x.LastName == "Hartsel");
            var HeidiHartzler = await context.Runners.SingleAsync(x => x.FirstName == "Heidi" && x.LastName == "Hartzler");
            var BrianHartzler = await context.Runners.SingleAsync(x => x.FirstName == "Brian" && x.LastName == "Hartzler");
            var EdwardHawkins = await context.Runners.SingleAsync(x => x.FirstName == "Edward" && x.LastName == "Hawkins");
            var JeffHeilman = await context.Runners.SingleAsync(x => x.FirstName == "Jeff" && x.LastName == "Heilman");
            var VladimirHerdman = await context.Runners.SingleAsync(x => x.FirstName == "Vladimir" && x.LastName == "Herdman");
            var MikeHewit = await context.Runners.SingleAsync(x => x.FirstName == "Mike" && x.LastName == "Hewit");
            var AndrewHibler = await context.Runners.SingleAsync(x => x.FirstName == "Andrew" && x.LastName == "Hibler");
            var EmmaHibler = await context.Runners.SingleAsync(x => x.FirstName == "Emma" && x.LastName == "Hibler");
            var GregHill = await context.Runners.SingleAsync(x => x.FirstName == "Greg" && x.LastName == "Hill");
            var JessicaHill = await context.Runners.SingleAsync(x => x.FirstName == "Jessica" && x.LastName == "Hill");
            var CalebHostetler = await context.Runners.SingleAsync(x => x.FirstName == "Caleb" && x.LastName == "Hostetler");
            var BenHouse = await context.Runners.SingleAsync(x => x.FirstName == "Ben" && x.LastName == "House");
            var DonHouse = await context.Runners.SingleAsync(x => x.FirstName == "Don" && x.LastName == "House");
            var DavidHuff = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Huff");
            var JeralImhoff = await context.Runners.SingleAsync(x => x.FirstName == "Jeral" && x.LastName == "Imhoff");
            var HaydenJarvis = await context.Runners.SingleAsync(x => x.FirstName == "Hayden" && x.LastName == "Jarvis");
            var MollieJarvis = await context.Runners.SingleAsync(x => x.FirstName == "Mollie" && x.LastName == "Jarvis");
            var ZachJohnston = await context.Runners.SingleAsync(x => x.FirstName == "Zach" && x.LastName == "Johnston");
            var KeithJohnston = await context.Runners.SingleAsync(x => x.FirstName == "Keith" && x.LastName == "Johnston");
            var TonyKall = await context.Runners.SingleAsync(x => x.FirstName == "Tony" && x.LastName == "Kall");
            var EarlKanzeg = await context.Runners.SingleAsync(x => x.FirstName == "Earl" && x.LastName == "Kanzeg");
            var ElizabethKanzeg = await context.Runners.SingleAsync(x => x.FirstName == "Elizabeth" && x.LastName == "Kanzeg");
            var KrisKapchak = await context.Runners.SingleAsync(x => x.FirstName == "Kris" && x.LastName == "Kapchak");
            var DebbyKlinect = await context.Runners.SingleAsync(x => x.FirstName == "Debby" && x.LastName == "Klinect");
            var KrisKopchak = await context.Runners.SingleAsync(x => x.FirstName == "Kris" && x.LastName == "Kopchak");
            var TiffanyKosman = await context.Runners.SingleAsync(x => x.FirstName == "Tiffany" && x.LastName == "Kosman");
            var McKennaKulas = await context.Runners.SingleAsync(x => x.FirstName == "McKenna" && x.LastName == "Kulas");
            var BrianKulchar = await context.Runners.SingleAsync(x => x.FirstName == "Brian" && x.LastName == "Kulchar");
            var JoeyKurtz = await context.Runners.SingleAsync(x => x.FirstName == "Joey" && x.LastName == "Kurtz");
            var TommieKurtz = await context.Runners.SingleAsync(x => x.FirstName == "Tommie" && x.LastName == "Kurtz");
            var LukeMalena = await context.Runners.SingleAsync(x => x.FirstName == "Luke" && x.LastName == "Malena");
            var ShannonMalikowski = await context.Runners.SingleAsync(x => x.FirstName == "Shannon" && x.LastName == "Malikowski");
            var JamesMathatas = await context.Runners.SingleAsync(x => x.FirstName == "James" && x.LastName == "Mathatas");
            var ChristyMathatas = await context.Runners.SingleAsync(x => x.FirstName == "Christy" && x.LastName == "Mathatas");
            var MacyMcAdams = await context.Runners.SingleAsync(x => x.FirstName == "Macy" && x.LastName == "McAdams");
            var BeckyMcAdams = await context.Runners.SingleAsync(x => x.FirstName == "Becky" && x.LastName == "McAdams");
            var BenjaminMelkey = await context.Runners.SingleAsync(x => x.FirstName == "Benjamin" && x.LastName == "Melkey");
            var JenniferMeyers = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "Meyers");
            var RaymondMiller = await context.Runners.SingleAsync(x => x.FirstName == "Raymond" && x.LastName == "Miller");
            var VanessaMonhemius = await context.Runners.SingleAsync(x => x.FirstName == "Vanessa" && x.LastName == "Monhemius");
            var JohnMonhemius = await context.Runners.SingleAsync(x => x.FirstName == "John" && x.LastName == "Monhemius");
            var GiovannaMoroschan = await context.Runners.SingleAsync(x => x.FirstName == "Giovanna" && x.LastName == "Moroschan");
            var KaylaMoroschan = await context.Runners.SingleAsync(x => x.FirstName == "Kayla" && x.LastName == "Moroschan");
            var PaigeMunchick = await context.Runners.SingleAsync(x => x.FirstName == "Paige" && x.LastName == "Munchick");
            var EmmaNagel = await context.Runners.SingleAsync(x => x.FirstName == "Emma" && x.LastName == "Nagel");
            var BenNagy = await context.Runners.SingleAsync(x => x.FirstName == "Ben" && x.LastName == "Nagy");
            var CarsonNagy = await context.Runners.SingleAsync(x => x.FirstName == "Carson" && x.LastName == "Nagy");
            var NoahNavratil = await context.Runners.SingleAsync(x => x.FirstName == "Noah" && x.LastName == "Navratil");
            var ClaraNeville = await context.Runners.SingleAsync(x => x.FirstName == "Clara" && x.LastName == "Neville");
            var JennaOliver = await context.Runners.SingleAsync(x => x.FirstName == "Jenna" && x.LastName == "Oliver");
            var BradOliver = await context.Runners.SingleAsync(x => x.FirstName == "Brad" && x.LastName == "Oliver");
            var EstevanOrtega = await context.Runners.SingleAsync(x => x.FirstName == "Estevan" && x.LastName == "Ortega");
            var TylerPalmer = await context.Runners.SingleAsync(x => x.FirstName == "Tyler" && x.LastName == "Palmer");
            var LiciaPappas = await context.Runners.SingleAsync(x => x.FirstName == "Licia" && x.LastName == "Pappas");
            var ZechPaul = await context.Runners.SingleAsync(x => x.FirstName == "Zech" && x.LastName == "Paul");
            var MatthewPettry = await context.Runners.SingleAsync(x => x.FirstName == "Matthew" && x.LastName == "Pettry");
            var MariaPorras = await context.Runners.SingleAsync(x => x.FirstName == "Maria" && x.LastName == "Porras");
            var VictoriaPorter = await context.Runners.SingleAsync(x => x.FirstName == "Victoria" && x.LastName == "Porter");
            var DannyPrice = await context.Runners.SingleAsync(x => x.FirstName == "Danny" && x.LastName == "Price");
            var CharlieReed = await context.Runners.SingleAsync(x => x.FirstName == "Charlie" && x.LastName == "Reed");
            var JackReed = await context.Runners.SingleAsync(x => x.FirstName == "Jack" && x.LastName == "Reed");
            var EmmaReed = await context.Runners.SingleAsync(x => x.FirstName == "Emma" && x.LastName == "Reed");
            var LisaReinhart = await context.Runners.SingleAsync(x => x.FirstName == "Lisa" && x.LastName == "Reinhart");
            var JenniferRidgway = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "Ridgway");
            var JoshuaRittgers = await context.Runners.SingleAsync(x => x.FirstName == "Joshua" && x.LastName == "Rittgers");
            var DavidRittgers = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Rittgers");
            var EileenRobison = await context.Runners.SingleAsync(x => x.FirstName == "Eileen" && x.LastName == "Robison");
            var MakaelaSalyer = await context.Runners.SingleAsync(x => x.FirstName == "Makaela" && x.LastName == "Salyer");
            var RobertSayer = await context.Runners.SingleAsync(x => x.FirstName == "Robert" && x.LastName == "Sayer");
            var KevinSeager = await context.Runners.SingleAsync(x => x.FirstName == "Kevin" && x.LastName == "Seager");
            var MelodySeager = await context.Runners.SingleAsync(x => x.FirstName == "Melody" && x.LastName == "Seager");
            var DavidSears = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Sears");
            var GarrettSilva = await context.Runners.SingleAsync(x => x.FirstName == "Garrett" && x.LastName == "Silva");
            var MariyaSilva = await context.Runners.SingleAsync(x => x.FirstName == "Mariya" && x.LastName == "Silva");
            var MadisonSnyder = await context.Runners.SingleAsync(x => x.FirstName == "Madison" && x.LastName == "Snyder");
            var AbigailSparks = await context.Runners.SingleAsync(x => x.FirstName == "Abigail" && x.LastName == "Sparks");
            var SophiaSpencer = await context.Runners.SingleAsync(x => x.FirstName == "Sophia" && x.LastName == "Spencer");
            var DonaldSpencer = await context.Runners.SingleAsync(x => x.FirstName == "Donald" && x.LastName == "Spencer");
            var LizStanley = await context.Runners.SingleAsync(x => x.FirstName == "Liz" && x.LastName == "Stanley");
            var CaleighStefanko = await context.Runners.SingleAsync(x => x.FirstName == "Caleigh" && x.LastName == "Stefanko");
            var CaitySteiner = await context.Runners.SingleAsync(x => x.FirstName == "Caity" && x.LastName == "Steiner");
            var ScottStoner = await context.Runners.SingleAsync(x => x.FirstName == "Scott" && x.LastName == "Stoner");
            var CarrieStoner = await context.Runners.SingleAsync(x => x.FirstName == "Carrie" && x.LastName == "Stoner");
            var AlyssaStoner = await context.Runners.SingleAsync(x => x.FirstName == "Alyssa" && x.LastName == "Stoner");
            var TeresaStrine = await context.Runners.SingleAsync(x => x.FirstName == "Teresa" && x.LastName == "Strine");
            var PhilipSyverson = await context.Runners.SingleAsync(x => x.FirstName == "Philip" && x.LastName == "Syverson");
            var GregSzklarz = await context.Runners.SingleAsync(x => x.FirstName == "Greg" && x.LastName == "Szklarz");
            var JackSzklarz = await context.Runners.SingleAsync(x => x.FirstName == "Jack" && x.LastName == "Szklarz");
            var FaithTheobald = await context.Runners.SingleAsync(x => x.FirstName == "Faith" && x.LastName == "Theobald");
            var EricThomas = await context.Runners.SingleAsync(x => x.FirstName == "Eric" && x.LastName == "Thomas");
            var RandiVahl = await context.Runners.SingleAsync(x => x.FirstName == "Randi" && x.LastName == "Vahl");
            var ShaunVahl = await context.Runners.SingleAsync(x => x.FirstName == "Shaun" && x.LastName == "Vahl");
            var AndrewVasel = await context.Runners.SingleAsync(x => x.FirstName == "Andrew" && x.LastName == "Vasel");
            var TristanVaughan = await context.Runners.SingleAsync(x => x.FirstName == "Tristan" && x.LastName == "Vaughan");
            var DanielVereb = await context.Runners.SingleAsync(x => x.FirstName == "Daniel" && x.LastName == "Vereb");
            var LivWells = await context.Runners.SingleAsync(x => x.FirstName == "Liv" && x.LastName == "Wells");
            var DillonWest = await context.Runners.SingleAsync(x => x.FirstName == "Dillon" && x.LastName == "West");
            var DrewWest = await context.Runners.SingleAsync(x => x.FirstName == "Drew" && x.LastName == "West");
            var KeithWinkler = await context.Runners.SingleAsync(x => x.FirstName == "Keith" && x.LastName == "Winkler");
            var AnnaWinnicki = await context.Runners.SingleAsync(x => x.FirstName == "Anna" && x.LastName == "Winnicki");
            var AmyWinnicki = await context.Runners.SingleAsync(x => x.FirstName == "Amy" && x.LastName == "Winnicki");
            var MichelleYoder = await context.Runners.SingleAsync(x => x.FirstName == "Michelle" && x.LastName == "Yoder");
            var BradenYoung = await context.Runners.SingleAsync(x => x.FirstName == "Braden" && x.LastName == "Young");
            var NickZeigler = await context.Runners.SingleAsync(x => x.FirstName == "Nick" && x.LastName == "Zeigler");

            #endregion

            #region Races

            var race2016 = await context.Races.SingleAsync(x => x.Name == RaceName2016);
            var race2017 = await context.Races.SingleAsync(x => x.Name == RaceName2017);
            var race2018 = await context.Races.SingleAsync(x => x.Name == RaceName2018);

            #endregion

            var ageGroups = new ConcurrentBag<AgeGroup>
            {
                new AgeGroup { Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2016 },
                new AgeGroup { Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2016 },
                new AgeGroup { Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2017 },
                new AgeGroup { Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2017 },
                new AgeGroup { Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2018 },
                new AgeGroup { Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2018 },
                new AgeGroup { Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2018 },
            };

            await context.AgeGroups.AddRangeAsync(ageGroups);
            await context.SaveChangesAsync();
            
            #region Age Groups

            var race2016Female14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Female60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Female && x.Race == race2016);
            var race2016Male14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2016);
            var race2016Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2016);

            var race2017Female14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Female60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Female && x.Race == race2017);
            var race2017Male14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2017);
            var race2017Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2017);

            var race2018Female14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Female60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Female && x.Race == race2018);
            var race2018Male14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2018);


            #endregion

            var raceRunners = new ConcurrentBag<RaceRunner>
            {
                new RaceRunner {Race = race2016, Runner = NoahAffolder, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = LucasClark, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = SamAffolder, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = TonyKall, AgeGroup = race2016Male19to24},
                new RaceRunner {Race = race2016, Runner = MattChidsey, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = KrisKapchak, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = BenHouse, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = MaxGucker, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = NoahNavratil, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = TristanVaughan, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = CalebHostetler, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = DillonWest, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = EstevanOrtega, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = MattButt, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = EdwardHawkins, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = RileyFreeland, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = ChristopherDostal, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = RobertSayer, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = TommieKurtz, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = SamBrandt, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = BaileyFreeland, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = NickZeigler, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = BradOliver, AgeGroup = race2016Male50to59},
                new RaceRunner {Race = race2016, Runner = DannyPrice, AgeGroup = race2016Male60Plus},
                new RaceRunner {Race = race2016, Runner = BenNagy, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = CaleighStefanko, AgeGroup = race2016Female14andUnder},
                new RaceRunner {Race = race2016, Runner = WilliamFoster, AgeGroup = race2016Male50to59},
                new RaceRunner {Race = race2016, Runner = JoeyKurtz, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = XanderBeltz, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = TylerPalmer, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = DrewWest, AgeGroup = race2016Male40to49},
                new RaceRunner {Race = race2016, Runner = ShaunVahl, AgeGroup = race2016Male40to49},
                new RaceRunner {Race = race2016, Runner = AnnaWinnicki, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = ColtonCarpenter, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = MatthewPettry, AgeGroup = race2016Male25to29},
                new RaceRunner {Race = race2016, Runner = DonHouse, AgeGroup = race2016Male50to59},
                new RaceRunner {Race = race2016, Runner = RandiVahl, AgeGroup = race2016Female40to49},
                new RaceRunner {Race = race2016, Runner = LukeAffolder, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = LizStanley, AgeGroup = race2016Female40to49},
                new RaceRunner {Race = race2016, Runner = GiovannaMoroschan, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = JeffHeilman, AgeGroup = race2016Male40to49},
                new RaceRunner {Race = race2016, Runner = KaylaMoroschan, AgeGroup = race2016Female14andUnder},
                new RaceRunner {Race = race2016, Runner = MichelleYoder, AgeGroup = race2016Female30to39},
                new RaceRunner {Race = race2016, Runner = GiaCatalano, AgeGroup = race2016Female19to24},
                new RaceRunner {Race = race2016, Runner = StephanieFoster, AgeGroup = race2016Female25to29},
                new RaceRunner {Race = race2016, Runner = CarsonNagy, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = SandraFoster, AgeGroup = race2016Female50to59},
                new RaceRunner {Race = race2016, Runner = ShannonMalikowski, AgeGroup = race2016Female40to49},
                new RaceRunner {Race = race2016, Runner = FaithTheobald, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = BillBrandt, AgeGroup = race2016Male40to49},
                new RaceRunner {Race = race2016, Runner = JenniferMeyers, AgeGroup = race2016Female30to39},
                new RaceRunner {Race = race2016, Runner = DarinClapp, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = VanessaMonhemius, AgeGroup = race2016Female14andUnder},
                new RaceRunner {Race = race2016, Runner = JohnMonhemius, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = EileenRobison, AgeGroup = race2016Female60Plus},
                new RaceRunner {Race = race2016, Runner = MeganBrandt, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = AmyWinnicki, AgeGroup = race2016Female50to59},
                new RaceRunner {Race = race2016, Runner = MariaClapp, AgeGroup = race2016Female30to39},
                new RaceRunner {Race = race2016, Runner = MaddieBrandt, AgeGroup = race2016Female19to24},
                new RaceRunner {Race = race2016, Runner = CharlieReed, AgeGroup = race2016Male15to18},
                new RaceRunner {Race = race2016, Runner = DonaldSpencer, AgeGroup = race2016Male19to24},
                new RaceRunner {Race = race2016, Runner = KelseyDake, AgeGroup = race2016Female19to24},
                new RaceRunner {Race = race2016, Runner = JessicaFlynn, AgeGroup = race2016Female30to39},
                new RaceRunner {Race = race2016, Runner = MikeHewit, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = EthanFlynn, AgeGroup = race2016Male30to39},
                new RaceRunner {Race = race2016, Runner = ZechPaul, AgeGroup = race2016Male25to29},
                new RaceRunner {Race = race2016, Runner = MadelineBohan, AgeGroup = race2016Female14andUnder},
                new RaceRunner {Race = race2016, Runner = EmmaReed, AgeGroup = race2016Female15to18},
                new RaceRunner {Race = race2016, Runner = LisaReinhart, AgeGroup = race2016Female25to29},
                new RaceRunner {Race = race2016, Runner = AmyDonnelly, AgeGroup = race2016Female40to49},
                new RaceRunner {Race = race2016, Runner = MikeBangert, AgeGroup = race2016Male50to59},
                new RaceRunner {Race = race2016, Runner = PhilipSyverson, AgeGroup = race2016Male50to59},
                new RaceRunner {Race = race2016, Runner = VictoriaPorter, AgeGroup = race2016Female40to49},
                new RaceRunner {Race = race2016, Runner = JackReed, AgeGroup = race2016Male14andUnder},
                new RaceRunner {Race = race2016, Runner = GraydonFlynn, AgeGroup = race2016Male19to24},
                new RaceRunner {Race = race2016, Runner = AbbieEichel, AgeGroup = race2016Female25to29},
                new RaceRunner {Race = race2016, Runner = LiciaPappas, AgeGroup = race2016Female50to59},
                new RaceRunner {Race = race2017, Runner = LucasClark, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = KrisKopchak, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = NoahNavratil, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = MaxGucker, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = TristanVaughan, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = ChuckEngle, AgeGroup = race2017Male40to49},
                new RaceRunner {Race = race2017, Runner = BenjaminMelkey, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = JeralImhoff, AgeGroup = race2017Male25to29},
                new RaceRunner {Race = race2017, Runner = DillonWest, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = SamBrandt, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = EstevanOrtega, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = BradenYoung, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = GregSzklarz, AgeGroup = race2017Male60Plus},
                new RaceRunner {Race = race2017, Runner = NickZeigler, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = AsaGynn, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = BrettGucker, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = MariaPorras, AgeGroup = race2017Female14andUnder},
                new RaceRunner {Race = race2017, Runner = JennaOliver, AgeGroup = race2017Female15to18},
                new RaceRunner {Race = race2017, Runner = TommieKurtz, AgeGroup = race2017Female15to18},
                new RaceRunner {Race = race2017, Runner = JackSzklarz, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = EmmaNagel, AgeGroup = race2017Female15to18},
                new RaceRunner {Race = race2017, Runner = JoshuaRittgers, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = HaydenJarvis, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = ScottStoner, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = MollieJarvis, AgeGroup = race2017Female30to39},
                new RaceRunner {Race = race2017, Runner = PaigeMunchick, AgeGroup = race2017Female14andUnder},
                new RaceRunner {Race = race2017, Runner = StevenBett, AgeGroup = race2017Male60Plus},
                new RaceRunner {Race = race2017, Runner = BradOliver, AgeGroup = race2017Male50to59},
                new RaceRunner {Race = race2017, Runner = CooperHartsel, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = JosephBruening, AgeGroup = race2017Male19to24},
                new RaceRunner {Race = race2017, Runner = WilliamFoster, AgeGroup = race2017Male50to59},
                new RaceRunner {Race = race2017, Runner = ZaneEvans, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = StephanieFoster, AgeGroup = race2017Female25to29},
                new RaceRunner {Race = race2017, Runner = BrettDeyung, AgeGroup = race2017Male40to49},
                new RaceRunner {Race = race2017, Runner = JohnMonhemius, AgeGroup = race2017Male30to39},
                new RaceRunner {Race = race2017, Runner = VanessaMonhemius, AgeGroup = race2017Female14andUnder},
                new RaceRunner {Race = race2017, Runner = CarrieStoner, AgeGroup = race2017Female40to49},
                new RaceRunner {Race = race2017, Runner = AndrewVasel, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = AlyssaStoner, AgeGroup = race2017Female14andUnder},
                new RaceRunner {Race = race2017, Runner = RandiVahl, AgeGroup = race2017Female40to49},
                new RaceRunner {Race = race2017, Runner = SandraFoster, AgeGroup = race2017Female50to59},
                new RaceRunner {Race = race2017, Runner = CharlieReed, AgeGroup = race2017Male15to18},
                new RaceRunner {Race = race2017, Runner = ShaunVahl, AgeGroup = race2017Male40to49},
                new RaceRunner {Race = race2017, Runner = BobChittenden, AgeGroup = race2017Male60Plus},
                new RaceRunner {Race = race2017, Runner = McKennaKulas, AgeGroup = race2017Female15to18},
                new RaceRunner {Race = race2017, Runner = DavidRittgers, AgeGroup = race2017Male40to49},
                new RaceRunner {Race = race2017, Runner = VladimirHerdman, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2017, Runner = CarrieHartsel, AgeGroup = race2017Female30to39},
                new RaceRunner {Race = race2017, Runner = GarrettSilva, AgeGroup = race2017Male25to29},
                new RaceRunner {Race = race2017, Runner = MariyaSilva, AgeGroup = race2017Female25to29},
                new RaceRunner {Race = race2017, Runner = KeithWinkler, AgeGroup = race2017Male50to59},
                new RaceRunner {Race = race2017, Runner = JackReed, AgeGroup = race2017Male14andUnder},
                new RaceRunner {Race = race2018, Runner = MaxGucker, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = TristanVaughan, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = ChuckEngle, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = JeralImhoff, AgeGroup = race2018Male30to39},
                new RaceRunner {Race = race2018, Runner = KyleChudzinski, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = MacyMcAdams, AgeGroup = race2018Female19to24},
                new RaceRunner {Race = race2018, Runner = AndrewHibler, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = AlexDerhammer, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = ZaneEvans, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = BrettGucker, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = LukeMalena, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = RileyFreeland, AgeGroup = race2018Female19to24},
                new RaceRunner {Race = race2018, Runner = LaddClifford, AgeGroup = race2018Male50to59},
                new RaceRunner {Race = race2018, Runner = AndyDavis, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = NickZeigler, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = ZachJohnston, AgeGroup = race2018Male25to29},
                new RaceRunner {Race = race2018, Runner = JosephBruening, AgeGroup = race2018Male25to29},
                new RaceRunner {Race = race2018, Runner = MichaelaDavis, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = MariaPorras, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = MakaelaSalyer, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = GregHill, AgeGroup = race2018Male25to29},
                new RaceRunner {Race = race2018, Runner = BaileyFreeland, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = JennaOliver, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = CooperHartsel, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = JoeyKurtz, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = NolanFreeland, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = SophiaSpencer, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = DavidHuff, AgeGroup = race2018Male30to39},
                new RaceRunner {Race = race2018, Runner = TylerPalmer, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = DillonWest, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = PaigeMunchick, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = DaveFreeland, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = KeithJohnston, AgeGroup = race2018Male50to59},
                new RaceRunner {Race = race2018, Runner = HaroldDravenstott, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = ScottStoner, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = JenniferRidgway, AgeGroup = race2018Female40to49},
                new RaceRunner {Race = race2018, Runner = BradOliver, AgeGroup = race2018Male50to59},
                new RaceRunner {Race = race2018, Runner = TJCorbett, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = RaymondMiller, AgeGroup = race2018Male60Plus},
                new RaceRunner {Race = race2018, Runner = AsaGynn, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = WilliamFoster, AgeGroup = race2018Male50to59},
                new RaceRunner {Race = race2018, Runner = EricThomas, AgeGroup = race2018Male30to39},
                new RaceRunner {Race = race2018, Runner = LivWells, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = KatieCanfield, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = EmmaHibler, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = ClayGucker, AgeGroup = race2018Male14andUnder},
                new RaceRunner {Race = race2018, Runner = AndrewVasel, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = KevinSeager, AgeGroup = race2018Male50to59},
                new RaceRunner {Race = race2018, Runner = ClaraNeville, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = VanessaMonhemius, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = JohnMonhemius, AgeGroup = race2018Male30to39},
                new RaceRunner {Race = race2018, Runner = DanielVereb, AgeGroup = race2018Male25to29},
                new RaceRunner {Race = race2018, Runner = RandiVahl, AgeGroup = race2018Female40to49},
                new RaceRunner {Race = race2018, Runner = MadelineBohan, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = ShaunVahl, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = SandraFoster, AgeGroup = race2018Female50to59},
                new RaceRunner {Race = race2018, Runner = MelodySeager, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = JessicaHill, AgeGroup = race2018Female25to29},
                new RaceRunner {Race = race2018, Runner = BeckyMcAdams, AgeGroup = race2018Female40to49},
                new RaceRunner {Race = race2018, Runner = JenniferFoster, AgeGroup = race2018Female25to29},
                new RaceRunner {Race = race2018, Runner = CharlieReed, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = KevinChudzinski, AgeGroup = race2018Male15to18},
                new RaceRunner {Race = race2018, Runner = RileyEvans, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = MadisonSnyder, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = DebbyKlinect, AgeGroup = race2018Female50to59},
                new RaceRunner {Race = race2018, Runner = AbigailSparks, AgeGroup = race2018Female30to39},
                new RaceRunner {Race = race2018, Runner = LydiaFike, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = DavidSears, AgeGroup = race2018Male60Plus},
                new RaceRunner {Race = race2018, Runner = EarlKanzeg, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = ElizabethKanzeg, AgeGroup = race2018Female15to18},
                new RaceRunner {Race = race2018, Runner = TeresaStrine, AgeGroup = race2018Female40to49},
                new RaceRunner {Race = race2018, Runner = CassieChance, AgeGroup = race2018Female40to49},
                new RaceRunner {Race = race2018, Runner = JamesMathatas, AgeGroup = race2018Male30to39},
                new RaceRunner {Race = race2018, Runner = ChristyMathatas, AgeGroup = race2018Female30to39},
                new RaceRunner {Race = race2018, Runner = CaitySteiner, AgeGroup = race2018Female25to29},
                new RaceRunner {Race = race2018, Runner = BrookeGucker, AgeGroup = race2018Female14andUnder},
                new RaceRunner {Race = race2018, Runner = HeidiHartzler, AgeGroup = race2018Female40to49},
                new RaceRunner {Race = race2018, Runner = BrianHartzler, AgeGroup = race2018Male40to49},
                new RaceRunner {Race = race2018, Runner = BrianKulchar, AgeGroup = race2018Male50to59},
                new RaceRunner {Race = race2018, Runner = TiffanyKosman, AgeGroup = race2018Female30to39},
                new RaceRunner {Race = race2018, Runner = ConnieEmerson, AgeGroup = race2018Female60Plus},
            };

            var results = new ConcurrentBag<Result>
            {
                new Result { Runner = NoahAffolder, Race = race2016, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 16, 15, 58) },
                new Result { Runner = LucasClark, Race = race2016, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 17, 23, 75) },
                new Result { Runner = SamAffolder, Race = race2016, OverallPlace = 3, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 17, 38, 25) },
                new Result { Runner = TonyKall, Race = race2016, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 3, 46) },
                new Result { Runner = MattChidsey, Race = race2016, OverallPlace = 5, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 18, 14, 99) },
                new Result { Runner = KrisKapchak, Race = race2016, OverallPlace = 6, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 18, 21, 26) },
                new Result { Runner = BenHouse, Race = race2016, OverallPlace = 7, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 18, 38, 56) },
                new Result { Runner = MaxGucker, Race = race2016, OverallPlace = 8, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 12, 64) },
                new Result { Runner = NoahNavratil, Race = race2016, OverallPlace = 9, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 20, 8, 10) },
                new Result { Runner = TristanVaughan, Race = race2016, OverallPlace = 10, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 20, 17, 50) },
                new Result { Runner = CalebHostetler, Race = race2016, OverallPlace = 11, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 20, 31, 58) },
                new Result { Runner = DillonWest, Race = race2016, OverallPlace = 12, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 21, 33, 27) },
                new Result { Runner = EstevanOrtega, Race = race2016, OverallPlace = 13, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 21, 33, 54) },
                new Result { Runner = MattButt, Race = race2016, OverallPlace = 14, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 21, 42, 72) },
                new Result { Runner = EdwardHawkins, Race = race2016, OverallPlace = 15, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 55, 57) },
                new Result { Runner = RileyFreeland, Race = race2016, OverallPlace = 16, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 58, 44) },
                new Result { Runner = ChristopherDostal, Race = race2016, OverallPlace = 17, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 24, 45) },
                new Result { Runner = RobertSayer, Race = race2016, OverallPlace = 18, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 49, 90) },
                new Result { Runner = TommieKurtz, Race = race2016, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 39, 70) },
                new Result { Runner = SamBrandt, Race = race2016, OverallPlace = 20, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 23, 39, 91) },
                new Result { Runner = BaileyFreeland, Race = race2016, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 40, 92) },
                new Result { Runner = NickZeigler, Race = race2016, OverallPlace = 22, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 24, 40, 21) },
                new Result { Runner = BradOliver, Race = race2016, OverallPlace = 23, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 51, 90) },
                new Result { Runner = DannyPrice, Race = race2016, OverallPlace = 24, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 55, 3) },
                new Result { Runner = BenNagy, Race = race2016, OverallPlace = 25, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 6, 61) },
                new Result { Runner = CaleighStefanko, Race = race2016, OverallPlace = 26, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 20, 15) },
                new Result { Runner = WilliamFoster, Race = race2016, OverallPlace = 27, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 22, 19) },
                new Result { Runner = JoeyKurtz, Race = race2016, OverallPlace = 28, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 33, 22) },
                new Result { Runner = XanderBeltz, Race = race2016, OverallPlace = 29, AgeGroupPlace = 15, Time = new TimeSpan(0, 0, 25, 33, 41) },
                new Result { Runner = TylerPalmer, Race = race2016, OverallPlace = 30, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 37, 0) },
                new Result { Runner = DrewWest, Race = race2016, OverallPlace = 31, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 42, 43) },
                new Result { Runner = ShaunVahl, Race = race2016, OverallPlace = 32, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 50, 96) },
                new Result { Runner = AnnaWinnicki, Race = race2016, OverallPlace = 33, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 51, 86) },
                new Result { Runner = ColtonCarpenter, Race = race2016, OverallPlace = 34, AgeGroupPlace = 16, Time = new TimeSpan(0, 0, 26, 3, 44) },
                new Result { Runner = MatthewPettry, Race = race2016, OverallPlace = 35, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 10, 24) },
                new Result { Runner = DonHouse, Race = race2016, OverallPlace = 36, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 26, 16, 20) },
                new Result { Runner = RandiVahl, Race = race2016, OverallPlace = 37, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 19, 25) },
                new Result { Runner = LukeAffolder, Race = race2016, OverallPlace = 38, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 26, 27, 20) },
                new Result { Runner = LizStanley, Race = race2016, OverallPlace = 39, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 26, 28, 57) },
                new Result { Runner = GiovannaMoroschan, Race = race2016, OverallPlace = 40, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 41, 98) },
                new Result { Runner = JeffHeilman, Race = race2016, OverallPlace = 41, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 26, 56, 12) },
                new Result { Runner = KaylaMoroschan, Race = race2016, OverallPlace = 42, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 27, 27, 73) },
                new Result { Runner = MichelleYoder, Race = race2016, OverallPlace = 43, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 18, 99) },
                new Result { Runner = GiaCatalano, Race = race2016, OverallPlace = 44, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 51, 18) },
                new Result { Runner = StephanieFoster, Race = race2016, OverallPlace = 45, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 17, 18) },
                new Result { Runner = CarsonNagy, Race = race2016, OverallPlace = 46, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 29, 19, 24) },
                new Result { Runner = SandraFoster, Race = race2016, OverallPlace = 47, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 32, 72) },
                new Result { Runner = ShannonMalikowski, Race = race2016, OverallPlace = 48, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 29, 38, 4) },
                new Result { Runner = FaithTheobald, Race = race2016, OverallPlace = 49, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 29, 38, 45) },
                new Result { Runner = BillBrandt, Race = race2016, OverallPlace = 50, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 29, 43, 55) },
                new Result { Runner = JenniferMeyers, Race = race2016, OverallPlace = 51, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 30, 15, 27) },
                new Result { Runner = DarinClapp, Race = race2016, OverallPlace = 52, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 30, 48, 16) },
                new Result { Runner = VanessaMonhemius, Race = race2016, OverallPlace = 53, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 48, 49) },
                new Result { Runner = JohnMonhemius, Race = race2016, OverallPlace = 54, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 30, 49, 0) },
                new Result { Runner = EileenRobison, Race = race2016, OverallPlace = 55, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 31, 7, 78) },
                new Result { Runner = MeganBrandt, Race = race2016, OverallPlace = 56, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 31, 46, 20) },
                new Result { Runner = AmyWinnicki, Race = race2016, OverallPlace = 57, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 32, 2, 65) },
                new Result { Runner = MariaClapp, Race = race2016, OverallPlace = 58, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 32, 19, 35) },
                new Result { Runner = MaddieBrandt, Race = race2016, OverallPlace = 59, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 32, 56, 95) },
                new Result { Runner = CharlieReed, Race = race2016, OverallPlace = 60, AgeGroupPlace = 17, Time = new TimeSpan(0, 0, 33, 25, 85) },
                new Result { Runner = DonaldSpencer, Race = race2016, OverallPlace = 61, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 33, 44, 49) },
                new Result { Runner = KelseyDake, Race = race2016, OverallPlace = 62, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 34, 6, 30) },
                new Result { Runner = JessicaFlynn, Race = race2016, OverallPlace = 63, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 34, 8, 70) },
                new Result { Runner = MikeHewit, Race = race2016, OverallPlace = 64, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 34, 30, 3) },
                new Result { Runner = EthanFlynn, Race = race2016, OverallPlace = 65, AgeGroupPlace = 18, Time = new TimeSpan(0, 0, 34, 32, 59) },
                new Result { Runner = ZechPaul, Race = race2016, OverallPlace = 66, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 34, 40, 14) },
                new Result { Runner = MadelineBohan, Race = race2016, OverallPlace = 67, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 34, 50, 91) },
                new Result { Runner = EmmaReed, Race = race2016, OverallPlace = 68, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 35, 6, 89) },
                new Result { Runner = LisaReinhart, Race = race2016, OverallPlace = 69, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 35, 8, 70) },
                new Result { Runner = AmyDonnelly, Race = race2016, OverallPlace = 70, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 0, 88) },
                new Result { Runner = MikeBangert, Race = race2016, OverallPlace = 71, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 5, 70) },
                new Result { Runner = PhilipSyverson, Race = race2016, OverallPlace = 72, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 36, 6, 0) },
                new Result { Runner = VictoriaPorter, Race = race2016, OverallPlace = 73, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 40, 45, 93) },
                new Result { Runner = JackReed, Race = race2016, OverallPlace = 74, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 41, 21, 32) },
                new Result { Runner = GraydonFlynn, Race = race2016, OverallPlace = 75, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 41, 28, 16) },
                new Result { Runner = AbbieEichel, Race = race2016, OverallPlace = 76, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 52, 10, 42) },
                new Result { Runner = LiciaPappas, Race = race2016, OverallPlace = 77, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 52, 11, 12) },
                new Result { Runner = LucasClark, Race = race2017, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 16, 51, 87) },
                new Result { Runner = KrisKopchak, Race = race2017, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 18, 1, 89) },
                new Result { Runner = NoahNavratil, Race = race2017, OverallPlace = 3, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 18, 17, 74) },
                new Result { Runner = MaxGucker, Race = race2017, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 23, 21) },
                new Result { Runner = TristanVaughan, Race = race2017, OverallPlace = 5, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 18, 32, 94) },
                new Result { Runner = ChuckEngle, Race = race2017, OverallPlace = 6, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 41, 61) },
                new Result { Runner = BenjaminMelkey, Race = race2017, OverallPlace = 7, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 19, 50, 87) },
                new Result { Runner = JeralImhoff, Race = race2017, OverallPlace = 8, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 56, 72) },
                new Result { Runner = DillonWest, Race = race2017, OverallPlace = 9, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 20, 15, 34) },
                new Result { Runner = SamBrandt, Race = race2017, OverallPlace = 10, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 20, 24, 39) },
                new Result { Runner = EstevanOrtega, Race = race2017, OverallPlace = 11, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 20, 26, 0) },
                new Result { Runner = BradenYoung, Race = race2017, OverallPlace = 12, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 20, 32, 89) },
                new Result { Runner = GregSzklarz, Race = race2017, OverallPlace = 13, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 19, 73) },
                new Result { Runner = NickZeigler, Race = race2017, OverallPlace = 14, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 22, 54, 60) },
                new Result { Runner = AsaGynn, Race = race2017, OverallPlace = 15, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 23, 16, 23) },
                new Result { Runner = BrettGucker, Race = race2017, OverallPlace = 16, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 17, 60) },
                new Result { Runner = MariaPorras, Race = race2017, OverallPlace = 17, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 23, 22, 46) },
                new Result { Runner = JennaOliver, Race = race2017, OverallPlace = 18, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 23, 24, 23) },
                new Result { Runner = TommieKurtz, Race = race2017, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 25, 11) },
                new Result { Runner = JackSzklarz, Race = race2017, OverallPlace = 20, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 23, 32, 11) },
                new Result { Runner = EmmaNagel, Race = race2017, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 37, 60) },
                new Result { Runner = JoshuaRittgers, Race = race2017, OverallPlace = 22, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 42, 28) },
                new Result { Runner = HaydenJarvis, Race = race2017, OverallPlace = 23, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 23, 49, 41) },
                new Result { Runner = ScottStoner, Race = race2017, OverallPlace = 24, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 24, 6, 3) },
                new Result { Runner = MollieJarvis, Race = race2017, OverallPlace = 25, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 23, 90) },
                new Result { Runner = PaigeMunchick, Race = race2017, OverallPlace = 26, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 24, 44, 34) },
                new Result { Runner = StevenBett, Race = race2017, OverallPlace = 27, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 24, 55, 74) },
                new Result { Runner = BradOliver, Race = race2017, OverallPlace = 28, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 7, 81) },
                new Result { Runner = CooperHartsel, Race = race2017, OverallPlace = 29, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 25, 8, 13) },
                new Result { Runner = JosephBruening, Race = race2017, OverallPlace = 30, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 8, 43) },
                new Result { Runner = WilliamFoster, Race = race2017, OverallPlace = 31, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 24, 52) },
                new Result { Runner = ZaneEvans, Race = race2017, OverallPlace = 32, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 25, 45, 84) },
                new Result { Runner = StephanieFoster, Race = race2017, OverallPlace = 33, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 55, 84) },
                new Result { Runner = BrettDeyung, Race = race2017, OverallPlace = 34, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 27, 1, 39) },
                new Result { Runner = JohnMonhemius, Race = race2017, OverallPlace = 35, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 27, 3, 84) },
                new Result { Runner = VanessaMonhemius, Race = race2017, OverallPlace = 36, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 27, 4, 14) },
                new Result { Runner = CarrieStoner, Race = race2017, OverallPlace = 37, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 2, 47) },
                new Result { Runner = AndrewVasel, Race = race2017, OverallPlace = 38, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 29, 11, 22) },
                new Result { Runner = AlyssaStoner, Race = race2017, OverallPlace = 39, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 29, 21, 81) },
                new Result { Runner = RandiVahl, Race = race2017, OverallPlace = 40, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 22, 99) },
                new Result { Runner = SandraFoster, Race = race2017, OverallPlace = 41, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 24, 51) },
                new Result { Runner = CharlieReed, Race = race2017, OverallPlace = 42, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 29, 45, 56) },
                new Result { Runner = ShaunVahl, Race = race2017, OverallPlace = 43, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 8, 80) },
                new Result { Runner = BobChittenden, Race = race2017, OverallPlace = 44, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 21, 42) },
                new Result { Runner = McKennaKulas, Race = race2017, OverallPlace = 45, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 30, 29, 70) },
                new Result { Runner = DavidRittgers, Race = race2017, OverallPlace = 46, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 30, 57, 80) },
                new Result { Runner = VladimirHerdman, Race = race2017, OverallPlace = 47, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 31, 38, 25) },
                new Result { Runner = CarrieHartsel, Race = race2017, OverallPlace = 49, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 33, 38, 5) },
                new Result { Runner = GarrettSilva, Race = race2017, OverallPlace = 50, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 34, 44, 46) },
                new Result { Runner = MariyaSilva, Race = race2017, OverallPlace = 51, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 37, 23, 87) },
                new Result { Runner = KeithWinkler, Race = race2017, OverallPlace = 52, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 37, 59, 22) },
                new Result { Runner = JackReed, Race = race2017, OverallPlace = 53, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 37, 59, 22) },
                new Result { Runner = MaxGucker, Race = race2018, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 41, 59) },
                new Result { Runner = TristanVaughan, Race = race2018, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 18, 29, 58) },
                new Result { Runner = ChuckEngle, Race = race2018, OverallPlace = 3, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 38, 60) },
                new Result { Runner = JeralImhoff, Race = race2018, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 52, 56) },
                new Result { Runner = KyleChudzinski, Race = race2018, OverallPlace = 5, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 19, 14, 0) },
                new Result { Runner = MacyMcAdams, Race = race2018, OverallPlace = 6, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 42, 83) },
                new Result { Runner = AndrewHibler, Race = race2018, OverallPlace = 7, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 13, 54) },
                new Result { Runner = AlexDerhammer, Race = race2018, OverallPlace = 8, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 20, 21, 30) },
                new Result { Runner = ZaneEvans, Race = race2018, OverallPlace = 9, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 20, 30, 46) },
                new Result { Runner = BrettGucker, Race = race2018, OverallPlace = 10, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 20, 49, 94) },
                new Result { Runner = LukeMalena, Race = race2018, OverallPlace = 11, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 20, 56, 45) },
                new Result { Runner = RileyFreeland, Race = race2018, OverallPlace = 12, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 11, 3) },
                new Result { Runner = LaddClifford, Race = race2018, OverallPlace = 13, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 15, 31) },
                new Result { Runner = AndyDavis, Race = race2018, OverallPlace = 14, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 53, 80) },
                new Result { Runner = NickZeigler, Race = race2018, OverallPlace = 15, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 21, 57, 92) },
                new Result { Runner = ZachJohnston, Race = race2018, OverallPlace = 16, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 58, 43) },
                new Result { Runner = JosephBruening, Race = race2018, OverallPlace = 17, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 7, 22) },
                new Result { Runner = MichaelaDavis, Race = race2018, OverallPlace = 18, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 14, 93) },
                new Result { Runner = MariaPorras, Race = race2018, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 16, 26) },
                new Result { Runner = MakaelaSalyer, Race = race2018, OverallPlace = 20, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 17, 80) },
                new Result { Runner = GregHill, Race = race2018, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 21, 58) },
                new Result { Runner = BaileyFreeland, Race = race2018, OverallPlace = 22, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 25, 14) },
                new Result { Runner = JennaOliver, Race = race2018, OverallPlace = 23, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 22, 33, 17) },
                new Result { Runner = CooperHartsel, Race = race2018, OverallPlace = 24, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 22, 50, 24) },
                new Result { Runner = JoeyKurtz, Race = race2018, OverallPlace = 25, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 23, 2, 83) },
                new Result { Runner = NolanFreeland, Race = race2018, OverallPlace = 26, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 10, 73) },
                new Result { Runner = SophiaSpencer, Race = race2018, OverallPlace = 27, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 15, 96) },
                new Result { Runner = DavidHuff, Race = race2018, OverallPlace = 28, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 18, 69) },
                new Result { Runner = TylerPalmer, Race = race2018, OverallPlace = 29, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 23, 39, 95) },
                new Result { Runner = DillonWest, Race = race2018, OverallPlace = 30, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 23, 46, 53) },
                new Result { Runner = PaigeMunchick, Race = race2018, OverallPlace = 31, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 47, 44) },
                new Result { Runner = DaveFreeland, Race = race2018, OverallPlace = 32, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 54, 20) },
                new Result { Runner = KeithJohnston, Race = race2018, OverallPlace = 33, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 57, 91) },
                new Result { Runner = HaroldDravenstott, Race = race2018, OverallPlace = 34, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 24, 0, 38) },
                new Result { Runner = ScottStoner, Race = race2018, OverallPlace = 35, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 24, 5, 40) },
                new Result { Runner = JenniferRidgway, Race = race2018, OverallPlace = 36, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 22, 6) },
                new Result { Runner = BradOliver, Race = race2018, OverallPlace = 37, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 24, 33, 38) },
                new Result { Runner = TJCorbett, Race = race2018, OverallPlace = 38, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 24, 34, 20) },
                new Result { Runner = RaymondMiller, Race = race2018, OverallPlace = 39, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 51, 2) },
                new Result { Runner = AsaGynn, Race = race2018, OverallPlace = 40, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 24, 57, 85) },
                new Result { Runner = WilliamFoster, Race = race2018, OverallPlace = 41, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 3, 57) },
                new Result { Runner = EricThomas, Race = race2018, OverallPlace = 42, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 12, 2) },
                new Result { Runner = LivWells, Race = race2018, OverallPlace = 43, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 25, 18, 80) },
                new Result { Runner = KatieCanfield, Race = race2018, OverallPlace = 44, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 25, 34, 69) },
                new Result { Runner = EmmaHibler, Race = race2018, OverallPlace = 45, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 36, 25) },
                new Result { Runner = ClayGucker, Race = race2018, OverallPlace = 46, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 26, 13, 39) },
                new Result { Runner = AndrewVasel, Race = race2018, OverallPlace = 47, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 26, 15, 8) },
                new Result { Runner = KevinSeager, Race = race2018, OverallPlace = 48, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 26, 18, 81) },
                new Result { Runner = ClaraNeville, Race = race2018, OverallPlace = 49, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 33, 21) },
                new Result { Runner = VanessaMonhemius, Race = race2018, OverallPlace = 50, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 28, 9, 27) },
                new Result { Runner = JohnMonhemius, Race = race2018, OverallPlace = 51, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 28, 9, 84) },
                new Result { Runner = DanielVereb, Race = race2018, OverallPlace = 52, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 28, 23, 66) },
                new Result { Runner = RandiVahl, Race = race2018, OverallPlace = 53, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 28, 29, 4) },
                new Result { Runner = MadelineBohan, Race = race2018, OverallPlace = 54, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 28, 30, 88) },
                new Result { Runner = ShaunVahl, Race = race2018, OverallPlace = 55, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 28, 40, 35) },
                new Result { Runner = SandraFoster, Race = race2018, OverallPlace = 56, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 41, 10) },
                new Result { Runner = MelodySeager, Race = race2018, OverallPlace = 57, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 28, 46, 32) },
                new Result { Runner = JessicaHill, Race = race2018, OverallPlace = 58, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 57, 7) },
                new Result { Runner = BeckyMcAdams, Race = race2018, OverallPlace = 59, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 29, 13, 50) },
                new Result { Runner = JenniferFoster, Race = race2018, OverallPlace = 60, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 16, 2) },
                new Result { Runner = CharlieReed, Race = race2018, OverallPlace = 61, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 29, 17, 36) },
                new Result { Runner = KevinChudzinski, Race = race2018, OverallPlace = 62, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 29, 29, 70) },
                new Result { Runner = RileyEvans, Race = race2018, OverallPlace = 63, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 29, 32, 58) },
                new Result { Runner = MadisonSnyder, Race = race2018, OverallPlace = 64, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 29, 33, 99) },
                new Result { Runner = DebbyKlinect, Race = race2018, OverallPlace = 65, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 53, 62) },
                new Result { Runner = AbigailSparks, Race = race2018, OverallPlace = 66, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 30, 33, 25) },
                new Result { Runner = LydiaFike, Race = race2018, OverallPlace = 67, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 30, 48, 12) },
                new Result { Runner = DavidSears, Race = race2018, OverallPlace = 68, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 30, 52, 90) },
                new Result { Runner = EarlKanzeg, Race = race2018, OverallPlace = 69, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 33, 11, 61) },
                new Result { Runner = ElizabethKanzeg, Race = race2018, OverallPlace = 70, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 33, 40, 72) },
                new Result { Runner = TeresaStrine, Race = race2018, OverallPlace = 71, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 12, 55) },
                new Result { Runner = CassieChance, Race = race2018, OverallPlace = 72, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 38, 17, 90) },
                new Result { Runner = JamesMathatas, Race = race2018, OverallPlace = 73, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 46, 14, 19) },
                new Result { Runner = ChristyMathatas, Race = race2018, OverallPlace = 74, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 46, 15, 16) },
                new Result { Runner = CaitySteiner, Race = race2018, OverallPlace = 75, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 46, 55, 73) },
                new Result { Runner = BrookeGucker, Race = race2018, OverallPlace = 76, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 46, 56, 5) },
                new Result { Runner = HeidiHartzler, Race = race2018, OverallPlace = 77, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 46, 56, 41) },
                new Result { Runner = BrianHartzler, Race = race2018, OverallPlace = 78, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 46, 56, 50) },
                new Result { Runner = BrianKulchar, Race = race2018, OverallPlace = 79, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 52, 48, 19) },
                new Result { Runner = TiffanyKosman, Race = race2018, OverallPlace = 80, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 54, 17, 45) },
                new Result { Runner = ConnieEmerson, Race = race2018, OverallPlace = 81, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 54, 17, 65) },
            };
            
            
            await context.RaceRunners.AddRangeAsync(raceRunners);
            await context.Results.AddRangeAsync(results);
            await context.SaveChangesAsync();
        }
    }
}