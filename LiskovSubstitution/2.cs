	
using System;
 
namespace LiskovSubstitutionPrinciple
{
    public interface IAirConditionable
    {
        string OpenAirConditioning();
    }
 
    public abstract class Car
    {
        public string Run()
        {
            return "Araba çalıştırıldı.";
        }
    }
 
    public class Ferrari : Car, IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima açıldı.";
        }
    }
 
    public class Murat131 : Car
    {
    }
 

