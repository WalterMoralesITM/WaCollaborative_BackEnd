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

            modelBuilder.Entity<Status>().ToTable("Status", schema: "Parameters");           
        }

        #endregion Model

    }
}
