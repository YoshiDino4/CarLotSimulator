using System;
using System.Xml.Schema;

namespace CarLotSimulator;

public class Car
{
    public Car()
    {
        
    }

    public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
    {
        Make = make;
        Model = model;
        Year = year;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;
    }

    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string noise)
    {
        Console.WriteLine(noise);
    }

    public void MakeHonkNoise(string noise)
    {
        Console.WriteLine(noise);
    }
}