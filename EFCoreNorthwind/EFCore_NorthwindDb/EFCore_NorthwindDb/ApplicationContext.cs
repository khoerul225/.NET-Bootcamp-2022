using Microsoft.EntityFrameworkCore;

namespace EFCore_NorthwindDb
{
    public class ApplicationContext : DbContext ///inherit dari Microsoft entity frame

    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationContext()
        {

            
        }

    }
}