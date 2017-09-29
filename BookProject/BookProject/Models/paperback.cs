using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace BookProject.Models
{
    public class paperback
    {
        public int ID { get; set; }
        public int ISBNNumber { get; set; }
        public string Title { get; set; }
        public string Author{ get; set; }     
    }

    public class paperbackDBContext : DbContext
    {
        public DbSet<paperback> Paperback { get; set; }
    }
}