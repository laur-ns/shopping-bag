﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shopping_basket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopping_basket.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();

                }
                // actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = ""

                        },
                        new Actor()
                        {
                            Name = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        },
                        new Actor()
                        {
                            Name = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        },
                        new Actor()
                        {
                            Name = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        },
                        new Actor()
                        {
                            Name = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        }
                    });
                    context.SaveChanges();

                }
                // producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"

                        },
                        new Producer()
                        {
                            Name = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        },
                        new Producer()
                        {
                            Name = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        },
                        new Producer()
                        {
                            Name = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        },
                        new Producer()
                        {
                            Name = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://i.imgur.com/pjpVFwa.png"
                        }
                    });
                    context.SaveChanges();
                }
                // movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNWYxZWFiNTItN2FkNS00ZDJmLWE1MWItYjMyMTgyOTI4MmQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNWYxZWFiNTItN2FkNS00ZDJmLWE1MWItYjMyMTgyOTI4MmQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProducerID = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNWYxZWFiNTItN2FkNS00ZDJmLWE1MWItYjMyMTgyOTI4MmQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNWYxZWFiNTItN2FkNS00ZDJmLWE1MWItYjMyMTgyOTI4MmQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNWYxZWFiNTItN2FkNS00ZDJmLWE1MWItYjMyMTgyOTI4MmQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Crime
                        },
                        new Movie()
                        {
                            Name = "Coach Carter",
                            Description = "This is the Coach Carter movie description",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BNWYxZWFiNTItN2FkNS00ZDJmLWE1MWItYjMyMTgyOTI4MmQ4XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaID = 1,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                // actors & movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 2
                        },
                         new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 2
                        },

                        new Actor_Movie()
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new Actor_Movie()
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new Actor_Movie()
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new Actor_Movie()
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new Actor_Movie()
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
