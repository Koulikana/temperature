namespace temperature
{
    public class ConvertisseurFarenheit
    {
        private double temperature;

        public ConvertisseurFarenheit(double temperature) => Celsius = temperature;

        public double Celsius
        {
            get => temperature;
            set => temperature = value;
        }

        public double Farenheit
        {
            get => 1.8 * Celsius + 32;
        }
    }
}
