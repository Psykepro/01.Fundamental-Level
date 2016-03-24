namespace Template
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    /// <summary>
    /// MainApp startup class for Real-World 
    /// Template Design Pattern.
    /// </summary>
    internal class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        private static void Main()
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    internal abstract class DataAccessObject
    {
        protected string connectionString;

        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app
            this.connectionString = "provider=Microsoft.JET.OLEDB.4.0; " + "data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();

        public abstract void Process();

        public virtual void Disconnect()
        {
            this.connectionString = string.Empty;
        }

        // The 'Template Method' 
        public void Run()
        {
            this.Connect();
            this.Select();
            this.Process();
            this.Disconnect();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    internal class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, this.connectionString);

            this.dataSet = new DataSet();
            dataAdapter.Fill(this.dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = this.dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }

            Console.WriteLine();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    internal class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, this.connectionString);

            this.dataSet = new DataSet();
            dataAdapter.Fill(this.dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = this.dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }

            Console.WriteLine();
        }
    }
}