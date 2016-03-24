using System;
using System.Globalization;
using System.Threading;


internal class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private decimal price;

    public Laptop(string model,decimal price,string manufacturer,string processor,string ram,string graphicsCard,string hdd,string screen,Battery laptopBattery)
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.LaptopBattery = laptopBattery;
    }

    public Laptop(string model, decimal price):this(model,price,null,null,null,null,null,null,null)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, decimal price, string processor)
        : this(model, price, null, processor, null, null, null, null, null)
    {
        this.Model = model;
        this.Price = price;
        this.Processor = processor;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if(string.IsNullOrEmpty(value.Trim()))
                throw new ArgumentException("Model can't be null or empty!");
            this.model = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value<0.0m)
                throw new ArgumentOutOfRangeException("Price can't be negative!");
            this.price = value;
        } 
    }
    public string Manufacturer { get; set; }
    public string Processor { get; set; }
    public string RAM { get; set; }
    public string GraphicsCard { get; set; }
    public string HDD { get; set; }
    public string Screen { get; set; }
    public Battery LaptopBattery { get; set; }

    public override string ToString()
    {
        var information = string.Format("{0}", "Laptop Decription \r\n");

        information += string.Format("model : {0}\r\n", this.Model);
        if (!string.IsNullOrEmpty(this.Manufacturer))
        {
            information += string.Format("manufacturer : {0}\r\n", this.Manufacturer);
        }


        if (!string.IsNullOrEmpty(this.Processor))
        {
            information += string.Format("processor : {0}\r\n", this.Processor);
        }

        if (!string.IsNullOrEmpty(this.RAM))
        {
            information += string.Format("RAM : {0}\r\n", this.RAM);
        }
        if (!string.IsNullOrEmpty(this.GraphicsCard))
        {
            information += string.Format("graphics card : {0}\r\n", this.GraphicsCard);
        }
        if (!string.IsNullOrEmpty(this.HDD))
        {
            information += string.Format("HDD : {0}\r\n", this.HDD);
        }
        if (!string.IsNullOrEmpty(this.Screen))
        {
            information += string.Format("screen : {0}\r\n", this.Screen);
        }
        if (this.LaptopBattery != null)
        {
            information += string.Format("battery : {0}\r\n", this.LaptopBattery);
            information += string.Format("battery life : {0} hours\r\n", LaptopBattery.BatteryLife);
        }
        information += string.Format("price : {0:F2} lv.\r\n", this.Price);
        information += "\r\n";
        return information;
    }
}
