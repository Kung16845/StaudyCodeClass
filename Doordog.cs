public class DogDoor{
    private bool open;

    public DogDoor(){
        this.open = false;
    }
    public void Open(){
        Console.WriteLine("The dog door is open");
        this.open = true;
    }
    public void Close(){
        Console.WriteLine("The dog door is close");
        this.open = false;
    }
    public bool IsOpen(){
        return this.open;
    }
    
}