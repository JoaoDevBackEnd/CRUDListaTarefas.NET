using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIListaTarefas.Data.Entity;

namespace WebAPIListaTarefas.Data.Database
{
    public class DataContext :DbContext
    {
         protected readonly IConfiguration configuration;
        public DataContext(IConfiguration config){
            configuration = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Datas> DataEntity {get;set;}
        public DbSet<ListTask> ListTaskEntity {get;set;}
        public DbSet<Tasks> TaskEntity {get;set;}
        public DbSet<Users> UsersEntity{get;set;}
    }
}