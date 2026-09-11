namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First Task : Student Grade Manager
            List<int> grades = new List<int> { 80, 89, 77, 93, 87, 69, 99, 65 };

            Console.Write("Grades: ");
            foreach (int g in grades)
                Console.Write(g + " ");

            Console.WriteLine();
            Console.WriteLine("Count: " + grades.Count);
            Console.WriteLine("First: " + grades[0]);
            Console.WriteLine("Last: " + grades[grades.Count - 1]);

            grades.Sort();

            Console.Write("Sorted Ascending: ");
            foreach (int g in grades)
                Console.Write(g + " ");

            Console.WriteLine();

            int firstAbove90 = grades.Find(g => g > 90);

            List<int> failingGrades = grades.FindAll(g => g < 75);

            grades.RemoveAll(g => g < 75);

            bool hasPerfectScore = grades.Exists(g => g == 100);

            List<string> gradeLabels = new List<string>();

            foreach (int g in grades)
                gradeLabels.Add("Grade: " + g);

            // Second Task : Leaderboard

            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            leaderboard.Add(500, "Ahmed");
            leaderboard.Add(200, "Sara");
            leaderboard.Add(800, "Ali");
            leaderboard.Add(350, "Mona");

            foreach (KeyValuePair<int, string> entry in leaderboard)
                Console.WriteLine(entry.Key + " - " + entry.Value);

            int firstKey = 0;
            string firstValue = "";

            foreach (KeyValuePair<int, string> entry in leaderboard)
            {
                firstKey = entry.Key;
                firstValue = entry.Value;
                break;
            }

            bool scoreExists = leaderboard.ContainsKey(500);

            leaderboard.TryGetValue(999, out string? player999);

            leaderboard.Remove(200);

            foreach (KeyValuePair<int, string> entry in leaderboard)
                Console.WriteLine(entry.Key + " - " + entry.Value);

            // Third Task : Phone Book

            Dictionary<string, string> contacts = new Dictionary<string, string>
            {
                { "Ahmed", "0100000000" },
                { "Sara", "0111111111" },
                { "Ali", "0122222222" },
                { "Mona", "0133333333" }
            };

            contacts["Hassan"] = "0144444444";

            try
            {
                contacts.Add("Ahmed", "0199999999");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            bool added = contacts.TryAdd("Sara", "0188888888");
            Console.WriteLine("TryAdd succeeded: " + added);

            bool contactFound = contacts.ContainsKey("Omar");

            string? omarNumber;

            if (!contacts.TryGetValue("Omar", out omarNumber))
                omarNumber = "Not Found";

            foreach (string key in contacts.Keys)
                Console.Write(key + " ");

            Console.WriteLine();

            foreach (string value in contacts.Values)
                Console.Write(value + " ");

            Console.WriteLine();

            // Task Num 4 : Unique Email Validator

            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine("Count: " + emails.Count);

            Console.WriteLine(
                "Only 2 are stored because the comparer is case-insensitive, so \"ahmed@test.com\"/\"AHMED@test.com\" and \"sara@test.com\"/\"Sara@Test.Com\" are treated as the same email."
            );

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSet<int> unionResult = new HashSet<int>(setA);

            unionResult.UnionWith(setB);

            Console.Write("Union: ");

            foreach (int n in unionResult)
                Console.Write(n + " ");

            Console.WriteLine();

            HashSet<int> intersectResult = new HashSet<int>(setA);

            intersectResult.IntersectWith(setB);

            Console.Write("Intersect: ");

            foreach (int n in intersectResult)
                Console.Write(n + " ");

            Console.WriteLine();

            HashSet<int> exceptResult = new HashSet<int>(setA);

            exceptResult.ExceptWith(setB);

            Console.Write("Except: ");

            foreach (int n in exceptResult)
                Console.Write(n + " ");

            Console.WriteLine();

            HashSet<int> subsetCheck = new HashSet<int> { 1, 2 };

            bool isSubset = subsetCheck.IsSubsetOf(setA);

            Console.WriteLine("{1,2} is subset of Set A: " + isSubset);

        }
    }
}
