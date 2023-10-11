namespace Composition
{
  class Program


        //Inheritance -> Tightly coulped relationship between classes.
        //Compomsition -> Loosely coupled relationship between classes.
    {
        static void Main(string[] args) {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }
}