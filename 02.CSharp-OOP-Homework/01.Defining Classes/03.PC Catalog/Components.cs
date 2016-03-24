using System;

public class Components
{
    private string name;
    private decimal price;

    public Components(string name,decimal price,string details)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public Components(string name,decimal price):this(name,price,null)
    {        
    }

    public string Name
    {
        get { return this.name; }
        set
        {
        if(string.IsNullOrEmpty(value.Trim()))  
            throw new ArgumentException("Name","The name can't be null or empty!");
            this.name = value;
        } 
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0.0m) 
              throw new ArgumentOutOfRangeException("Price","The price can't be negative!");
            this.price = value;
        } 
    }

    public string Details { get; set; }
 
}
