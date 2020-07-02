namespace ReservationSystem.Migrations
{
    using ReservationSystem.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ReservationSystem.Models.RRSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ReservationSystem.Models.RRSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 301,
                Floor = 3,
                Name = "301 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 302,
                Floor = 3,
                Name = "302 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 303,
                Floor = 3,
                Name = "303 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 304,
                Floor = 3,
                Name = "304 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 305,
                Floor = 3,
                Name = "305 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 306,
                Floor = 3,
                Name = "306 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 307,
                Floor = 3,
                Name = "307 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 308,
                Floor = 3,
                Name = "308 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 309,
                Floor = 3,
                Name = "309 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 310,
                Floor = 3,
                Name = "310 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 311,
                Floor = 3,
                Name = "311 B",
                TypeID = 2
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 312,
                Floor = 3,
                Name = "312 B",
                TypeID = 2
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 313,
                Floor = 3,
                Name = "313 B",
                TypeID = 1
            }); 
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 314,
                Floor = 3,
                Name = "314 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 315,
                Floor = 3,
                Name = "315 B",
                TypeID = 1
            }); 
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 316,
                Floor = 3,
                Name = "316 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 317,
                Floor = 3,
                Name = "317 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 318,
                Floor = 3,
                Name = "318 B",
                TypeID = 1
            }); 
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 319,
                Floor = 3,
                Name = "319 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 320,
                Floor = 3,
                Name = "320 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 321,
                Floor = 3,
                Name = "321 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 322,
                Floor = 3,
                Name = "322 B",
                TypeID = 1
            });
            //////////////////////////////////////////

            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 401,
                Floor = 4,
                Name = "401 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 402,
                Floor = 4,
                Name = "402 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 403,
                Floor = 4,
                Name = "403 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 404,
                Floor = 4,
                Name = "404 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 405,
                Floor = 4,
                Name = "405 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 406,
                Floor = 4,
                Name = "406 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 407,
                Floor = 4,
                Name = "407 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 408,
                Floor = 4,
                Name = "408 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 409,
                Floor = 4,
                Name = "409 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 410,
                Floor = 4,
                Name = "410 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 411,
                Floor = 4,
                Name = "411 B",
                TypeID = 2
            }); 
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 412,
                Floor = 4,
                Name = "412 B",
                TypeID = 2
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 413,
                Floor = 4,
                Name = "413 B",
                TypeID = 1
            }); 
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 414,
                Floor = 4,
                Name = "414 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 415,
                Floor = 4,
                Name = "415 B",
                TypeID = 1
            }); context.Rooms.AddOrUpdate(new Room()
            {
                ID = 416,
                Floor = 4,
                Name = "416 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 417,
                Floor = 4,
                Name = "417 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 418,
                Floor = 4,
                Name = "418 B",
                TypeID = 0
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 419,
                Floor = 4,
                Name = "419 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 420,
                Floor = 4,
                Name = "420 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 421,
                Floor = 4,
                Name = "421 B",
                TypeID = 1
            });
            context.Rooms.AddOrUpdate(new Room()
            {
                ID = 422,
                Floor = 4,
                Name = "422 B",
                TypeID = 1
            });
        }
    }
}
