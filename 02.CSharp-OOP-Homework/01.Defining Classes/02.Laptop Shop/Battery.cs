using System;

internal class Battery
{
    private string type;
    private int cells;
    private int voltage;
    private double batteryLife;

    public Battery(string type,int cells,int voltage,double batteryLife)
    {
        this.BatteryType = type;
        this.Cells = cells;
        this.Voltage = voltage;
        this.BatteryLife = batteryLife;
    }
    public string BatteryType
    {
        get { return this.type; }
        set
        {
            if (string.IsNullOrEmpty(value.Trim()))
                throw new ArgumentException("The type information can't be null or empty!");
            this.type = value;
        }
    }

    public int Cells
    {
        get { return this.cells; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The cells can't be negative!");
            this.cells = value;
        }
    }

    public int Voltage
    {
        get { return this.voltage; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The voltage can't be negative!");
            this.voltage = value;
        }
    }

    public double BatteryLife
    {
        get { return this.batteryLife; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The battery life can't be negative!");
            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}-cells, {2} mAh", this.BatteryType, this.Cells, this.Voltage);
    }

}
