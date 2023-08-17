using RentCars.Types;
namespace RentCars.Models;

//6 - Faça a classe `Car` herdar de `Vehicle`
public class Car : Vehicle
{
    public int Seats {set; get;}
    public int Doors {set; get;}
    public TractionType Traction {set; get;}
    public BrakeType FrontBrake {set; get;}
    public BrakeType RearBrake {set; get;}
}