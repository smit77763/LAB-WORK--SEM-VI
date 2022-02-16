﻿using System;
using System.Collections.Generic;
using System.Text;


interface IVehicle
{
    public void GiveForRent(bool isRented);
    // public void GiveForRent(DateTime startDate, DateTime endDate, double advancePayment);
    public double CalculateRent(DateTime startDate, DateTime endDate, double noOfKms);
    // public double CalculateRent(double usageunits);
    // public double CalculateRent(double usageunits);
    // public double CalculateRent(double usageunits);

    public string GiveNameAndNumber();

}


class Car : IVehicle
{
    private string _type;
    private double _seater;
    private string _name;
    private string _rentType;
    private double _rentPerUnit;
    private double _age;
    private string _number;
    private DateTime _lastMaintenanceDate;
    private bool _isRented;

    public static List<Car> _vehicleList = new List<Car>();

    public Car(string type, double seater, string name, string rentType, double rentPerUnit, double age, string number, DateTime lastMaintenanceDate, bool isRented)
    {
        _type = type;
        _seater = seater;
        _name = name;
        _rentType = rentType;
        _rentPerUnit = rentPerUnit;
        _age = age;
        _number = number;
        _lastMaintenanceDate = lastMaintenanceDate;
        _isRented = isRented;
        _vehicleList.Add(this);
    }

    public Car(string name, string rentType, double rentPerUnit, double age, string number, DateTime lastMaintenanceDate, bool isRented)
    {
        _name = name;
        _rentType = rentType;
        _rentPerUnit = rentPerUnit;
        _age = age;
        _number = number;
        _lastMaintenanceDate = lastMaintenanceDate;
        _isRented = isRented;
        _vehicleList.Add(this);
    }

    public string Type
    {
        get => _type;
        set => _type = value;
    }
    public double Seater
    {
        get => _seater;
        set => _seater = value;
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public string RentType
    {
        get => _rentType;
        set => _rentType = value;
    }

    public double RentPerUnit
    {
        get => _rentPerUnit;
        set => _rentPerUnit = value;
    }

    public double Age
    {
        get => _age;
        set => _age = value;
    }

    public string NumberOfCar
    {
        get => _number;
        set => _number = value;
    }

    public bool IsRented
    {
        get => _isRented;
        set => _isRented = value;
    }
    public DateTime LastMaintenanceDate
    {
        get => _lastMaintenanceDate;
        set => _lastMaintenanceDate = value;
    }

    public void GiveForRent(bool isRented)
    {
        IsRented = isRented;
    }

    // public void GiveForRent(DateTime startDate, DateTime endDate, double advancePayment)
    // {

    // }

    public double CalculateRent(DateTime startDate, DateTime endDate, double noOfKms)
    {
        if (RentType == "perDay")
        {
            return (float)(endDate - startDate).TotalDays * RentPerUnit;
        }
        else
        {
            return RentPerUnit * noOfKms;
        }
    }

    public string GiveNameAndNumber()
    {
        return $"{this._name} ({this._number}) ";
    }




    public override string ToString()
    {
        return "NAME: " + Type + " " + Seater + " , YEARLY SALARY: $" + RentType;
    }
}

public interface IRentedVehicle
{

    public DateTime StartDateOfRent
    {
        get;
        set;
    }

    public DateTime EndDateOfRent
    {
        get;
        set;
    }

    public double NoOfKmsTravelled
    {
        get;
        set;
    }

    public double AdvancePayment
    {
        get;
        set;
    }

}


class RentedVehicle<T> : IRentedVehicle
{
    private DateTime _startDateOfRent;

    private DateTime _endDateOfRent;

    private double _noOfKmsTravelled;

    private double _advancePayment;

    public T carObj;

    // public static List<IRentedVehicle> _rentedVehicleList = new List<IRentedVehicle>();
    // public static List<RentedVehicle<Car>> _rentedVehicleList = new List<RentedVehicle<Car>>();


    public RentedVehicle(T VehicleObj)
    {
        carObj = VehicleObj;
        // _rentedVehicleList.Add(this);
    }

    public DateTime StartDateOfRent
    {
        get => _startDateOfRent;
        set => _startDateOfRent = value;
    }

    public DateTime EndDateOfRent
    {
        get => _endDateOfRent;
        set => _endDateOfRent = value;
    }

    public double NoOfKmsTravelled
    {
        get => _noOfKmsTravelled;
        set => _noOfKmsTravelled = value;
    }

    public double AdvancePayment
    {
        get => _advancePayment;
        set => _advancePayment = value;
    }


    // public void Add<Car>(Car obj)
    // {
    //     carObj = obj;
    // }


    public void GiveForRent(double noOfKms, double advancePayment)
    {
        NoOfKmsTravelled = noOfKms;
        AdvancePayment = advancePayment;
        ((IVehicle)(this.carObj)).GiveForRent(true);
    }

    public void GiveForRent(DateTime startDate, DateTime endDate, double advancePayment)
    {
        StartDateOfRent = startDate;
        EndDateOfRent = endDate;
        AdvancePayment = advancePayment;
        ((IVehicle)(this.carObj)).GiveForRent(true);
    }

    public string GetNameAndNumber()
    {
        return ((IVehicle)(this.carObj)).GiveNameAndNumber();
    }

    public double CalculateRent()
    {
        return ((IVehicle)(this.carObj)).CalculateRent(StartDateOfRent, EndDateOfRent, NoOfKmsTravelled) - AdvancePayment;
    }

    public override string ToString()
    {
        return $"{carObj}";
    }

}

class Program
{
    static void Main()
    {

        Car Indica1 = new Car("petrol", 6, "Indica", "perDay", 5000, 2.5, "UP-80K-6547", new DateTime(2020, 09, 29), false);
        Car Indica2 = new Car("diesel", 6, "Indica", "perDay", 2000, 0.5, "GJ-06-RJ-4381", new DateTime(2022, 02, 13), false);
        Car Indica3 = new Car("diesel", 6, "Indica", "perKm", 120, 4, "UP-11K-8271", new DateTime(2019, 05, 09), false);
        Car Indica4 = new Car("petrol", 6, "Indica", "perKm", 150, 1.5, "JK-01P-9875", new DateTime(2021, 05, 09), false);

        // Indica indica = new Indica("petrol", 6, "perDay", 5000, 2, "UP-80K-8271", new DateTime(2019, 05, 09));
        // Qualis qualis = new Qualis("diesel", 8, "perKm", 200, 1, "DL-8CD-4004", new DateTime(2022, 01, 29));
        // DavidHarley davidharley = new DavidHarley("perDay", 10000, 1, "DL­-8S­B-8900", new DateTime(2021, 09, 29));
        // MBenzEClass mbenzeclass = new MBenzEClass("perKm", 1000, 3, "DL-8SA-­7925", new DateTime(2021, 03, 15));

        Car Qualis1 = new Car("petrol", 8, "Qualis", "perDay", 5000, 2, "AP-96E-6547", new DateTime(2022, 02, 09), false);
        Car Qualis2 = new Car("diesel", 8, "Qualis", "perKm", 250, 1, "GJ-35K-5462", new DateTime(2020, 10, 10), false);
        Car Qualis3 = new Car("petrol", 8, "Qualis", "perDay", 1500, 2.5, "UP-87A-1987", new DateTime(2022, 02, 05), false);

        Car DavidHarley1 = new Car("DavidHarley", "perDay", 6000, 1.5, "GJ-12-AK-1354", new DateTime(2021, 09, 15), false);

        Car MBenzEClass1 = new Car("MBenzEClass", "perKm", 1500, 2, "DL-8SA-1254", new DateTime(2021, 03, 20), false);
        Car MBenzEClass2 = new Car("MBenzEClass", "perDay", 10000, 0.5, "DL-89E-2158", new DateTime(2020, 02, 05), false);

        var list = new List<IRentedVehicle>();

        RentedVehicle<Car> indica1 = new RentedVehicle<Car>(Indica1);
        indica1.GiveForRent(new DateTime(2022, 02, 09), new DateTime(2022, 03, 19), 100);
        double rent1 = indica1.CalculateRent();
        Console.WriteLine($"Rent for {Indica1.Name} ({Indica1.NumberOfCar}) IS : Rs. {rent1}");

        list.Add(indica1);

        RentedVehicle<Car> indica2 = new RentedVehicle<Car>(Indica2);
        indica2.GiveForRent(new DateTime(2022, 01, 15), new DateTime(2022, 02, 15), 500);
        double rent2 = indica2.CalculateRent();
        Console.WriteLine($"Rent for {Indica2.Name} ({Indica2.NumberOfCar}) IS : Rs. {rent2}");

        list.Add(indica2);

        RentedVehicle<Car> indica3 = new RentedVehicle<Car>(Indica3);
        indica3.GiveForRent(1400, 1000);
        double rent3 = indica3.CalculateRent();
        Console.WriteLine($"Rent for {Indica3.Name} ({Indica3.NumberOfCar}) IS : Rs. {rent3}");

        list.Add(indica3);

        RentedVehicle<Car> qualis1 = new RentedVehicle<Car>(Qualis1);
        qualis1.GiveForRent(new DateTime(2022, 02, 01), new DateTime(2022, 02, 15), 50);
        double rent4 = qualis1.CalculateRent();
        Console.WriteLine($"Rent for {Qualis1.Name} ({Qualis1.NumberOfCar}) IS : Rs. {rent4}");

        list.Add(qualis1);

        RentedVehicle<Car> mbenzeclass1 = new RentedVehicle<Car>(MBenzEClass1);
        mbenzeclass1.GiveForRent(1200, 1000);
        double rent5 = mbenzeclass1.CalculateRent();
        Console.WriteLine($"Rent for {MBenzEClass1.Name} ({MBenzEClass1.NumberOfCar}) IS : Rs. {rent5}");

        list.Add(mbenzeclass1);

        Console.WriteLine($"\n Rent for Today : ");

        double rentForToday = 0;
        // foreach (RentedVehicle rentedVehicle in RentedVehicle._rentedVehicleList)
        // {
        //     if (rentedVehicle.EndDateOfRent == DateTime.Now)
        //     {
        //         // Console.WriteLine($"{vehicle.Name} ({vehicle.NumberOfCar}) ");
        //         rentForToday += rentedVehicle.CalculateRent();
        //     }

        // }

        foreach (var field in list)
        {
            // var type = field.RentedVehicle;
            Console.WriteLine(field.AdvancePayment);
        }

        Console.WriteLine($"\nRent for Today ({DateTime.Now}) is : {rentForToday}\n");


        Console.WriteLine("\nCars on Rent: \n");
        foreach (Car vehicle in Car._vehicleList)
        {
            if (vehicle.IsRented)
            {
                Console.WriteLine($"{vehicle.Name} ({vehicle.NumberOfCar}) ");
            }

        }
        Console.WriteLine("\nCars Availabel: \n");
        foreach (Car vehicle in Car._vehicleList)
        {
            if (!vehicle.IsRented)
            {
                Console.WriteLine($"{vehicle.Name} ({vehicle.NumberOfCar}) ");
            }

        }
        Console.WriteLine($"\nVehicle in Maintainance : \n");

        foreach (Car vehicle in Car._vehicleList)
        {
            if (!vehicle.IsRented && ((DateTime.Now - vehicle.LastMaintenanceDate).TotalDays) <= 15)
            {
                Console.WriteLine($"{vehicle.Name} ({vehicle.NumberOfCar}) ");
            }

        }


        Console.WriteLine($"\nEnter date for checking availability (mm/dd/yyyy): \n");

        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        foreach (Car vehicle in Car._vehicleList)
        {
            if (!vehicle.IsRented && ((DateTime.Now - vehicle.LastMaintenanceDate).TotalDays) > 15)
            {
                Console.WriteLine($"{vehicle.Name} ({vehicle.NumberOfCar}) ");
            }

        }
        // foreach (RentedVehicle rentedVehicle in RentedVehicle._rentedVehicleList)
        // {
        //     if (rentedVehicle.EndDateOfRent < inputDate)
        //     {
        //         Console.WriteLine(rentedVehicle.GetNameAndNumber());
        //     }

        // }


    }
}