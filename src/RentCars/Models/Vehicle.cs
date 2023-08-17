using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
    public string Brand {set; get;} = "";
    public string Model {set; get;} = "";
    public decimal Price {set; get;}
    public FuelType Fuel {set; get;}
    public int EngineCapacity {set; get;}
    public Color MainColor {set; get;}
    public int Year {set; get;}
    public double PricePerDay {set; get;}
    public bool IsRented {set; get;} = false;
}