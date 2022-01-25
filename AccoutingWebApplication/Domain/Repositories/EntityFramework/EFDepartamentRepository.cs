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
    public class EFDepartamentRepository : IAllDepartaments
    {

        private readonly AppDbContext _context;
        public EFDepartamentRepository(AppDbContext context)
        {
            _context = context;
        }



        public IQueryable<Departament> AllDepartaments() => _context.Departaments;

        public Departament GetById(Guid id) => _context.Departaments.FirstOrDefault(x => x.Id == id);

        public void AddDepartament(Departament departament)
        {
            if (departament.Id == default)
                _context.Entry(departament).State = EntityState.Added;
            else
                _context.Entry(departament).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoveDepartament(Guid id)
        {
            _context.Departaments.Remove(new Departament() { Id = id });
            _context.SaveChanges();
        }


    }
}
