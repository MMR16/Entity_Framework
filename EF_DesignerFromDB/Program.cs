using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DesignerFromDB
{
    class Program
    {
        static void Main(string[] args)
        {
            pubsEntities DB = new pubsEntities();

            // GetAll
            //var authors = DB.authors.ToList();
            //foreach (var item in authors)
            //{
            //    Console.WriteLine(item);
            //}

            //
            //var One = DB.authors.FirstOrDefault(w => w.au_id == "472-27-2349");
            //Console.WriteLine(One);

            //var CA_Authors = DB.authors.Where(w => w.state.ToLower() == "ut");
            //foreach (var item in CA_Authors)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //remove
            //  DB.authors.Remove(DB.authors.Single(w => w.au_id == "998-72-3567"));

            //update
            //var author = DB.authors.FirstOrDefault(w=>w.au_id== "893-72-1158");
            //author.au_lname = "Mostafa";

            //insert 

            var New = new author()
            {
                au_id = "111 - 11 - 1111",
                au_lname = "Rady",
                au_fname = "Mostafa",
                phone = "415 354-7128",
                address = "18 Broadway Av.",
                city = "Covelo",
                state = "CA",
                zip = "84152",
                contract = false
            };

            DB.authors.Add(New);
           DB.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
