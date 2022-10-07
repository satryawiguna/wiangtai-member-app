using System;
using WiangtaiMemberApp.Data;
using WiangtaiMemberApp.Model;
using WiangtaiMemberApp.Web.Repository.Contracts;

namespace WiangtaiMemberApp.Web.Repository;

public class RaceTypeRepository : BaseRepository<RaceType>, IRaceTypeRepository
{
    public RaceTypeRepository(WiangtaiMemberAppDbContext context) : base(context)
    {
    }
}

