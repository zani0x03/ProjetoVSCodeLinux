using System.Collections.Generic;
using VSCodeLinuxModel;

namespace ServerLessDAL
{
    public interface ISetorRepository
    {
        List<SetorModel> RetornarSetoresAtivos();
    }
}