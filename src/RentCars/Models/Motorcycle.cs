using RentCars.Types;

namespace RentCars.Models;

//7 - Faça a classe `Motorcycle` herdar de `Vehicle`
public class Motorcycle : Vehicle
{
    public double SeatHeight {set;get;}
    public BrakeType FrontBrake {set; get;}
    public BrakeType RearBrake {set; get;}
}