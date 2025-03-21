using System;
using Spectre.Console;
using Bogus;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            int marcas = int.Parse(args[0]);

            Faker faker = new Faker();
            BarChart bc = new BarChart()
                .Label("Car sales")
                .CenterLabel();

            for (int i = 0; i < marcas; i++)
            {
                string marca = faker.Vehicle.Manufacturer();
                int carrosVendidos = faker.Random.Int(1, 20);
                bc.AddItem(marca, carrosVendidos, Color.White);
            }

            AnsiConsole.Write(bc);
        }
    }
}
