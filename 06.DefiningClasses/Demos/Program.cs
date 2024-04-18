namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek currentDay = DayOfWeek.Saturday;
            Console.WriteLine(IsHoliday(currentDay));
        }

        static bool IsHoliday(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return false;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return true;
                default:
                    return false;
            }
        }
    }
}
