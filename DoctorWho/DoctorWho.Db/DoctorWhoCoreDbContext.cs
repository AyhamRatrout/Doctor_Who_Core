using DoctorWho.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.IO;

namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public static DoctorWhoCoreDbContext _context = new DoctorWhoCoreDbContext();
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
        public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }
        public DbSet<EpisodeView> EpisodeViews { get; set; }
        public DbSet<ThreeMostFrequentlyAppearingCompanions> ThreeMostFrequentlyAppearingCompanions { get; set; }
        public DbSet<ThreeMostFrequentlyAppearingEnemies> ThreeMostFrequenlyAppearingEnemies { get; set; }
        public string Execute_fnCompanions(int EpisodeId) => throw new NotSupportedException();
        public string Execute_fnEnemies(int EpisodeId) => throw new NotSupportedException();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=DoctorWhoCore")
                .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name}, LogLevel.Information)
                .EnableSensitiveDataLogging(true);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasKey(a => a.AuthorId);
            modelBuilder.Entity<Author>().Property(a => a.AuthorName).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.AuthorName).HasMaxLength(350);
            using (var reader = new StreamReader(@"C:\Users\aiham\Doctor_Who_Core\Data_Files\Authors_List.csv"))
            {
                var i = 1;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    modelBuilder.Entity<Author>().HasData(
                        new Author { AuthorId = i, AuthorName = line });
                    i++;
                }
            }

            modelBuilder.Entity<Companion>().HasKey(c => c.CompanionId);
            modelBuilder.Entity<Companion>().Property(c => c.CompanionName).IsRequired();
            modelBuilder.Entity<Companion>().Property(c => c.CompanionName).HasMaxLength(350);
            modelBuilder.Entity<Companion>().Property(c => c.WhoPlayed).IsRequired();
            modelBuilder.Entity<Companion>().Property(c => c.WhoPlayed).HasMaxLength(350);
            using (var reader = new StreamReader(@"C:\Users\aiham\Doctor_Who_Core\Data_Files\Companions_List.csv"))
            {
                var i = 1;
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    modelBuilder.Entity<Companion>().HasData(
                        new Companion { CompanionId = i, CompanionName = data[0], WhoPlayed = data[1] });
                    i++;
                }
            }

            modelBuilder.Entity<Doctor>().HasKey(d => d.DoctorId);
            modelBuilder.Entity<Doctor>().Property(d => d.DoctorId).IsRequired();
            modelBuilder.Entity<Doctor>().Property(d => d.DoctorName).IsRequired();
            modelBuilder.Entity<Doctor>().Property(d => d.DoctorName).HasMaxLength(350);
            modelBuilder.Entity<Doctor>().Property(d => d.BirthDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Doctor>().Property(d => d.FirstEpisodeDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Doctor>().Property(d => d.LastEpisodeDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = DoctorIdEnum.First_Doctor, DoctorNumber = 1, DoctorName = "William Hartnell", BirthDate = new DateTime(1908, 01, 08), FirstEpisodeDate = new DateTime(1963, 10, 29), LastEpisodeDate = new DateTime(1966, 10, 29) },
                new Doctor { DoctorId = DoctorIdEnum.Second_Doctor, DoctorNumber = 2, DoctorName = "Patrick Troughton", BirthDate = new DateTime(1920, 03, 25), FirstEpisodeDate = new DateTime(1966, 11, 05), LastEpisodeDate = new DateTime(1969, 06, 21) },
                new Doctor { DoctorId = DoctorIdEnum.Third_Doctor, DoctorNumber = 3, DoctorName = "Jon Pertwee", BirthDate = new DateTime(1919, 07, 07), FirstEpisodeDate = new DateTime(1970, 01, 02), LastEpisodeDate = new DateTime(1974, 06, 08) },
                new Doctor { DoctorId = DoctorIdEnum.Fourth_Doctor, DoctorNumber = 4, DoctorName = "Tom Baker", BirthDate = new DateTime(1934, 01, 20), FirstEpisodeDate = new DateTime(1974, 12, 28), LastEpisodeDate = new DateTime(1981, 03, 21) },
                new Doctor { DoctorId = DoctorIdEnum.Fifth_Doctor, DoctorNumber = 5, DoctorName = "Peter Davison", BirthDate = new DateTime(1951, 04, 13), FirstEpisodeDate = new DateTime(1982, 01, 04), LastEpisodeDate = new DateTime(1984, 03, 16) },
                new Doctor { DoctorId = DoctorIdEnum.Sixth_Doctor, DoctorNumber = 6, DoctorName = "Colin Baker", BirthDate = new DateTime(1943, 06, 08), FirstEpisodeDate = new DateTime(1984, 03, 22), LastEpisodeDate = new DateTime(1986, 12, 06) },
                new Doctor { DoctorId = DoctorIdEnum.Seventh_Doctor, DoctorNumber = 7, DoctorName = "Sylvester McCoy", BirthDate = new DateTime(1943, 08, 20), FirstEpisodeDate = new DateTime(1987, 09, 07), LastEpisodeDate = new DateTime(1989, 12, 06) },
                new Doctor { DoctorId = DoctorIdEnum.Eighth_Doctor, DoctorNumber = 8, DoctorName = "Paul McGann", BirthDate = new DateTime(1959, 11, 14), FirstEpisodeDate = new DateTime(1996, 05, 27), LastEpisodeDate = new DateTime(1996, 05, 27) },
                new Doctor { DoctorId = DoctorIdEnum.Ninth_Doctor, DoctorNumber = 9, DoctorName = "Christopher Eccleston", BirthDate = new DateTime(1964, 02, 16), FirstEpisodeDate = new DateTime(2005, 03, 26), LastEpisodeDate = new DateTime(2005, 06, 18) },
                new Doctor { DoctorId = DoctorIdEnum.Tenth_Doctor, DoctorNumber = 10, DoctorName = "David Tennant", BirthDate = new DateTime(1971, 04, 18), FirstEpisodeDate = new DateTime(2005, 12, 25), LastEpisodeDate = new DateTime(2010, 01, 01) },
                new Doctor { DoctorId = DoctorIdEnum.Eleventh_Doctor, DoctorNumber = 11, DoctorName = "Matt Smith", BirthDate = new DateTime(1982, 10, 28), FirstEpisodeDate = new DateTime(2010, 04, 03), LastEpisodeDate = new DateTime(2013, 12, 25) },
                new Doctor { DoctorId = DoctorIdEnum.Twelfth_Doctor, DoctorNumber = 12, DoctorName = "Peter Capaldi", BirthDate = new DateTime(1958, 04, 14), FirstEpisodeDate = new DateTime(2014, 08, 23), LastEpisodeDate = new DateTime(2017, 12, 25) },
                new Doctor { DoctorId = DoctorIdEnum.Thirteenth_Doctor, DoctorNumber = 13, DoctorName = "Jodie Whittaker", BirthDate = new DateTime(1982, 06, 17), FirstEpisodeDate = new DateTime(2018, 10, 07), LastEpisodeDate = null });

            modelBuilder.Entity<Enemy>().HasKey(e => e.EnemyId);
            modelBuilder.Entity<Enemy>().Property(e => e.EnemyName).IsRequired();
            modelBuilder.Entity<Enemy>().Property(e => e.EnemyName).HasMaxLength(350);
            modelBuilder.Entity<Enemy>().Property(e => e.Description).HasDefaultValueSql("NULL");
            using (var reader = new StreamReader(@"C:\Users\aiham\Doctor_Who_Core\Data_Files\Enemies_List.csv"))
            {
                var i = 1;
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    modelBuilder.Entity<Enemy>().HasData(
                        new Enemy { EnemyId = i, EnemyName = data[0], Description = data[1] });
                    i++;
                }
            }

            modelBuilder.Entity<Episode>().HasKey(e => e.EpisodeId);
            modelBuilder.Entity<Episode>().Property(e => e.SeriesNumber).HasDefaultValueSql("0");
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeNumber).HasDefaultValueSql("0");
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeType).IsRequired();
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeType).HasMaxLength(50);
            modelBuilder.Entity<Episode>().Property(e => e.Title).IsRequired();
            modelBuilder.Entity<Episode>().Property(e => e.EpisodeDate).HasDefaultValueSql("NULL");
            modelBuilder.Entity<Episode>().Property(e => e.Notes).HasDefaultValueSql("NULL");
            using (var reader = new StreamReader(@"C:\Users\aiham\Doctor_Who_Core\Data_Files\Episodes_List.csv"))
            {
                var i = 1;
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    modelBuilder.Entity<Episode>().HasData(
                        new Episode
                        {
                            EpisodeId = i,
                            SeriesNumber = int.TryParse(data[0], out int val1) ? val1 : null,
                            EpisodeNumber = int.TryParse(data[1], out int val2) ? val2 : null,
                            EpisodeType = data[2],
                            Title = data[3],
                            EpisodeDate = DateTime.TryParseExact(data[4], "dd-MMM-yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result) ? result : null,
                            AuthorId = int.TryParse(data[5], out int val4) ? val4 : 0,
                            DoctorId = int.TryParse(data[6], out int val5) ? (DoctorIdEnum)val5 : 0,
                            Notes = data[7]
                        });
                    i++;
                }
            }

            modelBuilder.Entity<EpisodeCompanion>().HasKey(ec => ec.EpisodeCompanionId);
            modelBuilder.Entity<EpisodeCompanion>()
                        .HasOne(ec => ec.Companion)
                        .WithMany(c => c.EpisodeCompanions)
                        .HasForeignKey(ec => ec.CompanionId);
            modelBuilder.Entity<EpisodeCompanion>()
                        .HasOne(ec => ec.Episode)
                        .WithMany(e => e.EpisodeCompanions)
                        .HasForeignKey(ec => ec.EpisodeId);
            using (var reader = new StreamReader(@"C:\Users\aiham\Doctor_Who_Core\Data_Files\Episode_Companions_List.csv"))
            {
                var i = 1;
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    modelBuilder.Entity<EpisodeCompanion>().HasData(
                        new EpisodeCompanion
                        {
                            EpisodeCompanionId = i,
                            EpisodeId = int.Parse(data[0]),
                            CompanionId = int.Parse(data[1])
                        });
                    i++;
                }
            }

            modelBuilder.Entity<EpisodeEnemy>().HasKey(ee => ee.EpisodeEnemyId);
            modelBuilder.Entity<EpisodeEnemy>()
                        .HasOne(ee => ee.Enemy)
                        .WithMany(e => e.EpisodeEnemies)
                        .HasForeignKey(ee => ee.EnemyId);
            modelBuilder.Entity<EpisodeEnemy>()
                        .HasOne(ee => ee.Episode)
                        .WithMany(e => e.EpisodeEnemies)
                        .HasForeignKey(ee => ee.EpisodeId);
            using (var reader = new StreamReader(@"C:\Users\aiham\Doctor_Who_Core\Data_Files\Episode_Enemies_List.csv"))
            {
                var i = 1;
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var data = line.Split(',');
                    modelBuilder.Entity<EpisodeEnemy>().HasData(
                        new EpisodeEnemy
                        {
                            EpisodeEnemyId = i,
                            EpisodeId = int.Parse(data[0]),
                            EnemyId = int.Parse(data[1])
                        });
                    i++;
                }
            }

            modelBuilder.Entity<EpisodeView>().HasNoKey().ToView("viewEpisodes");

            modelBuilder.Entity<ThreeMostFrequentlyAppearingCompanions>().HasNoKey();
            modelBuilder.Entity<ThreeMostFrequentlyAppearingEnemies>().HasNoKey();

            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext).GetMethod(nameof(Execute_fnCompanions), new[] { typeof(int) }))
                .HasName("fnCompanions");
            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext).GetMethod(nameof(Execute_fnEnemies), new[] { typeof(int) }))
                .HasName("fnEnemies");
        }
    }
}
