namespace Crud.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Crud.Models.CrudContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Crud.Models.CrudContext";
        }

        protected override void Seed(Crud.Models.CrudContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact { Id = 1, Birthday = new DateTime(1920, 01, 20), City = "Chicago"
                                    , Email = "doc.mccoy@starfleet.com", FirstName = "DeForest", LastName = "Kelley"
                                    , State = "IL"
                                    , StreetAddress = "Sickbay"
                                    , UserId = new Guid("3f3e6193-1bcf-46a4-a590-61a56d7dd9f5")
                                    , ZipCode = "98765" } 
                , new Models.Contact { Id = 2, Birthday = new DateTime(1920, 03, 03), City = "New York"
                                    , Email = "i.beam.you.up@starfleet.com", FirstName = "James", LastName = "Doohan"
                                    , State = "NY"
                                    , StreetAddress = "Engineering"
                                    , UserId = new Guid("3f3e6193-1bcf-46a4-a590-61a56d7dd9f5")
                                    , ZipCode = "87654" }
                , new Models.Contact { Id = 3, Birthday = new DateTime(1931, 03, 26), City = "Los Angeles"
                                    , Email = "its.only.logic@starfleet.com", FirstName = "Leonard", LastName = "Nimoy"
                                    , State = "CA"
                                    , StreetAddress = "Science Station 1"
                                    , UserId = new Guid("3f3e6193-1bcf-46a4-a590-61a56d7dd9f5")
                                    , ZipCode = "76543-2109" }
                , new Models.Contact { Id = 4, Birthday = new DateTime(1931, 03, 22), City = "Riverside"
                                    , Email = "the.captain@starfleet.com", FirstName = "William", LastName = "Shatner"
                                    , State = "IA"
                                    , StreetAddress = "The Bridge"
                                    , UserId = new Guid("3f3e6193-1bcf-46a4-a590-61a56d7dd9f5")
                                    , ZipCode = "65432-0123" }
            );
        }
    }
}
