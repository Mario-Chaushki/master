using SoftUniStore.Models;

namespace SoftUniStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SoftUniStoreContext : DbContext
    {
        // Your context has been configured to use a 'SoftUniStoreContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SoftUniStore.Data.SoftUniStoreContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SoftUniStoreContext' 
        // connection string in the application configuration file.
        public SoftUniStoreContext()
            : base("name=SoftUniStoreContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Game> Games { get; set; }

        public virtual DbSet<Login> Logins { get; set; }
    }
}