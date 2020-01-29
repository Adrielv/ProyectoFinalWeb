using Microsoft.EntityFrameworkCore;
using ProyectoFinalWeb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalWeb.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server = (local); Database = ProyectoFinalWebdb ; Trusted_Connection = True;");
        }
    }
}
