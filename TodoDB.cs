using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MinimalAPI
{
    public class TodoDB : DbContext
    {
        public TodoDB(DbContextOptions<TodoDB> options) : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}