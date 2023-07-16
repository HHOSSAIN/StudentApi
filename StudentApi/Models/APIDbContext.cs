using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace StudentApi.Models
{
    //inherit the dbContext class from EF core to i)do establish a db connection,
    //ii)act as middleware between model and db table(mapping)
    public class APIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        //base(option) call is used to invoke the constructor of the base class (parent class, i.e. dbContext)
        //from within the constructor of the derived class (child class, i.e. APIDbContext)
        //By calling base(option), you ensure that the base class's constructor is executed before the derived class's
        //constructor, enabling proper initialization of the base class's state.
        //with the arg "DbConextOptions", we will specify the db provider we'll use & connection string to db...we can do this in program.cs
        public APIDbContext(DbContextOptions option) : base(option)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseCosmos(
                //"https://testcosmos101.documents.azure.com:443/", //"accountEndpoint" to connect to db,
                //"54hgftgpXU1gfggfgg1qxI8NNOj4CUrVquNDj1GkCmPiBBC5B9tqxLpcrJDoYlmnSHhgqlm1dh7abe0", //"accountKey" is primary key to perform read/write
                //"testdb" //"databaseName"
                //);

            optionsBuilder.UseSqlServer("Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
        }
    }
}
