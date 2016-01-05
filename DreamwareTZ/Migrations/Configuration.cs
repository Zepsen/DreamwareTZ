using System.Collections.Generic;

namespace DreamwareTZ.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DreamwareTZ.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DreamwareTZ.EntityModel.dreamContext>
    {
        public Configuration()
        {
            //!!Attention 
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DreamwareTZ.EntityModel.dreamContext context)
        {
            //Delete Admin and Users
            context.Users.ToList().ForEach(x => context.Users.Remove(x));
            context.Admins.ToList().ForEach(x => context.Admins.Remove(x));
            context.SaveChanges();
            
            //Create user
            context.Users.AddOrUpdate(
                 new User() { Login = "User1", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10) },
                 new User() { Login = "User2", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10) },
                 new User() { Login = "User3", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10) },
                 new User() { Login = "User4", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10) },
                 new User() { Login = "User5", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10) }
                );

            // Create Admin
            context.Admins.AddOrUpdate(
             
                 new Admin() {Login = "Admin", Password = "Admin", Status = 1},
                 new Admin() {Login = "Admin2", Password = "Admin", Status = 2},
                 new Admin() {Login = "Admin3", Password = "Admin", Status = 3}

             );

            context.SaveChanges();
        }
    }
}
