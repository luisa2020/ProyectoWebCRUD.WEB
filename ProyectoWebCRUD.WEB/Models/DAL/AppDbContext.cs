using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoWebCRUD.WEB.Models.Entities;

namespace ProyectoWebCRUD.WEB.Models.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }//es la tabla en la base de datos

    }
}
