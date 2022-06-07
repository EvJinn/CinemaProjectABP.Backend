using System.Threading.Tasks;

namespace CinemaProject.Data;

public interface ICinemaProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
