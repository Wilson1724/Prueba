using Microsoft.EntityFrameworkCore;
using ModeloPrueba.Entidades;

namespace ModeloDB
{
     public class PruebaDB: DbContext
    {
        public DbSet<staff> staffs { get; set; }
        public DbSet<store> stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=WILSON\\SQLEXPRESS; Initial Catalog=Prueba1 ;trusted_connection=true;");
        }
        //Configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Cardinalidad de store y staff 
            model.Entity<store>()
                .HasOne(storee => storee.staffstore)
                .WithOne(stafff => stafff.storestaff)
                .HasForeignKey<store>(storee => storee.manager_staff_id);
        }
        }
}
