using Microsoft.EntityFrameworkCore;

namespace golf_league.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.HoleInfo.Any())
            {
                context.HoleInfo.AddRange(
                    new HoleInfo
                    {
                        Id = new Guid(), TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"), 
                        Number = 1, Par=4, Length = 294, Hcp9 = 8, Hcp18 = 15, Active = true, 
                        CreateDt = DateTime.Now, LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(), TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 2,
                        Par = 4,
                        Length = 371,
                        Hcp9 = 5,
                        Hcp18 = 9,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 3,
                        Par = 4,
                        Length = 312,
                        Hcp9 = 9,
                        Hcp18 = 17,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 4,
                        Par = 3,
                        Length = 190,
                        Hcp9 = 4,
                        Hcp18 = 7,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 5,
                        Par = 5,
                        Length = 495,
                        Hcp9 = 7,
                        Hcp18 = 13,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 6,
                        Par = 5,
                        Length = 551,
                        Hcp9 = 1,
                        Hcp18 = 1,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 7,
                        Par = 4,
                        Length = 413,
                        Hcp9 = 2,
                        Hcp18 = 3,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 8,
                        Par = 4,
                        Length = 389,
                        Hcp9 = 3,
                        Hcp18 = 5,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 9,
                        Par = 4,
                        Length = 355,
                        Hcp9 = 6,
                        Hcp18 = 11,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 10,
                        Par = 4,
                        Length = 324,
                        Hcp9 = 5,
                        Hcp18 = 10,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 11,
                        Par = 3,
                        Length = 185,
                        Hcp9 = 3,
                        Hcp18 = 6,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 12,
                        Par = 4,
                        Length = 303,
                        Hcp9 = 6,
                        Hcp18 = 12,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 13,
                        Par = 4,
                        Length = 290,
                        Hcp9 = 7,
                        Hcp18 = 14,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 14,
                        Par = 3,
                        Length = 144,
                        Hcp9 = 9,
                        Hcp18 = 18,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 15,
                        Par = 3,
                        Length = 165,
                        Hcp9 = 8,
                        Hcp18 = 16,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 16,
                        Par = 5,
                        Length = 491,
                        Hcp9 = 1,
                        Hcp18 = 2,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 17,
                        Par = 4,
                        Length = 332,
                        Hcp9 = 4,
                        Hcp18 = 8,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a58c86bc-c2ac-4239-97b1-d8c494c32055"),
                        Number = 18,
                        Par = 4,
                        Length = 407,
                        Hcp9 = 2,
                        Hcp18 = 4,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    }, //end of WHITE TEES
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 1,
                        Length = 290,
                        Hcp9 = 8,
                        Hcp18 = 15,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 2,
                        Length = 361,
                        Hcp9 = 5,
                        Hcp18 = 9,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 3,
                        Length = 289,
                        Hcp9 = 9,
                        Hcp18 = 17,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 4,
                        Length = 135,
                        Hcp9 = 4,
                        Hcp18 = 7,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 5,
                        Length = 495,
                        Hcp9 = 7,
                        Hcp18 = 13,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 6,
                        Length = 520,
                        Hcp9 = 1,
                        Hcp18 = 1,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 7,
                        Length = 408,
                        Hcp9 = 2,
                        Hcp18 = 3,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 8,
                        Length = 389,
                        Hcp9 = 3,
                        Hcp18 = 5,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 9,
                        Length = 355,
                        Hcp9 = 6,
                        Hcp18 = 11,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 10,
                        Length = 245,
                        Hcp9 = 5,
                        Hcp18 = 10,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 11,
                        Length = 180,
                        Hcp9 = 3,
                        Hcp18 = 6,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 12,
                        Length = 269,
                        Hcp9 = 6,
                        Hcp18 = 12,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 13,
                        Length = 280,
                        Hcp9 = 7,
                        Hcp18 = 14,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 14,
                        Length = 144,
                        Hcp9 = 9,
                        Hcp18 = 18,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 15,
                        Length = 140,
                        Hcp9 = 8,
                        Hcp18 = 16,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 16,
                        Length = 320,
                        Hcp9 = 1,
                        Hcp18 = 2,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 17,
                        Length = 302,
                        Hcp9 = 4,
                        Hcp18 = 8,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("a440ac0b-e4f1-4cf6-a283-2ce1f6b8b6a2"),
                        Number = 18,
                        Length = 388,
                        Hcp9 = 2,
                        Hcp18 = 4,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    }, //end of GOLD TEES
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 1,
                        Length = 305,
                        Hcp9 = 8,
                        Hcp18 = 15,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 2,
                        Length = 421,
                        Hcp9 = 5,
                        Hcp18 = 9,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 3,
                        Length = 342,
                        Hcp9 = 9,
                        Hcp18 = 17,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 4,
                        Length = 193,
                        Hcp9 = 4,
                        Hcp18 = 7,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 5,
                        Length = 506,
                        Hcp9 = 7,
                        Hcp18 = 13,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 6,
                        Length = 572,
                        Hcp9 = 1,
                        Hcp18 = 1,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 7,
                        Length = 435,
                        Hcp9 = 2,
                        Hcp18 = 3,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 8,
                        Length = 394,
                        Hcp9 = 3,
                        Hcp18 = 5,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 9,
                        Length = 366,
                        Hcp9 = 6,
                        Hcp18 = 11,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 10,
                        Length = 331,
                        Hcp9 = 5,
                        Hcp18 = 10,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 11,
                        Length = 190,
                        Hcp9 = 3,
                        Hcp18 = 6,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 12,
                        Length = 306,
                        Hcp9 = 6,
                        Hcp18 = 12,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 13,
                        Length = 290,
                        Hcp9 = 7,
                        Hcp18 = 14,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 14,
                        Length = 154,
                        Hcp9 = 9,
                        Hcp18 = 18,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 15,
                        Length = 194,
                        Hcp9 = 8,
                        Hcp18 = 16,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 16,
                        Length = 501,
                        Hcp9 = 1,
                        Hcp18 = 2,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 17,
                        Length = 350,
                        Hcp9 = 4,
                        Hcp18 = 8,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    },
                    new HoleInfo
                    {
                        Id = new Guid(),
                        TeeId = new Guid("23a85f08-d192-4a75-8820-0bd78fbb48b3"),
                        Number = 18,
                        Length = 430,
                        Hcp9 = 2,
                        Hcp18 = 4,
                        Active = true,
                        CreateDt = DateTime.Now,
                        LastUpdateDt = DateTime.Now
                    } //end of BLACK TEES



                    );
                context.SaveChanges();
            }
        }
    }
}
