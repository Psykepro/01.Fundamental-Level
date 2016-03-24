using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;


internal class Computer
{
    private List<Components> components;
    private string name;

    public Computer(string name,List<Components>components)
    {
        this.Name = name;
        this.Components = components;
    }
    public List<Components> Components
    {
        get { return this.components; }
        set
        {
            if(value.Count<0)
                throw new ArgumentOutOfRangeException("The computer must have atleast 1 component!");
            this.components = value;
        } 
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if(string.IsNullOrEmpty(value.Trim()))
                throw new ArgumentException("Computer.Name","The name can't be null or empty!");
            this.name = value;
        } 
    }

    public decimal Price { get { return CalculateComputerPrice(this); }}
    public void AddComponents(Components component)
    {
        Components.Add(component);
    }

    public static decimal CalculateComputerPrice(Computer computer)
    {
        var components = computer.Components;
        return components.Sum(component => component.Price);
    }

   
    public override string ToString()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        var information = new string('-', 50) + "\r\n";
        information += "COMPUTER DESCRIPTION\r\n";
        information += new string('-', 50) + "\r\n";
        information += "Name: " + this.Name + "\r\n";
        information += "Components:\r\n";

        information = this.Components.Aggregate(information, (current, component) =>
            current + string.Format("\t{0} {2} ({1:c2})\r\n", component.Name, component.Price, component.Details ?? ""));

        information += string.Format("Total price: {0:c2}\r\n", this.Price);
        information += new string('-', 50) + "\r\n";

        return information;
    }
}