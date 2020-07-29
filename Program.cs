using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBarDG.Data;
using APIBarDG.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace APIBarDG
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CreateHostBuilder(args).Build().Run();

            using (var db = new ItemContext())
            {
                //db.Add(new Item { ID = 1, Nome = "cerveja", Preco = 5.00 });
                //db.Add(new Item { ID = 2, Nome = "conhaque", Preco = 20.00 });
                //db.Add(new Item { ID = 3, Nome = "suco", Preco = 50.00 });
                //db.Add(new Item { ID = 4, Nome = "agua", Preco = 70.00 });
                //db.SaveChanges();

                var itens = db.Item
                  .OrderBy(b => b.ID)
                  .First();
            }


            using (var db = new ComandaContext())
            {
                //// Create
                //Console.WriteLine("Inserting a new blog");
              

                //// Read
                //Console.WriteLine("Querying for a blog");
                //var blog = db.Comanda
                //    .OrderBy(b => b.ID)
                //    .First();

                //// Update
                //Console.WriteLine("Updating the blog and adding a post");
                //blog.Url = "https://devblogs.microsoft.com/dotnet";
                //blog.Posts.Add(
                //    new Post
                //    {
                //        Title = "Hello World",
                //        Content = "I wrote an app using EF Core!"
                //    });
                //db.SaveChanges();

                //// Delete
                //Console.WriteLine("Delete the blog");
                //db.Remove(blog);
                //db.SaveChanges();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
