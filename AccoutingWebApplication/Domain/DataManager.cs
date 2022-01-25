using AccoutingWebApplication.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Domain
{
    public class DataManager
    {
        public IAllEmployes Employes { get; set; }
        public IAllDepartaments Departaments { get; set; }

        public DataManager(IAllEmployes Employes, IAllDepartaments Departaments)
        {
            this.Employes = Employes;
            this.Departaments = Departaments;
        }
    }
}
