using System;


internal class LaptopShop
{
    private static void Main()
    {
        Laptop Lenovo = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259.00m,
                "Lenovo",
                "13.3 inches (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display)",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                new Battery("Li-Ion", 4, 2550, 4.5));
        
        Console.WriteLine(Lenovo);
        Laptop MSI = new Laptop("MSI GT72 2QD DOMINATOR G", 2000.5m);
        Console.WriteLine(MSI);
        Laptop Alienware = new Laptop("Alienware 13", 949.99m,"Intel® Core™ i7 Processor");
        Console.WriteLine(Alienware);
    }
}