using AccoutingWebApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Repositories.Abstract
{
    public interface IAllEmployes
    {
        IQueryable<Employe> AllEmployes();
        Employe GetById(Guid id);
        void AddEmploye(Employe employe);
        void RemoveEmploye(Guid id);
    }
}
