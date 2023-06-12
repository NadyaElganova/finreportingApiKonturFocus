using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinReportsandAnalitics.Models;



namespace FinReportsandAnalitics.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet <FinResultReport> FinResultReports { get; set; }   
        public DbSet<BalanceRepot> BalanceRepots { get; set; }  
        public DbSet <GuidForReportLines> GuidForReports { get; set; }

       
    }


}

   


    

