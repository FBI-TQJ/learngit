using TQJProject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TQJProject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TQJProjectDbContext _context;

        public InitialHostDbBuilder(TQJProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
