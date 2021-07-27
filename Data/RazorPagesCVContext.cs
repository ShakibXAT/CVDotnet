using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CV.Models;

    public class RazorPagesCVContext : DbContext
    {
        public RazorPagesCVContext (DbContextOptions<RazorPagesCVContext> options)
            : base(options)
        {
        }

        public DbSet<CV.Models.CvModel> CvModel { get; set; }
    }
