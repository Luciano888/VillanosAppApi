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
    public class CiudadanoService : ICiudadanoService
    {
        private readonly VillanoDbContext _VillanoDbContext;
        public IEnumerable<Ciudadano> GetAll()
        {
            var result = new List<Ciudadano>();

            try
            {
                result = _VillanoDbContext.Ciudadanos.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public Ciudadano Get(int id)
        {
            var result = new Ciudadano();

            try
            {
                result = _VillanoDbContext.Ciudadanos.Single(x => x.Id == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public bool Add(Ciudadano model)
        {
            try
            {
                _VillanoDbContext.Add(model);
                _VillanoDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return true;
        }

        public bool Update(Ciudadano model)
        {
            try
            {
                var originalModel = _VillanoDbContext.Ciudadanos.Single(x =>
                    x.Id == model.Id
                );

                originalModel.Nombre = model.Nombre;
                originalModel.Apellido = model.Apellido;
                originalModel.Domicilio = model.Domicilio;
                originalModel.Genero = model.Genero;
                originalModel.Identificacion = model.Identificacion;


                _VillanoDbContext.Update(originalModel);
                _VillanoDbContext.SaveChanges();
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
                _VillanoDbContext.Entry(new Ciudadano { Id = id }).State = EntityState.Deleted; ;
                _VillanoDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return true;
        }
    }
}
