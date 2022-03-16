using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Simple_Chat_API_Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Chat_API_Core.DbContexts
{
    public class AuthDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating (ModelBuilder builder) {

            base.OnModelCreating (builder);
            // Remove prefix AspNet of tables
            foreach (var entityType in builder.Model.GetEntityTypes ()) {
                var tableName = entityType.GetTableName ();
                if (tableName.StartsWith ("AspNet")) {
                    entityType.SetTableName (tableName.Substring (6));
                }
            }
        }
    }
}
