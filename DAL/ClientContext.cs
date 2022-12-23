using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
namespace DAL
{
   public class ClientContext : DbContext
    {
        public DbSet<Клиент> Клиент { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Строка подключения задается тут, а не в конструкторе, как как используется .net core
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-QBUR001L\SQLEXPRESS;Initial Catalog=operator;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
