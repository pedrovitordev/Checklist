using CheckList.Models.CheckList;
using CheckList.Models.CheckListItem;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CheckListEntity> CheckList { get; set; }

        public DbSet<CheckListItemEntity> CheckListItem { get; set; }
        
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}