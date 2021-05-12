using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface ICiudadanoService
    {
        IEnumerable<Ciudadano> GetAll();
        bool Add(Ciudadano model);
        bool Delete(int id);
        bool Update(Ciudadano model);
        Ciudadano Get(int id);
    }
}
