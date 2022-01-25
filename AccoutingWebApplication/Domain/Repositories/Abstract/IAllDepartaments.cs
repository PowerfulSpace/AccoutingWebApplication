using AccoutingWebApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Repositories.Abstract
{
    public interface IAllDepartaments
    {
        IQueryable<Departament> AllDepartaments();
        Departament GetById(Guid id);
        void AddDepartament(Departament departament);
        void RemoveDepartament(Guid id);
    }
}
