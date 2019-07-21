using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using LodiCornFest5k.Models;
using Microsoft.EntityFrameworkCore;

namespace LodiCornFest5k.Data
{
    public static class DbInitializer
    {
        private static readonly string RaceName2014 = "2014 Lodi Cornfest 5K";
        private static readonly string RaceName2015 = "2015 Lodi Cornfest 5K";
        private static readonly string RaceName2016 = "2016 Lodi Cornfest 5K";
        private static readonly string RaceName2017 = "2017 Lodi Cornfest 5K";
        private static readonly string RaceName2018 = "2018 Lodi Cornfest 5K";
        private static readonly string RaceName2019 = "2019 Lodi Cornfest 5K";

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
                new Runner { FirstName = "Noah", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "Sam", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "Luke", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "Murphy", LastName = "Affolder", Gender = Gender.Male},
                new Runner { FirstName = "David", LastName = "Alpine", Gender = Gender.Male},
                new Runner { FirstName = "Joe", LastName = "Armogida", Gender = Gender.Male},
                new Runner { FirstName = "Trevor", LastName = "Armstrong", Gender = Gender.Male},
                new Runner { FirstName = "Andrea", LastName = "Arthur", Gender = Gender.Female},
                new Runner { FirstName = "Lewis", LastName = "Austin", Gender = Gender.Male},
                new Runner { FirstName = "Mike", LastName = "Bangert", Gender = Gender.Male},
                new Runner { FirstName = "Jacob", LastName = "Beadnell", Gender = Gender.Male},
                new Runner { FirstName = "Xander", LastName = "Beltz", Gender = Gender.Male},
                new Runner { FirstName = "Adam", LastName = "Benway", Gender = Gender.Male},
                new Runner { FirstName = "Steven", LastName = "Bett", Gender = Gender.Male},
                new Runner { FirstName = "Molly", LastName = "Biegel", Gender = Gender.Female},
                new Runner { FirstName = "Thomas", LastName = "Bieniosek", Gender = Gender.Male},
                new Runner { FirstName = "Matthew", LastName = "Bildstein", Gender = Gender.Male},
                new Runner { FirstName = "Cameron", LastName = "Billy", Gender = Gender.Male},
                new Runner { FirstName = "Madeline", LastName = "Bohan", Gender = Gender.Female},
                new Runner { FirstName = "Rebecca", LastName = "Boscaljon", Gender = Gender.Female},
                new Runner { FirstName = "Valarie", LastName = "Boscaljon", Gender = Gender.Female},
                new Runner { FirstName = "Kyle", LastName = "Boyd", Gender = Gender.Male},
                new Runner { FirstName = "Matthew", LastName = "Boyd", Gender = Gender.Male},
                new Runner { FirstName = "Chris", LastName = "Boyd", Gender = Gender.Male},
                new Runner { FirstName = "Pamela", LastName = "Boyles", Gender = Gender.Female},
                new Runner { FirstName = "Sam", LastName = "Brandt", Gender = Gender.Male},
                new Runner { FirstName = "Bill", LastName = "Brandt", Gender = Gender.Male},
                new Runner { FirstName = "Megan", LastName = "Brandt", Gender = Gender.Female},
                new Runner { FirstName = "Maddie", LastName = "Brandt", Gender = Gender.Female},
                new Runner { FirstName = "Adam", LastName = "Brantner", Gender = Gender.Male},
                new Runner { FirstName = "Patrick", LastName = "Breean", Gender = Gender.Male},
                new Runner { FirstName = "Randi", LastName = "Breese", Gender = Gender.Female},
                new Runner { FirstName = "Joseph", LastName = "Bruening", Gender = Gender.Male},
                new Runner { FirstName = "Barbara", LastName = "Burton", Gender = Gender.Female},
                new Runner { FirstName = "Blake", LastName = "Butsko", Gender = Gender.Male},
                new Runner { FirstName = "Jim", LastName = "Butsko", Gender = Gender.Male},
                new Runner { FirstName = "Dominic", LastName = "Butsko", Gender = Gender.Male},
                new Runner { FirstName = "Vanessa", LastName = "Butsko", Gender = Gender.Female},
                new Runner { FirstName = "Matt", LastName = "Butt", Gender = Gender.Male},
                new Runner { FirstName = "Katie", LastName = "Canfield", Gender = Gender.Female},
                new Runner { FirstName = "Chris", LastName = "Cannon", Gender = Gender.Male},
                new Runner { FirstName = "Brenda", LastName = "Canterbury", Gender = Gender.Female},
                new Runner { FirstName = "Colton", LastName = "Carpenter", Gender = Gender.Male},
                new Runner { FirstName = "Samuel", LastName = "Carroll", Gender = Gender.Male},
                new Runner { FirstName = "Lori", LastName = "Carroll", Gender = Gender.Female},
                new Runner { FirstName = "Marley", LastName = "Carter", Gender = Gender.Female},
                new Runner { FirstName = "Gia", LastName = "Catalano", Gender = Gender.Female},
                new Runner { FirstName = "Jo", LastName = "Cavallaro", Gender = Gender.Female},
                new Runner { FirstName = "Cassie", LastName = "Chance", Gender = Gender.Female},
                new Runner { FirstName = "Matt", LastName = "Chidsey", Gender = Gender.Male},
                new Runner { FirstName = "Bob", LastName = "Chittenden", Gender = Gender.Male},
                new Runner { FirstName = "Eugene", LastName = "Cho", Gender = Gender.Male},
                new Runner { FirstName = "Kyle", LastName = "Chudzinski", Gender = Gender.Male},
                new Runner { FirstName = "Kevin", LastName = "Chudzinski", Gender = Gender.Male},
                new Runner { FirstName = "Daniel", LastName = "Chudzinski", Gender = Gender.Male},
                new Runner { FirstName = "Allison", LastName = "Chudzinski", Gender = Gender.Female},
                new Runner { FirstName = "Darin", LastName = "Clapp", Gender = Gender.Male},
                new Runner { FirstName = "Maria", LastName = "Clapp", Gender = Gender.Female},
                new Runner { FirstName = "Lucas", LastName = "Clark", Gender = Gender.Male},
                new Runner { FirstName = "Jackson", LastName = "Cleland", Gender = Gender.Male},
                new Runner { FirstName = "Ladd", LastName = "Clifford", Gender = Gender.Male},
                new Runner { FirstName = "Kaitlyn", LastName = "Clifford", Gender = Gender.Female},
                new Runner { FirstName = "TJ", LastName = "Corbett", Gender = Gender.Male},
                new Runner { FirstName = "Maureen", LastName = "Cottrell", Gender = Gender.Female},
                new Runner { FirstName = "Jeremy", LastName = "Cottrell", Gender = Gender.Male},
                new Runner { FirstName = "Tom", LastName = "Curran", Gender = Gender.Male},
                new Runner { FirstName = "Kelsey", LastName = "Dake", Gender = Gender.Female},
                new Runner { FirstName = "Andy", LastName = "Davis", Gender = Gender.Male},
                new Runner { FirstName = "Michaela", LastName = "Davis", Gender = Gender.Female},
                new Runner { FirstName = "Alex", LastName = "Derhammer", Gender = Gender.Male},
                new Runner { FirstName = "Rachel", LastName = "Deryck", Gender = Gender.Female},
                new Runner { FirstName = "Brett", LastName = "Deyling", Gender = Gender.Male},
                new Runner { FirstName = "Amy", LastName = "Donnelly", Gender = Gender.Female},
                new Runner { FirstName = "Patrick", LastName = "Donnelly", Gender = Gender.Male},
                new Runner { FirstName = "Aiden", LastName = "Donohue", Gender = Gender.Male},
                new Runner { FirstName = "Christopher", LastName = "Dostal", Gender = Gender.Male},
                new Runner { FirstName = "Harold", LastName = "Dravenstott", Gender = Gender.Male},
                new Runner { FirstName = "Zach", LastName = "Dreher", Gender = Gender.Male},
                new Runner { FirstName = "Mandy", LastName = "Ebert", Gender = Gender.Female},
                new Runner { FirstName = "Dan", LastName = "Eckert", Gender = Gender.Male},
                new Runner { FirstName = "Darren", LastName = "Egner", Gender = Gender.Male},
                new Runner { FirstName = "Abbie", LastName = "Eichel", Gender = Gender.Female},
                new Runner { FirstName = "Connie", LastName = "Emerson", Gender = Gender.Female},
                new Runner { FirstName = "Chuck", LastName = "Engle", Gender = Gender.Male},
                new Runner { FirstName = "Zane", LastName = "Evans", Gender = Gender.Male},
                new Runner { FirstName = "Riley", LastName = "Evans", Gender = Gender.Female},
                new Runner { FirstName = "Meghan", LastName = "Fiala", Gender = Gender.Female},
                new Runner { FirstName = "Lydia", LastName = "Fike", Gender = Gender.Female},
                new Runner { FirstName = "Jessica", LastName = "Flynn", Gender = Gender.Female},
                new Runner { FirstName = "Ethan", LastName = "Flynn", Gender = Gender.Male},
                new Runner { FirstName = "Graydon", LastName = "Flynn", Gender = Gender.Male},
                new Runner { FirstName = "Zack", LastName = "Flynn", Gender = Gender.Male},
                new Runner { FirstName = "Delainey", LastName = "Flynn", Gender = Gender.Female},
                new Runner { FirstName = "Elyse", LastName = "Flynn", Gender = Gender.Female},
                new Runner { FirstName = "Maxie", LastName = "Flynn", Gender = Gender.Female},
                new Runner { FirstName = "Reagan", LastName = "Flynn", Gender = Gender.Female},
                new Runner { FirstName = "Anton", LastName = "Foreit", Gender = Gender.Male},
                new Runner { FirstName = "Colleen", LastName = "Foreit", Gender = Gender.Female},
                new Runner { FirstName = "William", LastName = "Foster", Gender = Gender.Male},
                new Runner { FirstName = "Sandra", LastName = "Foster", Gender = Gender.Female},
                new Runner { FirstName = "Jennifer", LastName = "Foster", Gender = Gender.Female},
                new Runner { FirstName = "Stephanie", LastName = "Foster", Gender = Gender.Female},
                new Runner { FirstName = "Lauren", LastName = "Frank", Gender = Gender.Female},
                new Runner { FirstName = "Riley", LastName = "Freeland", Gender = Gender.Female},
                new Runner { FirstName = "Bailey", LastName = "Freeland", Gender = Gender.Female},
                new Runner { FirstName = "Nolan", LastName = "Freeland", Gender = Gender.Male},
                new Runner { FirstName = "Dave", LastName = "Freeland", Gender = Gender.Male},
                new Runner { FirstName = "Matthew", LastName = "Gerhart", Gender = Gender.Male},
                new Runner { FirstName = "Kelly", LastName = "Giles", Gender = Gender.Female},
                new Runner { FirstName = "Dan", LastName = "Grabowski", Gender = Gender.Male},
                new Runner { FirstName = "Maddie", LastName = "Grey", Gender = Gender.Female},
                new Runner { FirstName = "Ethan", LastName = "Gruber", Gender = Gender.Male},
                new Runner { FirstName = "Emily", LastName = "Gruber", Gender = Gender.Female},
                new Runner { FirstName = "Max", LastName = "Gucker", Gender = Gender.Male},
                new Runner { FirstName = "Brett", LastName = "Gucker", Gender = Gender.Male},
                new Runner { FirstName = "Clay", LastName = "Gucker", Gender = Gender.Male},
                new Runner { FirstName = "Brooke", LastName = "Gucker", Gender = Gender.Female},
                new Runner { FirstName = "Sheila", LastName = "Gucker", Gender = Gender.Female},
                new Runner { FirstName = "Ryan", LastName = "Gutschow", Gender = Gender.Male},
                new Runner { FirstName = "Kaylee", LastName = "Gutschow", Gender = Gender.Female},
                new Runner { FirstName = "Susan", LastName = "Gutschow", Gender = Gender.Female},
                new Runner { FirstName = "Asa", LastName = "Gynn", Gender = Gender.Male},
                new Runner { FirstName = "Cooper", LastName = "Hartsel", Gender = Gender.Male},
                new Runner { FirstName = "Carrie", LastName = "Hartsel", Gender = Gender.Female},
                new Runner { FirstName = "Heidi", LastName = "Hartzler", Gender = Gender.Female},
                new Runner { FirstName = "Brian", LastName = "Hartzler", Gender = Gender.Male},
                new Runner { FirstName = "Edward", LastName = "Hawkins", Gender = Gender.Male},
                new Runner { FirstName = "Elijah", LastName = "Haynes", Gender = Gender.Male},
                new Runner { FirstName = "Roy", LastName = "Heger", Gender = Gender.Male},
                new Runner { FirstName = "Jeff", LastName = "Heilman", Gender = Gender.Male},
                new Runner { FirstName = "Vladimir", LastName = "Herdman", Gender = Gender.Male},
                new Runner { FirstName = "Mike", LastName = "Hewit", Gender = Gender.Male},
                new Runner { FirstName = "Andrew", LastName = "Hibler", Gender = Gender.Male},
                new Runner { FirstName = "Emma", LastName = "Hibler", Gender = Gender.Female},
                new Runner { FirstName = "Greg", LastName = "Hill", Gender = Gender.Male},
                new Runner { FirstName = "Jessica", LastName = "Hill", Gender = Gender.Female},
                new Runner { FirstName = "Deborah", LastName = "Hissong", Gender = Gender.Female},
                new Runner { FirstName = "Andrea", LastName = "Hoff", Gender = Gender.Female},
                new Runner { FirstName = "Caleb", LastName = "Hostetler", Gender = Gender.Male},
                new Runner { FirstName = "Ben", LastName = "House", Gender = Gender.Male},
                new Runner { FirstName = "Don", LastName = "House", Gender = Gender.Male},
                new Runner { FirstName = "David", LastName = "Huff", Gender = Gender.Male},
                new Runner { FirstName = "Jeral", LastName = "Imhoff", Gender = Gender.Male},
                new Runner { FirstName = "Dakota", LastName = "Jacobson", Gender = Gender.Male},
                new Runner { FirstName = "Andrew", LastName = "Jarrett", Gender = Gender.Male},
                new Runner { FirstName = "Chris", LastName = "Jarrett", Gender = Gender.Male},
                new Runner { FirstName = "Jeff", LastName = "Jarrett", Gender = Gender.Male},
                new Runner { FirstName = "Hayden", LastName = "Jarvis", Gender = Gender.Male},
                new Runner { FirstName = "Mollie", LastName = "Jarvis", Gender = Gender.Female},
                new Runner { FirstName = "Timothy", LastName = "Jensch", Gender = Gender.Male},
                new Runner { FirstName = "Adriana", LastName = "Jeziorski", Gender = Gender.Female},
                new Runner { FirstName = "James", LastName = "Johnson", Gender = Gender.Male},
                new Runner { FirstName = "Zach", LastName = "Johnston", Gender = Gender.Male},
                new Runner { FirstName = "Keith", LastName = "Johnston", Gender = Gender.Male},
                new Runner { FirstName = "Jannelle", LastName = "Jordan", Gender = Gender.Female},
                new Runner { FirstName = "McKenna", LastName = "Jordan", Gender = Gender.Female},
                new Runner { FirstName = "Tony", LastName = "Kall", Gender = Gender.Male},
                new Runner { FirstName = "Earl", LastName = "Kanzeg", Gender = Gender.Male},
                new Runner { FirstName = "Elizabeth", LastName = "Kanzeg", Gender = Gender.Female},
                new Runner { FirstName = "Kris", LastName = "Kapchak", Gender = Gender.Male},
                new Runner { FirstName = "Debby", LastName = "Klinect", Gender = Gender.Female},
                new Runner { FirstName = "Megan", LastName = "Knapp", Gender = Gender.Female},
                new Runner { FirstName = "Tracey", LastName = "Kochenderfer", Gender = Gender.Female},
                new Runner { FirstName = "Kris", LastName = "Kopchak", Gender = Gender.Male},
                new Runner { FirstName = "Tiffany", LastName = "Kosman", Gender = Gender.Female},
                new Runner { FirstName = "Benjamin", LastName = "Kruggel", Gender = Gender.Male},
                new Runner { FirstName = "McKenna", LastName = "Kulas", Gender = Gender.Female},
                new Runner { FirstName = "Brian", LastName = "Kulchar", Gender = Gender.Male},
                new Runner { FirstName = "Joey", LastName = "Kurtz", Gender = Gender.Male},
                new Runner { FirstName = "Tommie", LastName = "Kurtz", Gender = Gender.Female},
                new Runner { FirstName = "Noah", LastName = "Lake", Gender = Gender.Male},
                new Runner { FirstName = "Cliff", LastName = "Lear", Gender = Gender.Male},
                new Runner { FirstName = "Amber", LastName = "LeClair", Gender = Gender.Female},
                new Runner { FirstName = "Windy", LastName = "Lewis", Gender = Gender.Female},
                new Runner { FirstName = "Wilson", LastName = "Lewis", Gender = Gender.Male},
                new Runner { FirstName = "Zoe", LastName = "Looney", Gender = Gender.Female},
                new Runner { FirstName = "Luke", LastName = "Malena", Gender = Gender.Male},
                new Runner { FirstName = "Shannon", LastName = "Malikowski", Gender = Gender.Female},
                new Runner { FirstName = "Cameron", LastName = "Markeson", Gender = Gender.Male},
                new Runner { FirstName = "Logan", LastName = "Markle", Gender = Gender.Male},
                new Runner { FirstName = "Michael", LastName = "Martin", Gender = Gender.Male},
                new Runner { FirstName = "Kevin", LastName = "Martin", Gender = Gender.Male},
                new Runner { FirstName = "Karen", LastName = "Martin", Gender = Gender.Female},
                new Runner { FirstName = "Sherry", LastName = "Martin", Gender = Gender.Female},
                new Runner { FirstName = "Erin", LastName = "Mason", Gender = Gender.Female},
                new Runner { FirstName = "James", LastName = "Mathatas", Gender = Gender.Male},
                new Runner { FirstName = "Christy", LastName = "Mathatas", Gender = Gender.Female},
                new Runner { FirstName = "Macy", LastName = "McAdams", Gender = Gender.Female},
                new Runner { FirstName = "Becky", LastName = "McAdams", Gender = Gender.Female},
                new Runner { FirstName = "Brynne", LastName = "McAllister", Gender = Gender.Female},
                new Runner { FirstName = "Ryan", LastName = "McAllister", Gender = Gender.Male},
                new Runner { FirstName = "Jennifer", LastName = "McCuen", Gender = Gender.Female},
                new Runner { FirstName = "Devin", LastName = "Mcintosh", Gender = Gender.Male},
                new Runner { FirstName = "Patrick", LastName = "McKeown", Gender = Gender.Male},
                new Runner { FirstName = "Cindy", LastName = "Mcquown", Gender = Gender.Female},
                new Runner { FirstName = "Mike", LastName = "Means", Gender = Gender.Male},
                new Runner { FirstName = "Benjamin", LastName = "Melkey", Gender = Gender.Male},
                new Runner { FirstName = "Jennifer", LastName = "Meyers", Gender = Gender.Female},
                new Runner { FirstName = "Eric", LastName = "Middleton", Gender = Gender.Male},
                new Runner { FirstName = "Raymond", LastName = "Miller", Gender = Gender.Male},
                new Runner { FirstName = "Rob", LastName = "Miller", Gender = Gender.Male},
                new Runner { FirstName = "Madelyn", LastName = "Miller", Gender = Gender.Female},
                new Runner { FirstName = "Aaron", LastName = "Mohr", Gender = Gender.Male},
                new Runner { FirstName = "Vanessa", LastName = "Monhemius", Gender = Gender.Female},
                new Runner { FirstName = "John", LastName = "Monhemius", Gender = Gender.Male},
                new Runner { FirstName = "Giovanna", LastName = "Moroschan", Gender = Gender.Male},
                new Runner { FirstName = "Kayla", LastName = "Moroschan", Gender = Gender.Female},
                new Runner { FirstName = "Sommer", LastName = "Mueller", Gender = Gender.Female},
                new Runner { FirstName = "Paige", LastName = "Munchick", Gender = Gender.Female},
                new Runner { FirstName = "Rachel", LastName = "Murphy", Gender = Gender.Female},
                new Runner { FirstName = "Jonah", LastName = "Murphy", Gender = Gender.Male},
                new Runner { FirstName = "Scott", LastName = "Murphy", Gender = Gender.Male},
                new Runner { FirstName = "Donna", LastName = "Murphy", Gender = Gender.Female},
                new Runner { FirstName = "Blake", LastName = "Musick", Gender = Gender.Male},
                new Runner { FirstName = "Jen", LastName = "Myers", Gender = Gender.Female},
                new Runner { FirstName = "Sarah", LastName = "Naftzger", Gender = Gender.Female},
                new Runner { FirstName = "Dan", LastName = "Naftzger", Gender = Gender.Female},
                new Runner { FirstName = "Emma", LastName = "Nagel", Gender = Gender.Female},
                new Runner { FirstName = "Ben", LastName = "Nagy", Gender = Gender.Male},
                new Runner { FirstName = "Carson", LastName = "Nagy", Gender = Gender.Male},
                new Runner { FirstName = "Kristen", LastName = "Napholz", Gender = Gender.Female},
                new Runner { FirstName = "Noah", LastName = "Navratil", Gender = Gender.Male},
                new Runner { FirstName = "Clara", LastName = "Neville", Gender = Gender.Female},
                new Runner { FirstName = "Caleb", LastName = "Neville", Gender = Gender.Male},
                new Runner { FirstName = "Ryan", LastName = "O'Callaghan", Gender = Gender.Male},
                new Runner { FirstName = "Jenna", LastName = "Oliver", Gender = Gender.Female},
                new Runner { FirstName = "Brad", LastName = "Oliver", Gender = Gender.Male},
                new Runner { FirstName = "Tony", LastName = "Oliverio", Gender = Gender.Male},
                new Runner { FirstName = "Carrie", LastName = "Olson", Gender = Gender.Female},
                new Runner { FirstName = "Estevan", LastName = "Ortega", Gender = Gender.Male},
                new Runner { FirstName = "Tyler", LastName = "Palmer", Gender = Gender.Male},
                new Runner { FirstName = "Licia", LastName = "Pappas", Gender = Gender.Female},
                new Runner { FirstName = "Zech", LastName = "Paul", Gender = Gender.Male},
                new Runner { FirstName = "Matthew", LastName = "Pettry", Gender = Gender.Male},
                new Runner { FirstName = "Jim", LastName = "Plikerd", Gender = Gender.Male},
                new Runner { FirstName = "Connor", LastName = "Ploucha", Gender = Gender.Male},
                new Runner { FirstName = "Tristan", LastName = "Ponting", Gender = Gender.Male},
                new Runner { FirstName = "Maria", LastName = "Porras", Gender = Gender.Female},
                new Runner { FirstName = "Victoria", LastName = "Porter", Gender = Gender.Female},
                new Runner { FirstName = "Danny", LastName = "Price", Gender = Gender.Male},
                new Runner { FirstName = "Kristina", LastName = "Quick", Gender = Gender.Female},
                new Runner { FirstName = "Charlie", LastName = "Reed", Gender = Gender.Male},
                new Runner { FirstName = "Jack", LastName = "Reed", Gender = Gender.Male},
                new Runner { FirstName = "Emma", LastName = "Reed", Gender = Gender.Female},
                new Runner { FirstName = "Lisa", LastName = "Reinhart", Gender = Gender.Female},
                new Runner { FirstName = "Kelly", LastName = "Rennels", Gender = Gender.Male},
                new Runner { FirstName = "Jennifer", LastName = "Ridgway", Gender = Gender.Female},
                new Runner { FirstName = "Joshua", LastName = "Rittgers", Gender = Gender.Male},
                new Runner { FirstName = "David", LastName = "Rittgers", Gender = Gender.Male},
                new Runner { FirstName = "Daniel", LastName = "Rittgers", Gender = Gender.Male},
                new Runner { FirstName = "Vanessa", LastName = "Rivera", Gender = Gender.Female},
                new Runner { FirstName = "Ridge", LastName = "Robinson", Gender = Gender.Male},
                new Runner { FirstName = "Eileen", LastName = "Robison", Gender = Gender.Female},
                new Runner { FirstName = "Makaela", LastName = "Salyer", Gender = Gender.Female},
                new Runner { FirstName = "Robert", LastName = "Sayer", Gender = Gender.Male},
                new Runner { FirstName = "Russell", LastName = "Schultz", Gender = Gender.Male},
                new Runner { FirstName = "Caleb", LastName = "Seagar", Gender = Gender.Male},
                new Runner { FirstName = "Liana", LastName = "Seagar", Gender = Gender.Female},
                new Runner { FirstName = "Kevin", LastName = "Seager", Gender = Gender.Male},
                new Runner { FirstName = "Melody", LastName = "Seager", Gender = Gender.Female},
                new Runner { FirstName = "David", LastName = "Sears", Gender = Gender.Male},
                new Runner { FirstName = "Will", LastName = "Sicking", Gender = Gender.Male},
                new Runner { FirstName = "Garrett", LastName = "Silva", Gender = Gender.Male},
                new Runner { FirstName = "Mariya", LastName = "Silva", Gender = Gender.Female},
                new Runner { FirstName = "Madison", LastName = "Snyder", Gender = Gender.Female},
                new Runner { FirstName = "Gary", LastName = "Snyder", Gender = Gender.Male},
                new Runner { FirstName = "Abigail", LastName = "Sparks", Gender = Gender.Female},
                new Runner { FirstName = "Holly", LastName = "Spears", Gender = Gender.Female},
                new Runner { FirstName = "Sophia", LastName = "Spencer", Gender = Gender.Female},
                new Runner { FirstName = "Donald", LastName = "Spencer", Gender = Gender.Male},
                new Runner { FirstName = "Hunter", LastName = "Stallings", Gender = Gender.Male},
                new Runner { FirstName = "Melanie", LastName = "Stallings", Gender = Gender.Female},
                new Runner { FirstName = "Liz", LastName = "Stanley", Gender = Gender.Female},
                new Runner { FirstName = "Talena", LastName = "Starr", Gender = Gender.Female},
                new Runner { FirstName = "Jesse", LastName = "Stathes", Gender = Gender.Male},
                new Runner { FirstName = "Katelan", LastName = "Stathes", Gender = Gender.Female},
                new Runner { FirstName = "Caleigh", LastName = "Stefanko", Gender = Gender.Female},
                new Runner { FirstName = "Theresa", LastName = "Stefanko", Gender = Gender.Female},
                new Runner { FirstName = "Caity", LastName = "Steiner", Gender = Gender.Female},
                new Runner { FirstName = "Andrew", LastName = "Stephens", Gender = Gender.Male},
                new Runner { FirstName = "Scott", LastName = "Stoner", Gender = Gender.Male},
                new Runner { FirstName = "Carrie", LastName = "Stoner", Gender = Gender.Female},
                new Runner { FirstName = "Alyssa", LastName = "Stoner", Gender = Gender.Female},
                new Runner { FirstName = "Teresa", LastName = "Strine", Gender = Gender.Female},
                new Runner { FirstName = "Stacy", LastName = "Stuchal", Gender = Gender.Female},
                new Runner { FirstName = "Matthew", LastName = "Study", Gender = Gender.Male},
                new Runner { FirstName = "Aaron", LastName = "Surrarrer", Gender = Gender.Male},
                new Runner { FirstName = "Ian", LastName = "Swain", Gender = Gender.Male},
                new Runner { FirstName = "Hannah", LastName = "Swain", Gender = Gender.Female},
                new Runner { FirstName = "Adam", LastName = "Swiat", Gender = Gender.Male},
                new Runner { FirstName = "Philip", LastName = "Syverson", Gender = Gender.Male},
                new Runner { FirstName = "Greg", LastName = "Szklarz", Gender = Gender.Male},
                new Runner { FirstName = "Jack", LastName = "Szklarz", Gender = Gender.Male},
                new Runner { FirstName = "Brock", LastName = "Tegtmeier", Gender = Gender.Male},
                new Runner { FirstName = "Kade", LastName = "Tegtmeier", Gender = Gender.Male},
                new Runner { FirstName = "Heather", LastName = "Tegtmeier", Gender = Gender.Female},
                new Runner { FirstName = "Randy", LastName = "Tegtmeier", Gender = Gender.Male},
                new Runner { FirstName = "Faith", LastName = "Theobald", Gender = Gender.Female},
                new Runner { FirstName = "Eric", LastName = "Thomas", Gender = Gender.Male},
                new Runner { FirstName = "Ken", LastName = "Turocy", Gender = Gender.Male},
                new Runner { FirstName = "Wendy", LastName = "Turocy", Gender = Gender.Female},
                new Runner { FirstName = "Jim", LastName = "Tuttle", Gender = Gender.Male},
                new Runner { FirstName = "Randi", LastName = "Vahl", Gender = Gender.Female},
                new Runner { FirstName = "Shaun", LastName = "Vahl", Gender = Gender.Male},
                new Runner { FirstName = "Andrew", LastName = "Vasel", Gender = Gender.Male},
                new Runner { FirstName = "Tristan", LastName = "Vaughan", Gender = Gender.Male},
                new Runner { FirstName = "Daniel", LastName = "Vereb", Gender = Gender.Male},
                new Runner { FirstName = "Chuck", LastName = "Walter", Gender = Gender.Male},
                new Runner { FirstName = "Adam", LastName = "Wanter", Gender = Gender.Male},
                new Runner { FirstName = "Liv", LastName = "Wells", Gender = Gender.Female},
                new Runner { FirstName = "Dillon", LastName = "West", Gender = Gender.Male},
                new Runner { FirstName = "Drew", LastName = "West", Gender = Gender.Male},
                new Runner { FirstName = "Anna", LastName = "West", Gender = Gender.Female},
                new Runner { FirstName = "Tim", LastName = "White", Gender = Gender.Male},
                new Runner { FirstName = "Blake", LastName = "Wilson", Gender = Gender.Male},
                new Runner { FirstName = "Kayla", LastName = "Wilson", Gender = Gender.Female},
                new Runner { FirstName = "Keith", LastName = "Winkler", Gender = Gender.Male},
                new Runner { FirstName = "Anna", LastName = "Winnicki", Gender = Gender.Female},
                new Runner { FirstName = "Amy", LastName = "Winnicki", Gender = Gender.Female},
                new Runner { FirstName = "Brad", LastName = "Woodland", Gender = Gender.Male},
                new Runner { FirstName = "Cole", LastName = "Yagersz", Gender = Gender.Male},
                new Runner { FirstName = "Michelle", LastName = "Yoder", Gender = Gender.Female},
                new Runner { FirstName = "Braden", LastName = "Young", Gender = Gender.Male},
                new Runner { FirstName = "Nick", LastName = "Yount", Gender = Gender.Male},
                new Runner { FirstName = "Nick", LastName = "Ziegler", Gender = Gender.Male}
            };

            var races = new ConcurrentBag<Race>
            {
                new Race {Name = RaceName2014, Date = new DateTime(2014, 7, 19)},
                new Race {Name = RaceName2015, Date = new DateTime(2015, 7, 25)},
                new Race {Name = RaceName2016, Date = new DateTime(2016, 7, 23)},
                new Race {Name = RaceName2017, Date = new DateTime(2017, 7, 22)},
                new Race {Name = RaceName2018, Date = new DateTime(2018, 7, 21)},
                new Race {Name = RaceName2019, Date = new DateTime(2019, 7, 20)}
            };

            await context.Runners.AddRangeAsync(runners);
            await context.Races.AddRangeAsync(races);
            await context.SaveChangesAsync();

            #region Runners

            var NoahAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Noah" && x.LastName == "Affolder");
            var SamAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Sam" && x.LastName == "Affolder");
            var LukeAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Luke" && x.LastName == "Affolder");
            var MurphyAffolder = await context.Runners.SingleAsync(x => x.FirstName == "Murphy" && x.LastName == "Affolder");
            var DavidAlpine = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Alpine");
            var JoeArmogida = await context.Runners.SingleAsync(x => x.FirstName == "Joe" && x.LastName == "Armogida");
            var TrevorArmstrong = await context.Runners.SingleAsync(x => x.FirstName == "Trevor" && x.LastName == "Armstrong");
            var AndreaArthur = await context.Runners.SingleAsync(x => x.FirstName == "Andrea" && x.LastName == "Arthur");
            var LewisAustin = await context.Runners.SingleAsync(x => x.FirstName == "Lewis" && x.LastName == "Austin");
            var MikeBangert = await context.Runners.SingleAsync(x => x.FirstName == "Mike" && x.LastName == "Bangert");
            var JacobBeadnell = await context.Runners.SingleAsync(x => x.FirstName == "Jacob" && x.LastName == "Beadnell");
            var XanderBeltz = await context.Runners.SingleAsync(x => x.FirstName == "Xander" && x.LastName == "Beltz");
            var AdamBenway = await context.Runners.SingleAsync(x => x.FirstName == "Adam" && x.LastName == "Benway");
            var StevenBett = await context.Runners.SingleAsync(x => x.FirstName == "Steven" && x.LastName == "Bett");
            var MollyBiegel = await context.Runners.SingleAsync(x => x.FirstName == "Molly" && x.LastName == "Biegel");
            var ThomasBieniosek = await context.Runners.SingleAsync(x => x.FirstName == "Thomas" && x.LastName == "Bieniosek");
            var MatthewBildstein = await context.Runners.SingleAsync(x => x.FirstName == "Matthew" && x.LastName == "Bildstein");
            var CameronBilly = await context.Runners.SingleAsync(x => x.FirstName == "Cameron" && x.LastName == "Billy");
            var MadelineBohan = await context.Runners.SingleAsync(x => x.FirstName == "Madeline" && x.LastName == "Bohan");
            var RebeccaBoscaljon = await context.Runners.SingleAsync(x => x.FirstName == "Rebecca" && x.LastName == "Boscaljon");
            var ValarieBoscaljon = await context.Runners.SingleAsync(x => x.FirstName == "Valarie" && x.LastName == "Boscaljon");
            var KyleBoyd = await context.Runners.SingleAsync(x => x.FirstName == "Kyle" && x.LastName == "Boyd");
            var MatthewBoyd = await context.Runners.SingleAsync(x => x.FirstName == "Matthew" && x.LastName == "Boyd");
            var ChrisBoyd = await context.Runners.SingleAsync(x => x.FirstName == "Chris" && x.LastName == "Boyd");
            var PamelaBoyles = await context.Runners.SingleAsync(x => x.FirstName == "Pamela" && x.LastName == "Boyles");
            var SamBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Sam" && x.LastName == "Brandt");
            var BillBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Bill" && x.LastName == "Brandt");
            var MeganBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Megan" && x.LastName == "Brandt");
            var MaddieBrandt = await context.Runners.SingleAsync(x => x.FirstName == "Maddie" && x.LastName == "Brandt");
            var AdamBrantner = await context.Runners.SingleAsync(x => x.FirstName == "Adam" && x.LastName == "Brantner");
            var PatrickBreean = await context.Runners.SingleAsync(x => x.FirstName == "Patrick" && x.LastName == "Breean");
            var RandiBreese = await context.Runners.SingleAsync(x => x.FirstName == "Randi" && x.LastName == "Breese");
            var JosephBruening = await context.Runners.SingleAsync(x => x.FirstName == "Joseph" && x.LastName == "Bruening");
            var BarbaraBurton = await context.Runners.SingleAsync(x => x.FirstName == "Barbara" && x.LastName == "Burton");
            var BlakeButsko = await context.Runners.SingleAsync(x => x.FirstName == "Blake" && x.LastName == "Butsko");
            var JimButsko = await context.Runners.SingleAsync(x => x.FirstName == "Jim" && x.LastName == "Butsko");
            var DominicButsko = await context.Runners.SingleAsync(x => x.FirstName == "Dominic" && x.LastName == "Butsko");
            var VanessaButsko = await context.Runners.SingleAsync(x => x.FirstName == "Vanessa" && x.LastName == "Butsko");
            var MattButt = await context.Runners.SingleAsync(x => x.FirstName == "Matt" && x.LastName == "Butt");
            var KatieCanfield = await context.Runners.SingleAsync(x => x.FirstName == "Katie" && x.LastName == "Canfield");
            var ChrisCannon = await context.Runners.SingleAsync(x => x.FirstName == "Chris" && x.LastName == "Cannon");
            var BrendaCanterbury = await context.Runners.SingleAsync(x => x.FirstName == "Brenda" && x.LastName == "Canterbury");
            var ColtonCarpenter = await context.Runners.SingleAsync(x => x.FirstName == "Colton" && x.LastName == "Carpenter");
            var SamuelCarroll = await context.Runners.SingleAsync(x => x.FirstName == "Samuel" && x.LastName == "Carroll");
            var LoriCarroll = await context.Runners.SingleAsync(x => x.FirstName == "Lori" && x.LastName == "Carroll");
            var MarleyCarter = await context.Runners.SingleAsync(x => x.FirstName == "Marley" && x.LastName == "Carter");
            var GiaCatalano = await context.Runners.SingleAsync(x => x.FirstName == "Gia" && x.LastName == "Catalano");
            var JoCavallaro = await context.Runners.SingleAsync(x => x.FirstName == "Jo" && x.LastName == "Cavallaro");
            var CassieChance = await context.Runners.SingleAsync(x => x.FirstName == "Cassie" && x.LastName == "Chance");
            var MattChidsey = await context.Runners.SingleAsync(x => x.FirstName == "Matt" && x.LastName == "Chidsey");
            var BobChittenden = await context.Runners.SingleAsync(x => x.FirstName == "Bob" && x.LastName == "Chittenden");
            var EugeneCho = await context.Runners.SingleAsync(x => x.FirstName == "Eugene" && x.LastName == "Cho");
            var KyleChudzinski = await context.Runners.SingleAsync(x => x.FirstName == "Kyle" && x.LastName == "Chudzinski");
            var KevinChudzinski = await context.Runners.SingleAsync(x => x.FirstName == "Kevin" && x.LastName == "Chudzinski");
            var DanielChudzinski = await context.Runners.SingleAsync(x => x.FirstName == "Daniel" && x.LastName == "Chudzinski");
            var AllisonChudzinski = await context.Runners.SingleAsync(x => x.FirstName == "Allison" && x.LastName == "Chudzinski");
            var DarinClapp = await context.Runners.SingleAsync(x => x.FirstName == "Darin" && x.LastName == "Clapp");
            var MariaClapp = await context.Runners.SingleAsync(x => x.FirstName == "Maria" && x.LastName == "Clapp");
            var LucasClark = await context.Runners.SingleAsync(x => x.FirstName == "Lucas" && x.LastName == "Clark");
            var JacksonCleland = await context.Runners.SingleAsync(x => x.FirstName == "Jackson" && x.LastName == "Cleland");
            var LaddClifford = await context.Runners.SingleAsync(x => x.FirstName == "Ladd" && x.LastName == "Clifford");
            var KaitlynClifford = await context.Runners.SingleAsync(x => x.FirstName == "Kaitlyn" && x.LastName == "Clifford");
            var TJCorbett = await context.Runners.SingleAsync(x => x.FirstName == "TJ" && x.LastName == "Corbett");
            var MaureenCottrell = await context.Runners.SingleAsync(x => x.FirstName == "Maureen" && x.LastName == "Cottrell");
            var JeremyCottrell = await context.Runners.SingleAsync(x => x.FirstName == "Jeremy" && x.LastName == "Cottrell");
            var TomCurran = await context.Runners.SingleAsync(x => x.FirstName == "Tom" && x.LastName == "Curran");
            var KelseyDake = await context.Runners.SingleAsync(x => x.FirstName == "Kelsey" && x.LastName == "Dake");
            var AndyDavis = await context.Runners.SingleAsync(x => x.FirstName == "Andy" && x.LastName == "Davis");
            var MichaelaDavis = await context.Runners.SingleAsync(x => x.FirstName == "Michaela" && x.LastName == "Davis");
            var AlexDerhammer = await context.Runners.SingleAsync(x => x.FirstName == "Alex" && x.LastName == "Derhammer");
            var RachelDeryck = await context.Runners.SingleAsync(x => x.FirstName == "Rachel" && x.LastName == "Deryck");
            var BrettDeyling = await context.Runners.SingleAsync(x => x.FirstName == "Brett" && x.LastName == "Deyling");
            var AmyDonnelly = await context.Runners.SingleAsync(x => x.FirstName == "Amy" && x.LastName == "Donnelly");
            var PatrickDonnelly = await context.Runners.SingleAsync(x => x.FirstName == "Patrick" && x.LastName == "Donnelly");
            var AidenDonohue = await context.Runners.SingleAsync(x => x.FirstName == "Aiden" && x.LastName == "Donohue");
            var ChristopherDostal = await context.Runners.SingleAsync(x => x.FirstName == "Christopher" && x.LastName == "Dostal");
            var HaroldDravenstott = await context.Runners.SingleAsync(x => x.FirstName == "Harold" && x.LastName == "Dravenstott");
            var ZachDreher = await context.Runners.SingleAsync(x => x.FirstName == "Zach" && x.LastName == "Dreher");
            var MandyEbert = await context.Runners.SingleAsync(x => x.FirstName == "Mandy" && x.LastName == "Ebert");
            var DanEckert = await context.Runners.SingleAsync(x => x.FirstName == "Dan" && x.LastName == "Eckert");
            var DarrenEgner = await context.Runners.SingleAsync(x => x.FirstName == "Darren" && x.LastName == "Egner");
            var AbbieEichel = await context.Runners.SingleAsync(x => x.FirstName == "Abbie" && x.LastName == "Eichel");
            var ConnieEmerson = await context.Runners.SingleAsync(x => x.FirstName == "Connie" && x.LastName == "Emerson");
            var ChuckEngle = await context.Runners.SingleAsync(x => x.FirstName == "Chuck" && x.LastName == "Engle");
            var ZaneEvans = await context.Runners.SingleAsync(x => x.FirstName == "Zane" && x.LastName == "Evans");
            var RileyEvans = await context.Runners.SingleAsync(x => x.FirstName == "Riley" && x.LastName == "Evans");
            var MeghanFiala = await context.Runners.SingleAsync(x => x.FirstName == "Meghan" && x.LastName == "Fiala");
            var LydiaFike = await context.Runners.SingleAsync(x => x.FirstName == "Lydia" && x.LastName == "Fike");
            var JessicaFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Jessica" && x.LastName == "Flynn");
            var EthanFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Ethan" && x.LastName == "Flynn");
            var GraydonFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Graydon" && x.LastName == "Flynn");
            var ZackFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Zack" && x.LastName == "Flynn");
            var DelaineyFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Delainey" && x.LastName == "Flynn");
            var ElyseFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Elyse" && x.LastName == "Flynn");
            var MaxieFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Maxie" && x.LastName == "Flynn");
            var ReaganFlynn = await context.Runners.SingleAsync(x => x.FirstName == "Reagan" && x.LastName == "Flynn");
            var AntonForeit = await context.Runners.SingleAsync(x => x.FirstName == "Anton" && x.LastName == "Foreit");
            var ColleenForeit = await context.Runners.SingleAsync(x => x.FirstName == "Colleen" && x.LastName == "Foreit");
            var WilliamFoster = await context.Runners.SingleAsync(x => x.FirstName == "William" && x.LastName == "Foster");
            var SandraFoster = await context.Runners.SingleAsync(x => x.FirstName == "Sandra" && x.LastName == "Foster");
            var JenniferFoster = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "Foster");
            var StephanieFoster = await context.Runners.SingleAsync(x => x.FirstName == "Stephanie" && x.LastName == "Foster");
            var LaurenFrank = await context.Runners.SingleAsync(x => x.FirstName == "Lauren" && x.LastName == "Frank");
            var RileyFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Riley" && x.LastName == "Freeland");
            var BaileyFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Bailey" && x.LastName == "Freeland");
            var NolanFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Nolan" && x.LastName == "Freeland");
            var DaveFreeland = await context.Runners.SingleAsync(x => x.FirstName == "Dave" && x.LastName == "Freeland");
            var MatthewGerhart = await context.Runners.SingleAsync(x => x.FirstName == "Matthew" && x.LastName == "Gerhart");
            var KellyGiles = await context.Runners.SingleAsync(x => x.FirstName == "Kelly" && x.LastName == "Giles");
            var DanGrabowski = await context.Runners.SingleAsync(x => x.FirstName == "Dan" && x.LastName == "Grabowski");
            var MaddieGrey = await context.Runners.SingleAsync(x => x.FirstName == "Maddie" && x.LastName == "Grey");
            var EthanGruber = await context.Runners.SingleAsync(x => x.FirstName == "Ethan" && x.LastName == "Gruber");
            var EmilyGruber = await context.Runners.SingleAsync(x => x.FirstName == "Emily" && x.LastName == "Gruber");
            var MaxGucker = await context.Runners.SingleAsync(x => x.FirstName == "Max" && x.LastName == "Gucker");
            var BrettGucker = await context.Runners.SingleAsync(x => x.FirstName == "Brett" && x.LastName == "Gucker");
            var ClayGucker = await context.Runners.SingleAsync(x => x.FirstName == "Clay" && x.LastName == "Gucker");
            var BrookeGucker = await context.Runners.SingleAsync(x => x.FirstName == "Brooke" && x.LastName == "Gucker");
            var SheilaGucker = await context.Runners.SingleAsync(x => x.FirstName == "Sheila" && x.LastName == "Gucker");
            var RyanGutschow = await context.Runners.SingleAsync(x => x.FirstName == "Ryan" && x.LastName == "Gutschow");
            var KayleeGutschow = await context.Runners.SingleAsync(x => x.FirstName == "Kaylee" && x.LastName == "Gutschow");
            var SusanGutschow = await context.Runners.SingleAsync(x => x.FirstName == "Susan" && x.LastName == "Gutschow");
            var AsaGynn = await context.Runners.SingleAsync(x => x.FirstName == "Asa" && x.LastName == "Gynn");
            var CooperHartsel = await context.Runners.SingleAsync(x => x.FirstName == "Cooper" && x.LastName == "Hartsel");
            var CarrieHartsel = await context.Runners.SingleAsync(x => x.FirstName == "Carrie" && x.LastName == "Hartsel");
            var HeidiHartzler = await context.Runners.SingleAsync(x => x.FirstName == "Heidi" && x.LastName == "Hartzler");
            var BrianHartzler = await context.Runners.SingleAsync(x => x.FirstName == "Brian" && x.LastName == "Hartzler");
            var EdwardHawkins = await context.Runners.SingleAsync(x => x.FirstName == "Edward" && x.LastName == "Hawkins");
            var ElijahHaynes = await context.Runners.SingleAsync(x => x.FirstName == "Elijah" && x.LastName == "Haynes");
            var RoyHeger = await context.Runners.SingleAsync(x => x.FirstName == "Roy" && x.LastName == "Heger");
            var JeffHeilman = await context.Runners.SingleAsync(x => x.FirstName == "Jeff" && x.LastName == "Heilman");
            var VladimirHerdman = await context.Runners.SingleAsync(x => x.FirstName == "Vladimir" && x.LastName == "Herdman");
            var MikeHewit = await context.Runners.SingleAsync(x => x.FirstName == "Mike" && x.LastName == "Hewit");
            var AndrewHibler = await context.Runners.SingleAsync(x => x.FirstName == "Andrew" && x.LastName == "Hibler");
            var EmmaHibler = await context.Runners.SingleAsync(x => x.FirstName == "Emma" && x.LastName == "Hibler");
            var GregHill = await context.Runners.SingleAsync(x => x.FirstName == "Greg" && x.LastName == "Hill");
            var JessicaHill = await context.Runners.SingleAsync(x => x.FirstName == "Jessica" && x.LastName == "Hill");
            var DeborahHissong = await context.Runners.SingleAsync(x => x.FirstName == "Deborah" && x.LastName == "Hissong");
            var AndreaHoff = await context.Runners.SingleAsync(x => x.FirstName == "Andrea" && x.LastName == "Hoff");
            var CalebHostetler = await context.Runners.SingleAsync(x => x.FirstName == "Caleb" && x.LastName == "Hostetler");
            var BenHouse = await context.Runners.SingleAsync(x => x.FirstName == "Ben" && x.LastName == "House");
            var DonHouse = await context.Runners.SingleAsync(x => x.FirstName == "Don" && x.LastName == "House");
            var DavidHuff = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Huff");
            var JeralImhoff = await context.Runners.SingleAsync(x => x.FirstName == "Jeral" && x.LastName == "Imhoff");
            var DakotaJacobson = await context.Runners.SingleAsync(x => x.FirstName == "Dakota" && x.LastName == "Jacobson");
            var AndrewJarrett = await context.Runners.SingleAsync(x => x.FirstName == "Andrew" && x.LastName == "Jarrett");
            var ChrisJarrett = await context.Runners.SingleAsync(x => x.FirstName == "Chris" && x.LastName == "Jarrett");
            var JeffJarrett = await context.Runners.SingleAsync(x => x.FirstName == "Jeff" && x.LastName == "Jarrett");
            var HaydenJarvis = await context.Runners.SingleAsync(x => x.FirstName == "Hayden" && x.LastName == "Jarvis");
            var MollieJarvis = await context.Runners.SingleAsync(x => x.FirstName == "Mollie" && x.LastName == "Jarvis");
            var TimothyJensch = await context.Runners.SingleAsync(x => x.FirstName == "Timothy" && x.LastName == "Jensch");
            var AdrianaJeziorski = await context.Runners.SingleAsync(x => x.FirstName == "Adriana" && x.LastName == "Jeziorski");
            var JamesJohnson = await context.Runners.SingleAsync(x => x.FirstName == "James" && x.LastName == "Johnson");
            var ZachJohnston = await context.Runners.SingleAsync(x => x.FirstName == "Zach" && x.LastName == "Johnston");
            var KeithJohnston = await context.Runners.SingleAsync(x => x.FirstName == "Keith" && x.LastName == "Johnston");
            var JannelleJordan = await context.Runners.SingleAsync(x => x.FirstName == "Jannelle" && x.LastName == "Jordan");
            var McKennaJordan = await context.Runners.SingleAsync(x => x.FirstName == "McKenna" && x.LastName == "Jordan");
            var TonyKall = await context.Runners.SingleAsync(x => x.FirstName == "Tony" && x.LastName == "Kall");
            var EarlKanzeg = await context.Runners.SingleAsync(x => x.FirstName == "Earl" && x.LastName == "Kanzeg");
            var ElizabethKanzeg = await context.Runners.SingleAsync(x => x.FirstName == "Elizabeth" && x.LastName == "Kanzeg");
            var KrisKapchak = await context.Runners.SingleAsync(x => x.FirstName == "Kris" && x.LastName == "Kapchak");
            var DebbyKlinect = await context.Runners.SingleAsync(x => x.FirstName == "Debby" && x.LastName == "Klinect");
            var MeganKnapp = await context.Runners.SingleAsync(x => x.FirstName == "Megan" && x.LastName == "Knapp");
            var TraceyKochenderfer = await context.Runners.SingleAsync(x => x.FirstName == "Tracey" && x.LastName == "Kochenderfer");
            var KrisKopchak = await context.Runners.SingleAsync(x => x.FirstName == "Kris" && x.LastName == "Kopchak");
            var TiffanyKosman = await context.Runners.SingleAsync(x => x.FirstName == "Tiffany" && x.LastName == "Kosman");
            var BenjaminKruggel = await context.Runners.SingleAsync(x => x.FirstName == "Benjamin" && x.LastName == "Kruggel");
            var McKennaKulas = await context.Runners.SingleAsync(x => x.FirstName == "McKenna" && x.LastName == "Kulas");
            var BrianKulchar = await context.Runners.SingleAsync(x => x.FirstName == "Brian" && x.LastName == "Kulchar");
            var JoeyKurtz = await context.Runners.SingleAsync(x => x.FirstName == "Joey" && x.LastName == "Kurtz");
            var TommieKurtz = await context.Runners.SingleAsync(x => x.FirstName == "Tommie" && x.LastName == "Kurtz");
            var NoahLake = await context.Runners.SingleAsync(x => x.FirstName == "Noah" && x.LastName == "Lake");
            var CliffLear = await context.Runners.SingleAsync(x => x.FirstName == "Cliff" && x.LastName == "Lear");
            var AmberLeClair = await context.Runners.SingleAsync(x => x.FirstName == "Amber" && x.LastName == "LeClair");
            var WindyLewis = await context.Runners.SingleAsync(x => x.FirstName == "Windy" && x.LastName == "Lewis");
            var WilsonLewis = await context.Runners.SingleAsync(x => x.FirstName == "Wilson" && x.LastName == "Lewis");
            var ZoeLooney = await context.Runners.SingleAsync(x => x.FirstName == "Zoe" && x.LastName == "Looney");
            var LukeMalena = await context.Runners.SingleAsync(x => x.FirstName == "Luke" && x.LastName == "Malena");
            var ShannonMalikowski = await context.Runners.SingleAsync(x => x.FirstName == "Shannon" && x.LastName == "Malikowski");
            var CameronMarkeson = await context.Runners.SingleAsync(x => x.FirstName == "Cameron" && x.LastName == "Markeson");
            var LoganMarkle = await context.Runners.SingleAsync(x => x.FirstName == "Logan" && x.LastName == "Markle");
            var MichaelMartin = await context.Runners.SingleAsync(x => x.FirstName == "Michael" && x.LastName == "Martin");
            var KevinMartin = await context.Runners.SingleAsync(x => x.FirstName == "Kevin" && x.LastName == "Martin");
            var KarenMartin = await context.Runners.SingleAsync(x => x.FirstName == "Karen" && x.LastName == "Martin");
            var SherryMartin = await context.Runners.SingleAsync(x => x.FirstName == "Sherry" && x.LastName == "Martin");
            var ErinMason = await context.Runners.SingleAsync(x => x.FirstName == "Erin" && x.LastName == "Mason");
            var JamesMathatas = await context.Runners.SingleAsync(x => x.FirstName == "James" && x.LastName == "Mathatas");
            var ChristyMathatas = await context.Runners.SingleAsync(x => x.FirstName == "Christy" && x.LastName == "Mathatas");
            var MacyMcAdams = await context.Runners.SingleAsync(x => x.FirstName == "Macy" && x.LastName == "McAdams");
            var BeckyMcAdams = await context.Runners.SingleAsync(x => x.FirstName == "Becky" && x.LastName == "McAdams");
            var BrynneMcAllister = await context.Runners.SingleAsync(x => x.FirstName == "Brynne" && x.LastName == "McAllister");
            var RyanMcAllister = await context.Runners.SingleAsync(x => x.FirstName == "Ryan" && x.LastName == "McAllister");
            var JenniferMcCuen = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "McCuen");
            var DevinMcintosh = await context.Runners.SingleAsync(x => x.FirstName == "Devin" && x.LastName == "Mcintosh");
            var PatrickMcKeown = await context.Runners.SingleAsync(x => x.FirstName == "Patrick" && x.LastName == "McKeown");
            var CindyMcquown = await context.Runners.SingleAsync(x => x.FirstName == "Cindy" && x.LastName == "Mcquown");
            var MikeMeans = await context.Runners.SingleAsync(x => x.FirstName == "Mike" && x.LastName == "Means");
            var BenjaminMelkey = await context.Runners.SingleAsync(x => x.FirstName == "Benjamin" && x.LastName == "Melkey");
            var JenniferMeyers = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "Meyers");
            var EricMiddleton = await context.Runners.SingleAsync(x => x.FirstName == "Eric" && x.LastName == "Middleton");
            var RaymondMiller = await context.Runners.SingleAsync(x => x.FirstName == "Raymond" && x.LastName == "Miller");
            var RobMiller = await context.Runners.SingleAsync(x => x.FirstName == "Rob" && x.LastName == "Miller");
            var MadelynMiller = await context.Runners.SingleAsync(x => x.FirstName == "Madelyn" && x.LastName == "Miller");
            var AaronMohr = await context.Runners.SingleAsync(x => x.FirstName == "Aaron" && x.LastName == "Mohr");
            var VanessaMonhemius = await context.Runners.SingleAsync(x => x.FirstName == "Vanessa" && x.LastName == "Monhemius");
            var JohnMonhemius = await context.Runners.SingleAsync(x => x.FirstName == "John" && x.LastName == "Monhemius");
            var GiovannaMoroschan = await context.Runners.SingleAsync(x => x.FirstName == "Giovanna" && x.LastName == "Moroschan");
            var KaylaMoroschan = await context.Runners.SingleAsync(x => x.FirstName == "Kayla" && x.LastName == "Moroschan");
            var SommerMueller = await context.Runners.SingleAsync(x => x.FirstName == "Sommer" && x.LastName == "Mueller");
            var PaigeMunchick = await context.Runners.SingleAsync(x => x.FirstName == "Paige" && x.LastName == "Munchick");
            var RachelMurphy = await context.Runners.SingleAsync(x => x.FirstName == "Rachel" && x.LastName == "Murphy");
            var JonahMurphy = await context.Runners.SingleAsync(x => x.FirstName == "Jonah" && x.LastName == "Murphy");
            var ScottMurphy = await context.Runners.SingleAsync(x => x.FirstName == "Scott" && x.LastName == "Murphy");
            var DonnaMurphy = await context.Runners.SingleAsync(x => x.FirstName == "Donna" && x.LastName == "Murphy");
            var BlakeMusick = await context.Runners.SingleAsync(x => x.FirstName == "Blake" && x.LastName == "Musick");
            var JenMyers = await context.Runners.SingleAsync(x => x.FirstName == "Jen" && x.LastName == "Myers");
            var SarahNaftzger = await context.Runners.SingleAsync(x => x.FirstName == "Sarah" && x.LastName == "Naftzger");
            var DanNaftzger = await context.Runners.SingleAsync(x => x.FirstName == "Dan" && x.LastName == "Naftzger");
            var EmmaNagel = await context.Runners.SingleAsync(x => x.FirstName == "Emma" && x.LastName == "Nagel");
            var BenNagy = await context.Runners.SingleAsync(x => x.FirstName == "Ben" && x.LastName == "Nagy");
            var CarsonNagy = await context.Runners.SingleAsync(x => x.FirstName == "Carson" && x.LastName == "Nagy");
            var KristenNapholz = await context.Runners.SingleAsync(x => x.FirstName == "Kristen" && x.LastName == "Napholz");
            var NoahNavratil = await context.Runners.SingleAsync(x => x.FirstName == "Noah" && x.LastName == "Navratil");
            var ClaraNeville = await context.Runners.SingleAsync(x => x.FirstName == "Clara" && x.LastName == "Neville");
            var CalebNeville = await context.Runners.SingleAsync(x => x.FirstName == "Caleb" && x.LastName == "Neville");
            var RyanOCallaghan = await context.Runners.SingleAsync(x => x.FirstName == "Ryan" && x.LastName == "O'Callaghan");
            var JennaOliver = await context.Runners.SingleAsync(x => x.FirstName == "Jenna" && x.LastName == "Oliver");
            var BradOliver = await context.Runners.SingleAsync(x => x.FirstName == "Brad" && x.LastName == "Oliver");
            var TonyOliverio = await context.Runners.SingleAsync(x => x.FirstName == "Tony" && x.LastName == "Oliverio");
            var CarrieOlson = await context.Runners.SingleAsync(x => x.FirstName == "Carrie" && x.LastName == "Olson");
            var EstevanOrtega = await context.Runners.SingleAsync(x => x.FirstName == "Estevan" && x.LastName == "Ortega");
            var TylerPalmer = await context.Runners.SingleAsync(x => x.FirstName == "Tyler" && x.LastName == "Palmer");
            var LiciaPappas = await context.Runners.SingleAsync(x => x.FirstName == "Licia" && x.LastName == "Pappas");
            var ZechPaul = await context.Runners.SingleAsync(x => x.FirstName == "Zech" && x.LastName == "Paul");
            var MatthewPettry = await context.Runners.SingleAsync(x => x.FirstName == "Matthew" && x.LastName == "Pettry");
            var JimPlikerd = await context.Runners.SingleAsync(x => x.FirstName == "Jim" && x.LastName == "Plikerd");
            var ConnorPloucha = await context.Runners.SingleAsync(x => x.FirstName == "Connor" && x.LastName == "Ploucha");
            var TristanPonting = await context.Runners.SingleAsync(x => x.FirstName == "Tristan" && x.LastName == "Ponting");
            var MariaPorras = await context.Runners.SingleAsync(x => x.FirstName == "Maria" && x.LastName == "Porras");
            var VictoriaPorter = await context.Runners.SingleAsync(x => x.FirstName == "Victoria" && x.LastName == "Porter");
            var DannyPrice = await context.Runners.SingleAsync(x => x.FirstName == "Danny" && x.LastName == "Price");
            var KristinaQuick = await context.Runners.SingleAsync(x => x.FirstName == "Kristina" && x.LastName == "Quick");
            var CharlieReed = await context.Runners.SingleAsync(x => x.FirstName == "Charlie" && x.LastName == "Reed");
            var JackReed = await context.Runners.SingleAsync(x => x.FirstName == "Jack" && x.LastName == "Reed");
            var EmmaReed = await context.Runners.SingleAsync(x => x.FirstName == "Emma" && x.LastName == "Reed");
            var LisaReinhart = await context.Runners.SingleAsync(x => x.FirstName == "Lisa" && x.LastName == "Reinhart");
            var KellyRennels = await context.Runners.SingleAsync(x => x.FirstName == "Kelly" && x.LastName == "Rennels");
            var JenniferRidgway = await context.Runners.SingleAsync(x => x.FirstName == "Jennifer" && x.LastName == "Ridgway");
            var JoshuaRittgers = await context.Runners.SingleAsync(x => x.FirstName == "Joshua" && x.LastName == "Rittgers");
            var DavidRittgers = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Rittgers");
            var DanielRittgers = await context.Runners.SingleAsync(x => x.FirstName == "Daniel" && x.LastName == "Rittgers");
            var VanessaRivera = await context.Runners.SingleAsync(x => x.FirstName == "Vanessa" && x.LastName == "Rivera");
            var RidgeRobinson = await context.Runners.SingleAsync(x => x.FirstName == "Ridge" && x.LastName == "Robinson");
            var EileenRobison = await context.Runners.SingleAsync(x => x.FirstName == "Eileen" && x.LastName == "Robison");
            var MakaelaSalyer = await context.Runners.SingleAsync(x => x.FirstName == "Makaela" && x.LastName == "Salyer");
            var RobertSayer = await context.Runners.SingleAsync(x => x.FirstName == "Robert" && x.LastName == "Sayer");
            var RussellSchultz = await context.Runners.SingleAsync(x => x.FirstName == "Russell" && x.LastName == "Schultz");
            var CalebSeagar = await context.Runners.SingleAsync(x => x.FirstName == "Caleb" && x.LastName == "Seagar");
            var LianaSeagar = await context.Runners.SingleAsync(x => x.FirstName == "Liana" && x.LastName == "Seagar");
            var KevinSeager = await context.Runners.SingleAsync(x => x.FirstName == "Kevin" && x.LastName == "Seager");
            var MelodySeager = await context.Runners.SingleAsync(x => x.FirstName == "Melody" && x.LastName == "Seager");
            var DavidSears = await context.Runners.SingleAsync(x => x.FirstName == "David" && x.LastName == "Sears");
            var WillSicking = await context.Runners.SingleAsync(x => x.FirstName == "Will" && x.LastName == "Sicking");
            var GarrettSilva = await context.Runners.SingleAsync(x => x.FirstName == "Garrett" && x.LastName == "Silva");
            var MariyaSilva = await context.Runners.SingleAsync(x => x.FirstName == "Mariya" && x.LastName == "Silva");
            var MadisonSnyder = await context.Runners.SingleAsync(x => x.FirstName == "Madison" && x.LastName == "Snyder");
            var GarySnyder = await context.Runners.SingleAsync(x => x.FirstName == "Gary" && x.LastName == "Snyder");
            var AbigailSparks = await context.Runners.SingleAsync(x => x.FirstName == "Abigail" && x.LastName == "Sparks");
            var HollySpears = await context.Runners.SingleAsync(x => x.FirstName == "Holly" && x.LastName == "Spears");
            var SophiaSpencer = await context.Runners.SingleAsync(x => x.FirstName == "Sophia" && x.LastName == "Spencer");
            var DonaldSpencer = await context.Runners.SingleAsync(x => x.FirstName == "Donald" && x.LastName == "Spencer");
            var HunterStallings = await context.Runners.SingleAsync(x => x.FirstName == "Hunter" && x.LastName == "Stallings");
            var MelanieStallings = await context.Runners.SingleAsync(x => x.FirstName == "Melanie" && x.LastName == "Stallings");
            var LizStanley = await context.Runners.SingleAsync(x => x.FirstName == "Liz" && x.LastName == "Stanley");
            var TalenaStarr = await context.Runners.SingleAsync(x => x.FirstName == "Talena" && x.LastName == "Starr");
            var JesseStathes = await context.Runners.SingleAsync(x => x.FirstName == "Jesse" && x.LastName == "Stathes");
            var KatelanStathes = await context.Runners.SingleAsync(x => x.FirstName == "Katelan" && x.LastName == "Stathes");
            var CaleighStefanko = await context.Runners.SingleAsync(x => x.FirstName == "Caleigh" && x.LastName == "Stefanko");
            var TheresaStefanko = await context.Runners.SingleAsync(x => x.FirstName == "Theresa" && x.LastName == "Stefanko");
            var CaitySteiner = await context.Runners.SingleAsync(x => x.FirstName == "Caity" && x.LastName == "Steiner");
            var AndrewStephens = await context.Runners.SingleAsync(x => x.FirstName == "Andrew" && x.LastName == "Stephens");
            var ScottStoner = await context.Runners.SingleAsync(x => x.FirstName == "Scott" && x.LastName == "Stoner");
            var CarrieStoner = await context.Runners.SingleAsync(x => x.FirstName == "Carrie" && x.LastName == "Stoner");
            var AlyssaStoner = await context.Runners.SingleAsync(x => x.FirstName == "Alyssa" && x.LastName == "Stoner");
            var TeresaStrine = await context.Runners.SingleAsync(x => x.FirstName == "Teresa" && x.LastName == "Strine");
            var StacyStuchal = await context.Runners.SingleAsync(x => x.FirstName == "Stacy" && x.LastName == "Stuchal");
            var MatthewStudy = await context.Runners.SingleAsync(x => x.FirstName == "Matthew" && x.LastName == "Study");
            var AaronSurrarrer = await context.Runners.SingleAsync(x => x.FirstName == "Aaron" && x.LastName == "Surrarrer");
            var IanSwain = await context.Runners.SingleAsync(x => x.FirstName == "Ian" && x.LastName == "Swain");
            var HannahSwain = await context.Runners.SingleAsync(x => x.FirstName == "Hannah" && x.LastName == "Swain");
            var AdamSwiat = await context.Runners.SingleAsync(x => x.FirstName == "Adam" && x.LastName == "Swiat");
            var PhilipSyverson = await context.Runners.SingleAsync(x => x.FirstName == "Philip" && x.LastName == "Syverson");
            var GregSzklarz = await context.Runners.SingleAsync(x => x.FirstName == "Greg" && x.LastName == "Szklarz");
            var JackSzklarz = await context.Runners.SingleAsync(x => x.FirstName == "Jack" && x.LastName == "Szklarz");
            var BrockTegtmeier = await context.Runners.SingleAsync(x => x.FirstName == "Brock" && x.LastName == "Tegtmeier");
            var KadeTegtmeier = await context.Runners.SingleAsync(x => x.FirstName == "Kade" && x.LastName == "Tegtmeier");
            var HeatherTegtmeier = await context.Runners.SingleAsync(x => x.FirstName == "Heather" && x.LastName == "Tegtmeier");
            var RandyTegtmeier = await context.Runners.SingleAsync(x => x.FirstName == "Randy" && x.LastName == "Tegtmeier");
            var FaithTheobald = await context.Runners.SingleAsync(x => x.FirstName == "Faith" && x.LastName == "Theobald");
            var EricThomas = await context.Runners.SingleAsync(x => x.FirstName == "Eric" && x.LastName == "Thomas");
            var KenTurocy = await context.Runners.SingleAsync(x => x.FirstName == "Ken" && x.LastName == "Turocy");
            var WendyTurocy = await context.Runners.SingleAsync(x => x.FirstName == "Wendy" && x.LastName == "Turocy");
            var JimTuttle = await context.Runners.SingleAsync(x => x.FirstName == "Jim" && x.LastName == "Tuttle");
            var RandiVahl = await context.Runners.SingleAsync(x => x.FirstName == "Randi" && x.LastName == "Vahl");
            var ShaunVahl = await context.Runners.SingleAsync(x => x.FirstName == "Shaun" && x.LastName == "Vahl");
            var AndrewVasel = await context.Runners.SingleAsync(x => x.FirstName == "Andrew" && x.LastName == "Vasel");
            var TristanVaughan = await context.Runners.SingleAsync(x => x.FirstName == "Tristan" && x.LastName == "Vaughan");
            var DanielVereb = await context.Runners.SingleAsync(x => x.FirstName == "Daniel" && x.LastName == "Vereb");
            var ChuckWalter = await context.Runners.SingleAsync(x => x.FirstName == "Chuck" && x.LastName == "Walter");
            var AdamWanter = await context.Runners.SingleAsync(x => x.FirstName == "Adam" && x.LastName == "Wanter");
            var LivWells = await context.Runners.SingleAsync(x => x.FirstName == "Liv" && x.LastName == "Wells");
            var DillonWest = await context.Runners.SingleAsync(x => x.FirstName == "Dillon" && x.LastName == "West");
            var DrewWest = await context.Runners.SingleAsync(x => x.FirstName == "Drew" && x.LastName == "West");
            var AnnaWest = await context.Runners.SingleAsync(x => x.FirstName == "Anna" && x.LastName == "West");
            var TimWhite = await context.Runners.SingleAsync(x => x.FirstName == "Tim" && x.LastName == "White");
            var BlakeWilson = await context.Runners.SingleAsync(x => x.FirstName == "Blake" && x.LastName == "Wilson");
            var KaylaWilson = await context.Runners.SingleAsync(x => x.FirstName == "Kayla" && x.LastName == "Wilson");
            var KeithWinkler = await context.Runners.SingleAsync(x => x.FirstName == "Keith" && x.LastName == "Winkler");
            var AnnaWinnicki = await context.Runners.SingleAsync(x => x.FirstName == "Anna" && x.LastName == "Winnicki");
            var AmyWinnicki = await context.Runners.SingleAsync(x => x.FirstName == "Amy" && x.LastName == "Winnicki");
            var BradWoodland = await context.Runners.SingleAsync(x => x.FirstName == "Brad" && x.LastName == "Woodland");
            var ColeYagersz = await context.Runners.SingleAsync(x => x.FirstName == "Cole" && x.LastName == "Yagersz");
            var MichelleYoder = await context.Runners.SingleAsync(x => x.FirstName == "Michelle" && x.LastName == "Yoder");
            var BradenYoung = await context.Runners.SingleAsync(x => x.FirstName == "Braden" && x.LastName == "Young");
            var NickYount = await context.Runners.SingleAsync(x => x.FirstName == "Nick" && x.LastName == "Yount");
            var NickZiegler = await context.Runners.SingleAsync(x => x.FirstName == "Nick" && x.LastName == "Ziegler");

            #endregion

            #region Races
            
            var race2014 = await context.Races.SingleAsync(x => x.Name == RaceName2014);
            var race2015 = await context.Races.SingleAsync(x => x.Name == RaceName2015);
            var race2016 = await context.Races.SingleAsync(x => x.Name == RaceName2016);
            var race2017 = await context.Races.SingleAsync(x => x.Name == RaceName2017);
            var race2018 = await context.Races.SingleAsync(x => x.Name == RaceName2018);
            var race2019 = await context.Races.SingleAsync(x => x.Name == RaceName2019);

            #endregion

            var ageGroups = new ConcurrentBag<AgeGroup>
            {
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2014},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2014},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2015},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2015},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2016},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2016},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2017},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2017},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2018},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2018},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Female, Race = race2019},
                new AgeGroup {Name = AgeGroupName14AndUnder, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName15to18, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName19to24, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName25to29, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName30to39, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName40to49, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName50to59, Gender = Gender.Male, Race = race2019},
                new AgeGroup {Name = AgeGroupName60Plus, Gender = Gender.Male, Race = race2019}
            };

            await context.AgeGroups.AddRangeAsync(ageGroups);
            await context.SaveChangesAsync();

            #region Age Groups
            
            var race2014Female14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Female60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Female && x.Race == race2014);
            var race2014Male14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male40to49 = await context.AgeGroups.SingleAsync(x =>x.Name == AgeGroupName40to49 && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2014);
            var race2014Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2014);
            
            var race2015Female14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Female60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Female && x.Race == race2015);
            var race2015Male14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male40to49 = await context.AgeGroups.SingleAsync(x =>x.Name == AgeGroupName40to49 && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2015);
            var race2015Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2015);
            
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
            var race2018Male50to59 = await context.AgeGroups.SingleAsync(x =>x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2018);
            var race2018Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2018);

            var race2019Female14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Female60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Female && x.Race == race2019);
            var race2019Male14andUnder = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName14AndUnder && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male15to18 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName15to18 && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male19to24 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName19to24 && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male25to29 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName25to29 && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male30to39 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName30to39 && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male40to49 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName40to49 && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male50to59 = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName50to59 && x.Gender == Gender.Male && x.Race == race2019);
            var race2019Male60Plus = await context.AgeGroups.SingleAsync(x => x.Name == AgeGroupName60Plus && x.Gender == Gender.Male && x.Race == race2019);

            #endregion

            var raceRunners = new ConcurrentBag<RaceRunner>
            {
                new RaceRunner { Race = race2014, Runner = RidgeRobinson, AgeGroup = race2014Male25to29 },
                new RaceRunner { Race = race2014, Runner = NoahLake, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = MurphyAffolder, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = EugeneCho, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = DarrenEgner, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = RussellSchultz, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = CameronBilly, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = RyanGutschow, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = JimTuttle, AgeGroup = race2014Male40to49 },
                new RaceRunner { Race = race2014, Runner = EricMiddleton, AgeGroup = race2014Male30to39 },
                new RaceRunner { Race = race2014, Runner = CameronMarkeson, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = AdamBenway, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = EthanGruber, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = JacksonCleland, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = MichaelMartin, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = EstevanOrtega, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = AaronMohr, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = DanielChudzinski, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = LoganMarkle, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = MatthewGerhart, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = MaxGucker, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = SamuelCarroll, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = TalenaStarr, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = AndrewStephens, AgeGroup = race2014Male30to39 },
                new RaceRunner { Race = race2014, Runner = KyleBoyd, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = TrevorArmstrong, AgeGroup = race2014Male30to39 },
                new RaceRunner { Race = race2014, Runner = DevinMcintosh, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = RileyFreeland, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = MatthewBoyd, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = IanSwain, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = BradWoodland, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = MatthewStudy, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = BaileyFreeland, AgeGroup = race2014Female14andUnder },
                new RaceRunner { Race = race2014, Runner = AdrianaJeziorski, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = DannyPrice, AgeGroup = race2014Male60Plus },
                new RaceRunner { Race = race2014, Runner = ZoeLooney, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = RachelMurphy, AgeGroup = race2014Female14andUnder },
                new RaceRunner { Race = race2014, Runner = MandyEbert, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = JonahMurphy, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = KayleeGutschow, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = JannelleJordan, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = DavidAlpine, AgeGroup = race2014Male60Plus },
                new RaceRunner { Race = race2014, Runner = HannahSwain, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = AndreaArthur, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = MatthewPettry, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = JesseStathes, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = AnnaWinnicki, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = AllisonChudzinski, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = WilliamFoster, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = ChrisBoyd, AgeGroup = race2014Male40to49 },
                new RaceRunner { Race = race2014, Runner = AntonForeit, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = MollieJarvis, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = DillonWest, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = ChrisJarrett, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = TimWhite, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = ScottMurphy, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = KevinSeager, AgeGroup = race2014Male40to49 },
                new RaceRunner { Race = race2014, Runner = ZackFlynn, AgeGroup = race2014Male25to29 },
                new RaceRunner { Race = race2014, Runner = MikeMeans, AgeGroup = race2014Male30to39 },
                new RaceRunner { Race = race2014, Runner = KyleChudzinski, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = ColleenForeit, AgeGroup = race2014Female40to49 },
                new RaceRunner { Race = race2014, Runner = RandiBreese, AgeGroup = race2014Female40to49 },
                new RaceRunner { Race = race2014, Runner = EmilyGruber, AgeGroup = race2014Female19to24 },
                new RaceRunner { Race = race2014, Runner = MaureenCottrell, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = BrendaCanterbury, AgeGroup = race2014Female40to49 },
                new RaceRunner { Race = race2014, Runner = MollyBiegel, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = RyanOCallaghan, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = RoyHeger, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = McKennaJordan, AgeGroup = race2014Female14andUnder },
                new RaceRunner { Race = race2014, Runner = ChuckWalter, AgeGroup = race2014Male60Plus },
                new RaceRunner { Race = race2014, Runner = JenniferFoster, AgeGroup = race2014Female19to24 },
                new RaceRunner { Race = race2014, Runner = JessicaFlynn, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = DelaineyFlynn, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = EmmaReed, AgeGroup = race2014Female15to18 },
                new RaceRunner { Race = race2014, Runner = NolanFreeland, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = PatrickDonnelly, AgeGroup = race2014Male40to49 },
                new RaceRunner { Race = race2014, Runner = KellyGiles, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = SandraFoster, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = KatelanStathes, AgeGroup = race2014Female25to29 },
                new RaceRunner { Race = race2014, Runner = MadisonSnyder, AgeGroup = race2014Female14andUnder },
                new RaceRunner { Race = race2014, Runner = TimothyJensch, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = CalebSeagar, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = LianaSeagar, AgeGroup = race2014Female14andUnder },
                new RaceRunner { Race = race2014, Runner = ElijahHaynes, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = GarySnyder, AgeGroup = race2014Male50to59 },
                new RaceRunner { Race = race2014, Runner = JeffJarrett, AgeGroup = race2014Male19to24 },
                new RaceRunner { Race = race2014, Runner = SherryMartin, AgeGroup = race2014Female40to49 },
                new RaceRunner { Race = race2014, Runner = AmyWinnicki, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = TraceyKochenderfer, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = JamesJohnson, AgeGroup = race2014Male60Plus },
                new RaceRunner { Race = race2014, Runner = JeremyCottrell, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = ElyseFlynn, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = LoriCarroll, AgeGroup = race2014Female40to49 },
                new RaceRunner { Race = race2014, Runner = DonnaMurphy, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = RachelDeryck, AgeGroup = race2014Female14andUnder },
                new RaceRunner { Race = race2014, Runner = BarbaraBurton, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = SusanGutschow, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = HollySpears, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = ReaganFlynn, AgeGroup = race2014Female19to24 },
                new RaceRunner { Race = race2014, Runner = DeborahHissong, AgeGroup = race2014Female50to59 },
                new RaceRunner { Race = race2014, Runner = GraydonFlynn, AgeGroup = race2014Male15to18 },
                new RaceRunner { Race = race2014, Runner = KevinChudzinski, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = CarrieOlson, AgeGroup = race2014Female30to39 },
                new RaceRunner { Race = race2014, Runner = KristinaQuick, AgeGroup = race2014Female25to29 },
                new RaceRunner { Race = race2014, Runner = MaxieFlynn, AgeGroup = race2014Female19to24 },
                new RaceRunner { Race = race2014, Runner = EthanFlynn, AgeGroup = race2014Male14andUnder },
                new RaceRunner { Race = race2014, Runner = AdamWanter, AgeGroup = race2014Male25to29 },
                new RaceRunner { Race = race2015, Runner = MattChidsey, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = ChrisCannon, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = NoahLake, AgeGroup = race2015Male19to24 },
                new RaceRunner { Race = race2015, Runner = LewisAustin, AgeGroup = race2015Male19to24 },
                new RaceRunner { Race = race2015, Runner = AndrewJarrett, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = MichaelMartin, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = MatthewBildstein, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = MatthewGerhart, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = MaxGucker, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = MadelynMiller, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = BlakeButsko, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = RileyFreeland, AgeGroup = race2015Female15to18 },
                new RaceRunner { Race = race2015, Runner = PatrickBreean, AgeGroup = race2015Male19to24 },
                new RaceRunner { Race = race2015, Runner = DarrenEgner, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = VanessaRivera, AgeGroup = race2015Female15to18 },
                new RaceRunner { Race = race2015, Runner = ZachDreher, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = JohnMonhemius, AgeGroup = race2015Male30to39 },
                new RaceRunner { Race = race2015, Runner = JosephBruening, AgeGroup = race2015Male19to24 },
                new RaceRunner { Race = race2015, Runner = AnnaWinnicki, AgeGroup = race2015Female15to18 },
                new RaceRunner { Race = race2015, Runner = EstevanOrtega, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = DillonWest, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = KristenNapholz, AgeGroup = race2015Female15to18 },
                new RaceRunner { Race = race2015, Runner = SamBrandt, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = BaileyFreeland, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = JimButsko, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = RachelMurphy, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = CliffLear, AgeGroup = race2015Male30to39 },
                new RaceRunner { Race = race2015, Runner = AaronSurrarrer, AgeGroup = race2015Male30to39 },
                new RaceRunner { Race = race2015, Runner = DrewWest, AgeGroup = race2015Male30to39 },
                new RaceRunner { Race = race2015, Runner = DominicButsko, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = ConnorPloucha, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = DanGrabowski, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = KevinMartin, AgeGroup = race2015Male19to24 },
                new RaceRunner { Race = race2015, Runner = NickZiegler, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = MikeMeans, AgeGroup = race2015Male30to39 },
                new RaceRunner { Race = race2015, Runner = NickYount, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = AdamSwiat, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = PatrickMcKeown, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = NolanFreeland, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = AndrewHibler, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = WilliamFoster, AgeGroup = race2015Male50to59 },
                new RaceRunner { Race = race2015, Runner = BradOliver, AgeGroup = race2015Male50to59 },
                new RaceRunner { Race = race2015, Runner = ThomasBieniosek, AgeGroup = race2015Male60Plus },
                new RaceRunner { Race = race2015, Runner = KaylaWilson, AgeGroup = race2015Female15to18 },
                new RaceRunner { Race = race2015, Runner = RoyHeger, AgeGroup = race2015Male60Plus },
                new RaceRunner { Race = race2015, Runner = StephanieFoster, AgeGroup = race2015Female19to24 },
                new RaceRunner { Race = race2015, Runner = CaleighStefanko, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = EmmaHibler, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = TomCurran, AgeGroup = race2015Male50to59 },
                new RaceRunner { Race = race2015, Runner = VanessaButsko, AgeGroup = race2015Female40to49 },
                new RaceRunner { Race = race2015, Runner = JeffHeilman, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = DanEckert, AgeGroup = race2015Male25to29 },
                new RaceRunner { Race = race2015, Runner = ZackFlynn, AgeGroup = race2015Male25to29 },
                new RaceRunner { Race = race2015, Runner = DelaineyFlynn, AgeGroup = race2015Female19to24 },
                new RaceRunner { Race = race2015, Runner = MaddieGrey, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = JoshuaRittgers, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = KarenMartin, AgeGroup = race2015Female40to49 },
                new RaceRunner { Race = race2015, Runner = KellyRennels, AgeGroup = race2015Male50to59 },
                new RaceRunner { Race = race2015, Runner = BrettDeyling, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = BrettGucker, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = CindyMcquown, AgeGroup = race2015Female50to59 },
                new RaceRunner { Race = race2015, Runner = DanielRittgers, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = KenTurocy, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = AidenDonohue, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = SheilaGucker, AgeGroup = race2015Female30to39 },
                new RaceRunner { Race = race2015, Runner = MaddieBrandt, AgeGroup = race2015Female19to24 },
                new RaceRunner { Race = race2015, Runner = ElyseFlynn, AgeGroup = race2015Female30to39 },
                new RaceRunner { Race = race2015, Runner = SandraFoster, AgeGroup = race2015Female50to59 },
                new RaceRunner { Race = race2015, Runner = CharlieReed, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = ChuckWalter, AgeGroup = race2015Male60Plus },
                new RaceRunner { Race = race2015, Runner = JessicaFlynn, AgeGroup = race2015Female30to39 },
                new RaceRunner { Race = race2015, Runner = MadisonSnyder, AgeGroup = race2015Female14andUnder },
                new RaceRunner { Race = race2015, Runner = AmyWinnicki, AgeGroup = race2015Female50to59 },
                new RaceRunner { Race = race2015, Runner = GarySnyder, AgeGroup = race2015Male50to59 },
                new RaceRunner { Race = race2015, Runner = DavidRittgers, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = LaurenFrank, AgeGroup = race2015Female15to18 },
                new RaceRunner { Race = race2015, Runner = WendyTurocy, AgeGroup = race2015Female40to49 },
                new RaceRunner { Race = race2015, Runner = TonyOliverio, AgeGroup = race2015Male50to59 },
                new RaceRunner { Race = race2015, Runner = JenniferMcCuen, AgeGroup = race2015Female40to49 },
                new RaceRunner { Race = race2015, Runner = ShaunVahl, AgeGroup = race2015Male40to49 },
                new RaceRunner { Race = race2015, Runner = RandiBreese, AgeGroup = race2015Female40to49 },
                new RaceRunner { Race = race2015, Runner = GraydonFlynn, AgeGroup = race2015Male15to18 },
                new RaceRunner { Race = race2015, Runner = AdamWanter, AgeGroup = race2015Male25to29 },
                new RaceRunner { Race = race2015, Runner = MaxieFlynn, AgeGroup = race2015Female19to24 },
                new RaceRunner { Race = race2015, Runner = JackReed, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = HollySpears, AgeGroup = race2015Female30to39 },
                new RaceRunner { Race = race2015, Runner = TheresaStefanko, AgeGroup = race2015Female50to59 },
                new RaceRunner { Race = race2015, Runner = ReaganFlynn, AgeGroup = race2015Female19to24 },
                new RaceRunner { Race = race2015, Runner = EthanFlynn, AgeGroup = race2015Male14andUnder },
                new RaceRunner { Race = race2015, Runner = WillSicking, AgeGroup = race2015Male14andUnder },
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
                new RaceRunner {Race = race2016, Runner = NickZiegler, AgeGroup = race2016Male15to18},
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
                new RaceRunner {Race = race2017, Runner = NickZiegler, AgeGroup = race2017Male15to18},
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
                new RaceRunner {Race = race2017, Runner = BrettDeyling, AgeGroup = race2017Male40to49},
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
                new RaceRunner {Race = race2018, Runner = NickZiegler, AgeGroup = race2018Male15to18},
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
                new RaceRunner {Race = race2019, Runner = RussellSchultz, AgeGroup = race2019Male19to24},
                new RaceRunner {Race = race2019, Runner = MaxGucker, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = TristanVaughan, AgeGroup = race2019Male19to24},
                new RaceRunner {Race = race2019, Runner = ChuckEngle, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = AlexDerhammer, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = BrettGucker, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = AndrewHibler, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = BrockTegtmeier, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = JohnMonhemius, AgeGroup = race2019Male30to39},
                new RaceRunner {Race = race2019, Runner = RobMiller, AgeGroup = race2019Male50to59},
                new RaceRunner {Race = race2019, Runner = ColeYagersz, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = AdamBrantner, AgeGroup = race2019Male30to39},
                new RaceRunner {Race = race2019, Runner = KadeTegtmeier, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = SophiaSpencer, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = CooperHartsel, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = ScottStoner, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = NolanFreeland, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = HunterStallings, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = MakaelaSalyer, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = EmmaHibler, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = MariaPorras, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = VladimirHerdman, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = PaigeMunchick, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = AlyssaStoner, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = WilliamFoster, AgeGroup = race2019Male50to59},
                new RaceRunner {Race = race2019, Runner = BrynneMcAllister, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = DavidHuff, AgeGroup = race2019Male30to39},
                new RaceRunner {Race = race2019, Runner = TJCorbett, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = BlakeWilson, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = JoeyKurtz, AgeGroup = race2019Male15to18},
                new RaceRunner {Race = race2019, Runner = HaroldDravenstott, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = DakotaJacobson, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = ClayGucker, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = RyanMcAllister, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = JacobBeadnell, AgeGroup = race2019Male19to24},
                new RaceRunner {Race = race2019, Runner = DillonWest, AgeGroup = race2019Male19to24},
                new RaceRunner {Race = race2019, Runner = LivWells, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = VanessaMonhemius, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = BlakeMusick, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = CalebNeville, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = KaitlynClifford, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = HeatherTegtmeier, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = JoeArmogida, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = SandraFoster, AgeGroup = race2019Female50to59},
                new RaceRunner {Race = race2019, Runner = SommerMueller, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = RandyTegtmeier, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = MeganKnapp, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = BrookeGucker, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = MadisonSnyder, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = RileyEvans, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = AmberLeClair, AgeGroup = race2019Female30to39},
                new RaceRunner {Race = race2019, Runner = JenMyers, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = BenjaminKruggel, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = KatieCanfield, AgeGroup = race2019Female15to18},
                new RaceRunner {Race = race2019, Runner = ErinMason, AgeGroup = race2019Female30to39},
                new RaceRunner {Race = race2019, Runner = JimPlikerd, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = RandiVahl, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = ShaunVahl, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = RebeccaBoscaljon, AgeGroup = race2019Female30to39},
                new RaceRunner {Race = race2019, Runner = JamesJohnson, AgeGroup = race2019Male60Plus},
                new RaceRunner {Race = race2019, Runner = MelanieStallings, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = MarleyCarter, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = TristanPonting, AgeGroup = race2019Male14andUnder},
                new RaceRunner {Race = race2019, Runner = AdamSwiat, AgeGroup = race2019Male40to49},
                new RaceRunner {Race = race2019, Runner = SarahNaftzger, AgeGroup = race2019Female14andUnder},
                new RaceRunner {Race = race2019, Runner = WindyLewis, AgeGroup = race2019Female50to59},
                new RaceRunner {Race = race2019, Runner = AnnaWest, AgeGroup = race2019Female19to24},
                new RaceRunner {Race = race2019, Runner = DanNaftzger, AgeGroup = race2019Male30to39},
                new RaceRunner {Race = race2019, Runner = WilsonLewis, AgeGroup = race2019Male50to59},
                new RaceRunner {Race = race2019, Runner = ValarieBoscaljon, AgeGroup = race2019Female50to59},
                new RaceRunner {Race = race2019, Runner = AndreaHoff, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = StacyStuchal, AgeGroup = race2019Female40to49},
                new RaceRunner {Race = race2019, Runner = PamelaBoyles, AgeGroup = race2019Female30to39},
                new RaceRunner {Race = race2019, Runner = JoCavallaro, AgeGroup = race2019Female60Plus},
                new RaceRunner {Race = race2019, Runner = MeghanFiala, AgeGroup = race2019Female40to49}
            };

            var results = new ConcurrentBag<Result>
            {
                new Result { Runner = RidgeRobinson, Race = race2014, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 16, 4, 1), AgeGroup = race2014Male25to29 },
                new Result { Runner = NoahLake, Race = race2014, OverallPlace = 2, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 19, 19), AgeGroup = race2014Male19to24 },
                new Result { Runner = MurphyAffolder, Race = race2014, OverallPlace = 3, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 32, 33), AgeGroup = race2014Male15to18 },
                new Result { Runner = EugeneCho, Race = race2014, OverallPlace = 4, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 18, 41, 89), AgeGroup = race2014Male15to18 },
                new Result { Runner = DarrenEgner, Race = race2014, OverallPlace = 5, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 19, 25, 28), AgeGroup = race2014Male15to18 },
                new Result { Runner = RussellSchultz, Race = race2014, OverallPlace = 6, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 19, 35, 26), AgeGroup = race2014Male15to18 },
                new Result { Runner = CameronBilly, Race = race2014, OverallPlace = 7, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 19, 55, 72), AgeGroup = race2014Male15to18 },
                new Result { Runner = RyanGutschow, Race = race2014, OverallPlace = 8, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 19, 57, 22), AgeGroup = race2014Male15to18 },
                new Result { Runner = JimTuttle, Race = race2014, OverallPlace = 9, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 59, 21), AgeGroup = race2014Male40to49 },
                new Result { Runner = EricMiddleton, Race = race2014, OverallPlace = 10, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 30, 15), AgeGroup = race2014Male30to39 },
                new Result { Runner = CameronMarkeson, Race = race2014, OverallPlace = 11, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 20, 46, 79), AgeGroup = race2014Male15to18 },
                new Result { Runner = AdamBenway, Race = race2014, OverallPlace = 12, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 20, 49, 38), AgeGroup = race2014Male15to18 },
                new Result { Runner = EthanGruber, Race = race2014, OverallPlace = 13, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 20, 50, 89), AgeGroup = race2014Male15to18 },
                new Result { Runner = JacksonCleland, Race = race2014, OverallPlace = 14, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 51, 35), AgeGroup = race2014Male14andUnder },
                new Result { Runner = MichaelMartin, Race = race2014, OverallPlace = 15, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 21, 7, 76), AgeGroup = race2014Male15to18 },
                new Result { Runner = EstevanOrtega, Race = race2014, OverallPlace = 16, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 20, 44), AgeGroup = race2014Male14andUnder },
                new Result { Runner = AaronMohr, Race = race2014, OverallPlace = 17, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 21, 27, 1), AgeGroup = race2014Male15to18 },
                new Result { Runner = DanielChudzinski, Race = race2014, OverallPlace = 18, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 21, 29, 0), AgeGroup = race2014Male15to18 },
                new Result { Runner = LoganMarkle, Race = race2014, OverallPlace = 19, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 21, 29, 30), AgeGroup = race2014Male15to18 },
                new Result { Runner = MatthewGerhart, Race = race2014, OverallPlace = 20, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 21, 29, 65), AgeGroup = race2014Male14andUnder },
                new Result { Runner = MaxGucker, Race = race2014, OverallPlace = 21, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 21, 31, 50), AgeGroup = race2014Male14andUnder },
                new Result { Runner = SamuelCarroll, Race = race2014, OverallPlace = 22, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 21, 36, 85), AgeGroup = race2014Male15to18 },
                new Result { Runner = TalenaStarr, Race = race2014, OverallPlace = 23, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 39, 64), AgeGroup = race2014Female15to18 },
                new Result { Runner = AndrewStephens, Race = race2014, OverallPlace = 24, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 40, 66), AgeGroup = race2014Male30to39 },
                new Result { Runner = KyleBoyd, Race = race2014, OverallPlace = 25, AgeGroupPlace = 15, Time = new TimeSpan(0, 0, 21, 50, 60), AgeGroup = race2014Male15to18 },
                new Result { Runner = TrevorArmstrong, Race = race2014, OverallPlace = 26, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 21, 55, 71), AgeGroup = race2014Male30to39 },
                new Result { Runner = DevinMcintosh, Race = race2014, OverallPlace = 27, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 0, 79), AgeGroup = race2014Male19to24 },
                new Result { Runner = RileyFreeland, Race = race2014, OverallPlace = 28, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 7, 15), AgeGroup = race2014Female15to18 },
                new Result { Runner = MatthewBoyd, Race = race2014, OverallPlace = 29, AgeGroupPlace = 16, Time = new TimeSpan(0, 0, 22, 8, 59), AgeGroup = race2014Male15to18 },
                new Result { Runner = IanSwain, Race = race2014, OverallPlace = 30, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 22, 9, 4), AgeGroup = race2014Male14andUnder },
                new Result { Runner = BradWoodland, Race = race2014, OverallPlace = 31, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 13, 6), AgeGroup = race2014Male50to59 },
                new Result { Runner = MatthewStudy, Race = race2014, OverallPlace = 32, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 32, 7), AgeGroup = race2014Male19to24 },
                new Result { Runner = BaileyFreeland, Race = race2014, OverallPlace = 33, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 35, 63), AgeGroup = race2014Female14andUnder },
                new Result { Runner = AdrianaJeziorski, Race = race2014, OverallPlace = 34, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 54, 71), AgeGroup = race2014Female15to18 },
                new Result { Runner = DannyPrice, Race = race2014, OverallPlace = 35, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 57, 50), AgeGroup = race2014Male60Plus },
                new Result { Runner = ZoeLooney, Race = race2014, OverallPlace = 36, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 22, 58, 59), AgeGroup = race2014Female15to18 },
                new Result { Runner = RachelMurphy, Race = race2014, OverallPlace = 37, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 59, 83), AgeGroup = race2014Female14andUnder },
                new Result { Runner = MandyEbert, Race = race2014, OverallPlace = 38, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 7, 17), AgeGroup = race2014Female15to18 },
                new Result { Runner = JonahMurphy, Race = race2014, OverallPlace = 39, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 23, 32, 17), AgeGroup = race2014Male14andUnder },
                new Result { Runner = KayleeGutschow, Race = race2014, OverallPlace = 40, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 23, 39, 34), AgeGroup = race2014Female15to18 },
                new Result { Runner = JannelleJordan, Race = race2014, OverallPlace = 41, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 24, 12, 57), AgeGroup = race2014Female15to18 },
                new Result { Runner = DavidAlpine, Race = race2014, OverallPlace = 42, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 24, 17, 85), AgeGroup = race2014Male60Plus },
                new Result { Runner = HannahSwain, Race = race2014, OverallPlace = 43, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 24, 23, 72), AgeGroup = race2014Female15to18 },
                new Result { Runner = AndreaArthur, Race = race2014, OverallPlace = 44, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 35, 17), AgeGroup = race2014Female30to39 },
                new Result { Runner = MatthewPettry, Race = race2014, OverallPlace = 45, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 24, 41, 65), AgeGroup = race2014Male19to24 },
                new Result { Runner = JesseStathes, Race = race2014, OverallPlace = 46, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 24, 41, 93), AgeGroup = race2014Male19to24 },
                new Result { Runner = AnnaWinnicki, Race = race2014, OverallPlace = 47, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 24, 49, 40), AgeGroup = race2014Female15to18 },
                new Result { Runner = AllisonChudzinski, Race = race2014, OverallPlace = 48, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 24, 51, 11), AgeGroup = race2014Female15to18 },
                new Result { Runner = WilliamFoster, Race = race2014, OverallPlace = 49, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 0, 20), AgeGroup = race2014Male50to59 },
                new Result { Runner = ChrisBoyd, Race = race2014, OverallPlace = 50, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 9, 85), AgeGroup = race2014Male40to49 },
                new Result { Runner = AntonForeit, Race = race2014, OverallPlace = 51, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 26, 23), AgeGroup = race2014Male50to59 },
                new Result { Runner = MollieJarvis, Race = race2014, OverallPlace = 52, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 29, 28), AgeGroup = race2014Female30to39 },
                new Result { Runner = DillonWest, Race = race2014, OverallPlace = 53, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 25, 40, 4), AgeGroup = race2014Male14andUnder },
                new Result { Runner = ChrisJarrett, Race = race2014, OverallPlace = 54, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 25, 44, 54), AgeGroup = race2014Male19to24 },
                new Result { Runner = TimWhite, Race = race2014, OverallPlace = 55, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 52, 27), AgeGroup = race2014Male50to59 },
                new Result { Runner = ScottMurphy, Race = race2014, OverallPlace = 56, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 25, 54, 92), AgeGroup = race2014Male50to59 },
                new Result { Runner = KevinSeager, Race = race2014, OverallPlace = 57, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 26, 1, 1), AgeGroup = race2014Male40to49 },
                new Result { Runner = ZackFlynn, Race = race2014, OverallPlace = 58, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 26, 3, 84), AgeGroup = race2014Male25to29 },
                new Result { Runner = MikeMeans, Race = race2014, OverallPlace = 59, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 36, 69), AgeGroup = race2014Male30to39 },
                new Result { Runner = KyleChudzinski, Race = race2014, OverallPlace = 60, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 26, 55, 94), AgeGroup = race2014Male14andUnder },
                new Result { Runner = ColleenForeit, Race = race2014, OverallPlace = 61, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 27, 10, 59), AgeGroup = race2014Female40to49 },
                new Result { Runner = RandiBreese, Race = race2014, OverallPlace = 62, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 27, 11, 48), AgeGroup = race2014Female40to49 },
                new Result { Runner = EmilyGruber, Race = race2014, OverallPlace = 63, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 27, 24, 92), AgeGroup = race2014Female19to24 },
                new Result { Runner = MaureenCottrell, Race = race2014, OverallPlace = 64, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 27, 25, 57), AgeGroup = race2014Female30to39 },
                new Result { Runner = BrendaCanterbury, Race = race2014, OverallPlace = 65, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 27, 34, 63), AgeGroup = race2014Female40to49 },
                new Result { Runner = MollyBiegel, Race = race2014, OverallPlace = 66, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 27, 36, 58), AgeGroup = race2014Female15to18 },
                new Result { Runner = RyanOCallaghan, Race = race2014, OverallPlace = 67, AgeGroupPlace = 17, Time = new TimeSpan(0, 0, 27, 38, 84), AgeGroup = race2014Male15to18 },
                new Result { Runner = RoyHeger, Race = race2014, OverallPlace = 68, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 27, 48, 14), AgeGroup = race2014Male50to59 },
                new Result { Runner = McKennaJordan, Race = race2014, OverallPlace = 69, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 27, 51, 32), AgeGroup = race2014Female14andUnder },
                new Result { Runner = ChuckWalter, Race = race2014, OverallPlace = 70, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 28, 9, 9), AgeGroup = race2014Male60Plus },
                new Result { Runner = JenniferFoster, Race = race2014, OverallPlace = 71, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 28, 13, 64), AgeGroup = race2014Female19to24 },
                new Result { Runner = JessicaFlynn, Race = race2014, OverallPlace = 72, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 28, 24, 0), AgeGroup = race2014Female30to39 },
                new Result { Runner = DelaineyFlynn, Race = race2014, OverallPlace = 73, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 28, 27, 13), AgeGroup = race2014Female15to18 },
                new Result { Runner = EmmaReed, Race = race2014, OverallPlace = 74, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 28, 28, 45), AgeGroup = race2014Female15to18 },
                new Result { Runner = NolanFreeland, Race = race2014, OverallPlace = 75, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 28, 46, 83), AgeGroup = race2014Male14andUnder },
                new Result { Runner = PatrickDonnelly, Race = race2014, OverallPlace = 76, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 29, 32, 7), AgeGroup = race2014Male40to49 },
                new Result { Runner = KellyGiles, Race = race2014, OverallPlace = 77, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 29, 59, 13), AgeGroup = race2014Female30to39 },
                new Result { Runner = SandraFoster, Race = race2014, OverallPlace = 78, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 30, 5, 71), AgeGroup = race2014Female50to59 },
                new Result { Runner = KatelanStathes, Race = race2014, OverallPlace = 79, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 30, 15, 0), AgeGroup = race2014Female25to29 },
                new Result { Runner = MadisonSnyder, Race = race2014, OverallPlace = 80, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 30, 16, 19), AgeGroup = race2014Female14andUnder },
                new Result { Runner = TimothyJensch, Race = race2014, OverallPlace = 81, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 30, 40, 81), AgeGroup = race2014Male14andUnder },
                new Result { Runner = CalebSeagar, Race = race2014, OverallPlace = 82, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 30, 43, 21), AgeGroup = race2014Male14andUnder },
                new Result { Runner = LianaSeagar, Race = race2014, OverallPlace = 83, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 30, 43, 81), AgeGroup = race2014Female14andUnder },
                new Result { Runner = ElijahHaynes, Race = race2014, OverallPlace = 84, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 30, 57, 45), AgeGroup = race2014Male14andUnder },
                new Result { Runner = GarySnyder, Race = race2014, OverallPlace = 85, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 30, 58, 14), AgeGroup = race2014Male50to59 },
                new Result { Runner = JeffJarrett, Race = race2014, OverallPlace = 86, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 31, 5, 76), AgeGroup = race2014Male19to24 },
                new Result { Runner = SherryMartin, Race = race2014, OverallPlace = 87, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 31, 12, 39), AgeGroup = race2014Female40to49 },
                new Result { Runner = AmyWinnicki, Race = race2014, OverallPlace = 88, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 31, 13, 52), AgeGroup = race2014Female50to59 },
                new Result { Runner = TraceyKochenderfer, Race = race2014, OverallPlace = 89, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 31, 14, 2), AgeGroup = race2014Female50to59 },
                new Result { Runner = JamesJohnson, Race = race2014, OverallPlace = 90, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 32, 37, 78), AgeGroup = race2014Male60Plus },
                new Result { Runner = JeremyCottrell, Race = race2014, OverallPlace = 91, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 33, 7, 81), AgeGroup = race2014Male14andUnder },
                new Result { Runner = ElyseFlynn, Race = race2014, OverallPlace = 92, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 33, 8, 62), AgeGroup = race2014Female30to39 },
                new Result { Runner = LoriCarroll, Race = race2014, OverallPlace = 93, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 33, 18, 26), AgeGroup = race2014Female40to49 },
                new Result { Runner = DonnaMurphy, Race = race2014, OverallPlace = 94, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 33, 58, 86), AgeGroup = race2014Female50to59 },
                new Result { Runner = RachelDeryck, Race = race2014, OverallPlace = 95, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 34, 2, 57), AgeGroup = race2014Female14andUnder },
                new Result { Runner = BarbaraBurton, Race = race2014, OverallPlace = 96, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 34, 43, 53), AgeGroup = race2014Female50to59 },
                new Result { Runner = SusanGutschow, Race = race2014, OverallPlace = 97, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 37, 52, 43), AgeGroup = race2014Female50to59 },
                new Result { Runner = HollySpears, Race = race2014, OverallPlace = 98, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 38, 54, 81), AgeGroup = race2014Female30to39 },
                new Result { Runner = ReaganFlynn, Race = race2014, OverallPlace = 99, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 38, 57, 96), AgeGroup = race2014Female19to24 },
                new Result { Runner = DeborahHissong, Race = race2014, OverallPlace = 100, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 40, 13, 49), AgeGroup = race2014Female50to59 },
                new Result { Runner = GraydonFlynn, Race = race2014, OverallPlace = 101, AgeGroupPlace = 18, Time = new TimeSpan(0, 0, 41, 18, 10), AgeGroup = race2014Male15to18 },
                new Result { Runner = KevinChudzinski, Race = race2014, OverallPlace = 102, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 41, 40, 47), AgeGroup = race2014Male14andUnder },
                new Result { Runner = CarrieOlson, Race = race2014, OverallPlace = 103, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 41, 44, 64), AgeGroup = race2014Female30to39 },
                new Result { Runner = KristinaQuick, Race = race2014, OverallPlace = 104, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 41, 46, 25), AgeGroup = race2014Female25to29 },
                new Result { Runner = MaxieFlynn, Race = race2014, OverallPlace = 105, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 42, 17, 32), AgeGroup = race2014Female19to24 },
                new Result { Runner = EthanFlynn, Race = race2014, OverallPlace = 106, AgeGroupPlace = 15, Time = new TimeSpan(0, 0, 43, 16, 53), AgeGroup = race2014Male14andUnder },
                new Result { Runner = AdamWanter, Race = race2014, OverallPlace = 107, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 43, 18, 71), AgeGroup = race2014Male25to29 },
                new Result { Runner = MattChidsey, Race = race2015, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 17, 31), AgeGroup = race2015Male15to18 },
                new Result { Runner = ChrisCannon, Race = race2015, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 17, 23, 52), AgeGroup = race2015Male15to18 },
                new Result { Runner = NoahLake, Race = race2015, OverallPlace = 3, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 29, 54), AgeGroup = race2015Male19to24 },
                new Result { Runner = LewisAustin, Race = race2015, OverallPlace = 4, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 18, 2, 21), AgeGroup = race2015Male19to24 },
                new Result { Runner = AndrewJarrett, Race = race2015, OverallPlace = 5, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 18, 50, 54), AgeGroup = race2015Male15to18 },
                new Result { Runner = MichaelMartin, Race = race2015, OverallPlace = 6, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 18, 55, 53), AgeGroup = race2015Male15to18 },
                new Result { Runner = MatthewBildstein, Race = race2015, OverallPlace = 7, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 25, 30), AgeGroup = race2015Male14andUnder },
                new Result { Runner = MatthewGerhart, Race = race2015, OverallPlace = 8, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 20, 24, 72), AgeGroup = race2015Male15to18 },
                new Result { Runner = MaxGucker, Race = race2015, OverallPlace = 9, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 20, 33, 98), AgeGroup = race2015Male14andUnder },
                new Result { Runner = MadelynMiller, Race = race2015, OverallPlace = 10, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 40, 3), AgeGroup = race2015Female14andUnder },
                new Result { Runner = BlakeButsko, Race = race2015, OverallPlace = 11, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 20, 55, 13), AgeGroup = race2015Male14andUnder },
                new Result { Runner = RileyFreeland, Race = race2015, OverallPlace = 12, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 57, 8), AgeGroup = race2015Female15to18 },
                new Result { Runner = PatrickBreean, Race = race2015, OverallPlace = 13, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 21, 6, 3), AgeGroup = race2015Male19to24 },
                new Result { Runner = DarrenEgner, Race = race2015, OverallPlace = 14, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 21, 11, 25), AgeGroup = race2015Male15to18 },
                new Result { Runner = VanessaRivera, Race = race2015, OverallPlace = 15, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 23, 27), AgeGroup = race2015Female15to18 },
                new Result { Runner = ZachDreher, Race = race2015, OverallPlace = 16, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 21, 37, 3), AgeGroup = race2015Male15to18 },
                new Result { Runner = JohnMonhemius, Race = race2015, OverallPlace = 17, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 38, 71), AgeGroup = race2015Male30to39 },
                new Result { Runner = JosephBruening, Race = race2015, OverallPlace = 18, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 21, 46, 44), AgeGroup = race2015Male19to24 },
                new Result { Runner = AnnaWinnicki, Race = race2015, OverallPlace = 19, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 21, 54, 83), AgeGroup = race2015Female15to18 },
                new Result { Runner = EstevanOrtega, Race = race2015, OverallPlace = 20, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 21, 57, 86), AgeGroup = race2015Male15to18 },
                new Result { Runner = DillonWest, Race = race2015, OverallPlace = 21, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 22, 0, 24), AgeGroup = race2015Male15to18 },
                new Result { Runner = KristenNapholz, Race = race2015, OverallPlace = 22, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 22, 17, 7), AgeGroup = race2015Female15to18 },
                new Result { Runner = SamBrandt, Race = race2015, OverallPlace = 23, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 22, 53, 20), AgeGroup = race2015Male14andUnder },
                new Result { Runner = BaileyFreeland, Race = race2015, OverallPlace = 24, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 58, 91), AgeGroup = race2015Female14andUnder },
                new Result { Runner = JimButsko, Race = race2015, OverallPlace = 25, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 23, 18, 31), AgeGroup = race2015Male40to49 },
                new Result { Runner = RachelMurphy, Race = race2015, OverallPlace = 26, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 27, 70), AgeGroup = race2015Female14andUnder },
                new Result { Runner = CliffLear, Race = race2015, OverallPlace = 27, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 28, 29), AgeGroup = race2015Male30to39 },
                new Result { Runner = AaronSurrarrer, Race = race2015, OverallPlace = 28, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 49, 6), AgeGroup = race2015Male30to39 },
                new Result { Runner = DrewWest, Race = race2015, OverallPlace = 29, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 23, 49, 45), AgeGroup = race2015Male30to39 },
                new Result { Runner = DominicButsko, Race = race2015, OverallPlace = 30, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 58, 14), AgeGroup = race2015Male14andUnder },
                new Result { Runner = ConnorPloucha, Race = race2015, OverallPlace = 31, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 24, 10, 53), AgeGroup = race2015Male15to18 },
                new Result { Runner = DanGrabowski, Race = race2015, OverallPlace = 32, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 24, 10, 84), AgeGroup = race2015Male40to49 },
                new Result { Runner = KevinMartin, Race = race2015, OverallPlace = 33, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 24, 18, 34), AgeGroup = race2015Male19to24 },
                new Result { Runner = NickZiegler, Race = race2015, OverallPlace = 34, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 24, 23, 75), AgeGroup = race2015Male14andUnder },
                new Result { Runner = MikeMeans, Race = race2015, OverallPlace = 35, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 24, 29, 34), AgeGroup = race2015Male30to39 },
                new Result { Runner = NickYount, Race = race2015, OverallPlace = 36, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 24, 31, 77), AgeGroup = race2015Male15to18 },
                new Result { Runner = AdamSwiat, Race = race2015, OverallPlace = 37, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 24, 32, 21), AgeGroup = race2015Male40to49 },
                new Result { Runner = PatrickMcKeown, Race = race2015, OverallPlace = 38, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 24, 32, 89), AgeGroup = race2015Male15to18 },
                new Result { Runner = NolanFreeland, Race = race2015, OverallPlace = 39, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 24, 43, 95), AgeGroup = race2015Male14andUnder },
                new Result { Runner = AndrewHibler, Race = race2015, OverallPlace = 40, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 24, 45, 24), AgeGroup = race2015Male14andUnder },
                new Result { Runner = WilliamFoster, Race = race2015, OverallPlace = 41, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 0, 23), AgeGroup = race2015Male50to59 },
                new Result { Runner = BradOliver, Race = race2015, OverallPlace = 42, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 10, 36), AgeGroup = race2015Male50to59 },
                new Result { Runner = ThomasBieniosek, Race = race2015, OverallPlace = 43, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 15, 89), AgeGroup = race2015Male60Plus },
                new Result { Runner = KaylaWilson, Race = race2015, OverallPlace = 44, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 25, 37, 95), AgeGroup = race2015Female15to18 },
                new Result { Runner = RoyHeger, Race = race2015, OverallPlace = 45, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 59, 62), AgeGroup = race2015Male60Plus },
                new Result { Runner = StephanieFoster, Race = race2015, OverallPlace = 46, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 6, 31), AgeGroup = race2015Female19to24 },
                new Result { Runner = CaleighStefanko, Race = race2015, OverallPlace = 47, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 10, 20), AgeGroup = race2015Female14andUnder },
                new Result { Runner = EmmaHibler, Race = race2015, OverallPlace = 48, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 26, 14, 23), AgeGroup = race2015Female14andUnder },
                new Result { Runner = TomCurran, Race = race2015, OverallPlace = 49, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 26, 17, 17), AgeGroup = race2015Male50to59 },
                new Result { Runner = VanessaButsko, Race = race2015, OverallPlace = 50, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 23, 73), AgeGroup = race2015Female40to49 },
                new Result { Runner = JeffHeilman, Race = race2015, OverallPlace = 51, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 30, 51), AgeGroup = race2015Male40to49 },
                new Result { Runner = DanEckert, Race = race2015, OverallPlace = 52, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 40, 37), AgeGroup = race2015Male25to29 },
                new Result { Runner = ZackFlynn, Race = race2015, OverallPlace = 53, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 26, 41, 75), AgeGroup = race2015Male25to29 },
                new Result { Runner = DelaineyFlynn, Race = race2015, OverallPlace = 54, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 26, 46, 67), AgeGroup = race2015Female19to24 },
                new Result { Runner = MaddieGrey, Race = race2015, OverallPlace = 55, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 27, 11, 99), AgeGroup = race2015Female14andUnder },
                new Result { Runner = JoshuaRittgers, Race = race2015, OverallPlace = 56, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 27, 15, 38), AgeGroup = race2015Male14andUnder },
                new Result { Runner = KarenMartin, Race = race2015, OverallPlace = 57, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 27, 28, 4), AgeGroup = race2015Female40to49 },
                new Result { Runner = KellyRennels, Race = race2015, OverallPlace = 58, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 27, 35, 40), AgeGroup = race2015Male50to59 },
                new Result { Runner = BrettDeyling, Race = race2015, OverallPlace = 59, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 27, 50, 44), AgeGroup = race2015Male40to49 },
                new Result { Runner = BrettGucker, Race = race2015, OverallPlace = 60, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 28, 3, 7), AgeGroup = race2015Male14andUnder },
                new Result { Runner = CindyMcquown, Race = race2015, OverallPlace = 61, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 8, 44), AgeGroup = race2015Female50to59 },
                new Result { Runner = DanielRittgers, Race = race2015, OverallPlace = 62, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 28, 26, 43), AgeGroup = race2015Male14andUnder },
                new Result { Runner = KenTurocy, Race = race2015, OverallPlace = 63, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 28, 37, 57), AgeGroup = race2015Male40to49 },
                new Result { Runner = AidenDonohue, Race = race2015, OverallPlace = 64, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 28, 50, 85), AgeGroup = race2015Male14andUnder },
                new Result { Runner = SheilaGucker, Race = race2015, OverallPlace = 65, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 51, 84), AgeGroup = race2015Female30to39 },
                new Result { Runner = MaddieBrandt, Race = race2015, OverallPlace = 66, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 28, 53, 80), AgeGroup = race2015Female19to24 },
                new Result { Runner = ElyseFlynn, Race = race2015, OverallPlace = 67, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 26, 27), AgeGroup = race2015Female30to39 },
                new Result { Runner = SandraFoster, Race = race2015, OverallPlace = 68, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 30, 52, 58), AgeGroup = race2015Female50to59 },
                new Result { Runner = CharlieReed, Race = race2015, OverallPlace = 69, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 30, 53, 38), AgeGroup = race2015Male14andUnder },
                new Result { Runner = ChuckWalter, Race = race2015, OverallPlace = 70, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 55, 64), AgeGroup = race2015Male60Plus },
                new Result { Runner = JessicaFlynn, Race = race2015, OverallPlace = 71, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 56, 65), AgeGroup = race2015Female30to39 },
                new Result { Runner = MadisonSnyder, Race = race2015, OverallPlace = 72, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 30, 57, 56), AgeGroup = race2015Female14andUnder },
                new Result { Runner = AmyWinnicki, Race = race2015, OverallPlace = 73, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 31, 3, 8), AgeGroup = race2015Female50to59 },
                new Result { Runner = GarySnyder, Race = race2015, OverallPlace = 74, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 31, 26, 27), AgeGroup = race2015Male50to59 },
                new Result { Runner = DavidRittgers, Race = race2015, OverallPlace = 75, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 32, 7, 3), AgeGroup = race2015Male40to49 },
                new Result { Runner = LaurenFrank, Race = race2015, OverallPlace = 76, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 32, 50, 57), AgeGroup = race2015Female15to18 },
                new Result { Runner = WendyTurocy, Race = race2015, OverallPlace = 77, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 33, 27, 30), AgeGroup = race2015Female40to49 },
                new Result { Runner = TonyOliverio, Race = race2015, OverallPlace = 78, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 33, 30, 46), AgeGroup = race2015Male50to59 },
                new Result { Runner = JenniferMcCuen, Race = race2015, OverallPlace = 79, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 33, 30, 86), AgeGroup = race2015Female40to49 },
                new Result { Runner = ShaunVahl, Race = race2015, OverallPlace = 80, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 34, 41, 97), AgeGroup = race2015Male40to49 },
                new Result { Runner = RandiBreese, Race = race2015, OverallPlace = 81, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 34, 43, 10), AgeGroup = race2015Female40to49 },
                new Result { Runner = GraydonFlynn, Race = race2015, OverallPlace = 82, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 34, 59, 63), AgeGroup = race2015Male15to18 },
                new Result { Runner = AdamWanter, Race = race2015, OverallPlace = 83, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 36, 2, 46), AgeGroup = race2015Male25to29 },
                new Result { Runner = MaxieFlynn, Race = race2015, OverallPlace = 84, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 53, 82), AgeGroup = race2015Female19to24 },
                new Result { Runner = JackReed, Race = race2015, OverallPlace = 85, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 38, 25, 78), AgeGroup = race2015Male14andUnder },
                new Result { Runner = HollySpears, Race = race2015, OverallPlace = 86, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 38, 32, 97), AgeGroup = race2015Female30to39 },
                new Result { Runner = TheresaStefanko, Race = race2015, OverallPlace = 87, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 39, 22, 83), AgeGroup = race2015Female50to59 },
                new Result { Runner = ReaganFlynn, Race = race2015, OverallPlace = 88, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 39, 29, 30), AgeGroup = race2015Female19to24 },
                new Result { Runner = EthanFlynn, Race = race2015, OverallPlace = 89, AgeGroupPlace = 15, Time = new TimeSpan(0, 0, 40, 19, 82), AgeGroup = race2015Male14andUnder },
                new Result { Runner = WillSicking, Race = race2015, OverallPlace = 90, AgeGroupPlace = 16, Time = new TimeSpan(0, 0, 40, 34, 50), AgeGroup = race2015Male14andUnder },
                new Result { Runner = NoahAffolder, Race = race2016, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 16, 15, 58), AgeGroup = race2016Male15to18 },
                new Result { Runner = LucasClark, Race = race2016, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 17, 23, 75), AgeGroup = race2016Male15to18 },
                new Result { Runner = SamAffolder, Race = race2016, OverallPlace = 3, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 17, 38, 25), AgeGroup = race2016Male15to18 },
                new Result { Runner = TonyKall, Race = race2016, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 3, 46), AgeGroup = race2016Male19to24 },
                new Result { Runner = MattChidsey, Race = race2016, OverallPlace = 5, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 18, 14, 99), AgeGroup = race2016Male15to18 },
                new Result { Runner = KrisKapchak, Race = race2016, OverallPlace = 6, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 18, 21, 26), AgeGroup = race2016Male15to18 },
                new Result { Runner = BenHouse, Race = race2016, OverallPlace = 7, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 18, 38, 56), AgeGroup = race2016Male15to18 },
                new Result { Runner = MaxGucker, Race = race2016, OverallPlace = 8, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 12, 64), AgeGroup = race2016Male14andUnder },
                new Result { Runner = NoahNavratil, Race = race2016, OverallPlace = 9, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 20, 8, 10), AgeGroup = race2016Male15to18 },
                new Result { Runner = TristanVaughan, Race = race2016, OverallPlace = 10, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 20, 17, 50), AgeGroup = race2016Male15to18 },
                new Result { Runner = CalebHostetler, Race = race2016, OverallPlace = 11, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 20, 31, 58), AgeGroup = race2016Male15to18 },
                new Result { Runner = DillonWest, Race = race2016, OverallPlace = 12, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 21, 33, 27), AgeGroup = race2016Male15to18 },
                new Result { Runner = EstevanOrtega, Race = race2016, OverallPlace = 13, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 21, 33, 54), AgeGroup = race2016Male15to18 },
                new Result { Runner = MattButt, Race = race2016, OverallPlace = 14, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 21, 42, 72), AgeGroup = race2016Male15to18 },
                new Result { Runner = EdwardHawkins, Race = race2016, OverallPlace = 15, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 55, 57), AgeGroup = race2016Male30to39 },
                new Result { Runner = RileyFreeland, Race = race2016, OverallPlace = 16, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 58, 44), AgeGroup = race2016Female15to18 },
                new Result { Runner = ChristopherDostal, Race = race2016, OverallPlace = 17, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 24, 45), AgeGroup = race2016Male30to39 },
                new Result { Runner = RobertSayer, Race = race2016, OverallPlace = 18, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 49, 90), AgeGroup = race2016Male30to39 },
                new Result { Runner = TommieKurtz, Race = race2016, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 39, 70), AgeGroup = race2016Female15to18 },
                new Result { Runner = SamBrandt, Race = race2016, OverallPlace = 20, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 23, 39, 91), AgeGroup = race2016Male15to18 },
                new Result { Runner = BaileyFreeland, Race = race2016, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 40, 92), AgeGroup = race2016Female15to18 },
                new Result { Runner = NickZiegler, Race = race2016, OverallPlace = 22, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 24, 40, 21), AgeGroup = race2016Male15to18 },
                new Result { Runner = BradOliver, Race = race2016, OverallPlace = 23, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 51, 90), AgeGroup = race2016Male50to59 },
                new Result { Runner = DannyPrice, Race = race2016, OverallPlace = 24, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 55, 3), AgeGroup = race2016Male60Plus },
                new Result { Runner = BenNagy, Race = race2016, OverallPlace = 25, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 6, 61), AgeGroup = race2016Male14andUnder },
                new Result { Runner = CaleighStefanko, Race = race2016, OverallPlace = 26, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 20, 15), AgeGroup = race2016Female14andUnder },
                new Result { Runner = WilliamFoster, Race = race2016, OverallPlace = 27, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 22, 19), AgeGroup = race2016Male50to59 },
                new Result { Runner = JoeyKurtz, Race = race2016, OverallPlace = 28, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 33, 22), AgeGroup = race2016Male14andUnder },
                new Result { Runner = XanderBeltz, Race = race2016, OverallPlace = 29, AgeGroupPlace = 15, Time = new TimeSpan(0, 0, 25, 33, 41), AgeGroup = race2016Male15to18 },
                new Result { Runner = TylerPalmer, Race = race2016, OverallPlace = 30, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 37, 0), AgeGroup = race2016Male14andUnder },
                new Result { Runner = DrewWest, Race = race2016, OverallPlace = 31, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 42, 43), AgeGroup = race2016Male40to49 },
                new Result { Runner = ShaunVahl, Race = race2016, OverallPlace = 32, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 50, 96), AgeGroup = race2016Male40to49 },
                new Result { Runner = AnnaWinnicki, Race = race2016, OverallPlace = 33, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 51, 86), AgeGroup = race2016Female15to18 },
                new Result { Runner = ColtonCarpenter, Race = race2016, OverallPlace = 34, AgeGroupPlace = 16, Time = new TimeSpan(0, 0, 26, 3, 44), AgeGroup = race2016Male15to18 },
                new Result { Runner = MatthewPettry, Race = race2016, OverallPlace = 35, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 10, 24), AgeGroup = race2016Male25to29 },
                new Result { Runner = DonHouse, Race = race2016, OverallPlace = 36, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 26, 16, 20), AgeGroup = race2016Male50to59 },
                new Result { Runner = RandiVahl, Race = race2016, OverallPlace = 37, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 19, 25), AgeGroup = race2016Female40to49 },
                new Result { Runner = LukeAffolder, Race = race2016, OverallPlace = 38, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 26, 27, 20), AgeGroup = race2016Male14andUnder },
                new Result { Runner = LizStanley, Race = race2016, OverallPlace = 39, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 26, 28, 57), AgeGroup = race2016Female40to49 },
                new Result { Runner = GiovannaMoroschan, Race = race2016, OverallPlace = 40, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 41, 98), AgeGroup = race2016Male30to39 },
                new Result { Runner = JeffHeilman, Race = race2016, OverallPlace = 41, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 26, 56, 12), AgeGroup = race2016Male40to49 },
                new Result { Runner = KaylaMoroschan, Race = race2016, OverallPlace = 42, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 27, 27, 73), AgeGroup = race2016Female14andUnder },
                new Result { Runner = MichelleYoder, Race = race2016, OverallPlace = 43, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 18, 99), AgeGroup = race2016Female30to39 },
                new Result { Runner = GiaCatalano, Race = race2016, OverallPlace = 44, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 51, 18), AgeGroup = race2016Female19to24 },
                new Result { Runner = StephanieFoster, Race = race2016, OverallPlace = 45, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 17, 18), AgeGroup = race2016Female25to29 },
                new Result { Runner = CarsonNagy, Race = race2016, OverallPlace = 46, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 29, 19, 24), AgeGroup = race2016Male14andUnder },
                new Result { Runner = SandraFoster, Race = race2016, OverallPlace = 47, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 32, 72), AgeGroup = race2016Female50to59 },
                new Result { Runner = ShannonMalikowski, Race = race2016, OverallPlace = 48, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 29, 38, 4), AgeGroup = race2016Female40to49 },
                new Result { Runner = FaithTheobald, Race = race2016, OverallPlace = 49, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 29, 38, 45), AgeGroup = race2016Female15to18 },
                new Result { Runner = BillBrandt, Race = race2016, OverallPlace = 50, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 29, 43, 55), AgeGroup = race2016Male40to49 },
                new Result { Runner = JenniferMeyers, Race = race2016, OverallPlace = 51, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 30, 15, 27), AgeGroup = race2016Female30to39 },
                new Result { Runner = DarinClapp, Race = race2016, OverallPlace = 52, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 30, 48, 16), AgeGroup = race2016Male30to39 },
                new Result { Runner = VanessaMonhemius, Race = race2016, OverallPlace = 53, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 48, 49), AgeGroup = race2016Female14andUnder },
                new Result { Runner = JohnMonhemius, Race = race2016, OverallPlace = 54, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 30, 49, 0), AgeGroup = race2016Male30to39 },
                new Result { Runner = EileenRobison, Race = race2016, OverallPlace = 55, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 31, 7, 78), AgeGroup = race2016Female60Plus },
                new Result { Runner = MeganBrandt, Race = race2016, OverallPlace = 56, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 31, 46, 20), AgeGroup = race2016Female15to18 },
                new Result { Runner = AmyWinnicki, Race = race2016, OverallPlace = 57, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 32, 2, 65), AgeGroup = race2016Female50to59 },
                new Result { Runner = MariaClapp, Race = race2016, OverallPlace = 58, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 32, 19, 35), AgeGroup = race2016Female30to39 },
                new Result { Runner = MaddieBrandt, Race = race2016, OverallPlace = 59, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 32, 56, 95), AgeGroup = race2016Female19to24 },
                new Result { Runner = CharlieReed, Race = race2016, OverallPlace = 60, AgeGroupPlace = 17, Time = new TimeSpan(0, 0, 33, 25, 85), AgeGroup = race2016Male15to18 },
                new Result { Runner = DonaldSpencer, Race = race2016, OverallPlace = 61, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 33, 44, 49), AgeGroup = race2016Male19to24 },
                new Result { Runner = KelseyDake, Race = race2016, OverallPlace = 62, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 34, 6, 30), AgeGroup = race2016Female19to24 },
                new Result { Runner = JessicaFlynn, Race = race2016, OverallPlace = 63, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 34, 8, 70), AgeGroup = race2016Female30to39 },
                new Result { Runner = MikeHewit, Race = race2016, OverallPlace = 64, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 34, 30, 3), AgeGroup = race2016Male30to39 },
                new Result { Runner = EthanFlynn, Race = race2016, OverallPlace = 65, AgeGroupPlace = 18, Time = new TimeSpan(0, 0, 34, 32, 59), AgeGroup = race2016Male30to39 },
                new Result { Runner = ZechPaul, Race = race2016, OverallPlace = 66, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 34, 40, 14), AgeGroup = race2016Male25to29 },
                new Result { Runner = MadelineBohan, Race = race2016, OverallPlace = 67, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 34, 50, 91), AgeGroup = race2016Female14andUnder },
                new Result { Runner = EmmaReed, Race = race2016, OverallPlace = 68, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 35, 6, 89), AgeGroup = race2016Female15to18 },
                new Result { Runner = LisaReinhart, Race = race2016, OverallPlace = 69, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 35, 8, 70), AgeGroup = race2016Female25to29 },
                new Result { Runner = AmyDonnelly, Race = race2016, OverallPlace = 70, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 0, 88), AgeGroup = race2016Female40to49 },
                new Result { Runner = MikeBangert, Race = race2016, OverallPlace = 71, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 5, 70), AgeGroup = race2016Male50to59 },
                new Result { Runner = PhilipSyverson, Race = race2016, OverallPlace = 72, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 36, 6, 0), AgeGroup = race2016Male50to59 },
                new Result { Runner = VictoriaPorter, Race = race2016, OverallPlace = 73, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 40, 45, 93), AgeGroup = race2016Female40to49 },
                new Result { Runner = JackReed, Race = race2016, OverallPlace = 74, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 41, 21, 32), AgeGroup = race2016Male14andUnder },
                new Result { Runner = GraydonFlynn, Race = race2016, OverallPlace = 75, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 41, 28, 16), AgeGroup = race2016Male19to24 },
                new Result { Runner = AbbieEichel, Race = race2016, OverallPlace = 76, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 52, 10, 42), AgeGroup = race2016Female25to29 },
                new Result { Runner = LiciaPappas, Race = race2016, OverallPlace = 77, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 52, 11, 12), AgeGroup = race2016Female50to59 },
                new Result { Runner = LucasClark, Race = race2017, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 16, 51, 87), AgeGroup = race2017Male15to18 },
                new Result { Runner = KrisKopchak, Race = race2017, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 18, 1, 89), AgeGroup = race2017Male15to18 },
                new Result { Runner = NoahNavratil, Race = race2017, OverallPlace = 3, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 18, 17, 74), AgeGroup = race2017Male15to18 },
                new Result { Runner = MaxGucker, Race = race2017, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 23, 21), AgeGroup = race2017Male14andUnder },
                new Result { Runner = TristanVaughan, Race = race2017, OverallPlace = 5, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 18, 32, 94), AgeGroup = race2017Male15to18 },
                new Result { Runner = ChuckEngle, Race = race2017, OverallPlace = 6, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 41, 61), AgeGroup = race2017Male40to49 },
                new Result { Runner = BenjaminMelkey, Race = race2017, OverallPlace = 7, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 19, 50, 87), AgeGroup = race2017Male14andUnder },
                new Result { Runner = JeralImhoff, Race = race2017, OverallPlace = 8, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 56, 72), AgeGroup = race2017Male25to29 },
                new Result { Runner = DillonWest, Race = race2017, OverallPlace = 9, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 20, 15, 34), AgeGroup = race2017Male15to18 },
                new Result { Runner = SamBrandt, Race = race2017, OverallPlace = 10, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 20, 24, 39), AgeGroup = race2017Male15to18 },
                new Result { Runner = EstevanOrtega, Race = race2017, OverallPlace = 11, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 20, 26, 0), AgeGroup = race2017Male15to18 },
                new Result { Runner = BradenYoung, Race = race2017, OverallPlace = 12, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 20, 32, 89), AgeGroup = race2017Male15to18 },
                new Result { Runner = GregSzklarz, Race = race2017, OverallPlace = 13, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 19, 73), AgeGroup = race2017Male60Plus },
                new Result { Runner = NickZiegler, Race = race2017, OverallPlace = 14, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 22, 54, 60), AgeGroup = race2017Male15to18 },
                new Result { Runner = AsaGynn, Race = race2017, OverallPlace = 15, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 23, 16, 23), AgeGroup = race2017Male15to18 },
                new Result { Runner = BrettGucker, Race = race2017, OverallPlace = 16, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 17, 60), AgeGroup = race2017Male14andUnder },
                new Result { Runner = MariaPorras, Race = race2017, OverallPlace = 17, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 23, 22, 46), AgeGroup = race2017Female14andUnder },
                new Result { Runner = JennaOliver, Race = race2017, OverallPlace = 18, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 23, 24, 23), AgeGroup = race2017Female15to18 },
                new Result { Runner = TommieKurtz, Race = race2017, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 25, 11), AgeGroup = race2017Female15to18 },
                new Result { Runner = JackSzklarz, Race = race2017, OverallPlace = 20, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 23, 32, 11), AgeGroup = race2017Male14andUnder },
                new Result { Runner = EmmaNagel, Race = race2017, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 37, 60), AgeGroup = race2017Female15to18 },
                new Result { Runner = JoshuaRittgers, Race = race2017, OverallPlace = 22, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 42, 28), AgeGroup = race2017Male14andUnder },
                new Result { Runner = HaydenJarvis, Race = race2017, OverallPlace = 23, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 23, 49, 41), AgeGroup = race2017Male14andUnder },
                new Result { Runner = ScottStoner, Race = race2017, OverallPlace = 24, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 24, 6, 3), AgeGroup = race2017Male14andUnder },
                new Result { Runner = MollieJarvis, Race = race2017, OverallPlace = 25, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 23, 90), AgeGroup = race2017Female30to39 },
                new Result { Runner = PaigeMunchick, Race = race2017, OverallPlace = 26, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 24, 44, 34), AgeGroup = race2017Female14andUnder },
                new Result { Runner = StevenBett, Race = race2017, OverallPlace = 27, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 24, 55, 74), AgeGroup = race2017Male60Plus },
                new Result { Runner = BradOliver, Race = race2017, OverallPlace = 28, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 7, 81), AgeGroup = race2017Male50to59 },
                new Result { Runner = CooperHartsel, Race = race2017, OverallPlace = 29, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 25, 8, 13), AgeGroup = race2017Male14andUnder },
                new Result { Runner = JosephBruening, Race = race2017, OverallPlace = 30, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 25, 8, 43), AgeGroup = race2017Male19to24 },
                new Result { Runner = WilliamFoster, Race = race2017, OverallPlace = 31, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 24, 52), AgeGroup = race2017Male50to59 },
                new Result { Runner = ZaneEvans, Race = race2017, OverallPlace = 32, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 25, 45, 84), AgeGroup = race2017Male14andUnder },
                new Result { Runner = StephanieFoster, Race = race2017, OverallPlace = 33, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 26, 55, 84), AgeGroup = race2017Female25to29 },
                new Result { Runner = BrettDeyling, Race = race2017, OverallPlace = 34, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 27, 1, 39), AgeGroup = race2017Male40to49 },
                new Result { Runner = JohnMonhemius, Race = race2017, OverallPlace = 35, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 27, 3, 84), AgeGroup = race2017Male30to39 },
                new Result { Runner = VanessaMonhemius, Race = race2017, OverallPlace = 36, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 27, 4, 14), AgeGroup = race2017Female14andUnder },
                new Result { Runner = CarrieStoner, Race = race2017, OverallPlace = 37, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 2, 47), AgeGroup = race2017Female40to49 },
                new Result { Runner = AndrewVasel, Race = race2017, OverallPlace = 38, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 29, 11, 22), AgeGroup = race2017Male14andUnder },
                new Result { Runner = AlyssaStoner, Race = race2017, OverallPlace = 39, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 29, 21, 81), AgeGroup = race2017Female14andUnder },
                new Result { Runner = RandiVahl, Race = race2017, OverallPlace = 40, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 22, 99), AgeGroup = race2017Female40to49 },
                new Result { Runner = SandraFoster, Race = race2017, OverallPlace = 41, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 24, 51), AgeGroup = race2017Female50to59 },
                new Result { Runner = CharlieReed, Race = race2017, OverallPlace = 42, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 29, 45, 56), AgeGroup = race2017Male15to18 },
                new Result { Runner = ShaunVahl, Race = race2017, OverallPlace = 43, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 8, 80), AgeGroup = race2017Male40to49 },
                new Result { Runner = BobChittenden, Race = race2017, OverallPlace = 44, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 21, 42), AgeGroup = race2017Male60Plus },
                new Result { Runner = McKennaKulas, Race = race2017, OverallPlace = 45, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 30, 29, 70), AgeGroup = race2017Female15to18 },
                new Result { Runner = DavidRittgers, Race = race2017, OverallPlace = 46, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 30, 57, 80), AgeGroup = race2017Male40to49 },
                new Result { Runner = VladimirHerdman, Race = race2017, OverallPlace = 47, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 31, 38, 25), AgeGroup = race2017Male14andUnder },
                new Result { Runner = CarrieHartsel, Race = race2017, OverallPlace = 49, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 33, 38, 5), AgeGroup = race2017Female30to39 },
                new Result { Runner = GarrettSilva, Race = race2017, OverallPlace = 50, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 34, 44, 46), AgeGroup = race2017Male25to29 },
                new Result { Runner = MariyaSilva, Race = race2017, OverallPlace = 51, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 37, 23, 87), AgeGroup = race2017Female25to29 },
                new Result { Runner = KeithWinkler, Race = race2017, OverallPlace = 52, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 37, 59, 22), AgeGroup = race2017Male50to59 },
                new Result { Runner = JackReed, Race = race2017, OverallPlace = 53, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 37, 59, 22), AgeGroup = race2017Male14andUnder },
                new Result { Runner = MaxGucker, Race = race2018, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 41, 59), AgeGroup = race2018Male15to18 },
                new Result { Runner = TristanVaughan, Race = race2018, OverallPlace = 2, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 18, 29, 58), AgeGroup = race2018Male15to18 },
                new Result { Runner = ChuckEngle, Race = race2018, OverallPlace = 3, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 38, 60), AgeGroup = race2018Male40to49 },
                new Result { Runner = JeralImhoff, Race = race2018, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 52, 56), AgeGroup = race2018Male30to39 },
                new Result { Runner = KyleChudzinski, Race = race2018, OverallPlace = 5, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 19, 14, 0), AgeGroup = race2018Male15to18 },
                new Result { Runner = MacyMcAdams, Race = race2018, OverallPlace = 6, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 19, 42, 83), AgeGroup = race2018Female19to24 },
                new Result { Runner = AndrewHibler, Race = race2018, OverallPlace = 7, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 13, 54), AgeGroup = race2018Male14andUnder },
                new Result { Runner = AlexDerhammer, Race = race2018, OverallPlace = 8, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 20, 21, 30), AgeGroup = race2018Male15to18 },
                new Result { Runner = ZaneEvans, Race = race2018, OverallPlace = 9, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 20, 30, 46), AgeGroup = race2018Male14andUnder },
                new Result { Runner = BrettGucker, Race = race2018, OverallPlace = 10, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 20, 49, 94), AgeGroup = race2018Male14andUnder },
                new Result { Runner = LukeMalena, Race = race2018, OverallPlace = 11, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 20, 56, 45), AgeGroup = race2018Male14andUnder },
                new Result { Runner = RileyFreeland, Race = race2018, OverallPlace = 12, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 11, 3), AgeGroup = race2018Female19to24 },
                new Result { Runner = LaddClifford, Race = race2018, OverallPlace = 13, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 15, 31), AgeGroup = race2018Male50to59 },
                new Result { Runner = AndyDavis, Race = race2018, OverallPlace = 14, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 53, 80), AgeGroup = race2018Male40to49 },
                new Result { Runner = NickZiegler, Race = race2018, OverallPlace = 15, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 21, 57, 92), AgeGroup = race2018Male15to18 },
                new Result { Runner = ZachJohnston, Race = race2018, OverallPlace = 16, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 58, 43), AgeGroup = race2018Male25to29 },
                new Result { Runner = JosephBruening, Race = race2018, OverallPlace = 17, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 7, 22), AgeGroup = race2018Male25to29 },
                new Result { Runner = MichaelaDavis, Race = race2018, OverallPlace = 18, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 14, 93), AgeGroup = race2018Female15to18 },
                new Result { Runner = MariaPorras, Race = race2018, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 16, 26), AgeGroup = race2018Female15to18 },
                new Result { Runner = MakaelaSalyer, Race = race2018, OverallPlace = 20, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 17, 80), AgeGroup = race2018Female14andUnder },
                new Result { Runner = GregHill, Race = race2018, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 21, 58), AgeGroup = race2018Male25to29 },
                new Result { Runner = BaileyFreeland, Race = race2018, OverallPlace = 22, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 22, 25, 14), AgeGroup = race2018Female15to18 },
                new Result { Runner = JennaOliver, Race = race2018, OverallPlace = 23, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 22, 33, 17), AgeGroup = race2018Female15to18 },
                new Result { Runner = CooperHartsel, Race = race2018, OverallPlace = 24, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 22, 50, 24), AgeGroup = race2018Male15to18 },
                new Result { Runner = JoeyKurtz, Race = race2018, OverallPlace = 25, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 23, 2, 83), AgeGroup = race2018Male15to18 },
                new Result { Runner = NolanFreeland, Race = race2018, OverallPlace = 26, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 10, 73), AgeGroup = race2018Male14andUnder },
                new Result { Runner = SophiaSpencer, Race = race2018, OverallPlace = 27, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 23, 15, 96), AgeGroup = race2018Female15to18 },
                new Result { Runner = DavidHuff, Race = race2018, OverallPlace = 28, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 18, 69), AgeGroup = race2018Male30to39 },
                new Result { Runner = TylerPalmer, Race = race2018, OverallPlace = 29, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 23, 39, 95), AgeGroup = race2018Male14andUnder },
                new Result { Runner = DillonWest, Race = race2018, OverallPlace = 30, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 23, 46, 53), AgeGroup = race2018Male15to18 },
                new Result { Runner = PaigeMunchick, Race = race2018, OverallPlace = 31, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 47, 44), AgeGroup = race2018Female14andUnder },
                new Result { Runner = DaveFreeland, Race = race2018, OverallPlace = 32, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 54, 20), AgeGroup = race2018Male40to49 },
                new Result { Runner = KeithJohnston, Race = race2018, OverallPlace = 33, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 57, 91), AgeGroup = race2018Male50to59 },
                new Result { Runner = HaroldDravenstott, Race = race2018, OverallPlace = 34, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 24, 0, 38), AgeGroup = race2018Male40to49 },
                new Result { Runner = ScottStoner, Race = race2018, OverallPlace = 35, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 24, 5, 40), AgeGroup = race2018Male15to18 },
                new Result { Runner = JenniferRidgway, Race = race2018, OverallPlace = 36, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 22, 6), AgeGroup = race2018Female40to49 },
                new Result { Runner = BradOliver, Race = race2018, OverallPlace = 37, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 24, 33, 38), AgeGroup = race2018Male50to59 },
                new Result { Runner = TJCorbett, Race = race2018, OverallPlace = 38, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 24, 34, 20), AgeGroup = race2018Male15to18 },
                new Result { Runner = RaymondMiller, Race = race2018, OverallPlace = 39, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 24, 51, 2), AgeGroup = race2018Male60Plus },
                new Result { Runner = AsaGynn, Race = race2018, OverallPlace = 40, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 24, 57, 85), AgeGroup = race2018Male15to18 },
                new Result { Runner = WilliamFoster, Race = race2018, OverallPlace = 41, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 3, 57), AgeGroup = race2018Male50to59 },
                new Result { Runner = EricThomas, Race = race2018, OverallPlace = 42, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 12, 2), AgeGroup = race2018Male30to39 },
                new Result { Runner = LivWells, Race = race2018, OverallPlace = 43, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 25, 18, 80), AgeGroup = race2018Female15to18 },
                new Result { Runner = KatieCanfield, Race = race2018, OverallPlace = 44, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 25, 34, 69), AgeGroup = race2018Female15to18 },
                new Result { Runner = EmmaHibler, Race = race2018, OverallPlace = 45, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 36, 25), AgeGroup = race2018Female14andUnder },
                new Result { Runner = ClayGucker, Race = race2018, OverallPlace = 46, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 26, 13, 39), AgeGroup = race2018Male14andUnder },
                new Result { Runner = AndrewVasel, Race = race2018, OverallPlace = 47, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 26, 15, 8), AgeGroup = race2018Male15to18 },
                new Result { Runner = KevinSeager, Race = race2018, OverallPlace = 48, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 26, 18, 81), AgeGroup = race2018Male50to59 },
                new Result { Runner = ClaraNeville, Race = race2018, OverallPlace = 49, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 33, 21), AgeGroup = race2018Female14andUnder },
                new Result { Runner = VanessaMonhemius, Race = race2018, OverallPlace = 50, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 28, 9, 27), AgeGroup = race2018Female14andUnder },
                new Result { Runner = JohnMonhemius, Race = race2018, OverallPlace = 51, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 28, 9, 84), AgeGroup = race2018Male30to39 },
                new Result { Runner = DanielVereb, Race = race2018, OverallPlace = 52, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 28, 23, 66), AgeGroup = race2018Male25to29 },
                new Result { Runner = RandiVahl, Race = race2018, OverallPlace = 53, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 28, 29, 4), AgeGroup = race2018Female40to49 },
                new Result { Runner = MadelineBohan, Race = race2018, OverallPlace = 54, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 28, 30, 88), AgeGroup = race2018Female15to18 },
                new Result { Runner = ShaunVahl, Race = race2018, OverallPlace = 55, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 28, 40, 35), AgeGroup = race2018Male40to49 },
                new Result { Runner = SandraFoster, Race = race2018, OverallPlace = 56, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 41, 10), AgeGroup = race2018Female50to59 },
                new Result { Runner = MelodySeager, Race = race2018, OverallPlace = 57, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 28, 46, 32), AgeGroup = race2018Female14andUnder },
                new Result { Runner = JessicaHill, Race = race2018, OverallPlace = 58, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 57, 7), AgeGroup = race2018Female25to29 },
                new Result { Runner = BeckyMcAdams, Race = race2018, OverallPlace = 59, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 29, 13, 50), AgeGroup = race2018Female40to49 },
                new Result { Runner = JenniferFoster, Race = race2018, OverallPlace = 60, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 16, 2), AgeGroup = race2018Female25to29 },
                new Result { Runner = CharlieReed, Race = race2018, OverallPlace = 61, AgeGroupPlace = 13, Time = new TimeSpan(0, 0, 29, 17, 36), AgeGroup = race2018Male15to18 },
                new Result { Runner = KevinChudzinski, Race = race2018, OverallPlace = 62, AgeGroupPlace = 14, Time = new TimeSpan(0, 0, 29, 29, 70), AgeGroup = race2018Male15to18 },
                new Result { Runner = RileyEvans, Race = race2018, OverallPlace = 63, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 29, 32, 58), AgeGroup = race2018Female14andUnder },
                new Result { Runner = MadisonSnyder, Race = race2018, OverallPlace = 64, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 29, 33, 99), AgeGroup = race2018Female14andUnder },
                new Result { Runner = DebbyKlinect, Race = race2018, OverallPlace = 65, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 29, 53, 62), AgeGroup = race2018Female50to59 },
                new Result { Runner = AbigailSparks, Race = race2018, OverallPlace = 66, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 30, 33, 25), AgeGroup = race2018Female30to39 },
                new Result { Runner = LydiaFike, Race = race2018, OverallPlace = 67, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 30, 48, 12), AgeGroup = race2018Female14andUnder },
                new Result { Runner = DavidSears, Race = race2018, OverallPlace = 68, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 30, 52, 90), AgeGroup = race2018Male60Plus },
                new Result { Runner = EarlKanzeg, Race = race2018, OverallPlace = 69, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 33, 11, 61), AgeGroup = race2018Male40to49 },
                new Result { Runner = ElizabethKanzeg, Race = race2018, OverallPlace = 70, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 33, 40, 72), AgeGroup = race2018Female15to18 },
                new Result { Runner = TeresaStrine, Race = race2018, OverallPlace = 71, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 36, 12, 55), AgeGroup = race2018Female40to49 },
                new Result { Runner = CassieChance, Race = race2018, OverallPlace = 72, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 38, 17, 90), AgeGroup = race2018Female40to49 },
                new Result { Runner = JamesMathatas, Race = race2018, OverallPlace = 73, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 46, 14, 19), AgeGroup = race2018Male30to39 },
                new Result { Runner = ChristyMathatas, Race = race2018, OverallPlace = 74, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 46, 15, 16), AgeGroup = race2018Female30to39 },
                new Result { Runner = CaitySteiner, Race = race2018, OverallPlace = 75, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 46, 55, 73), AgeGroup = race2018Female25to29 },
                new Result { Runner = BrookeGucker, Race = race2018, OverallPlace = 76, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 46, 56, 5), AgeGroup = race2018Female14andUnder },
                new Result { Runner = HeidiHartzler, Race = race2018, OverallPlace = 77, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 46, 56, 41), AgeGroup = race2018Female40to49 },
                new Result { Runner = BrianHartzler, Race = race2018, OverallPlace = 78, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 46, 56, 50), AgeGroup = race2018Male40to49 },
                new Result { Runner = BrianKulchar, Race = race2018, OverallPlace = 79, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 52, 48, 19), AgeGroup = race2018Male50to59 },
                new Result { Runner = TiffanyKosman, Race = race2018, OverallPlace = 80, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 54, 17, 45), AgeGroup = race2018Female30to39 },
                new Result { Runner = ConnieEmerson, Race = race2018, OverallPlace = 81, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 54, 17, 65), AgeGroup = race2018Female60Plus },
                new Result { Runner = RussellSchultz, Race = race2019, OverallPlace = 1, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 10, 64), AgeGroup = race2019Male19to24 },
                new Result { Runner = MaxGucker, Race = race2019, OverallPlace = 2, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 17, 28, 42), AgeGroup = race2019Male15to18 },
                new Result { Runner = TristanVaughan, Race = race2019, OverallPlace = 3, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 17, 47, 12), AgeGroup = race2019Male19to24 },
                new Result { Runner = ChuckEngle, Race = race2019, OverallPlace = 4, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 18, 55, 57), AgeGroup = race2019Male40to49 },
                new Result { Runner = AlexDerhammer, Race = race2019, OverallPlace = 5, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 19, 14, 18), AgeGroup = race2019Male15to18 },
                new Result { Runner = BrettGucker, Race = race2019, OverallPlace = 6, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 19, 16, 52), AgeGroup = race2019Male15to18 },
                new Result { Runner = AndrewHibler, Race = race2019, OverallPlace = 7, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 20, 39, 17), AgeGroup = race2019Male15to18 },
                new Result { Runner = BrockTegtmeier, Race = race2019, OverallPlace = 8, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 20, 44, 6), AgeGroup = race2019Male15to18 },
                new Result { Runner = JohnMonhemius, Race = race2019, OverallPlace = 9, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 49, 20), AgeGroup = race2019Male30to39 },
                new Result { Runner = RobMiller, Race = race2019, OverallPlace = 10, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 20, 51, 43), AgeGroup = race2019Male50to59 },
                new Result { Runner = ColeYagersz, Race = race2019, OverallPlace = 11, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 20, 58, 51), AgeGroup = race2019Male15to18 },
                new Result { Runner = AdamBrantner, Race = race2019, OverallPlace = 12, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 21, 4, 28), AgeGroup = race2019Male30to39 },
                new Result { Runner = KadeTegtmeier, Race = race2019, OverallPlace = 13, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 21, 57, 70), AgeGroup = race2019Male14andUnder },
                new Result { Runner = SophiaSpencer, Race = race2019, OverallPlace = 14, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 22, 0, 0), AgeGroup = race2019Female15to18 },
                new Result { Runner = CooperHartsel, Race = race2019, OverallPlace = 15, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 22, 9, 75), AgeGroup = race2019Male15to18 },
                new Result { Runner = ScottStoner, Race = race2019, OverallPlace = 16, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 22, 25, 85), AgeGroup = race2019Male15to18 },
                new Result { Runner = NolanFreeland, Race = race2019, OverallPlace = 17, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 22, 27, 81), AgeGroup = race2019Male15to18 },
                new Result { Runner = HunterStallings, Race = race2019, OverallPlace = 18, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 29, 31), AgeGroup = race2019Male14andUnder },
                new Result { Runner = MakaelaSalyer, Race = race2019, OverallPlace = 19, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 22, 59, 87), AgeGroup = race2019Female15to18 },
                new Result { Runner = EmmaHibler, Race = race2019, OverallPlace = 20, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 23, 35, 18), AgeGroup = race2019Female14andUnder },
                new Result { Runner = MariaPorras, Race = race2019, OverallPlace = 21, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 38, 96), AgeGroup = race2019Female15to18 },
                new Result { Runner = VladimirHerdman, Race = race2019, OverallPlace = 22, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 23, 42, 66), AgeGroup = race2019Male14andUnder },
                new Result { Runner = PaigeMunchick, Race = race2019, OverallPlace = 23, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 23, 48, 57), AgeGroup = race2019Female15to18 },
                new Result { Runner = AlyssaStoner, Race = race2019, OverallPlace = 24, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 49, 13), AgeGroup = race2019Female14andUnder },
                new Result { Runner = WilliamFoster, Race = race2019, OverallPlace = 25, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 23, 51, 22), AgeGroup = race2019Male50to59 },
                new Result { Runner = BrynneMcAllister, Race = race2019, OverallPlace = 26, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 24, 1, 58), AgeGroup = race2019Female14andUnder },
                new Result { Runner = DavidHuff, Race = race2019, OverallPlace = 27, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 24, 5, 38), AgeGroup = race2019Male30to39 },
                new Result { Runner = TJCorbett, Race = race2019, OverallPlace = 28, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 24, 38, 17), AgeGroup = race2019Male15to18 },
                new Result { Runner = BlakeWilson, Race = race2019, OverallPlace = 29, AgeGroupPlace = 11, Time = new TimeSpan(0, 0, 24, 40, 50), AgeGroup = race2019Male15to18 },
                new Result { Runner = JoeyKurtz, Race = race2019, OverallPlace = 30, AgeGroupPlace = 12, Time = new TimeSpan(0, 0, 24, 46, 7), AgeGroup = race2019Male15to18 },
                new Result { Runner = HaroldDravenstott, Race = race2019, OverallPlace = 31, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 25, 35, 92), AgeGroup = race2019Male40to49 },
                new Result { Runner = DakotaJacobson, Race = race2019, OverallPlace = 32, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 25, 40, 82), AgeGroup = race2019Male14andUnder },
                new Result { Runner = ClayGucker, Race = race2019, OverallPlace = 33, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 25, 50, 6), AgeGroup = race2019Male14andUnder },
                new Result { Runner = RyanMcAllister, Race = race2019, OverallPlace = 34, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 50, 49), AgeGroup = race2019Male40to49 },
                new Result { Runner = JacobBeadnell, Race = race2019, OverallPlace = 35, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 25, 51, 52), AgeGroup = race2019Male19to24 },
                new Result { Runner = DillonWest, Race = race2019, OverallPlace = 36, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 26, 8, 89), AgeGroup = race2019Male19to24 },
                new Result { Runner = LivWells, Race = race2019, OverallPlace = 37, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 26, 9, 84), AgeGroup = race2019Female15to18 },
                new Result { Runner = VanessaMonhemius, Race = race2019, OverallPlace = 38, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 27, 14, 14), AgeGroup = race2019Female14andUnder },
                new Result { Runner = BlakeMusick, Race = race2019, OverallPlace = 39, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 27, 23, 79), AgeGroup = race2019Male14andUnder },
                new Result { Runner = CalebNeville, Race = race2019, OverallPlace = 40, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 27, 24, 42), AgeGroup = race2019Male14andUnder },
                new Result { Runner = KaitlynClifford, Race = race2019, OverallPlace = 41, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 27, 29, 52), AgeGroup = race2019Female15to18 },
                new Result { Runner = HeatherTegtmeier, Race = race2019, OverallPlace = 42, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 27, 54, 17), AgeGroup = race2019Female40to49 },
                new Result { Runner = JoeArmogida, Race = race2019, OverallPlace = 43, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 28, 7, 51), AgeGroup = race2019Male14andUnder },
                new Result { Runner = SandraFoster, Race = race2019, OverallPlace = 44, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 28, 8, 23), AgeGroup = race2019Female50to59 },
                new Result { Runner = SommerMueller, Race = race2019, OverallPlace = 45, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 28, 14, 51), AgeGroup = race2019Female40to49 },
                new Result { Runner = RandyTegtmeier, Race = race2019, OverallPlace = 46, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 28, 54, 51), AgeGroup = race2019Male40to49 },
                new Result { Runner = MeganKnapp, Race = race2019, OverallPlace = 47, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 29, 18, 23), AgeGroup = race2019Female14andUnder },
                new Result { Runner = BrookeGucker, Race = race2019, OverallPlace = 48, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 29, 29, 96), AgeGroup = race2019Female14andUnder },
                new Result { Runner = MadisonSnyder, Race = race2019, OverallPlace = 49, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 29, 30, 32), AgeGroup = race2019Female14andUnder },
                new Result { Runner = RileyEvans, Race = race2019, OverallPlace = 50, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 29, 30, 77), AgeGroup = race2019Female14andUnder },
                new Result { Runner = AmberLeClair, Race = race2019, OverallPlace = 51, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 29, 56, 76), AgeGroup = race2019Female30to39 },
                new Result { Runner = JenMyers, Race = race2019, OverallPlace = 52, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 30, 3, 95), AgeGroup = race2019Female40to49 },
                new Result { Runner = BenjaminKruggel, Race = race2019, OverallPlace = 53, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 30, 7, 52), AgeGroup = race2019Male40to49 },
                new Result { Runner = KatieCanfield, Race = race2019, OverallPlace = 54, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 30, 27, 68), AgeGroup = race2019Female15to18 },
                new Result { Runner = ErinMason, Race = race2019, OverallPlace = 55, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 31, 3, 87), AgeGroup = race2019Female30to39 },
                new Result { Runner = JimPlikerd, Race = race2019, OverallPlace = 56, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 31, 12, 71), AgeGroup = race2019Male40to49 },
                new Result { Runner = RandiVahl, Race = race2019, OverallPlace = 57, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 31, 54, 12), AgeGroup = race2019Female40to49 },
                new Result { Runner = ShaunVahl, Race = race2019, OverallPlace = 58, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 31, 54, 34), AgeGroup = race2019Male40to49 },
                new Result { Runner = RebeccaBoscaljon, Race = race2019, OverallPlace = 59, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 32, 46, 16), AgeGroup = race2019Female30to39 },
                new Result { Runner = JamesJohnson, Race = race2019, OverallPlace = 60, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 35, 44, 69), AgeGroup = race2019Male60Plus },
                new Result { Runner = MelanieStallings, Race = race2019, OverallPlace = 61, AgeGroupPlace = 5, Time = new TimeSpan(0, 0, 35, 45, 10), AgeGroup = race2019Female40to49 },
                new Result { Runner = MarleyCarter, Race = race2019, OverallPlace = 62, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 37, 10, 91), AgeGroup = race2019Female14andUnder },
                new Result { Runner = TristanPonting, Race = race2019, OverallPlace = 63, AgeGroupPlace = 9, Time = new TimeSpan(0, 0, 37, 18, 99), AgeGroup = race2019Male14andUnder },
                new Result { Runner = AdamSwiat, Race = race2019, OverallPlace = 64, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 37, 19, 39), AgeGroup = race2019Male40to49 },
                new Result { Runner = SarahNaftzger, Race = race2019, OverallPlace = 65, AgeGroupPlace = 10, Time = new TimeSpan(0, 0, 39, 30, 88), AgeGroup = race2019Female14andUnder },
                new Result { Runner = WindyLewis, Race = race2019, OverallPlace = 66, AgeGroupPlace = 2, Time = new TimeSpan(0, 0, 39, 36, 69), AgeGroup = race2019Female50to59 },
                new Result { Runner = AnnaWest, Race = race2019, OverallPlace = 67, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 39, 37, 41), AgeGroup = race2019Female19to24 },
                new Result { Runner = DanNaftzger, Race = race2019, OverallPlace = 68, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 39, 38, 70), AgeGroup = race2019Male30to39 },
                new Result { Runner = WilsonLewis, Race = race2019, OverallPlace = 69, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 39, 54, 12), AgeGroup = race2019Male50to59 },
                new Result { Runner = ValarieBoscaljon, Race = race2019, OverallPlace = 70, AgeGroupPlace = 3, Time = new TimeSpan(0, 0, 39, 57, 18), AgeGroup = race2019Female50to59 },
                new Result { Runner = AndreaHoff, Race = race2019, OverallPlace = 71, AgeGroupPlace = 6, Time = new TimeSpan(0, 0, 47, 55, 91), AgeGroup = race2019Female40to49 },
                new Result { Runner = StacyStuchal, Race = race2019, OverallPlace = 72, AgeGroupPlace = 7, Time = new TimeSpan(0, 0, 47, 56, 43), AgeGroup = race2019Female40to49 },
                new Result { Runner = PamelaBoyles, Race = race2019, OverallPlace = 73, AgeGroupPlace = 4, Time = new TimeSpan(0, 0, 48, 45, 82), AgeGroup = race2019Female30to39 },
                new Result { Runner = JoCavallaro, Race = race2019, OverallPlace = 74, AgeGroupPlace = 1, Time = new TimeSpan(0, 0, 48, 46, 21), AgeGroup = race2019Female60Plus },
                new Result { Runner = MeghanFiala, Race = race2019, OverallPlace = 75, AgeGroupPlace = 8, Time = new TimeSpan(0, 0, 49, 57, 87), AgeGroup = race2019Female40to49 }
            };

            await context.RaceRunners.AddRangeAsync(raceRunners);
            await context.Results.AddRangeAsync(results);
            await context.SaveChangesAsync();
        }
    }
}