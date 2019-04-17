namespace LiskovSubstitutionPrinciple
{
    public abstract class Car
    {
        public string Run()
        {
            return "Araba çalıştırıldı.";
        }
 
        public abstract string OpenAirConditioning();
    }
}

public class Ferrari : Car
    {
        public override string OpenAirConditioning()
        {
            return "Klima açıldı.";
        }
    }
 
public class Murat131 : Car
    {
        public override string OpenAirConditioning()
        {
            throw new NotImplementedException();
 
            //return null;
        }
    }

static void Main(string[] args)
{
    Car car = new Ferrari();
    car.Run();
    car.OpenAirConditioning();
// Sıkıntı yok her şey yolunda.
    car = new Murat131();
    car.Run();
    car.OpenAirConditioning(); // ?
}
