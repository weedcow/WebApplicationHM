using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationHM.DAL
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class HamyDataContext : DbContext
    {
        public HamyDataContext() : base("name=HamyDataContext")
            {
            }

        public DbSet<WebApplicationHM.Models.Post> Posts { get; set; }
    }
}