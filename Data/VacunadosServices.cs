using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_9.Data
{
    public class VacunadosServices
    {
        #region Private members
        private VacunadosDbContext dbContext;
        #endregion

        #region Constructor
        public VacunadosServices(VacunadosDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Vacunados>> GetVacunadosAsync()
        {
            return await dbContext.Vacunado.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="Vacunados"></param>
        /// <returns></returns>
        public async Task<Vacunados> AddVacunadosAsync(Vacunados Vacunado)
        {
            try
            {
                dbContext.Vacunado.Add(Vacunado);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Vacunado;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="Vacunados"></param>
        /// <returns></returns>
        public async Task<Vacunados> UpdateVacunadosAsync(Vacunados Vacunado)
        {
            try
            {
                var VacunadosExist = dbContext.Vacunado.FirstOrDefault(p => p.Id == Vacunado.Id);
                if (VacunadosExist != null)
                {
                    dbContext.Update(Vacunado);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Vacunado;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="Vacunados"></param>
        /// <returns></returns>
        public async Task DeleteVacunadosAsync(Vacunados Vacunado)
        {
            try
            {
                dbContext.Vacunado.Remove(Vacunado);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
