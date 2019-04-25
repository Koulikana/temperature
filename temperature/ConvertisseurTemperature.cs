
namespace temperature
{
    class ConvertisseurFarenheit
    {
        private double temperature;

        public ConvertisseurFarenheit(double temperature) => Celsius = temperature;

        public double Celsius
        {
            get => temperature;
            set => temperature = value;
        }

        public double Farenheit()
        {
            return 1.8 * Celsius + 32;
        }
    }
}
