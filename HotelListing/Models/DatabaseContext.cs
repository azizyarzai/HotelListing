using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {

        } 

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData
                (
                    new Country
                    {
                        Id = 1,
                        Name = "Afghanistan",
                        ShortName = "AF"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "India",
                        ShortName = "In"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Iran",
                        ShortName = "IR"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "United States Of America",
                        ShortName = "US"
                    }
                );

            builder.Entity<Hotel>().HasData
                (
                    new Hotel
                    {
                        Id = 1,
                        Name = "Sandals Resort and Spa",
                        Address = "Kabul",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Comfort Suites",
                        Address = "George Town",
                        CountryId = 2,
                        Rating = 4.3
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Grand Palldium",
                        Address = "Nassu",
                        CountryId = 3,
                        Rating = 4
                    },
                    new Hotel
                    {
                        Id = 4,
                        Name = "Dubai Marina",
                        Address = "Kabul",
                        CountryId = 4,
                        Rating = 3.5
                    }
                );
        }
    }
}
