namespace program;
public class Program
{
    public static void Main(string[] args)
    {
        string answer;
        System.Console.WriteLine("What shape would you like to calculate the area of ? Plase enter 'r' for rectangle, 'c' for circle, or 't' for triangle.");

        answer = System.Console.ReadLine();

        if (answer == "r")
        {
            System.Console.WriteLine("You have chosen rectangle. Please enter the width and height separated by a space.");
            string[] dimensions = System.Console.ReadLine().Split(' ');
            double width = double.Parse(dimensions[0]);
            double height = double.Parse(dimensions[1]);
            double area = width * height;
            System.Console.WriteLine($"The area of the rectangle is {area}.");
        }
        else if (answer == "c")
        {
            System.Console.WriteLine("You have chosen circle. Please enter the radius.");
            double radius = double.Parse(System.Console.ReadLine());
            double area = Math.PI * radius * radius;
            System.Console.WriteLine($"The area of the circle is {area}.");
        }
        else if (answer == "t")
        {
            System.Console.WriteLine("You have chosen triangle. Please enter the base and height separated by a space.");
            string[] dimensions = System.Console.ReadLine().Split(' ');
            double baseLength = double.Parse(dimensions[0]);
            double height = double.Parse(dimensions[1]);
            double area = 0.5 * baseLength * height;
            System.Console.WriteLine($"The area of the triangle is {area}.");
        }
        else
        {
            System.Console.WriteLine("Invalid shape selected.");
        }
        System.Console.WriteLine("Thank you for using the area calculator!");
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
        System.Console.Clear();
    }
}
