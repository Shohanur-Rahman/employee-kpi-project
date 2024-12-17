using KPIMS.Core.Models;

namespace KPIMS.Repos.Repositories.Common.Interfaces
{
    public interface IDropdownRepo
    {
        Task<List<DbPrograsState>> GetPrograsStatesAsync();
        Task<List<DbWorkItemType>> GetWorkItemTypesAsync();
        Task<List<DbKpiIndicator>> GetKpiIndicatorsAsync();
    }
}
