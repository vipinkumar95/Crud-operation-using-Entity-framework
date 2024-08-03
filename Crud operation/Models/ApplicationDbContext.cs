using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_operation.Models
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Student> students {  get; set; }
    }
}