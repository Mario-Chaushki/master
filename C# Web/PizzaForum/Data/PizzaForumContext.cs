using PizzaForum.Models;

namespace PizzaForum.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PizzaForumContext : DbContext
    {
        // Your context has been configured to use a 'PizzaForumContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PizzaForum.Data.PizzaForumContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PizzaForumContext' 
        // connection string in the application configuration file.
        public PizzaForumContext()
            : base("PizzaForumContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}