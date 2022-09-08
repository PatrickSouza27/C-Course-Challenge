namespace Exercise.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }
        public Employee(string name, int hour, double valuehour)
        {
            Name = name;
            Hours = hour;
            ValuePerHour = valuehour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
