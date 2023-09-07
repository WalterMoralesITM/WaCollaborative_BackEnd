namespace WaCollaborative.Infrastructure.Data
{
    #region Import

    using Microsoft.EntityFrameworkCore;
    using WaCollaborative.Domain.Entities;

    #endregion Import

    /// <summary>
    /// The class DataContext
    /// </summary>

    public class DataContext : DbContext
    {
        #region Constructor

        public DataContext()
        {           
        }

        /// <summary>
        /// Constructor Default
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        #endregion Constructor

        #region Entities

        public virtual DbSet<Status> Status { get; set; }

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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {   
                
                optionsBuilder.UseSqlServer("Data Source=WIN10;Initial Catalog=WaCollaborativeBD;Persist Security Info=True;User ID=sa;Password=programador;Pooling=False; Encrypt=False");
            }
        }
        
        #endregion Model

    }
}
