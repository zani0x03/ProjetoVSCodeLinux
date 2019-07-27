using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using VSCodeLinuxModel;

namespace ServerLessDAL
{
    public class SetorRepository:ISetorRepository
    {
        public List<SetorModel> RetornarSetoresAtivos(){
            string strConexao = "Persist Security Info=False;server=XXXXX;database=XXXX;uid=XXX;pwd=XXX";
            string sql = "select * from setor where status = 1";
            List<SetorModel> lstRet = null;
            using (MySqlConnection conexao = new MySqlConnection(strConexao))
            {
                lstRet = conexao.Query<SetorModel>(sql).ToList();
            }
            return lstRet;
        }
    }
}
