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
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DreamwareTZ.EntityModel.dreamContext context)
        {
            //Delete and Create Users
            var usersOld = context.Users.ToList();
            context.Users.RemoveRange(usersOld);
            context.SaveChanges();
            context.Users.AddRange(new List<User>()
             {
                 new User() {Login = "User1", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10)},
                 new User() {Login = "User2", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10)},
                 new User() {Login = "User3", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10)},
                 new User() {Login = "User4", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10)},
                 new User() {Login = "User5", Password = "User1", RegistrationDate = DateTime.Today, BirthDate = DateTime.Today.AddYears(-10)},
             });

            context.SaveChanges();

            //Delete and Create Admni
            var adminsOld = context.Admins.ToList();
            context.Admins.RemoveRange(adminsOld);
            context.SaveChanges();
            context.Admins.AddRange(new List<Admin>()
             {
                 new Admin() {Login = "Admin", Password = "Admin", Status = 1},
                 new Admin() {Login = "Admin2", Password = "Admin", Status = 2},
                 new Admin() {Login = "Admin3", Password = "Admin", Status = 3}

             });

            context.SaveChanges();
        }
    }
}
