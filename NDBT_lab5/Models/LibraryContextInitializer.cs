using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NDBT_lab5.Models
{
    public class LibraryContextInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            context.Titles.Add(
                new Title
                {
                    Name = "Patterns of Enterprise Application Architecture",
                    Author = "Martin Fowler",
                    Shelf = new Shelf
                    {
                        Site = "Glasgow Caledonian University",
                        Code = "C1234"
                    },
                    Copies = new List<Copy>{
                        new Copy{
                            PurchaseDate = new DateTime(2010,12,21),
                            IsAvailable = false,
                        },
                         new Copy{
                            PurchaseDate = new DateTime(2011,2,5),
                            IsAvailable = true,
                        },
                         new Copy{
                            PurchaseDate = new DateTime(2012,4,17),
                            IsAvailable = true,
                        }
                    }
                });

            context.Titles.Add(
                new Title
                {
                    Name = "Domain-driven Design: Tackling Complexity in the Heart of Software",
                    Author = "Eric Evans",
                    Shelf = new Shelf
                    {
                        Site = "Strathclyde University",
                        Code = "D5678"
                    },
                    Copies = new List<Copy>{
                        new Copy{
                            PurchaseDate = new DateTime(2004,10,15),
                            IsAvailable = false,
                        },
                         new Copy{
                            PurchaseDate = new DateTime(2007,6,25),
                            IsAvailable = true,
                        }
                    }
                });


            context.SaveChanges();

        }
    }
}