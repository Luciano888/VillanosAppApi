using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class TareaService : ITareaService
    {
        private readonly VillanoDbContext _villanoDbContext;
        public TareaService(
        VillanoDbContext villanoDbContext
    )
        {
            _villanoDbContext = villanoDbContext;
        }
        public IEnumerable<Tarea> GetAll()
        {
            var result = new List<Tarea>();

            try
            {
                result = _villanoDbContext.Tareas.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public Tarea Get(int id)
        {
            var result = new Tarea();

            try
            {
                result = _villanoDbContext.Tareas.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public bool Add(Tarea model)
        {
            try
            {
                _villanoDbContext.Add(model);
                _villanoDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return true;
        }

        public bool Update(Tarea model)
        {
            try
            {
                var originalModel = _villanoDbContext.Tareas.Single(x =>
                    x.Id == model.Id
                );

                originalModel.DetalleTarea = model.DetalleTarea;


                _villanoDbContext.Update(originalModel);
                _villanoDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _villanoDbContext.Entry(new Tarea { Id = id }).State = EntityState.Deleted; ;
                _villanoDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return true;
        }
    }
}
