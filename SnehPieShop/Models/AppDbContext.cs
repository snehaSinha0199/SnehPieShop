using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SnehPieShop.Models;

namespace SnehaPieShop.Models
{

    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }

       // public DbSet<Order> order { get; set; }


        public DbSet<Team> team { get; set; }

        //public DbSet<Cart> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 1, Name = "Sneha sinha", ShortDescription = "", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" });
            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 2, Name = "Vaibhav Bhatngara", ShortDescription = "Hard", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" });
            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 3, Name = "Subhash Gurjar", ShortDescription = "working", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg"});
            modelBuilder.Entity<Team>().HasData(new Team { TeamId = 4, Name = "Simran singh", ShortDescription = "Smart", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" });
            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "A pie is a baked dish which is usually made of a pastry dough casing that contains a filling of various sweet or savoury ingredients" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "Blueberry pie is a pie with a blueberry filling." });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies", Description = "On top of the seasonal chart and recipes the great post also offers up information on the different kinds of pies that can be made" });

            //seed pies
            
            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                LongDescription =
                    " The first apple pie recipe was printed over 630 years ago in England in 1381. The list of ingredients included good apples, good spices, figs, raisins, pears, saffron, and cofyn (a type of pastry crust). 10. Early English apple pies had no sugar because sugar was very expensive.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Blueberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Cheese Cake",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Cherry Pie",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "Christmas Apple Pie",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this pie!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 6,
                Name = "Cranberry Pie",
                Price = 17.95M,
                ShortDescription = "A Christmas favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 7,
                Name = "Peach Pie",
                Price = 15.95M,
                ShortDescription = "Sweet as peach",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 8,
                Name = "Pumpkin Pie",
                Price = 12.95M,
                ShortDescription = "Our Halloween favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 9,
                Name = "Rhubarb Pie",
                Price = 15.95M,
                ShortDescription = "My God, so sweet!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 10,
                Name = "Strawberry Pie",
                Price = 15.95M,
                ShortDescription = "Our delicious strawberry pie!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 11,
                Name = "Strawberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });



            //Seed order for the team
        /*    modelBuilder.Entity<Team>().HasData(new Team { ID = 1, Name = "Vaibhav Bhatnagar", Description = "A pie is a baked dish which is usually made of a pastry dough casing that contains a filling of various sweet or savoury ingredients", Img = "~/Image/vaibhav.jpg", Ph = 918918989189 });
            modelBuilder.Entity<Team>().HasData(new Team { ID = 2, Name = "Subhash Gurjar", Description = "Blueberry pie is a pie with a blueberry filling.", Img = "~/Image/subhash.jpg", Ph = 9302930209 });
            modelBuilder.Entity<Team>().HasData(new Team { ID = 3, Name = "Sneha Sinha", Description = "On top of the seasonal chart and recipes the great post also offers up information on the different kinds of pies that can be made", Img = "~/Image/sneha.jpg", Ph = 918918989189 });
            modelBuilder.Entity<Team>().HasData(new Team { ID = 4, Name = "Simran Singh", Description = "On top of the seasonal chart and recipes the great post also offers up information on the different kinds of pies that can be made", Img = "~/Image/simran.jpg", Ph = 918918989189 });
        */

        }
    }
}
