namespace Domain
{
    public class DatabaseOptions
    {
#if DEBUG
        public const string DatabaseConnectionString = @"Data Source=DESKTOP-7I0RAPV;Initial Catalog=PostMaker;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";
#endif  
#if RELEASE
        public const string DatabaseConnectionString = @"Server=tcp:padti.database.windows.net,1433;Initial Catalog=PostMaker;Persist Security Info=False;User ID=pad;Password=utm.lab3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
#endif 

    }
}
