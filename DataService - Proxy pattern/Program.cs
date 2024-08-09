using DataService___Proxy_pattern.model;

class Program
{
    static void Main(string[] args)
    {
        IDataService dataService = new DataServiceProxy();

        //first call
        Console.WriteLine("First call:");
        string data1 = dataService.GetData();
        Console.WriteLine(data1);

        //second call this will returns cached data
        Console.WriteLine("\nSecond call:");
        string data2 = dataService.GetData();
        Console.WriteLine(data2);
    }
}