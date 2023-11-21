using Microsoft.EntityFrameworkCore;

namespace P2MABB.Server.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
