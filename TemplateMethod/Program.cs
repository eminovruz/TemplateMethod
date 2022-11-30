abstract public class HouseBuilder
{
    abstract public void BuildWalls(int wallCount);
    abstract public void BuildWindows();
    abstract public void BuildDam();

    public void CreatePool()
        { }

    public void CreateNewFloor()
        { }

    public void CreateCleverHomeSystem()
        { }
}

public class MainYasayisKompleksi : HouseBuilder
{
    public override void BuildDam()
    {
        Console.WriteLine($"Dam Created");
    }

    public override void BuildWalls(int wallCount)
    {
        Console.WriteLine($"{wallCount} walls created");
    }

    public override void BuildWindows()
    {
        Console.WriteLine($"Windows created");
    }

    public MainYasayisKompleksi()
    {
        BuildDam();
        BuildWalls(4);
        BuildWindows();
    }
}

public class SaglamHeyat : HouseBuilder
{
    public override void BuildDam()
    {
        Console.WriteLine($"Dam Created");
    }

    public override void BuildWalls(int wallCount)
    {
        Console.WriteLine($"{wallCount} walls created");
    }
    public override void BuildWindows()
    {
        Console.WriteLine($"Windows created");
    }

    public void CreatePool()
    {
        Console.WriteLine("Pool Created!");
    }

    public SaglamHeyat()
    {
        BuildDam();
        BuildWalls(4);
        BuildWindows();
        CreatePool();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SaglamHeyat house1 = new();
        Console.WriteLine("------- Main Yasayis Kompleksi ------");
        MainYasayisKompleksi house2 = new();
    }
}



