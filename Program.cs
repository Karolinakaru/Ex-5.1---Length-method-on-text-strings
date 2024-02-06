internal class Program
{
    static void Main()
    {
        string city, voivodeship;
        int cityLength, voivodeshipLength;
        Console.WriteLine("Podaj nazwę miasta: ");
        city = Console.ReadLine();

        Console.WriteLine("Podaj nazwę województwa: ");
        voivodeship = Console.ReadLine();

        cityLength = city.Length;
        voivodeshipLength = voivodeship.Length;

        Console.WriteLine($"Nazwa miasta {city}zawiera {cityLength} liter. Nazwa województwa {voivodeship} zawiera {voivodeshipLength} liter.");
        Console.ReadKey();
    }
}