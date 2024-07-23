using System.Collections.Generic;
namespace CarLotSimulator;



public class CarLot
{
    public static int numberOfCars;
    public List<Car> Cars { get; set; } = new List<Car>();
}