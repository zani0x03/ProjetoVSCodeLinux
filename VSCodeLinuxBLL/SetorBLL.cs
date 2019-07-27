using System;
using System.Collections.Generic;
using ServerLessDAL;
using VSCodeLinuxModel;

namespace VSCodeLinuxBLL
{
    public class SetorBLL:ISetorBLL
    {
        private ISetorRepository iSetorDAL;
        public SetorBLL(ISetorRepository iSetorDAL){
            this.iSetorDAL = iSetorDAL;
        }

        public List<SetorModel> RetornarSetoresAtivos(){
            return iSetorDAL.RetornarSetoresAtivos();
        }
    }
}
