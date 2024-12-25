namespace Assignment6
{

    #region Q1
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion
    #region Q2 and Q3
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    #endregion
    #region Q3
    [Flags]
    public enum Permissions
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    #endregion
    #region Q4
    public enum Colors
    {
        Red,
        Green,
        Blue
    }
    #endregion
    #region Q5
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    #endregion

    internal class Program
    {

        #region 1-Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.


        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Days of the week:");


        //    foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        //    {
        //        Console.WriteLine(day);
        //    }
        //}
        #endregion
        #region 2-Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        //        string? input = Console.ReadLine(); // Allow for nullable string input

        //        if (!string.IsNullOrEmpty(input) && Enum.TryParse(typeof(Season), input, true, out var result) && result != null)
        //        {
        //            Season season = (Season)result;
        //            string months = season switch
        //            {
        //                Season.Spring => "March to May",
        //                Season.Summer => "June to August",
        //                Season.Autumn => "September to November",
        //                Season.Winter => "December to February",
        //                _ => "Unknown"
        //            };

        //            Console.WriteLine($"The months for {season} are: {months}");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid season entered. Please try again.");
        //        }
        //    }
        //}
        #endregion
        #region 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.  Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable



        //public static void Main()
        //{
        //    Season? season = null;

        //    while (season == null)
        //    {
        //        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
        //        string? seasonInput = Console.ReadLine();

        //        if (seasonInput == null || string.IsNullOrEmpty(seasonInput))
        //        {
        //            Console.WriteLine("No input provided. Please enter a valid season.");
        //            continue;
        //        }

        //        if (Enum.TryParse(seasonInput, true, out Season parsedSeason))
        //        {
        //            season = parsedSeason;

        //            string monthRange = season switch
        //            {
        //                Season.Spring => "March to May",
        //                Season.Summer => "June to August",
        //                Season.Autumn => "September to November",
        //                Season.Winter => "December to February",
        //                _ => "Invalid season"
        //            };

        //            Console.WriteLine($"The month range for {season} is: {monthRange}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid season entered. Please try again.");
        //        }
        //    }

        //    Permissions userPermissions = Permissions.Read | Permissions.Write;

        //    bool hasDeletePermission = userPermissions.HasFlag(Permissions.Delete);
        //    Console.WriteLine($"Has Delete Permission: {hasDeletePermission}");

        //    userPermissions |= Permissions.Delete;
        //    Console.WriteLine($"Permissions after adding Delete: {userPermissions}");

        //    userPermissions &= ~Permissions.Write;
        //    Console.WriteLine($"Permissions after removing Write: {userPermissions}");

        //    Console.WriteLine($"Final Permissions: {userPermissions}");
        //}

        //IF i did a Big Mistake im Sorry i try it understand Question the way understand it
        #endregion
        #region 4-Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

        //internal static void Main()
        //{
        //    HashSet<string> validColors = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        //{
        //    "Red", "Green", "Blue", "Yellow", "Orange", "Purple", "Pink", "Brown", "Black", "White", "Gray"
        //};

        //    while (true)
        //    {
        //        Console.WriteLine("Enter a color (e.g., Red, Green, Blue) or type 'exit' to quit:");
        //        string? colorInput = Console.ReadLine();

        //        if (string.Equals(colorInput, "exit", StringComparison.OrdinalIgnoreCase))
        //        {
        //            break;
        //        }

        //        if (string.IsNullOrEmpty(colorInput))
        //        {
        //            Console.WriteLine("No color entered. Please try again.");
        //            continue;
        //        }

        //        if (!validColors.Contains(colorInput.Trim()))
        //        {
        //            Console.WriteLine($"'{colorInput}' is not a recognized color. Please enter a valid color.");
        //            continue;
        //        }

        //        if (Enum.TryParse(typeof(Colors), colorInput, true, out var parsedColor))
        //        {
        //            Console.WriteLine($"{colorInput} is a primary color.");
        //            break; 
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{colorInput} is not a primary color.");
        //        }
        //    }
        //}
        // I DID All Colors Becasue when write any word its said not a primary Color i just want the Colors that outside Primary Color (Red, Green, Blue)



        #endregion
        #region 5-Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

        // static Point GetPointFromUser()
        // {
        //     double x, y;

        //     while (true)
        //     {
        //         Console.Write("Enter X: ");
        //         if (double.TryParse(Console.ReadLine(), out x))
        //         {
        //             break;
        //         }
        //         else
        //         {
        //             Console.WriteLine("Invalid input for X. Please enter a valid number.");
        //         }
        //     }

        //     while (true)
        //     {
        //         Console.Write("Enter Y: ");
        //         if (double.TryParse(Console.ReadLine(), out y))
        //         {
        //             break;
        //         }
        //         else
        //         {
        //             Console.WriteLine("Invalid input for Y. Please enter a valid number.");
        //         }
        //     }

        //     return new Point(x, y);
        // }

        //public static double CalculateDistance(Point p1, Point p2)
        // {
        //     double dx = p2.X - p1.X;
        //     double dy = p2.Y - p1.Y;
        //     return Math.Sqrt(dx * dx + dy * dy);
        // }
        // public static void Main()
        // {
        //     Console.WriteLine("Enter the coordinates of the first point (X and Y):");
        //     Point point1 = GetPointFromUser();

        //     Console.WriteLine("Enter the coordinates of the second point (X and Y):");
        //     Point point2 = GetPointFromUser();

        //     double distance = CalculateDistance(point1, point2);
        //     Console.WriteLine($"The distance between the two points is: {distance}");
        // }

        #endregion
    }
}

