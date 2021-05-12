using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface ITareaService 
    {
        IEnumerable<Tarea> GetAll();
        bool Add(Tarea model);
        bool Delete(int id);
        bool Update(Tarea model);
        Tarea Get(int id);
    }
}
