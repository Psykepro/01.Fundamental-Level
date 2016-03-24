using System;
using System.Collections.Generic;
using System.Linq;

internal class PCCatalog
{
    private static void Main()
    {
        List<Computer> Computers = new List<Computer>();
        List<Components> cheapComponents = new List<Components>();

        cheapComponents.Add(new Components("Video Card", 120));
        cheapComponents.Add(new Components("RAM", 90.50m, "8 GB"));
        cheapComponents.Add(new Components("HardD Drive", 100, "1000 GB"));

        List<Components> averageComponents = new List<Components>();

        averageComponents.Add(new Components("Motherboard", 100.80m));
        averageComponents.Add(new Components("RAM", 60));
        averageComponents.Add(new Components("Video Card", 200, "2 GB 256 bit"));

        List<Components> expensiveComponents = new List<Components>();

        expensiveComponents.Add(new Components("CPU", 350, "Quad Core 3,5 GHz"));
        expensiveComponents.Add(new Components("RAM", 200, "14 GB"));
        expensiveComponents.Add(new Components("Video Card", 500, "4 GB 512 bit"));
        
        Computer cheapComputer = new Computer("Cheap Computer", cheapComponents);
        Computers.Add(cheapComputer);
        Computer averageComputer = new Computer("Average Computer", averageComponents);
        Computers.Add(averageComputer);
        Computer expensiveComputer = new Computer("Expensive Computer", expensiveComponents);
        Computers.Add(expensiveComputer);
        var sortedCatalog = Computers.OrderByDescending(computer => computer.Price).Select(computer => computer);
        foreach (var computer in sortedCatalog)
        {
            Console.Write("{0}", computer);
            
        }


    }
}
