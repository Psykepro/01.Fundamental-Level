using System;

internal class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name,int age):this(name,age,null)
    {
    }

    public Person(string name,int age,string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {

                throw new ArgumentException("The name can't be null or empty!");
            }
            this.name=value;
        } 
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value > 100 || value < 1)
            throw new ArgumentOutOfRangeException("The age must be in range from 1 to 100!");
            this.age = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value == null)
            {
                this.email = "[no email]";
            }
            else if (value.Contains("@"))
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("The email must be null or non-empty string containing '@' !");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Name : {0} Age : {1} Email : {2}",Name,Age,Email);
    }
}
