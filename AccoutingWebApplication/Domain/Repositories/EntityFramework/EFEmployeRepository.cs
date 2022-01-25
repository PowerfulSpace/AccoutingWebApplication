using AccoutingWebApplication.Domain;
using AccoutingWebApplication.Domain.Models;
using AccoutingWebApplication.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Repositories.EntityFramework
{
    public class EFEmployeRepository : IAllEmployes
    {
        private readonly AppDbContext _context;
        public EFEmployeRepository(AppDbContext context)
        {
            _context = context;
        }


        public IQueryable<Employe> AllEmployes() => _context.Employes;

        public Employe GetById(Guid id) => _context.Employes.FirstOrDefault(x => x.Id == id);


        public void AddEmploye(Employe employe)
        {
            if (employe.Id == default)
                _context.Entry(employe).State = EntityState.Added;
            else
                _context.Entry(employe).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoveEmploye(Guid id)
        {
            _context.Employes.Remove(new Employe() { Id = id });
            _context.SaveChanges();
        }

    }
}
