using System;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }

    public Car(string make, string model, int year, double price)
    {
        Make = make;
        Model = model;
        Year = year;
        Price = price;
    }
}

class Program
{
    static Car[] cars = new Car[100];
    static int numCars = 0;

    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Автосалон");
            Console.WriteLine("1. Добавить автомобиль");
            Console.WriteLine("2. Вывести список автомобилей");
            Console.WriteLine("3. Выход");
            Console.WriteLine();

            Console.Write("Введите номер действия: ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    AddCar();
                    break;
                case '2':
                    DisplayCars();
                    break;
                case '3':
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddCar()
    {
        Console.WriteLine("Добавление нового автомобиля:");
        Console.Write("Марка: ");
        string make = Console.ReadLine();
        Console.Write("Модель: ");
        string model = Console.ReadLine();
        Console.Write("Год выпуска: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Цена: ");
        double price = double.Parse(Console.ReadLine());

        cars[numCars] = new Car(make, model, year, price);
        numCars++;

        Console.WriteLine("Автомобиль успешно добавлен.");
    }

    static void DisplayCars()
    {
        Console.WriteLine("Список автомобилей:");
        Console.WriteLine("--------------------");
        Console.WriteLine("| Марка | Модель | Год выпуска | Цена |");
        Console.WriteLine("--------------------");

        for (int i = 0; i < numCars; i++)
        {
            Console.WriteLine($"| {cars[i].Make,-10} | {cars[i].Model,-10} | {cars[i].Year,-12} | {cars[i].Price,-4:C} |");
        }

        Console.WriteLine("--------------------");
    }
}
