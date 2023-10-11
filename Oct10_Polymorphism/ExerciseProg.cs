public class DbConnection
{
    public DbConnection(string connectionString)
    {
        if(string.IsNullOrEmpty(connectionString) || string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentNullException("Connection Stirng cannnot be NULL or Empty");
        }
    }

    public TimeSpan timeout = TimeSpan.FromMinutes(2);

    public virtual void OpenConnetion()
    {

    } 
    public virtual void CloseConnetion()
    {

    }

}


public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {

    }

    public override void OpenConnetion()
    {
        Console.WriteLine("Connection established with SQL Database");
    }

    public override void CloseConnetion()
    {
        Console.WriteLine("SQL connection closed successfully");
    }

}

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {

    }

    public override void OpenConnetion()
    {
        Console.WriteLine("Connection established with Oracle Database");
    }

    public override void CloseConnetion()
    {
        Console.WriteLine("Oracle connection closed successfully");
    }

}


/*public class Program
{
    static void Main()
    {
        var sql = new SqlConnection("");
        sql.OpenConnetion();

        sql.CloseConnetion();
    }
} */