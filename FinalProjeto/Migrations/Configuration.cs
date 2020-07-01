namespace FinalProjeto.Migrations
{
    using FinalProjeto.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalProjeto.Persistance.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalProjeto.Persistance.ApplicationDbContext context)
        {
            #region SEED MOVIES SYSTEM


            //=================Seeding Movies=================
            //Movie template = new Movie() { Title = "", Duration = 0, PhotoUrl = "", Price = 0, ProductionYear = new DateTime(1, 1, 1), Rating = 0D, TrailerUrl = "", Watched = false ,Country=Country.United_States_of_America};

            Movie m1 = new Movie() { Title = "Titanic", Duration = 194, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 9.8, ProductionYear = new DateTime(1997, 1, 1), Rating = 7.8D, TrailerUrl = "https://www.youtube.com/watch?v=b0KYvGa_nN8", Watched = false, Country = Country.United_States_of_America };
            Movie m2 = new Movie() { Title = "Inception", Duration = 148, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 16, ProductionYear = new DateTime(2010, 1, 1), Rating = 8.8D, TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0", Watched = false, Country = Country.United_States_of_America };
            Movie m3 = new Movie() { Title = "Once Upon a Time... in Hollywood", Duration = 161, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 7.7, ProductionYear = new DateTime(2019, 1, 1), Rating = 7.7D, TrailerUrl = "https://www.youtube.com/watch?v=ELeMaP8EPAA", Watched = false, Country = Country.United_States_of_America };
            Movie m4 = new Movie() { Title = "Avatar", Duration = 162, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTYwOTEwNjAzMl5BMl5BanBnXkFtZTcwODc5MTUwMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 13.5, ProductionYear = new DateTime(2009, 1, 1), Rating = 7.8D, TrailerUrl = "https://www.youtube.com/watch?v=6ziBFh3V1aM", Watched = false, Country = Country.United_States_of_America };

            Movie m5 = new Movie() { Title = "The Abyss", Duration = 171, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BYWMzMDNlMDQtMTYyYi00OTM3LTllZDYtYThhMTk5MzNhZTRhXkEyXkFqcGdeQXVyMDUyOTUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 13, ProductionYear = new DateTime(1989, 1, 1), Rating = 7.6D, TrailerUrl = "https://www.youtube.com/watch?v=4zbpL3LeW7k", Watched = false, Country = Country.United_States_of_America };

            Movie m6 = new Movie() { Title = "The Rock", Duration = 136, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZDJjOTE0N2EtMmRlZS00NzU0LWE0ZWQtM2Q3MWMxNjcwZjBhXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 13, ProductionYear = new DateTime(1996, 1, 1), Rating = 7.6D, TrailerUrl = "https://www.youtube.com/watch?v=313n0wga2xo", Watched = false, Country = Country.United_States_of_America };
            Movie m7 = new Movie() { Title = "Der Name der Rose", Duration = 170, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZjEyZTdhNDMtMWFkMS00ZmRjLWEyNmEtZDU3MWFkNDEzMDYwXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 18, ProductionYear = new DateTime(1986, 1, 1), Rating = 7.6D, TrailerUrl = "https://www.youtube.com/watch?v=wrWpJkWPVNI", Watched = false, Country = Country.United_States_of_America };
            Movie m8 = new Movie() { Title = "Snowden", Duration = 134, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg2MzYzNzgzOF5BMl5BanBnXkFtZTgwOTg4NzQ4OTE@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 10, ProductionYear = new DateTime(2016, 1, 1), Rating = 7.3D, TrailerUrl = "https://www.youtube.com/watch?v=QlSAiI3xMh4", Watched = false, Country = Country.United_States_of_America };
            Movie m9 = new Movie() { Title = "Season of the Witch", Duration = 95, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMzc3MjYxNzg2N15BMl5BanBnXkFtZTcwNzQyMTkwNA@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 9, ProductionYear = new DateTime(2011, 1, 1), Rating = 5.4D, TrailerUrl = "https://www.youtube.com/watch?v=PE6QUf1b-Xw", Watched = false, Country = Country.United_States_of_America };
            Movie m10 = new Movie() { Title = "The Wicker Man", Duration = 102, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOGQwN2UyM2YtNzNhOC00YjU5LWI0ZDgtZjMxZjM5ZmI0YjRmXkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UY268_CR1,0,182,268_AL_.jpg", Price = 8, ProductionYear = new DateTime(2006, 1, 1), Rating = 3.7D, TrailerUrl = "https://www.youtube.com/watch?v=QITzuunu-SU", Watched = false, Country = Country.United_States_of_America };
            Movie m11 = new Movie() { Title = "Captain Corelli's Mandolin", Duration = 131, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjEwMzE5ODcyMF5BMl5BanBnXkFtZTcwODQ1NjEyMQ@@._V1_UY268_CR1,0,182,268_AL_.jpg", Price = 7, ProductionYear = new DateTime(2001, 1, 1), Rating = 5.9D, TrailerUrl = "https://www.youtube.com/watch?v=xjjGrxipPGQ", Watched = false, Country = Country.United_States_of_America };
            Movie m12 = new Movie() { Title = "Pirates of the Caribbean: On Stranger Tides", Duration = 136, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 5, ProductionYear = new DateTime(2011, 1, 1), Rating = 6.6D, TrailerUrl = "https://www.youtube.com/watch?v=0BXCVe8Yww4", Watched = false, Country = Country.United_States_of_America };
            //TELIOMENA




            Movie m13 = new Movie() { Title = "Fantastic Beasts and Where to Find Them", Duration = 174, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BYWVlMDI5N2UtZTIyMC00NjZkLWI5Y2QtODM5NGE5MzA0NmVjXkEyXkFqcGdeQXVyNzU3NjUxMzE@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 12, ProductionYear = new DateTime(2018, 1, 1), Rating = 6.6D, TrailerUrl = "https://www.youtube.com/watch?v=vvFybpmyB9E", Watched = false, Country = Country.United_States_of_America };
            Movie m14 = new Movie() { Title = "Into the Woods", Duration = 165, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY4MzQ4OTY3NF5BMl5BanBnXkFtZTgwNjM5MDI3MjE@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 11, ProductionYear = new DateTime(2014, 1, 1), Rating = 5.9D, TrailerUrl = "https://www.youtube.com/watch?v=7pjy5MK1X70", Watched = false, Country = Country.United_States_of_America };
            Movie m15 = new Movie() { Title = "Tusk", Duration = 102, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNmQyMmUzMmYtMTA4OS00ZmRjLWE0NWYtNjc0ZGM0N2E4YzQ5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 6, ProductionYear = new DateTime(2014, 1, 1), Rating = 5.3D, TrailerUrl = "https://www.youtube.com/watch?v=BCQJnOn0ru0", Watched = false, Country = Country.United_States_of_America };
            Movie m16 = new Movie() { Title = "The Tourist", Duration = 103, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTMyMzc3OTkwMV5BMl5BanBnXkFtZTcwMjc0MTgwNA@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 8, ProductionYear = new DateTime(2010, 1, 1), Rating = 6.0D, TrailerUrl = "https://www.youtube.com/watch?v=5XtbLezJtMg", Watched = false, Country = Country.United_States_of_America };
            Movie m17 = new Movie() { Title = "Sweeney Todd: The Demon Barber of Fleet Street", Duration = 116, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg3NjUxMzM5NV5BMl5BanBnXkFtZTcwMzQ1NjQzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 9.5, ProductionYear = new DateTime(2007, 1, 1), Rating = 7.3D, TrailerUrl = "https://www.youtube.com/watch?v=_4R72KROZ20", Watched = false, Country = Country.United_States_of_America };
            Movie m18 = new Movie() { Title = "Edward Scissorhands", Duration = 105, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNDUxN2I5NDUtZjdlMC00NjlmLTg0OTQtNjk0NjAxZjFmZTUzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 12.5, ProductionYear = new DateTime(1990, 1, 1), Rating = 7.9D, TrailerUrl = "https://www.youtube.com/watch?v=TBHIO60whNw", Watched = false, Country = Country.United_States_of_America };
            Movie m19 = new Movie() { Title = "Maleficent", Duration = 119, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZjJiYTExOTAtNWU0Yi00NzJjLTkwOTgtOTU2NWM1ZjJmYWVhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 11.5, ProductionYear = new DateTime(2019, 1, 1), Rating = 6.7D, TrailerUrl = "https://www.youtube.com/watch?v=n0OFH4xpPr4", Watched = false, Country = Country.United_States_of_America };
            Movie m20 = new Movie() { Title = "Girl, Interrupted", Duration = 127, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNzdjZDYwM2QtMGNlZS00MGQzLTlhMjctYTU4NWI5MWJlYmQwXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 10.5, ProductionYear = new DateTime(1999, 1, 1), Rating = 7.3D, TrailerUrl = "https://www.youtube.com/watch?v=5BHHUBZf7y4", Watched = false, Country = Country.United_States_of_America };
            Movie m21 = new Movie() { Title = "Changeling", Duration = 141, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTA1Mzg3NjIxNV5BMl5BanBnXkFtZTcwNzU2NTc5MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 8.5, ProductionYear = new DateTime(2008, 1, 1), Rating = 7.7D, TrailerUrl = "https://www.youtube.com/watch?v=PmfjureC-5I", Watched = false, Country = Country.United_States_of_America };
            Movie m100 = new Movie() { Title = "Salt", Duration = 100, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjIyODA2NDg4NV5BMl5BanBnXkFtZTcwMjg4NDAwMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 11, ProductionYear = new DateTime(2010, 1, 1), Rating = 6.4D, TrailerUrl = "https://www.youtube.com/watch?v=QZ40WlshNwU", Watched = false, Country = Country.United_States_of_America };
            Movie m22 = new Movie() { Title = "Les Misérables", Duration = 158, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQ4NDI3NDg4M15BMl5BanBnXkFtZTcwMjY5OTI1OA@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 12, ProductionYear = new DateTime(2012, 1, 1), Rating = 7.6D, TrailerUrl = "https://www.youtube.com/watch?v=YmvHzCLP6ug", Watched = false, Country = Country.United_States_of_America };
            Movie m23 = new Movie() { Title = "The Danish Girl", Duration = 119, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjA0NjA4NjE2Nl5BMl5BanBnXkFtZTgwNzIxNTY2NjE@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 14, ProductionYear = new DateTime(2015, 1, 1), Rating = 7.1D, TrailerUrl = "https://www.youtube.com/watch?v=d88APYIGkjk", Watched = false, Country = Country.United_States_of_America };
            //TELIOMENA


            Movie m24 = new Movie() { Title = "The Theory of Everything", Duration = 163, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTAwMTU4MDA3NDNeQTJeQWpwZ15BbWU4MDk4NTMxNTIx._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 16.5, ProductionYear = new DateTime(2014, 1, 1), Rating = 7.7D, TrailerUrl = "https://www.youtube.com/watch?v=Salz7uGp72c", Watched = false, Country = Country.United_States_of_America };
            Movie m25 = new Movie() { Title = "On the Waterfront", Duration = 108, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BY2I0MWFiZDMtNWQyYy00Njk5LTk3MDktZjZjNTNmZmVkYjkxXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 18.5, ProductionYear = new DateTime(1954, 1, 1), Rating = 8.1D, TrailerUrl = "https://www.youtube.com/watch?v=QOLHbQjtSFs", Watched = false, Country = Country.United_States_of_America };
            Movie m26 = new Movie() { Title = "East of Eden", Duration = 118, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTYzNjI3MWUtZjg3Yi00ZDBkLWIwM2YtYmUyZGZjN2RiZjI5XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 13.5, ProductionYear = new DateTime(1955, 1, 1), Rating = 7.9D, TrailerUrl = "https://www.youtube.com/watch?v=IqVoIQ5UsT8", Watched = false, Country = Country.United_States_of_America };
            Movie m27 = new Movie() { Title = "Rebel Without a Cause", Duration = 111, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjMwNWIwYzAtMWVhZi00YzQ2LTlmNGYtOTg3NDdkNTRjOWI2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 12.5, ProductionYear = new DateTime(1955, 1, 1), Rating = 7.7D, TrailerUrl = "https://www.youtube.com/watch?v=wXRgAXU1-T4", Watched = false, Country = Country.United_States_of_America };
            Movie m28 = new Movie() { Title = "Breakfast at Tiffany's", Duration = 105, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNGEwMTRmZTQtMDY4Ni00MTliLTk5ZmMtOWMxYWMyMTllMDg0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 11.5, ProductionYear = new DateTime(1961, 1, 1), Rating = 7.7D, TrailerUrl = "https://www.youtube.com/watch?v=-XcLVQCDtbM", Watched = false, Country = Country.United_States_of_America };
            Movie m29 = new Movie() { Title = "Charade", Duration = 18, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTA0Y2UyMDUtZGZiOS00ZmVkLTg3NmItODQyNTY1ZjU1MWE4L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 7, ProductionYear = new DateTime(1963, 1, 1), Rating = 7.9D, TrailerUrl = "https://www.youtube.com/watch?v=C6T2Q4XO7uA", Watched = false, Country = Country.United_States_of_America };
            Movie m30 = new Movie() { Title = "Being There", Duration = 110, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BY2JkZTcxYjEtNmUwNi00MjIzLWE1YjUtMDYzNWJjYWQwMzA5XkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 6, ProductionYear = new DateTime(1979, 1, 1), Rating = 8.0D, TrailerUrl = "https://www.youtube.com/watch?v=oOOghKacg40", Watched = false, Country = Country.United_States_of_America };
            Movie m31 = new Movie() { Title = "The Pink Panther Strikes Again", Duration = 103, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZjhiNDU3NDEtNzFlMC00NTU2LThlMGMtNTA1ODJkNjIxN2RjXkEyXkFqcGdeQXVyMjI4MjA5MzA@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 9, ProductionYear = new DateTime(1976, 1, 1), Rating = 7.2D, TrailerUrl = "https://www.youtube.com/watch?v=VVnX-cPXpFA", Watched = false, Country = Country.United_States_of_America };
            Movie m32 = new Movie() { Title = "Sissi", Duration = 102, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjdhNTBjMmMtZmVlNi00NWRhLWEwNjItM2ZjYzkzMzhhNDZhXkEyXkFqcGdeQXVyNDE5MTU2MDE@._V1_UY268_CR1,0,182,268_AL_.jpg", Price = 3.5, ProductionYear = new DateTime(1955, 1, 1), Rating = 7.0D, TrailerUrl = "https://www.youtube.com/watch?v=G2irBCrSakE", Watched = false, Country = Country.United_States_of_America };
            Movie m33 = new Movie() { Title = "The Naked Gun: From the Files of Police Squad!", Duration = 85, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BODk1ZWM4ZjItMjFhZi00MDMxLTgxNmYtODFhNWZlZTkwM2UwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 3.4, ProductionYear = new DateTime(1988, 1, 1), Rating = 7.6D, TrailerUrl = "https://www.youtube.com/watch?v=PACTQutbow4", Watched = false, Country = Country.United_States_of_America };
            Movie m34 = new Movie() { Title = "8 Mile", Duration = 110, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOWI3MDIzZmYtN2Y3MC00YTljLWFiYmYtNWIzMjg1ZWQ1ODlhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 7.1, ProductionYear = new DateTime(2002, 1, 1), Rating = 7.6D, TrailerUrl = "https://www.youtube.com/watch?v=axGVrfwm9L4", Watched = false, Country = Country.United_States_of_America };
            Movie m35 = new Movie() { Title = "Running Scared", Duration = 122, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTIwOTAzMDc4MF5BMl5BanBnXkFtZTcwNjY5MzIzMQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", Price = 9.5, ProductionYear = new DateTime(2006, 1, 1), Rating = 7.4D, TrailerUrl = "https://www.youtube.com/watch?v=D8mGXIb1Nog", Watched = false, Country = Country.United_States_of_America };
            Movie m36 = new Movie() { Title = "Rear Window", Duration = 112, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY268_CR0,0,182,268_AL_.jpg", Price = 12, ProductionYear = new DateTime(1954, 1, 1), Rating = 8.4D, TrailerUrl = "https://www.youtube.com/watch?v=m01YktiEZCw", Watched = false, Country = Country.United_States_of_America };
            //TELIOMENA


            //=================Seeding Actors=================
            Actor a1 = new Actor() { FirstName = "Leonardo", LastName = "DiCaprio", Email = "LeonardoDiCaprio@gmail.com", DateOfBirth = new DateTime(1974, 11, 11), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY317_CR10,0,214,317_AL_.jpg", Salary = 50000000, Telephone = "691-52-13-212", Country = Country.United_States_of_America };
            a1.Movies = new List<Movie>() { m1, m2, m3 };
            Actor a2 = new Actor() { FirstName = "Kate", LastName = "Winslet", Email = "KateWinslet@gmail.com", DateOfBirth = new DateTime(1975, 10, 05), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BODgzMzM2NTE0Ml5BMl5BanBnXkFtZTcwMTcyMTkyOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 45000000, Telephone = "694-56-54-653", Country = Country.United_Kingdom };
            a2.Movies = new List<Movie>() { m1 };
            Actor a3 = new Actor() { FirstName = "Billy", LastName = "Zane", Email = "BillyZane@gmail.com", DateOfBirth = new DateTime(1966, 2, 24), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI5NzA2NTE0NF5BMl5BanBnXkFtZTcwNzAxMTUxMw@@._V1_UY317_CR15,0,214,317_AL_.jpg", Salary = 40000000, Telephone = "694-56-45-644", Country = Country.United_States_of_America };
            a3.Movies = new List<Movie>() { m1 };
            Actor a4 = new Actor() { FirstName = "Brad", LastName = "Pitt", Email = "BradPitt@gmail.com", DateOfBirth = new DateTime(1963, 12, 18), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjA1MjE2MTQ2MV5BMl5BanBnXkFtZTcwMjE5MDY0Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 30000000, Telephone = "695-34-54-656", Country = Country.United_States_of_America };
            a4.Movies = new List<Movie>() { m3 };
            Actor a5 = new Actor() { FirstName = "Margot", LastName = "Robbie", Email = "MargotRobbie@gmail.com", DateOfBirth = new DateTime(1990, 7, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTgxNDcwMzU2Nl5BMl5BanBnXkFtZTcwNDc4NzkzOQ@@._V1_UY317_CR12,0,214,317_AL_.jpg", Salary = 20000000, Telephone = "696-34-34-456", Country = Country.Australia };
            a5.Movies = new List<Movie>() { m3 };
            Actor a6 = new Actor() { FirstName = "Joseph", LastName = "Gordon-Levitt", Email = "JosephGordonLevitt@gmail.com", DateOfBirth = new DateTime(1981, 2, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZTk5ZGQ0OGQtYWYwMy00ZTE1LWE0NWUtMTQ2MmYxMWUxZWM3XkEyXkFqcGdeQXVyMjAyNzk2Nw@@._V1_UY317_CR6,0,214,317_AL_.jpg", Salary = 50000000, Telephone = "694-54-54-856", Country = Country.United_States_of_America };
            a6.Movies = new List<Movie>() { m2, m8 };
            Actor a7 = new Actor() { FirstName = "Ellen", LastName = "Page", Email = "EllenPage@gmail.com", DateOfBirth = new DateTime(1987, 2, 21), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTU3MzM3MDYzMV5BMl5BanBnXkFtZTcwNzk1Mzc3NA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 10000000, Telephone = "691-23-54-456", Country = Country.Canada };
            a7.Movies = new List<Movie>() { m2 };
            Actor a8 = new Actor() { FirstName = "Sam", LastName = "Worthington", Email = "SamWorthington@gmail.com", DateOfBirth = new DateTime(1976, 8, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTc5NTMyMjIwMV5BMl5BanBnXkFtZTcwNTMyNjYwMw@@._V1_UY317_CR6,0,214,317_AL_.jpg", Salary = 500000, Telephone = "693-46-36-75", Country = Country.United_Kingdom };
            a8.Movies = new List<Movie>() { m4 };
            Actor a9 = new Actor() { FirstName = "Zoe", LastName = "Saldana", Email = "ZoeSaldana@gmail.com", DateOfBirth = new DateTime(1978, 6, 19), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM2MjIwOTc0Nl5BMl5BanBnXkFtZTcwNzQ5ODM1Mw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 50000000, Telephone = "691-46-36-257", Country = Country.United_States_of_America };
            a9.Movies = new List<Movie>() { m4 };
            Actor a10 = new Actor() { FirstName = "Sigourney", LastName = "Weaver", Email = "SigourneyWeaver@gmail.com", DateOfBirth = new DateTime(1949, 10, 8), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTk1MTcyNTE3OV5BMl5BanBnXkFtZTcwMTA0MTMyMw@@._V1_UY317_CR12,0,214,317_AL_.jpg", Salary = 4000000, Telephone = "694-64-34-456", Country = Country.United_States_of_America };
            a10.Movies = new List<Movie>() { m4 };

            Actor a11 = new Actor() { FirstName = "Ed", LastName = "Harris", Email = "EdHarris@gmail.com", DateOfBirth = new DateTime(1950, 11, 28), DateOfDeath = null, PhotoUrl = "", Salary = 400000, Telephone = "695-21-65-652", Country = Country.United_States_of_America };
            a11.Movies = new List<Movie>() { m5, m6 };
            Actor a12 = new Actor() { FirstName = "Michael", LastName = "Biehn", Email = "MichaelBiehn@gmail.com", DateOfBirth = new DateTime(1956, 6, 30), DateOfDeath = null, PhotoUrl = "", Salary = 500000, Telephone = "695-21-65-344", Country = Country.United_States_of_America };
            a12.Movies = new List<Movie>() { m5 };
            Actor a13 = new Actor() { FirstName = "Mary", LastName = "Mastrantonio", Email = "Mastrantonio@gmail.com", DateOfBirth = new DateTime(1958, 11, 17), DateOfDeath = null, PhotoUrl = "", Salary = 456000, Telephone = "699-54-37-757", Country = Country.United_States_of_America };
            a13.Movies = new List<Movie>() { m5 };




            Actor a14 = new Actor() { FirstName = "Sean", LastName = "Connery", Email = "Connery@gmail.com", DateOfBirth = new DateTime(1930, 8, 25), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMzcwNTM4MzctYjQzMi00NTA2LTljYWItNTYzNmE1MTYxN2RlXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UY317_CR16,0,214,317_AL_.jpg", Salary = 356000, Telephone = "695-56-26-122", Country = Country.United_Kingdom };
            a14.Movies = new List<Movie>() { m6, m7 };

            Actor a15 = new Actor() { FirstName = "Nicolas", LastName = "Cage", Email = "Cage@gmail.com", DateOfBirth = new DateTime(1964, 1, 7), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjUxMjE4MTQxMF5BMl5BanBnXkFtZTcwNzc2MDM1NA@@._V1_UY317_CR9,0,214,317_AL_.jpg", Salary = 2565000, Telephone = "695-56-26-123", Country = Country.United_States_of_America };
            a15.Movies = new List<Movie>() { m6, m9, m10, m11 };


            Actor a17 = new Actor() { FirstName = "Christian", LastName = "Slater", Email = "Slater@gmail.com", DateOfBirth = new DateTime(1969, 8, 18), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY5ODA1ODY2Nl5BMl5BanBnXkFtZTgwNjcwNDczNzE@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 256000, Telephone = "695-56-26-123", Country = Country.United_States_of_America };
            a17.Movies = new List<Movie>() { m7 };



            Actor a18 = new Actor() { FirstName = "Helmut", LastName = "Qualtinger", Email = "Qualtinger@gmail.com", DateOfBirth = new DateTime(1928, 10, 8), DateOfDeath = new DateTime(1986, 9, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZGY5ZDI4YzEtYmViOS00YmY4LTk2OWQtN2I5OGU0NTdhNDk5XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_UY317_CR162,0,214,317_AL_.jpg", Salary = 2346000, Telephone = "695-56-16-123", Country = Country.Austria };
            a18.Movies = new List<Movie>() { m7 };








            Actor a20 = new Actor() { FirstName = "Shailene", LastName = "Woodley", Email = "Woodley@gmail.com", DateOfBirth = new DateTime(1991, 11, 15), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTIxNTE2NTQ3Nl5BMl5BanBnXkFtZTcwMzMwOTk2Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 146000, Telephone = "695-56-16-432", Country = Country.United_States_of_America };
            a20.Movies = new List<Movie>() { m8 };
            Actor a21 = new Actor() { FirstName = "Melissa", LastName = "Leo", Email = "MelissaLeo@gmail.com", DateOfBirth = new DateTime(1960, 9, 14), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTc3MDAxOTkyOF5BMl5BanBnXkFtZTcwOTg1MDIzNA@@._V1_UY317_CR8,0,214,317_AL_.jpg", Salary = 4567000, Telephone = "695-43-16-432", Country = Country.United_States_of_America };
            a21.Movies = new List<Movie>() { m8 };






            Actor a22 = new Actor() { FirstName = "Ron", LastName = "Perlman", Email = "Perlman@gmail.com", DateOfBirth = new DateTime(1950, 4, 13), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY0NzAzMTEyOV5BMl5BanBnXkFtZTcwNjYwMzYwNg@@._V1_UY317_CR2,0,214,317_AL_.jpg", Salary = 336700, Telephone = "695-43-54-432", Country = Country.United_States_of_America };
            a22.Movies = new List<Movie>() { m9 };













            Actor a23 = new Actor() { FirstName = "Claire", LastName = "Foy", Email = "Foy@gmail.com", DateOfBirth = new DateTime(1984, 4, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTI5OTMwNzM4NV5BMl5BanBnXkFtZTcwNDY1NjkyNA@@._V1_UY317_CR7,0,214,317_AL_.jpg", Salary = 6736000, Telephone = "695-43-54-654", Country = Country.United_Kingdom };
            a23.Movies = new List<Movie>() { m9 };










            Actor a24 = new Actor() { FirstName = "Ellen", LastName = "Burstyn", Email = "Burstyn@gmail.com", DateOfBirth = new DateTime(1932, 12, 7), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTU4MjYxMDc3MF5BMl5BanBnXkFtZTYwNzU3MDIz._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 367000, Telephone = "695-53-54-654", Country = Country.United_States_of_America };
            a24.Movies = new List<Movie>() { m10 };
            Actor a25 = new Actor() { FirstName = "Leelee", LastName = "Sobieski", Email = "Sobieski@gmail.com", DateOfBirth = new DateTime(1983, 6, 10), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI4NDc0MzMzMV5BMl5BanBnXkFtZTYwOTc3Mjk2._V1_UY317_CR12,0,214,317_AL_.jpg", Salary = 357000, Telephone = "695-53-64-654", Country = Country.United_States_of_America };
            a25.Movies = new List<Movie>() { m10 };












            Actor a26 = new Actor() { FirstName = "Penélope", LastName = "Cruz", Email = "Cruz@gmail.com", DateOfBirth = new DateTime(1974, 4, 28), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM0Mzc1MTc2OF5BMl5BanBnXkFtZTcwMzE4MzQxMw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 2757000, Telephone = "695-53-64-544", Country = Country.Spain };
            a26.Movies = new List<Movie>() { m11, m12 };
            Actor a27 = new Actor() { FirstName = "John", LastName = "Hurt", Email = "Hurt@gmail.com", DateOfBirth = new DateTime(1940, 1, 22), DateOfDeath = new DateTime(2017, 1, 25), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM1NTgyMTAyOV5BMl5BanBnXkFtZTcwMTE4MjQwNA@@._V1_UY317_CR5,0,214,317_AL_.jpg", Salary = 7525000, Telephone = "695-53-64-543", Country = Country.United_Kingdom };
            a27.Movies = new List<Movie>() { m11 };









            Actor a28 = new Actor() { FirstName = "Johnny", LastName = "Depp", Email = "Depp@gmail.com", DateOfBirth = new DateTime(1963, 6, 9), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM0ODU5Nzk2OV5BMl5BanBnXkFtZTcwMzI2ODgyNQ@@._V1_UY317_CR4,0,214,317_AL_.jpg", Salary = 756000, Telephone = "695-23-64-543", Country = Country.United_States_of_America };
            a28.Movies = new List<Movie>() { m12, m16, m17, m18 };
            Actor a29 = new Actor() { FirstName = "Ian", LastName = "McShane", Email = "McShane@gmail.com", DateOfBirth = new DateTime(1942, 9, 29), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNDZjYzFjNWYtOTA2Yy00MjY5LWI4OGQtM2RlNDU5ZTlhMjU0XkEyXkFqcGdeQXVyNzE0OTI2MzY@._V1_UY317_CR12,0,214,317_AL_.jpg", Salary = 7525000, Telephone = "699-23-64-543", Country = Country.United_Kingdom };
            a29.Movies = new List<Movie>() { m12 };



            Actor a30 = new Actor() { FirstName = "Eddie", LastName = "Redmayne", Email = "Redmayne@gmail.com", DateOfBirth = new DateTime(1982, 1, 6), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTU0MjEyNzQyM15BMl5BanBnXkFtZTcwMTc4ODUxOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 756000, Telephone = "699-35-64-543", Country = Country.United_Kingdom };
            a30.Movies = new List<Movie>() { m13, m23, m24 };
            Actor a31 = new Actor() { FirstName = "Katherine", LastName = "Waterston", Email = "Waterston@gmail.com", DateOfBirth = new DateTime(1980, 3, 3), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTczMTI1MjQzN15BMl5BanBnXkFtZTgwNjY2ODY2NDE@._V1_UY317_CR194,0,214,317_AL_.jpg", Salary = 2576000, Telephone = "699-35-67-543", Country = Country.United_Kingdom };
            a31.Movies = new List<Movie>() { m13 };










            Actor a32 = new Actor() { FirstName = "Alison", LastName = "Sudol", Email = "Sudol@gmail.com", DateOfBirth = new DateTime(1984, 12, 23), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY5NTg4MDI3M15BMl5BanBnXkFtZTgwNzM2Mzc1MDI@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 565000, Telephone = "699-35-67-345", Country = Country.United_States_of_America };
            a32.Movies = new List<Movie>() { m13 };






            Actor a33 = new Actor() { FirstName = "Anna", LastName = "Kendrick", Email = "Kendrick@gmail.com", DateOfBirth = new DateTime(1985, 8, 9), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjIzOTA0OTQyN15BMl5BanBnXkFtZTcwMjE1OTIwMw@@._V1_UY317_CR5,0,214,317_AL_.jpg", Salary = 5456000, Telephone = "699-35-56-256", Country = Country.United_States_of_America };
            a33.Movies = new List<Movie>() { m14 };






            Actor a34 = new Actor() { FirstName = "Meryl", LastName = "Streep", Email = "Streep@gmail.com", DateOfBirth = new DateTime(1949, 6, 22), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTU4Mjk5MDExOF5BMl5BanBnXkFtZTcwOTU1MTMyMw@@._V1_UY317_CR6,0,214,317_AL_.jpg", Salary = 756000, Telephone = "699-65-56-256", Country = Country.United_States_of_America };
            a34.Movies = new List<Movie>() { m14 };
            Actor a35 = new Actor() { FirstName = "Chris", LastName = "Pine", Email = "Pine@gmail.com", DateOfBirth = new DateTime(1980, 8, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM4OTQ4NTU3NV5BMl5BanBnXkFtZTcwNjEwNDU0OQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 5645000, Telephone = "699-65-56-456", Country = Country.United_States_of_America };
            a35.Movies = new List<Movie>() { m14 };




            Actor a36 = new Actor() { FirstName = "Justin", LastName = "Long", Email = "Long@gmail.com", DateOfBirth = new DateTime(1978, 6, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjIwNTEwODY4NF5BMl5BanBnXkFtZTgwMzg0ODMwMjE@._V1_UY317_CR15,0,214,317_AL_.jpg", Salary = 257000, Telephone = "699-65-56-246", Country = Country.United_States_of_America };
            a36.Movies = new List<Movie>() { m15 };
            Actor a37 = new Actor() { FirstName = "Michael", LastName = "Parks", Email = "Parks@gmail.com", DateOfBirth = new DateTime(1940, 4, 24), DateOfDeath = new DateTime(2017, 5, 9), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTc1NDM3NjU5NV5BMl5BanBnXkFtZTcwNDEzNTcyNA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 478000, Telephone = "699-65-46-246", Country = Country.United_States_of_America };
            a37.Movies = new List<Movie>() { m15 };
            Actor a38 = new Actor() { FirstName = "Haley Joel", LastName = "Osment", Email = "Osment@gmail.com", DateOfBirth = new DateTime(1988, 10, 4), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZjY0MjRhNjEtNGVlYi00YzZhLWFhNDEtMjlhNjBiNzM3Y2RkXkEyXkFqcGdeQXVyMjQxMDQzMjA@._V1_UY317_CR104,0,214,317_AL_.jpg", Salary = 874000, Telephone = "699-65-22-246", Country = Country.United_States_of_America };
            a38.Movies = new List<Movie>() { m15 };




            Actor a39 = new Actor() { FirstName = "Angelina", LastName = "Jolie", Email = "Jolie@gmail.com", DateOfBirth = new DateTime(1975, 6, 4), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BODg3MzYwMjE4N15BMl5BanBnXkFtZTcwMjU5NzAzNw@@._V1_UY317_CR22,0,214,317_AL_.jpg", Salary = 678000, Telephone = "699-65-11-246", Country = Country.United_States_of_America };
            a39.Movies = new List<Movie>() { m16, m19, m20, m21, m100 };
            Actor a40 = new Actor() { FirstName = "Paul", LastName = "Bettany", Email = "Bettany@gmail.com", DateOfBirth = new DateTime(1971, 5, 27), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNjUzMDIzNjkxMl5BMl5BanBnXkFtZTgwNjgyNzA0MjI@._V1_UY317_CR131,0,214,317_AL_.jpg", Salary = 876000, Telephone = "699-65-11-222", Country = Country.United_Kingdom };
            a40.Movies = new List<Movie>() { m16 };



            Actor a41 = new Actor() { FirstName = "Helena Bonham", LastName = "Carter", Email = "Carter@gmail.com", DateOfBirth = new DateTime(1966, 5, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTUzMzUzMDg5MV5BMl5BanBnXkFtZTcwMDA5NDMwNA@@._V1_UY317_CR4,0,214,317_AL_.jpg", Salary = 335000, Telephone = "699-65-11-223", Country = Country.United_Kingdom };
            a41.Movies = new List<Movie>() { m17 };
            Actor a42 = new Actor() { FirstName = "Alan", LastName = "Rickman", Email = "Rickman@gmail.com", DateOfBirth = new DateTime(1946, 2, 21), DateOfDeath = new DateTime(2016, 1, 14), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTUwNTc4MTg4Ml5BMl5BanBnXkFtZTcwNDY2MjkxOA@@._V1_UY317_CR10,0,214,317_AL_.jpg", Salary = 753000, Telephone = "697-65-11-223", Country = Country.United_Kingdom };
            a42.Movies = new List<Movie>() { m17 };



            Actor a43 = new Actor() { FirstName = "Winona", LastName = "Ryder", Email = "Ryder@gmail.com", DateOfBirth = new DateTime(1971, 10, 29), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQ3NzM3MTc2NF5BMl5BanBnXkFtZTcwODMxNjA0NA@@._V1_UY317_CR9,0,214,317_AL_.jpg", Salary = 4676000, Telephone = "697-65-11-224", Country = Country.United_States_of_America };
            a43.Movies = new List<Movie>() { m18, m20 };
            Actor a44 = new Actor() { FirstName = "Dianne", LastName = "Wiest", Email = "Wiest@gmail.com", DateOfBirth = new DateTime(1948, 3, 28), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM1NjM4MTUwN15BMl5BanBnXkFtZTcwOTU0MTUyMw@@._V1_UY317_CR7,0,214,317_AL_.jpg", Salary = 356000, Telephone = "697-65-11-225", Country = Country.United_States_of_America };
            a44.Movies = new List<Movie>() { m18 };



            Actor a45 = new Actor() { FirstName = "Elle", LastName = "Fanning", Email = "Fanning@gmail.com", DateOfBirth = new DateTime(1998, 4, 9), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BN2I3N2UwMzQtNjhlYy00NmEwLTgwMDgtNmY5MzNlOGE4NDQxXkEyXkFqcGdeQXVyNDIzOTc1MDY@._V1_UY317_CR131,0,214,317_AL_.jpg", Salary = 764000, Telephone = "699-54-37-888", Country = Country.United_States_of_America };
            a45.Movies = new List<Movie>() { m19 };



            Actor a46 = new Actor() { FirstName = "Sharlto", LastName = "Copley", Email = "Copley@gmail.com", DateOfBirth = new DateTime(1973, 11, 27), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BY2Q5ZDlmYmMtYTdhMy00MDIzLTkyNmUtMTM0MzU3YmI4NTIxXkEyXkFqcGdeQXVyNTU5ODEyOTE@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 764000, Telephone = "697-24-25-266", Country = Country.South_Africa };
            a46.Movies = new List<Movie>() { m19 };



            Actor a47 = new Actor() { FirstName = "Clea", LastName = "DuVall", Email = "DuVall@gmail.com", DateOfBirth = new DateTime(1977, 9, 25), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjU0NDc3MTM4NV5BMl5BanBnXkFtZTcwMjY4Mzc1OA@@._V1_UY317_CR1,0,214,317_AL_.jpg", Salary = 1256000, Telephone = "697-24-25-263", Country = Country.United_States_of_America };
            a47.Movies = new List<Movie>() { m20 };



            Actor a48 = new Actor() { FirstName = "Colm", LastName = "Feore", Email = "Feore@gmail.com", DateOfBirth = new DateTime(1958, 8, 22), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY2MDYzNjA2MF5BMl5BanBnXkFtZTYwMzQxMjE2._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 1565000, Telephone = "697-24-25-264", Country = Country.United_States_of_America };
            a48.Movies = new List<Movie>() { m21 };
            Actor a49 = new Actor() { FirstName = "Amy", LastName = "Ryan", Email = "Ryan@gmail.com", DateOfBirth = new DateTime(1968, 5, 3), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY0MTcwMzM0Nl5BMl5BanBnXkFtZTcwODIyMjM3NA@@._V1_UY317_CR3,0,214,317_AL_.jpg", Salary = 1456000, Telephone = "697-24-25-265", Country = Country.United_States_of_America };
            a49.Movies = new List<Movie>() { m21 };


            Actor a50 = new Actor() { FirstName = "Liev", LastName = "Schreiber", Email = "Schreiber@gmail.com", DateOfBirth = new DateTime(1967, 10, 4), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjM5NjI1NzA1Ml5BMl5BanBnXkFtZTgwNDc0ODM3ODE@._V1_UY317_CR14,0,214,317_AL_.jpg", Salary = 1567000, Telephone = "697-24-25-365", Country = Country.United_States_of_America };
            a50.Movies = new List<Movie>() { m100 };
            Actor a51 = new Actor() { FirstName = "Chiwetel", LastName = "Ejiofor", Email = "Ejiofor@gmail.com", DateOfBirth = new DateTime(1977, 7, 10), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNzA5MDEyMTY3Nl5BMl5BanBnXkFtZTgwODQ0MjcxMDE@._V1_UY317_CR6,0,214,317_AL_.jpg", Salary = 1678000, Telephone = "697-24-35-365", Country = Country.United_Kingdom };
            a51.Movies = new List<Movie>() { m100 };


            Actor a52 = new Actor() { FirstName = "Hugh", LastName = "Jackman", Email = "Jackman@gmail.com", DateOfBirth = new DateTime(1968, 10, 12), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNDExMzIzNjk3Nl5BMl5BanBnXkFtZTcwOTE4NDU5OA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 1367000, Telephone = "697-24-34-365", Country = Country.Australia };
            a52.Movies = new List<Movie>() { m22 };
            Actor a53 = new Actor() { FirstName = "Russell", LastName = "Crowe", Email = "Crowe@gmail.com", DateOfBirth = new DateTime(1964, 4, 7), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQyMTExNTMxOF5BMl5BanBnXkFtZTcwNDg1NzkzNw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 1783000, Telephone = "697-24-35-365", Country = Country.New_Zealand };
            a53.Movies = new List<Movie>() { m22 };
            Actor a54 = new Actor() { FirstName = "Anne", LastName = "Hathaway", Email = "Hathaway@gmail.com", DateOfBirth = new DateTime(1982, 11, 12), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNjQ5MTAxMDc5OF5BMl5BanBnXkFtZTcwOTI0OTE4OA@@._V1_UY317_CR1,0,214,317_AL_.jpg", Salary = 1873000, Telephone = "697-24-36-365", Country = Country.United_States_of_America };
            a54.Movies = new List<Movie>() { m22 };



            Actor a55 = new Actor() { FirstName = "Alicia,", LastName = "Vikander", Email = "Vikander@gmail.com", DateOfBirth = new DateTime(1988, 10, 3), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZmMxYzk1OWEtMjE0MC00NTRlLTgwNTEtMGQ1YjA1Yzg1Nzc3XkEyXkFqcGdeQXVyMjQwMDg0Ng@@._V1_UY317_CR3,0,214,317_AL_.jpg", Salary = 3578000, Telephone = "697-24-37-365", Country = Country.Sweden };
            a55.Movies = new List<Movie>() { m23 };
            Actor a56 = new Actor() { FirstName = "Amber", LastName = "Heard", Email = "Heard@gmail.com", DateOfBirth = new DateTime(1986, 4, 22), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjA4NDkyODA3M15BMl5BanBnXkFtZTgwMzUzMjYzNzM@._V1_UY317_CR51,0,214,317_AL_.jpg", Salary = 3785000, Telephone = "697-34-37-365", Country = Country.United_States_of_America };
            a56.Movies = new List<Movie>() { m23 };




            Actor a57 = new Actor() { FirstName = "Felicity", LastName = "Jones", Email = "Jones@gmail.com", DateOfBirth = new DateTime(1958, 11, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjA0MTIwMzIyN15BMl5BanBnXkFtZTgwNDEyMzg1NDE@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 1343000, Telephone = "697-44-37-365", Country = Country.United_Kingdom };
            a57.Movies = new List<Movie>() { m24 };
            Actor a58 = new Actor() { FirstName = "Tom", LastName = "Prior", Email = "Prior@gmail.com", DateOfBirth = new DateTime(1990, 12, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjIwMjQzNDUzN15BMl5BanBnXkFtZTgwNzI1MDU4MDE@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 3655000, Telephone = "697-54-37-365", Country = Country.United_Kingdom };
            a58.Movies = new List<Movie>() { m24 };



            Actor a59 = new Actor() { FirstName = "Marlon", LastName = "Brando", Email = "Brando@gmail.com", DateOfBirth = new DateTime(1924, 4, 3), DateOfDeath = new DateTime(2004, 7, 1), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg3MDYyMDE5OF5BMl5BanBnXkFtZTcwNjgyNTEzNA@@._V1_UY317_CR97,0,214,317_AL_.jpg", Salary = 3565000, Telephone = "697-64-37-365", Country = Country.United_States_of_America };
            a59.Movies = new List<Movie>() { m25 };
            Actor a60 = new Actor() { FirstName = "Karl", LastName = "Malden", Email = "Malden@gmail.com", DateOfBirth = new DateTime(1912, 3, 22), DateOfDeath = new DateTime(2009, 7, 1), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM1MjY3Njk5Ml5BMl5BanBnXkFtZTYwNTYwMzI2._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 3545000, Telephone = "699-64-37-365", Country = Country.United_States_of_America };
            a60.Movies = new List<Movie>() { m25 };
            Actor a61 = new Actor() { FirstName = "Lee J", LastName = "Cobb", Email = "Cobb@gmail.com", DateOfBirth = new DateTime(1911, 12, 8), DateOfDeath = new DateTime(1976, 2, 11), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNDc3MTM0MDQyMF5BMl5BanBnXkFtZTYwMTczMTg2._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 5645000, Telephone = "699-24-37-365", Country = Country.United_States_of_America };
            a61.Movies = new List<Movie>() { m25 };




            Actor a62 = new Actor() { FirstName = "James", LastName = "Dean", Email = "Dean@gmail.com", DateOfBirth = new DateTime(1931, 2, 8), DateOfDeath = new DateTime(1955, 9, 30), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg5NTgzMTkzNl5BMl5BanBnXkFtZTYwMTQwNjI2._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 6542000, Telephone = "699-34-37-365", Country = Country.United_States_of_America };
            a62.Movies = new List<Movie>() { m26, m27 };
            Actor a63 = new Actor() { FirstName = "Raymond", LastName = "Massey", Email = "Massey@gmail.com", DateOfBirth = new DateTime(1896, 8, 30), DateOfDeath = new DateTime(1983, 7, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg3ODY2MzkyMF5BMl5BanBnXkFtZTcwMjc2NTg2OA@@._V1_UY317_CR20,0,214,317_AL_.jpg", Salary = 6545000, Telephone = "699-44-37-365", Country = Country.Canada };
            a63.Movies = new List<Movie>() { m26 };
            Actor a64 = new Actor() { FirstName = "Julie", LastName = "Harris", Email = "Harris@gmail.com", DateOfBirth = new DateTime(1925, 12, 2), DateOfDeath = new DateTime(2013, 8, 24), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTkzODM1MjUwOV5BMl5BanBnXkFtZTcwMDY4NDgwMw@@._V1_UY317_CR11,0,214,317_AL_.jpg", Salary = 6547000, Telephone = "699-54-37-365", Country = Country.United_States_of_America };
            a64.Movies = new List<Movie>() { m26 };



            Actor a65 = new Actor() { FirstName = "Natalie", LastName = "Wood", Email = "Wood@gmail.com", DateOfBirth = new DateTime(1938, 7, 20), DateOfDeath = new DateTime(1981, 11, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI3NjM5OTgxNF5BMl5BanBnXkFtZTYwOTg4NTM2._V1_UY317_CR2,0,214,317_AL_.jpg", Salary = 3678000, Telephone = "699-54-37-222", Country = Country.United_States_of_America };
            a65.Movies = new List<Movie>() { m27 };
            Actor a66 = new Actor() { FirstName = "Sal", LastName = "Mineo", Email = "Mineo@gmail.com", DateOfBirth = new DateTime(1939, 1, 10), DateOfDeath = new DateTime(1976, 2, 12), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI2Nzc2NTUxOF5BMl5BanBnXkFtZTcwNjU2ODAyMw@@._V1_UY317_CR15,0,214,317_AL_.jpg", Salary = 654000, Telephone = "699-54-37-333", Country = Country.United_States_of_America };
            a66.Movies = new List<Movie>() { m27 };
            Actor a67 = new Actor() { FirstName = "Audrey", LastName = "Hepburn", Email = "Hepburn@gmail.com", DateOfBirth = new DateTime(1929, 5, 4), DateOfDeath = new DateTime(1993, 1, 20), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM4MTY3NTQyMF5BMl5BanBnXkFtZTYwMTk2MzQ2._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 535000, Telephone = "699-54-37-334", Country = Country.Belgium };
            a67.Movies = new List<Movie>() { m28, m29 };



            Actor a68 = new Actor() { FirstName = "George", LastName = "Peppard", Email = "Peppard@gmail.com", DateOfBirth = new DateTime(1928, 10, 1), DateOfDeath = new DateTime(1994, 5, 8), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY1OTczNDE2NF5BMl5BanBnXkFtZTcwMTY5Mzg3Mw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 7654000, Telephone = "699-54-37-335", Country = Country.United_States_of_America };
            a68.Movies = new List<Movie>() { m28 };




            Actor a69 = new Actor() { FirstName = "Patricia", LastName = "Neal", Email = "Neal@gmail.com", DateOfBirth = new DateTime(1926, 1, 20), DateOfDeath = new DateTime(2010, 8, 20), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTgzMjk3OTkwN15BMl5BanBnXkFtZTYwMDM5NDM2._V1_UY317_CR19,0,214,317_AL_.jpg", Salary = 7652000, Telephone = "699-54-37-336", Country = Country.United_States_of_America };
            a69.Movies = new List<Movie>() { m28 };






            Actor a70 = new Actor() { FirstName = "Cary", LastName = "Grant", Email = "Grant@gmail.com", DateOfBirth = new DateTime(1904, 1, 18), DateOfDeath = new DateTime(1986, 11, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNzYyODM4NDU1MV5BMl5BanBnXkFtZTYwMjI1ODM2._V1_UY317_CR16,0,214,317_AL_.jpg", Salary = 3578000, Telephone = "699-54-37-337", Country = Country.United_Kingdom };
            a70.Movies = new List<Movie>() { m29 };
            Actor a71 = new Actor() { FirstName = "Walter", LastName = "Matthau", Email = "Matthau@gmail.com", DateOfBirth = new DateTime(1920, 10, 1), DateOfDeath = new DateTime(2000, 7, 1), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTU1NjYzOTc0NV5BMl5BanBnXkFtZTYwMjAxNDQ2._V1_UY317_CR11,0,214,317_AL_.jpg", Salary = 3675000, Telephone = "699-54-37-388", Country = Country.United_States_of_America };
            a71.Movies = new List<Movie>() { m29 };



            Actor a72 = new Actor() { FirstName = "Peter", LastName = "Sellers", Email = "Sellers@gmail.com", DateOfBirth = new DateTime(1925, 9, 8), DateOfDeath = new DateTime(1980, 7, 24), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI0MjE1MjczMF5BMl5BanBnXkFtZTYwMDIxNTQ2._V1_UY317_CR23,0,214,317_AL_.jpg", Salary = 3567000, Telephone = "699-54-37-389", Country = Country.United_Kingdom };
            a72.Movies = new List<Movie>() { m30, m31 };
            Actor a73 = new Actor() { FirstName = "Shirley", LastName = "MacLaine", Email = "MacLaine@gmail.com", DateOfBirth = new DateTime(1958, 11, 17), DateOfDeath = new DateTime(1934, 4, 24), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI0MTE5MjQ1MF5BMl5BanBnXkFtZTYwMzU2MDg1._V1_UY317_CR2,0,214,317_AL_.jpg", Salary = 4567000, Telephone = "699-54-37-244", Country = Country.United_States_of_America };
            a73.Movies = new List<Movie>() { m30 };
            Actor a74 = new Actor() { FirstName = "Melvyn", LastName = "Douglas", Email = "Douglas@gmail.com", DateOfBirth = new DateTime(1901, 4, 5), DateOfDeath = new DateTime(1981, 8, 4), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjA5MDMxMDAxMV5BMl5BanBnXkFtZTYwODg1NDQ2._V1_UY317_CR16,0,214,317_AL_.jpg", Salary = 1575000, Telephone = "699-54-37-555", Country = Country.United_States_of_America };
            a74.Movies = new List<Movie>() { m30 };



            Actor a75 = new Actor() { FirstName = "Herbert", LastName = "Lom", Email = "Lom@gmail.com", DateOfBirth = new DateTime(1917, 9, 11), DateOfDeath = new DateTime(2012, 9, 27), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNzg5OTc0OTA3Ml5BMl5BanBnXkFtZTcwOTIyOTYyMQ@@._V1_UY317_CR14,0,214,317_AL_.jpg", Salary = 515000, Telephone = "699-54-37-523", Country = Country.Austria };
            a75.Movies = new List<Movie>() { m31 };
            Actor a76 = new Actor() { FirstName = "Lesley-Anne", LastName = "Down", Email = "Down@gmail.com", DateOfBirth = new DateTime(1954, 3, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjEzODY2NTE1OF5BMl5BanBnXkFtZTYwOTAxOTk0._V1_UY317_CR32,0,214,317_AL_.jpg", Salary = 257000, Telephone = "699-54-37-524", Country = Country.United_Kingdom };
            a76.Movies = new List<Movie>() { m31 };


            Actor a77 = new Actor() { FirstName = "Romy", LastName = "Schneider", Email = "Schneider@gmail.com", DateOfBirth = new DateTime(1938, 9, 23), DateOfDeath = new DateTime(1982, 5, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg4NDI2NzA3OF5BMl5BanBnXkFtZTcwNDM1OTQyOA@@._V1_UY317_CR20,0,214,317_AL_.jpg", Salary = 345000, Telephone = "699-54-37-525", Country = Country.Austria };
            a77.Movies = new List<Movie>() { m32 };
            Actor a78 = new Actor() { FirstName = "Karlheinz", LastName = "Böhm", Email = "Bohm@gmail.com", DateOfBirth = new DateTime(1928, 3, 16), DateOfDeath = new DateTime(2014, 5, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTA4NGJmYWUtMWI4ZS00NGNlLWE0NmUtN2U3MmRiZTUwODA5XkEyXkFqcGdeQXVyMzI5NDcxNzI@._V1_UY317_CR4,0,214,317_AL_.jpg", Salary = 457000, Telephone = "699-54-37-526", Country = Country.Germany };
            a78.Movies = new List<Movie>() { m32 };
            Actor a79 = new Actor() { FirstName = "Magda", LastName = "Schneider", Email = "Schneider@gmail.com", DateOfBirth = new DateTime(1909, 5, 17), DateOfDeath = new DateTime(1996, 7, 30), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZWI5ZDM4ZWItMmRiNy00ZWIwLWIxOWEtMGVmNDM2ZmVhYTJlXkEyXkFqcGdeQXVyNTk5NzQ5Ng@@._V1_UY317_CR24,0,214,317_AL_.jpg", Salary = 742000, Telephone = "699-54-37-527", Country = Country.Germany };
            a79.Movies = new List<Movie>() { m32 };




            Actor a80 = new Actor() { FirstName = "Leslie", LastName = "Nielsen", Email = "Nielsen@gmail.com", DateOfBirth = new DateTime(1926, 2, 11), DateOfDeath = new DateTime(2010, 11, 28), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI3MTE1NjM4N15BMl5BanBnXkFtZTYwNzI3MTI0._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 542000, Telephone = "699-54-37-528", Country = Country.Canada };
            a80.Movies = new List<Movie>() { m33 };
            Actor a81 = new Actor() { FirstName = "Priscilla", LastName = "Presley", Email = "Presley@gmail.com", DateOfBirth = new DateTime(1945, 5, 24), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY5MDkzOTU1NV5BMl5BanBnXkFtZTcwNTIxNzAyMg@@._V1_UY317_CR4,0,214,317_AL_.jpg", Salary = 865000, Telephone = "699-54-37-529", Country = Country.United_States_of_America };
            a81.Movies = new List<Movie>() { m33 };
            Actor a82 = new Actor() { FirstName = "O.J.", LastName = "Simpson", Email = "Simpson@gmail.com", DateOfBirth = new DateTime(1947, 7, 9), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjE5NTYzNTg2N15BMl5BanBnXkFtZTcwMzEwMTAxMw@@._V1_UY317_CR10,0,214,317_AL_.jpg", Salary = 8654000, Telephone = "699-54-37-530", Country = Country.United_States_of_America };
            a82.Movies = new List<Movie>() { m33 };



            Actor a83 = new Actor() { FirstName = "Eminem", LastName = "Mathers", Email = "Mathers@gmail.com", DateOfBirth = new DateTime(1972, 10, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MDAxMDYwOV5BMl5BanBnXkFtZTcwMTQ1MjE2Mw@@._V1_UY317_CR10,0,214,317_AL_.jpg", Salary = 654000, Telephone = "699-54-37-532", Country = Country.United_States_of_America };
            a83.Movies = new List<Movie>() { m34 };
            Actor a84 = new Actor() { FirstName = "Brittany", LastName = "Murphy", Email = "Murphy@gmail.com", DateOfBirth = new DateTime(1977, 11, 10), DateOfDeath = new DateTime(2009, 12, 20), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTc4MjM0MzMwNl5BMl5BanBnXkFtZTYwMTU4NDg1._V1_UY317_CR8,0,214,317_AL_.jpg", Salary = 876000, Telephone = "699-54-37-666", Country = Country.United_States_of_America };
            a84.Movies = new List<Movie>() { m34 };
            Actor a85 = new Actor() { FirstName = "Kim", LastName = "Basinger", Email = "Basinger@gmail.com", DateOfBirth = new DateTime(1953, 12, 8), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQyMDkxNjcxNV5BMl5BanBnXkFtZTcwODMyNzgyOA@@._V1_UY317_CR20,0,214,317_AL_.jpg", Salary = 856000, Telephone = "699-54-37-667", Country = Country.United_States_of_America };
            a85.Movies = new List<Movie>() { m34 };



            Actor a86 = new Actor() { FirstName = "Paul", LastName = "Walker", Email = "Walker@gmail.com", DateOfBirth = new DateTime(1973, 9, 12), DateOfDeath = new DateTime(2013, 11, 30), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjIwODc0OTk2Nl5BMl5BanBnXkFtZTcwOTQ5MDA0Mg@@._V1_UX214_CR0,0,214,317_AL_.jpg", Salary = 6676000, Telephone = "699-54-37-668", Country = Country.United_States_of_America };
            a86.Movies = new List<Movie>() { m35 };
            Actor a87 = new Actor() { FirstName = "Cameron", LastName = "---", Email = "Bright@gmail.com", DateOfBirth = new DateTime(1993, 1, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTk2NjE4NDA3N15BMl5BanBnXkFtZTcwNDE5ODk5Mg@@._V1_UY317_CR7,0,214,317_AL_.jpg", Salary = 5676000, Telephone = "699-54-37-669", Country = Country.Canada };
            a87.Movies = new List<Movie>() { m35 };
            Actor a88 = new Actor() { FirstName = "Chazz", LastName = "Palminteri", Email = "Palminteri@gmail.com", DateOfBirth = new DateTime(1952, 5, 15), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjExNjU4NTUzOV5BMl5BanBnXkFtZTgwMTY3MDMzMTE@._V1_UY317_CR17,0,214,317_AL_.jpg", Salary = 545000, Telephone = "699-54-37-700", Country = Country.United_States_of_America };
            a88.Movies = new List<Movie>() { m35 };



            Actor a89 = new Actor() { FirstName = "James", LastName = "Stewart", Email = "Stewart@gmail.com", DateOfBirth = new DateTime(1908, 5, 20), DateOfDeath = new DateTime(1997, 7, 2), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjIwNzMzODY0NV5BMl5BanBnXkFtZTcwMDk3NDQyOA@@._V1_UY317_CR20,0,214,317_AL_.jpg", Salary = 765000, Telephone = "699-54-37-702", Country = Country.United_States_of_America };
            a89.Movies = new List<Movie>() { m36 };
            Actor a90 = new Actor() { FirstName = "Greys", LastName = "Kelly", Email = "Kelly@gmail.com", DateOfBirth = new DateTime(1929, 11, 12), DateOfDeath = new DateTime(1982, 9, 14), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTgzNjI4MzY1NF5BMl5BanBnXkFtZTYwMTM4MzQ2._V1_UY317_CR17,0,214,317_AL_.jpg", Salary = 7654000, Telephone = "699-54-37-703", Country = Country.United_States_of_America };
            a90.Movies = new List<Movie>() { m36 };
            Actor a91 = new Actor() { FirstName = "Wendell", LastName = "Corey", Email = "Corey@gmail.com", DateOfBirth = new DateTime(1914, 3, 20), DateOfDeath = new DateTime(1968, 11, 8), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTgwODk5NjE1MF5BMl5BanBnXkFtZTcwMjY3MDgwOA@@._V1_UY317_CR9,0,214,317_AL_.jpg", Salary = 7656000, Telephone = "699-54-37-755", Country = Country.United_States_of_America };
            a91.Movies = new List<Movie>() { m36 };







            //Actor a = new Actor() { FirstName = "", LastName = "", Email = "@gmail.com", DateOfBirth = new DateTime(1, 1, 1), DateOfDeath = null, PhotoUrl = "#", Salary = 0, Telephone = "699-54-37-888" ,Country= Country.United_States_of_America};

            //=================Seeding Directors=================
            Director d1 = new Director() { FirstName = "James", LastName = "Cameron", Email = "JamesCameron@gmail.com", DateOfBirth = new DateTime(1954, 9, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MjMzOTg2MF5BMl5BanBnXkFtZTcwMTM3NjQxMw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.Canada };
            d1.Movies = new List<Movie>() { m1, m4, m5 };
            Director d2 = new Director() { FirstName = "Quentin", LastName = "Tarantino", Email = "QuentinTarantino@gmail.com", DateOfBirth = new DateTime(1963, 3, 27), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTgyMjI3ODA3Nl5BMl5BanBnXkFtZTcwNzY2MDYxOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d2.Movies = new List<Movie>() { m3 };
            Director d3 = new Director() { FirstName = "Christopher", LastName = "Nolan", Email = "ChristopherNolan@gmail.com", DateOfBirth = new DateTime(1970, 6, 30), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d3.Movies = new List<Movie>() { m2 };
            Director d4 = new Director() { FirstName = "Michael", LastName = "Bay", Email = "Bay@gmail.com", DateOfBirth = new DateTime(1965, 2, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTc2NzcyMDU5NV5BMl5BanBnXkFtZTcwODc1OTM0NA@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d4.Movies = new List<Movie>() { m6 };
            Director d5 = new Director() { FirstName = "Jean-Jacques", LastName = "Annaud", Email = "Annaud@gmail.com", DateOfBirth = new DateTime(1943, 10, 1), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTA2OTE0NDk3ODJeQTJeQWpwZ15BbWU3MDUxNzkzMDk@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.France };
            d5.Movies = new List<Movie>() { m7 };



            Director d6 = new Director() { FirstName = "Oliver", LastName = "Stone", Email = "Stone@gmail.com", DateOfBirth = new DateTime(1946, 9, 15), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTMwMjExMTY3OV5BMl5BanBnXkFtZTcwNjY3MDA2MQ@@._V1_UY317_CR2,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d6.Movies = new List<Movie>() { m8 };



            Director d7 = new Director() { FirstName = "Dominic", LastName = "Sena", Email = "Sena@gmail.com", DateOfBirth = new DateTime(1949, 4, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMjg4Mzg0Nl5BMl5BanBnXkFtZTcwMDY1NjkyNA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d7.Movies = new List<Movie>() { m9 };



            Director d8 = new Director() { FirstName = "Neil", LastName = "LaBute", Email = "Annaud@gmail.com", DateOfBirth = new DateTime(1963, 3, 19), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTgxNzI4MDMwNl5BMl5BanBnXkFtZTcwMjExOTA2Nw@@._V1_UY317_CR57,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d8.Movies = new List<Movie>() { m10 };
            Director d9 = new Director() { FirstName = "John", LastName = "Madden", Email = "Madden@gmail.com", DateOfBirth = new DateTime(1949, 4, 8), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg2NTg2MTM5N15BMl5BanBnXkFtZTYwOTk5MTc0._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d9.Movies = new List<Movie>() { m11 };
            Director d10 = new Director() { FirstName = "Rob", LastName = "Marshall", Email = "Marshall@gmail.com", DateOfBirth = new DateTime(1960, 9, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTUwMjAxNTE2MF5BMl5BanBnXkFtZTYwMjA0MTQ1._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d10.Movies = new List<Movie>() { m12, m14 };
            Director d11 = new Director() { FirstName = "David", LastName = "Yates", Email = "Yates@gmail.com", DateOfBirth = new DateTime(1963, 10, 8), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY2NTU4NjY4M15BMl5BanBnXkFtZTYwNjIxOTI1._V1_UY317_CR10,0,214,317_AL_.jpg", Country = Country.United_Kingdom };
            d11.Movies = new List<Movie>() { m13 };
            Director d12 = new Director() { FirstName = "Kevin", LastName = "Smith", Email = "Smith@gmail.com", DateOfBirth = new DateTime(1970, 8, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjQ0NzI0ODM2MV5BMl5BanBnXkFtZTgwMjc3Njg4NTM@._V1_UY317_CR2,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d12.Movies = new List<Movie>() { m15 };
            Director d13 = new Director() { FirstName = "Florian", LastName = "Henckel von Donnersmarck", Email = "Donnersmarck@gmail.com", DateOfBirth = new DateTime(1973, 5, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI0MTk2NDY5OV5BMl5BanBnXkFtZTcwODY2ODQ1MQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.Germany };
            d13.Movies = new List<Movie>() { m16 };
            Director d14 = new Director() { FirstName = "Tim", LastName = "Burton", Email = "Burton@gmail.com", DateOfBirth = new DateTime(1958, 8, 25), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTcwNTc4NTMzOF5BMl5BanBnXkFtZTYwMzc5ODYz._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d14.Movies = new List<Movie>() { m17, m18 };
            Director d15 = new Director() { FirstName = "Robert", LastName = "Stromberg", Email = "Stromberg@gmail.com", DateOfBirth = new DateTime(1965, 4, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI3NDEzNTE1MV5BMl5BanBnXkFtZTcwMTI2MzMyMw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d15.Movies = new List<Movie>() { m19 };
            Director d16 = new Director() { FirstName = "James", LastName = "Mangold", Email = "Mangold@gmail.com", DateOfBirth = new DateTime(1963, 12, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg5MjY0ODg1MF5BMl5BanBnXkFtZTYwMjUzMjc0._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d16.Movies = new List<Movie>() { m20 };
            Director d17 = new Director() { FirstName = "Clint", LastName = "Eastwood", Email = "Eastwood@gmail.com", DateOfBirth = new DateTime(1930, 5, 31), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg3MDc0MjY0OV5BMl5BanBnXkFtZTcwNzU1MDAxOA@@._V1_UY317_CR10,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d17.Movies = new List<Movie>() { m21 };
            Director d18 = new Director() { FirstName = "Phillip", LastName = "Noyce", Email = "Noyce@gmail.com", DateOfBirth = new DateTime(1950, 4, 29), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQ0NDIyNTYzOF5BMl5BanBnXkFtZTcwNTczNDc2Mw@@._V1_UY317_CR18,0,214,317_AL_.jpg", Country = Country.France };
            d18.Movies = new List<Movie>() { m100 };
            Director d19 = new Director() { FirstName = "Tom", LastName = "Hooper", Email = "Hooper@gmail.com", DateOfBirth = new DateTime(1972, 10, 5), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTMyOTQ5MTE5OV5BMl5BanBnXkFtZTcwNjMxNjA0NA@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_Kingdom };
            d19.Movies = new List<Movie>() { m22, m23 };
            Director d20 = new Director() { FirstName = "James", LastName = "Marsh", Email = "Marsh@gmail.com", DateOfBirth = new DateTime(1963, 4, 30), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg0NTE1NTY3Ml5BMl5BanBnXkFtZTcwMDc1NjYzNA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_Kingdom };
            d20.Movies = new List<Movie>() { m24 };
            Director d21 = new Director() { FirstName = "Elia", LastName = "Kazan", Email = "Kazan@gmail.com", DateOfBirth = new DateTime(1909, 7, 9), DateOfDeath = new DateTime(2003, 9, 28), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0OTg0NTk0N15BMl5BanBnXkFtZTgwMTQyOTE3MDI@._V1_UY317_CR52,0,214,317_AL_.jpg", Country = Country.Greece };
            d21.Movies = new List<Movie>() { m25, m26 };
            Director d22 = new Director() { FirstName = "Nicholas", LastName = "Ray", Email = "Ray@gmail.com", DateOfBirth = new DateTime(1911, 9, 7), DateOfDeath = new DateTime(1979, 6, 16), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZWQ3ZmZlMWUtOTdhZS00Mzk4LTk0YjEtYzM4MWNmNmMyNjY2XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY317_CR19,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d22.Movies = new List<Movie>() { m27 };
            Director d23 = new Director() { FirstName = "Blake", LastName = "Edwards", Email = "Edwards@gmail.com", DateOfBirth = new DateTime(1922, 6, 22), DateOfDeath = new DateTime(2010, 12, 15), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTUwMjAzNDc0NF5BMl5BanBnXkFtZTYwNzM0NDU2._V1_UY317_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d23.Movies = new List<Movie>() { m28, m31 };
            Director d24 = new Director() { FirstName = "Stanley", LastName = "Donen", Email = "Donen@gmail.com", DateOfBirth = new DateTime(1924, 4, 13), DateOfDeath = new DateTime(2019, 2, 21), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTQ0MDgxNzEtYWUyZC00MjhkLThmOTItOTU5ZmZjYTg4Zjc3XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY317_CR21,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d24.Movies = new List<Movie>() { m29 };
            Director d25 = new Director() { FirstName = "Hal", LastName = "Ashby", Email = "Ashby@gmail.com", DateOfBirth = new DateTime(1929, 9, 2), DateOfDeath = new DateTime(1988, 12, 27), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTE4MjI2Njc4MF5BMl5BanBnXkFtZTcwNDA0NjIyOA@@._V1_UY317_CR28,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d25.Movies = new List<Movie>() { m30 };
            Director d26 = new Director() { FirstName = "Ernst", LastName = "Marischka", Email = "Marischka@gmail.com", DateOfBirth = new DateTime(1893, 2, 2), DateOfDeath = new DateTime(1963, 5, 12), PhotoUrl = "https://alchetron.com/cdn/ernst-marischka-a682a930-5fca-4829-a8dc-fee814dd6f5-resize-750.jpeg", Country = Country.Austria };
            d26.Movies = new List<Movie>() { m32 };
            Director d27 = new Director() { FirstName = "David", LastName = "Zucker", Email = "Zucker@gmail.com", DateOfBirth = new DateTime(1947, 10, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTE1MmRkMTAtMzJhMC00ZTViLTg1NWYtNGM3Yjc0YWZkMDBhXkEyXkFqcGdeQXVyMTExMjU1MDQ3._V1_UY317_CR17,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d27.Movies = new List<Movie>() { m33 };
            Director d28 = new Director() { FirstName = "Curtis", LastName = "Hanson", Email = "Hanson@gmail.com", DateOfBirth = new DateTime(1945, 3, 24), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM3MzIzMzExOV5BMl5BanBnXkFtZTcwMTEyNjA1Mw@@._V1_UY317_CR28,0,214,317_AL_.jpg", Country = Country.United_States_of_America };
            d28.Movies = new List<Movie>() { m34 };
            Director d29 = new Director() { FirstName = "Wayne", LastName = "Kramer", Email = "Kramer@gmail.com", DateOfBirth = new DateTime(1965, 5, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTQ2OTNkYTEtM2U4Yy00ZDBlLTk2MTAtMmIwYzdkODliYTgwXkEyXkFqcGdeQXVyMjQ2NTAxMDk@._V1_UY317_CR133,0,214,317_AL_.jpg", Country = Country.South_Africa };
            d29.Movies = new List<Movie>() { m35 };
            Director d30 = new Director() { FirstName = "Alfred", LastName = "Hitchcock", Email = "Hitchcock@gmail.com", DateOfBirth = new DateTime(1899, 8, 13), DateOfDeath = new DateTime(1980, 4, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQxOTg3ODc2NV5BMl5BanBnXkFtZTYwNTg0NTU2._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_Kingdom };
            d30.Movies = new List<Movie>() { m36 };
            //Director d = new Director() { FirstName = "", LastName = "", Email = "@gmail.com", DateOfBirth = new DateTime(1, 1, 1), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_States_of_America };

            //=================Seeding Genres====================
            Genre g1 = new Genre() { Kind = "Drama" };
            Genre g2 = new Genre() { Kind = "Comedy" };
            Genre g3 = new Genre() { Kind = "Action" };
            Genre g4 = new Genre() { Kind = "Adventure" };
            Genre g5 = new Genre() { Kind = "Crime" };
            Genre g6 = new Genre() { Kind = "Biography" };
            Genre g7 = new Genre() { Kind = "Horror" };
            Genre g8 = new Genre() { Kind = "Mystery" };
            //Genre g = new Genre() { Kind = "" };

            //=================Seeding Photos====================
            #region Leonardo Di Caprio Photos
            Photo p1 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMTg0NzYwMzc0OV5BMl5BanBnXkFtZTcwMjc0NTk1Nw@@._V1_SY1000_CR0,0,1335,1000_AL_.jpg" };
            Photo p2 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMTM0NjA1NzYxN15BMl5BanBnXkFtZTYwNTE3MjQz._V1_.jpg" };
            p1.Actor = a1;
            p2.Actor = a1;
            #endregion

            #region Kate Winslet
            Photo p3 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BZjM5ZjI3MTctYmVhOS00NWM2LWE3MWItMDIxMzRlMTQ5NmZmXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            Photo p4 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BYTMwMjVmMzYtMDk1NC00MGU4LWI5YzctNmU5NjFiZWEzZjBhXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            Photo p5 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNmFhMjQwNGMtZTVkOS00OWI0LTgwYTctNjA4NTA3NmVjMDNkXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            p3.Actor = a2;
            p4.Actor = a2;
            p5.Actor = a2;
            #endregion
            #region Billy Zane
            Photo p6 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BOGQyOGRjN2YtMTg5OS00ODBmLWEyN2EtZDZiNDU1MWZhYzg0XkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg" };
            Photo p7 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMjAxMDVkMTktNmJjOC00YjRkLTkzMWMtYTM5YmUzZGY3MWZiXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            Photo p8 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMjNmYTdlYWMtN2U5MS00ZjdjLTgwZTQtYmExNDhlYmZlN2ZmXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            Photo p9 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNTMwNzU5NmItZjM3ZS00M2Y3LWI0N2EtYmI5MzcyOGE0NTM0XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            p6.Actor = a3;
            p7.Actor = a3;
            p8.Actor = a3;
            p9.Actor = a3;
            #endregion
            //       Brad Pitt
            Photo p18 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNzc4ZGZmZDktOTFhMS00Y2RkLWEyZWUtNzYxNjljOTZiNTcwXkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SY1000_SX1600_AL_.jpg" };
            Photo p19 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BZGY5OTc5NWYtZmMxZS00NWEwLWExZjItZmE3YTVkY2I0MTc0XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg" };
            Photo p20 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMDFkMTMwYjctMTRiNy00YWRiLTk3OTUtZDE3MmJiZWMxOTMyXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg" };
            p18.Actor = a4;
            p19.Actor = a4;
            p20.Actor = a4;

            //       Margot Robbie
            Photo p21 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMjA3OTAzNzEwOF5BMl5BanBnXkFtZTgwOTMwODgyOTE@._V1_SY1000_CR0,0,666,1000_AL_.jpg" };
            Photo p22 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMjMzOTcwNjg5Nl5BMl5BanBnXkFtZTgwMTcyODY0NDM@._V1_SY1000_CR0,0,851,1000_AL_.jpg" };
            Photo p23 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMTcxMDc4MjMwM15BMl5BanBnXkFtZTgwMDY5NjgzNDE@._V1_SY1000_CR0,0,666,1000_AL_.jpg" };
            p21.Actor = a5;
            p22.Actor = a5;
            p23.Actor = a5;


            //Joseph Gordon-Levitt
            Photo p24 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMWE0MDhmMTYtNzY2YS00ZDM1LThlNzQtNWFiZWYwYWNhZGE2XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            p24.Actor = a6;
            //Ellen Page
            Photo p25 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNGRjNGYxOWItMGZjNS00ZGZhLTljMmItOTMxNmVmMGNhNzYwXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg" };
            p25.Actor = a7;
            //Sam Worthington
            Photo p26 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMGFiZDY3NWYtNTkxYS00NDk5LThhZTYtYTU5NWVkMDZkNGIyXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            p26.Actor = a8;
            //Zoe Saldana
            Photo p27 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BYjEyYjgzOGYtMzU0ZS00M2Q5LWIwYmItMmNjNjk0NGNmN2I2XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg" };
            p27.Actor = a9;
            //Sigourney Weaver
            Photo p28 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNzA5MDQ0MzYtZTBhOS00YmYxLWE1MmMtNDgzYzI3MWZmMDMwXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_.jpg" };
            p28.Actor = a10;
            Photo p29 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNTQ3MDI3MDIyOF5BMl5BanBnXkFtZTgwMzYxNzY3NTM@._V1_SY1000_CR0,0,1487,1000_AL_.jpg" };
            p29.Actor = a10;
            Photo p30 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BOTk3ODg1Nzg3NV5BMl5BanBnXkFtZTgwNDU0ODQ3NTM@._V1_.jpg" };
            p30.Actor = a10;
            Photo p31 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BYTZjNDJlY2MtZjg3YS00NWYxLWIwMzctN2IxZWU3YjA2N2ExXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            p31.Actor = a10;







            //Ed Harris
            Photo p10 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BZDM0MDM5NzEtYTdiYS00NDM4LWI2YjMtNTViNWE5NTU4NmMwXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            Photo p11 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BODJhMWIzODQtY2VhOC00YTlkLWJjY2QtZDVmMTRmM2U2MWQyXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            Photo p12 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BY2EzYzBmYjItNjYxZC00MmNhLWI5ZTctYjlkMDVhNzQyNDY4XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            Photo p13 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMjIzODIxNTc0MF5BMl5BanBnXkFtZTgwNDQzMDE1NjM@._V1_SX1500_CR0,0,1500,999_AL_.jpg" };
            Photo p14 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BY2FkNWVlNWQtMjdmYS00ODg5LThiMTktNTU3Yzk3OWViZDhhXkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SX1777_CR0,0,1777,755_AL_.jpg" };
            p10.Actor = a11;
            p11.Actor = a11;
            p12.Actor = a11;
            p13.Actor = a11;
            p14.Actor = a11;

            //Michael Biehn
            Photo p15 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BYWU3NzRhNjAtMmE4Mi00OTdkLWJkNDQtZDFiNDJiYTMyNzk0XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg" };
            Photo p16 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BN2U2Njg4NTktM2QxMS00ZmQzLWFjNWEtOGIxOWU0YmY5OGQ5XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg" };
            p15.Actor = a12;
            p16.Actor = a12;

            //Mary Mastrantonio
            Photo p17 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BZTBkODNhMjMtMzMzZi00MGYxLWIzNDktOTVhODlmYWU4Njk5XkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SX1777_CR0,0,1777,752_AL_.jpg" };
            p17.Actor = a13;

            //
            //
            //            Sean Connery
            Photo p32 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BM2JmYTA4NWUtZDM2Yi00YWJkLTlhMDktMDIwYTA4OTM4MTk4XkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_.jpg" };
            p32.Actor = a14;
            Photo p33 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNTg5ZjI3ZDAtYmQ4MS00N2JmLWIzZGYtMDkyODhkNmIyMjJkXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            p33.Actor = a14;
            Photo p34 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BMTIyYzA2YmMtNmY3NS00N2VlLTk2OWQtNWJiODg3NGM4ZDE5XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            p34.Actor = a14;
            //
            //Nicolas Cage
            Photo p35 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNzc4MzNhMDItMmE2OS00YmU0LTllNWEtM2QyM2ZmMjI3NDAwXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" };
            p35.Actor = a15;
            Photo p36 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BYjlkNGJhNzYtYzA4Zi00ZDIxLWEzNWQtZTMxOGVmNmYxYjgzXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            p36.Actor = a15;
            Photo p37 = new Photo() { Url = "https://m.media-amazon.com/images/M/MV5BNDY1MTgzMzktOTIwOC00YjBlLTkyYmItNzZlNDc5ZDA4YmM3XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" };
            p37.Actor = a15;
            //
            //Christian Slater
            //
            //Helmut Qualtinger
            //
            //Shailene Woodley
            //
            //Melissa Leo
            //
            //                Ron Perlman
            //
            //Claire Foy
            //
            //Ellen Burstyn
            //
            //Leelee Sobieski
            //
            //Penélope Cruz
            //
            //John Hurt
            //
            //Johnny Depp
            //
            //                Ian McShane
            //
            //Eddie Redmayne
            //
            //Katherine Waterston
            //
            //Alison Sudol
            //
            //Anna Kendrick
            //
            //Meryl Streep
            //
            //Chris Pine
            //
            //Justin Long
            //
            //Michael Parks
            //Haley Joel Osment
            //
            //Angelina Jolie
            //
            //Paul Bettany
            //
            //Helena Bonham Carter
            //
            //
            //Alan Rickman
            //
            //Winona Ryder
            //
            //Dianne Wiest
            //
            //
            //Elle Fanning
            //
            //Sharlto Copley
            //
            //Clea DuVall
            //
            //Colm Feore
            //
            //Amy Ryan
            //
            //Liev Schreiber
            //
            //Chiwetel Ejiofor
            //
            //Hugh Jackman
            //
            //Russell Crowe
            //
            //Anne Hathaway
            //
            //Alicia Vikander
            //
            //Amber Heard
            //
            //Felicity Jones
            //
            //Tom Prior
            //
            //Marlon Brando
            //
            //Karl Malden
            //Lee J. Cobb
            //
            //James Dean
            //
            //Raymond Massey
            //
            //Julie Harris
            //
            //Natalie Wood
            //
            //Sal Mineo
            //
            //Audrey Hepburn
            //
            //George Peppard
            //
            //Patricia Neal
            //
            //Cary Grant
            //
            //Walter Matthau
            //
            //Peter Sellers
            //Shirley MacLaine
            //
            //Melvyn Douglas
            //
            //Herbert Lom
            //
            //Lesley - Anne Down
            //
            //Romy Schneider
            //
            //Karlheinz Böhm
            //
            //Magda Schneider
            //
            //Leslie Nielsen
            //
            //Priscilla Presley
            //
            //O.J.Simpson
            //
            //
            //Marshall Bruce Mathers(Eminem)
            //
            //Brittany Murphy
            //
            //Kim Basinger
            //
            //Paul Walker
            //
            //Cameron Bright
            //
            //Chazz Palminteri
            //
            //James Stewart
            //
            //Greys Kelly
            //
            //
            //Wendell Corey
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //==========Add Movies to Actors














            //==========Add Movies to Genres
            g1.Movies = new List<Movie>() { m1, m11, m17, m18, m23, m27, m28, m35 };          //Drama
            g2.Movies = new List<Movie>() { m3, m15, m29, m30, m31, m32, m33, m34 };          //Comedy
            g3.Movies = new List<Movie>() { m2, m4, m6, m9, m12, m16, m19, m22 };      //Action
            g4.Movies = new List<Movie>() { m5, m13, m14 };          //Adventure
            g5.Movies = new List<Movie>() { m7, m26 };             //Crime
            g6.Movies = new List<Movie>() { m8, m20, m21, m24, m25 };             //Biography
            g7.Movies = new List<Movie>() { m10 };             //Horror
            g8.Movies = new List<Movie>() { m36 };             //Mystery





            //==========Upsert Tables (Director,Photo,Actor,Genre --Automaticly creation of Movies)
            context.Directors.AddOrUpdate(x => new { x.FirstName, x.LastName }, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25, d26, d27, d28, d29, d30);
            context.Photos.AddOrUpdate(x => x.Url, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37);

            context.Actors.AddOrUpdate(x => new { x.FirstName, x.LastName }, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a17, a18, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a60, a61, a62, a63, a64, a65, a66, a67, a68, a69, a70, a70, a71, a72, a73, a74, a75, a76, a77, a78, a79, a80, a81, a82, a83, a84, a85, a86, a87, a88, a89, a90, a91);
            context.Genres.AddOrUpdate(x => x.Kind, g1, g2, g3, g4, g5, g6, g7, g8);

            context.SaveChanges();
            #endregion

        }
    }
}
