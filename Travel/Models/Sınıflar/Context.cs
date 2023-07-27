using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Travel.Models.Sınıflar {
    public class Context: DbContext {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<İletisim> iletisims { get; set; }
        public DbSet<Yorumlar> yorumlars { get; set; }

    }
}




// tabloları veritabanına yansıtacagız