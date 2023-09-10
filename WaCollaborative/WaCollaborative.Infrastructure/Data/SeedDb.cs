using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Infrastructure.Data
{
    public class SeedDb
    {

        #region Attributes

        private readonly DataContext _context;

        #endregion Attributes

        #region Constructor

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        #endregion Constructor

        #region Methods

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckStatusAsync();
        }

        private async Task CheckStatusAsync()
        {
            if (!_context.Status.Any())
            {
                _context.Status.Add(new Status { Name = "Activo", Shortname = "ACT" });
                _context.Status.Add(new Status { Name = "Inactivo", Shortname = "INACT" });
                await _context.SaveChangesAsync();
            }
        }

        #endregion Methods

    }
}