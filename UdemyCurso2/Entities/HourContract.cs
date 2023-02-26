namespace UdemyCurso2.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; private set; }
        public double ValuePerHour { get; private set; }
        public int Hours { get; private set; }

        public HourContract(DateTime date, double valueperhour, int hour)
        {
            Date = date;
            ValuePerHour = valueperhour;
            Hours = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
