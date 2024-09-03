using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sampleApplication.API.Model;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<ToDoTasks> sampleModel => Set<ToDoTasks>();
}
