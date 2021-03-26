using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Tarea_9.Data
{
    public class Vacunados
    {
        [Required(ErrorMessage = "Este campo es requerido...")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Teléfono { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string TipoDeSangre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Provincia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public double Latitud { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public double Longitud { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string COVID { get; set; }

        [Required(ErrorMessage = "Este campo es requerido...")]
        public string Justificacion { get; set; }

    }

    public class VacunadosDbContext : DbContext
    {
        #region Contructor
        public VacunadosDbContext(DbContextOptions<VacunadosDbContext> options)
                : base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<Vacunados> Vacunado { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vacunados>().HasData(GetVacunados());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Vacunados> GetVacunados()
        {
            return new List<Vacunados>
            {
            };
        }
        #endregion
    }

}
