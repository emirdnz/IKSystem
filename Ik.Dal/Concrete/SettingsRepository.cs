using Ik.Dal.Abstract;
using Ik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Dal.Concrete
{
    public class SettingsRepository : RepositoryBase<Settings>, ISettingsRepository
    {
    }
}
