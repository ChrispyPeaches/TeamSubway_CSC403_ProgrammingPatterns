/* Will Shepherd
 * CSC 403
 * 10/15/2023
 * Bridging structural design pattern
 */
// imports
using System;
using System.Reflection;

// abstraction -- the 'template,' if you will for other types of vehicles, or implementations
// of this abstraction
public abstract class Vehicle
{
    public string vehicleType;
    public string vehicleMake;
    public string vehicleModel;

    // get vehicle-specific information heres
    public Vehicle(string type, string make, string model)
    {
        vehicleType = type;
        vehicleMake = make;
        vehicleModel = model;
    }
    
    // make sure vehicles have a drive method
    public abstract void Drive();
}

// implementation of a vehicle -- car
public class Car : Vehicle
{
    // send make and model
    public Car(string make = "", string model = "") : base("Car", make, model) { }

    // implementation of the abstract drive method from the vehicle abstraction
    public override void Drive()
    {
        Console.WriteLine("I am driving a " + vehicleType + " (" + vehicleMake + " " + vehicleModel + ").");
        Console.WriteLine("VROOOOOOM!!!!");
    }
}



// implementation of a vehicle -- truck
public class Truck : Vehicle
{
    // send make and model
    public Truck(string make = "", string model = "") : base("Truck", make, model) { }

    // implementation of the abstract drive method from the vehicle abstraction
    public override void Drive()
    {
        // they're always ford-f150s -- let's be real
        Console.WriteLine("I love Ford-F150s!");
        Console.WriteLine("*truck breaks down*");
    }
}

// main part of the program for testing
class Program
{
    static void Main(string[] args)
    {
        // instantiation of different types of vehicles --
        // 2 cars and 1 truck
        Vehicle carOne = new Car("Toyota", "Camry");
        Vehicle carTwo = new Car("Honda", "Pilot");
        Vehicle truck = new Truck("Ford", "F-150");

        // call drive method for each vehicle
        carOne.Drive();
        carTwo.Drive();
        truck.Drive();
    }
}
