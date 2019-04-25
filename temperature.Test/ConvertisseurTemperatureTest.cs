using NUnit.Framework;

namespace temperature
{
    public class ConvertisseurFarenheitTests
    {
        [Test]
        public void TestConvertionFarenheitPourZero()
        {
            var convertisseur = new ConvertisseurFarenheit(0);
            Assert.AreEqual(32, convertisseur.Farenheit);
        }
    }
}