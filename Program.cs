public class Program{
    static void main(string[] args){
        Car myCar = new Car();
        myCar.band = "Toyota";
        myCar.model = "Altis";
        myCar.numberOfDoors = 4;
        myCar.numberofWhell = 4;

        Car myCar1 = new Car();
        myCar1.band = "GTR";
        myCar1.model = "Nissan";
        myCar1.numberOfDoors = 1;
        myCar1.numberofWhell = 1;

        PrintCarInformation(myCar);
        PrintCarInformation(myCar1);

        DogDoor door = new DogDoor();
        door.Open();
        door.Close();
        Console.WriteLine("Door is open ? : {0}", door.IsOpen());

        
    }
    static void PrintCarInformation(Car car){
        Console.WriteLine("**************************");
        Console.WriteLine("Band; {0}", car.band);
        Console.WriteLine("Mode: {0}", car.model);
        Console.WriteLine("Number of the Door: {0}", car.numberOfDoors);
        Console.WriteLine("Number of the Wheels: {0}", car.numberofWhell);
        Console.WriteLine(car.MoveForward());
        Console.WriteLine(car.MoveBackward());
        Console.WriteLine(car.Turn());
        Console.WriteLine(car.Stop());
        Console.WriteLine("**************************");
    }
}
   
    