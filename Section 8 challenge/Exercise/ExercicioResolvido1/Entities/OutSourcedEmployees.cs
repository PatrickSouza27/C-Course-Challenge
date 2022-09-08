namespace Exercise.Entities
{
    internal class OutSourcedEmployees : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployees(string name, int hour, double valuehour, double additionalCharge): base(name, hour, valuehour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + ((AdditionalCharge * 110 / 100));
        }
    }
}
