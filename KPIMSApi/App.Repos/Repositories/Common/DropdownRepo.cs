using AutoMapper;
using KPIMS.Core.Models;
using KPIMS.Repos.Repositories.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Repos.Repositories.Common
{
    public class DropdownRepo: IDropdownRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public DropdownRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<DbPrograsState>> GetPrograsStatesAsync()
        {
            return await _appDbContext.PrograsStates.AsNoTracking().ToListAsync();
        }

        public async Task<List<DbWorkItemType>> GetWorkItemTypesAsync()
        {
            return await _appDbContext.WorkItemTypes.AsNoTracking().OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<List<DbKpiIndicator>> GetKpiIndicatorsAsync()
        {
            return await _appDbContext.KpiIndicators.AsNoTracking().OrderByDescending(x => x.Id).ToListAsync();
        }
    }
}
