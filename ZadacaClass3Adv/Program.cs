
using Exercise;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;
using Validator = Exercise.Validator;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car()
        {
            BatchNumber = 15689,
            Countries = "Japan",
            FuelTank = 80,
            Id = 12,
            Type = "Coupe",
            YearOfProducton = 2019
        };

        Bike bike = new Bike()
        {
            Id = 17,
            BatchNumber = 2357,
            YearOfProducton = 2020,
            Type = "Sport",
            Color = "Black"
        };

        Vehicle vehicle = new Vehicle()
        {
            Id = 25,
            Type = "Toyota",
            YearOfProducton = 2017,
            BatchNumber = 657493
        };

        car.PrintVehicle();
        bike.PrintVehicle();
        vehicle.PrintVehicle();

        if (Validator.Validate(car))
            Validator.Validate(car);

        if (Validator.Validate(bike))
            Validator.Validate(bike);

        if (Validator.Validate(vehicle))
            Validator.Validate(vehicle);
    }
}