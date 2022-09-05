public class WorKClass{
    public static void Main (string[] args)
    {
        ABC feetToInchesConverter = new ABC(12);
        ABC mileTofeetConverter = new ABC(5280);

        Console.WriteLine("Feet to inches: {0}" , feetToInchesConverter.con(30));  
        Console.WriteLine("Miles to Feet : {0}",  feetToInchesConverter.con(1));   
        Console.WriteLine("Feet to Inches from miles: {0}", feetToInchesConverter.con(mileTofeetConverter.con(2)));
    }
}
