namespace WaCollaborative.Infrastructure.Data
{
    #region Import

    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using WaCollaborative.Domain.Entities;

    #endregion Import

    /// <summary>
    /// The class DataContext
    /// </summary>

    public class DataContext : DbContext
    {
        public IConfiguration _configuration { get; }

        #region Constructor

        public DataContext()
        {
        }

        /// <summary>
        /// Constructor Default
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        #endregion Constructor

        #region Entities

        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<State> States { get; set; }

        #endregion Entities

        #region Model

        /// <summary>
        /// Method Model
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", schema: "Parameters");

                entity.HasKey(s => new { s.Id })
                    .HasName("PK_Status");

                entity.HasIndex(s => new { s.Name }).IsUnique();
            });
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex(s => new { s.CountryId, s.Name }).IsUnique();
            modelBuilder.Entity<City>().HasIndex(c => new { c.StateId, c.Name }).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => new { c.Description }).IsUnique();
            modelBuilder.Entity<MeasurementUnit>().HasIndex(m => new { m.Description }).IsUnique();
            modelBuilder.Entity<Segment>().HasIndex(s => new { s.Description }).IsUnique();
            modelBuilder.Entity<Product>().HasIndex(p => new { p.Code }).IsUnique();
        }

        #endregion Model
    }
}