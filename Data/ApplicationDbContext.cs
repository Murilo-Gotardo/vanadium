using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vanadium.Models;

namespace vanadium.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserViewModel> User { get; set; } = default!;

        public DbSet<BooksViewModel> Books { get; set; } = default!;

        public DbSet<TagsViewModel> Tags { get; set; } = default!;

        public DbSet<ErrorViewModel> Errors { get; set; } = default!;
    }
}