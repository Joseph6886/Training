using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCustomers.Models
{
    public class Customers
    {
        public int ID { get; set; }
        
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]


        public String Address { get; set; }
        public string FirstName { get; set; }
        public decimal Age{ get; set; }
        public string LastName { get; set; }

    }
    public class MovieDBContext : DbContext
    {

        public DbSet<Movie> Movies { get; set; }


    }


}