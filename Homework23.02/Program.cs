namespace Homework23._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter dirty salary: ");
            double dirtySalary = double.Parse(Console.ReadLine());

            double cleanSalary;
            CalculateCleanSalary(dirtySalary, out cleanSalary);

            Console.WriteLine("Clean salary: " + cleanSalary);
        }

        static void CalculateCleanSalary(double dirtySalary, out double cleanSalary)
        {
            double militaryFee = 0.1 * dirtySalary;
            double taxes = 0.05 * dirtySalary;

            cleanSalary = dirtySalary - militaryFee - taxes;
        }
    }
}