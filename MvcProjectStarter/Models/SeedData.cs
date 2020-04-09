using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcProjectStarter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProjectStarter.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcSongContext(serviceProvider.
                GetRequiredService<DbContextOptions<MvcSongContext>>()))
            {
                if (context.Song.Any())
                {
                    return;//songs in the DB, we are good to go
                }

                context.Song.AddRange(
                    new Song
                    {
                        title = "Don't Stop Believin",
                        genre = "Rock",
                        artist = "Journey",
                        album = "Escape",
                        ReleaseDate = DateTime.Parse("1981-3-13")
                    },

                    new Song
                    {
                        title = "Thriller",
                        genre = "Rock",
                        artist = "Michael Jackson",
                        album = "Thriller",
                        ReleaseDate = DateTime.Parse("1981-4-14")
                    },


                    new Song
                    {
                        title = "Eye of the Tiger",
                        genre = "Rock",
                        artist = "Survivor",
                        album = "unknown",
                        ReleaseDate = DateTime.Parse("1985-3-13")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
