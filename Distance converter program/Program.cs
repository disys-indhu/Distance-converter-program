using System;
abstract class DistanceConverter
{
    public abstract void Kilometer();

}
class KilometerConverter : DistanceConverter
{
    public override void Kilometer()
    {
        Console.WriteLine("Enter meters:");
        double meter = Convert.ToDouble(Console.ReadLine());
        double meterToKilometer = meter * 0.001;
        Console.WriteLine(meterToKilometer + " Kilometers");
        Console.WriteLine("Enter miles");
        double miles = Convert.ToDouble(Console.ReadLine());
        double milesToKilometer = miles * 1.609;
        Console.WriteLine(milesToKilometer + " Kilometers");
    }
}
class MilesConverter : KilometerConverter
{
    public void Miles()
    {
        Console.WriteLine("Enter meters:");
        double meter = Convert.ToDouble(Console.ReadLine());
        double meterToMiles = meter * 0.00062;
        Console.WriteLine(meterToMiles + " Miles");
        Console.WriteLine("Enter kilometers:");
        double kilometer = Convert.ToDouble(Console.ReadLine());
        double kilometerToMiles = kilometer * 0.621;
        Console.WriteLine(kilometerToMiles + " Miles");
    }
}
class MeterConverter : MilesConverter
{
    public void Meter()
    {
        Console.WriteLine("Enter kilometers:");
        double kilometer = Convert.ToDouble(Console.ReadLine());
        double kilometerToMeter = kilometer * 1000;
        Console.WriteLine(kilometerToMeter + " Meter");
        Console.WriteLine("Enter miles:");
        double miles = Convert.ToDouble(Console.ReadLine());
        double milesToMeter = miles * 1609.344;
        Console.WriteLine(milesToMeter + " Meter");
    }
}
class FinalConverter
{
    public static void Main(String[] args)
    {
        MeterConverter obj = new MeterConverter();
        int choice, ch;
        do
        {
            Console.WriteLine("Distance Converter");
            Console.WriteLine("1.Kilometer\n2.Miles\n3.Meter");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Kilometer();
                    break;
                case 2:
                    obj.Miles();
                    break;

                case 3:
                    obj.Meter();
                    break;

            }
            Console.WriteLine("Enter 0 to quit and 1 to continue:");
            ch = int.Parse(Console.ReadLine());
        } while (ch == 1);

    }
}



