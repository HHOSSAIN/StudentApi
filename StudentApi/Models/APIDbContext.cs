using Microsoft.EntityFrameworkCore;

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
    }
}
