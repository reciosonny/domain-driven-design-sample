using SampleWebApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleWebApp.Domain.Persistence {
    public class SampleContext : DbContext {

        public SampleContext() : base("name=SampleDbConnectionString") {

        }

        public DbSet<TblPermits> Permits { get; set; }
    }


}