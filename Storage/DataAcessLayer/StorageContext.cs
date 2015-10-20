using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Storage.DataAcessLayer {
    public class StorageContext : DbContext     {

        public StorageContext() : base("DefaultConnection")
            {          }
        public System.Data.Entity.DbSet<Storage.Models.Product> Products { get; set; }
        }
}