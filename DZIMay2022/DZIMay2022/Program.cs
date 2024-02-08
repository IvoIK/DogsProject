namespace DZIMay2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> vehicles = new List<Car>();

            try
            {
                string[] redove = File.ReadAllLines("data.txt");

                for (int i = 0; i < redove.Length; i += 3)
                {
                    int type = int.Parse(redove[i]);
                    string brand = redove[i + 1];
                    string[] data = redove[i + 2].Split(' ');
                    int year = int.Parse(data[0]);
                    int mileage = int.Parse(data[1]);
                    decimal value = decimal.Parse(data[2]);

                    if (type == 1)
                    {
                        Car car = new Car(brand, year, mileage, value);
                        car.Price();
                        vehicles.Add(car);
                    }
                    else if (type == 2)
                    {
                        int tonnage = int.Parse(data[3]);
                        Truck truck = new Truck(brand, year, mileage, value, tonnage);
                        truck.Price();
                        vehicles.Add(truck);
                    }
                }

                for (int i = vehicles.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine($"{vehicles[i].Brand}: {vehicles[i].Mileage} km, {vehicles[i].Value:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Грешка: {ex.Message}");
            }
        }
    }
}