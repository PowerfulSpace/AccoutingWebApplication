using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Domain.Models
{
    public class Departament
    {
        public Departament() => DateAddedDepartament = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Имя")]
        public virtual string DepartamentName { get; set; }

        [Display(Name = "Добавление департамента")]
        public DateTime DateAddedDepartament { get; set; }

        [Display(Name = "Дата изменения информации департамента")]
        public DateTime DateChangeInformationDepartament { get; set; }

    }
}
