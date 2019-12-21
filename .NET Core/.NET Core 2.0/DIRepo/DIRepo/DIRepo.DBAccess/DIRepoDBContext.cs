using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace DIRepo
{
    public partial class DIRepoDBContext : DbContext
    {
        public DIRepoDBContext(DbContextOptions<DIRepoDBContext> options): base(options)
        {
        }
        public virtual DbSet<DIRepoEntities> DIRepoEntities { get; set; }
    }
}