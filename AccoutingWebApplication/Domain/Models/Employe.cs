using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccoutingWebApplication.Domain.Models
{
    public class Employe
    {

        public Employe() => DateEmployeeAdded = DateTime.UtcNow;


        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Имя")]
        public virtual string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public virtual string LastName { get; set; }

        [Display(Name = "Отчество")]
        public virtual string Surname { get; set; }

        [Display(Name = "Должность")]
        public virtual string Position { get; set; }


        [Display(Name = "Дата добавления сотрудника")]
        public DateTime DateEmployeeAdded { get; set; }

        [Display(Name = "Дата изменения сотрудника")]
        public DateTime DateChangeEmployee { get; set; }

        [Display(Name = "Дата приёма на работу сотрудника")]
        public DateTime EmploymentDate { get; set; }


        [Display(Name = "Департамент")]
        public virtual Departament Departament { get; set; }

    }
}
