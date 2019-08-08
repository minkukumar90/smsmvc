using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace smsmvc.Models
{
    [Table("EmployeeDetails")]
    public class EmployeeDetailsModels
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }

    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeDetailsModels> employee { get; set; }

    }

}