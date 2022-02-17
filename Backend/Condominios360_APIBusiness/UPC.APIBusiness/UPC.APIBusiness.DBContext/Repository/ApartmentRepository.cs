using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using DBEntity;
using Dapper;

namespace DBContext
{
  public class ApartmentRepository : BaseRepository, iApartmentRepository
  {
    public EntityApartment GetApartment(String id)
    {
      var apartment = new EntityApartment();

      try
      {
        using (var db = GetSqlConnection())
        {
          const string sql = "usp_ObtenerDepartamento";

          var p = new DynamicParameters();
          p.Add(name: "@CodDepartamento", value: id, dbType: DbType.String, direction: ParameterDirection.Input);

          apartment = db.Query<EntityApartment>(
            sql: sql,
            param: p,
            commandType: CommandType.StoredProcedure
          ).FirstOrDefault();
        }
        
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }


      return apartment;
    }

    public List<EntityApartment> GetApartments()
    {
      var apartments = new List<EntityApartment>();

      try
      {
        using (var db = GetSqlConnection())
        {
          const string sql = "usp_ListarDepartamentos";
          apartments = db.Query<EntityApartment>(
            sql: sql ,
            commandType: CommandType.StoredProcedure
            ).ToList();
        }
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }


      return apartments; 
    }
  }
}
