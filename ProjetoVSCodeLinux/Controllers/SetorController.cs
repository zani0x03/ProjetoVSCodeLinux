using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VSCodeLinuxBLL;
using VSCodeLinuxModel;

namespace ProjetoVSCodeLinux.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetorController : ControllerBase
    {
        private ISetorBLL iSetorBLL;

        public SetorController(ISetorBLL iSetorBLL)
        {
            this.iSetorBLL = iSetorBLL;
        }

        [Route("RetornarSetoresAtivos")]
        public List<SetorModel> RetornarSetoresAtivos(){
            return iSetorBLL.RetornarSetoresAtivos();
        }
    }
}