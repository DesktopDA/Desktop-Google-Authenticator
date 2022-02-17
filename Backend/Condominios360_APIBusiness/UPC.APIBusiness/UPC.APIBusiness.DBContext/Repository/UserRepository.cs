using Dapper;
using DBEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DBContext
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public List<EntityUser> GetUsers()
        {
            var returnEntity = new List<EntityUser>();
            using (var db = GetSqlConnection())
            {
                const string sql = @"usp_ObtenerDepartamentos";


                returnEntity = db.Query<EntityUser>(sql,
                    commandType: CommandType.StoredProcedure).ToList();
            }
            return returnEntity;
        }
    }
}
