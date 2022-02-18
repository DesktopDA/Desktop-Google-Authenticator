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
    public EntityBaseResponse GetApartment(String id)
    {
      var response = new EntityBaseResponse();

      try
      {
        using (var db = GetSqlConnection())
        {
          var apartment = new EntityApartment();
          const string sql = "usp_ObtenerDepartamento";

          var p = new DynamicParameters();
          p.Add(name: "@CodDepartamento", value: id, dbType: DbType.String, direction: ParameterDirection.Input);

          apartment = db.Query<EntityApartment>(
            sql: sql,
            param: p,
            commandType: CommandType.StoredProcedure
          ).FirstOrDefault();

          if (apartment != null)
          {
            response.issuccess = true;
            response.errorcode = "0000";
            response.errormessage = string.Empty;
            response.data = apartment;
          }
         else
          {
            response.issuccess = false;
            response.errorcode = "0000";
            response.errormessage= string.Empty;
            response.data = null;
          }
        }
        
      }
      catch (Exception ex)
      {
        response.issuccess=false;
        response.errorcode = "0001";
        response.errormessage = ex.Message;
        response.data= null;
      }
      return response;
    }

    public EntityBaseResponse GetApartments()
    {
      var response = new EntityBaseResponse();
     
      try
      {
        using (var db = GetSqlConnection())
        {
          var apartments = new List<EntityApartment>();
          const string sql = "usp_ListarDepartamentos";

          apartments = db.Query<EntityApartment>(
                  sql: sql ,
                  commandType: CommandType.StoredProcedure
            ).ToList();

          if(apartments.Count >0)
          {
            response.issuccess = true;
            response.errorcode = "0000";
            response.errormessage = string.Empty;
            response.data = apartments;
          }
          else
          {
            response.issuccess = false;
            response.errorcode = "0000";
            response.errormessage = string.Empty;
            response.data = null;
          }
        }
      }
      catch (Exception ex)
      {
        response.issuccess = false;
        response.errorcode = "0001";
        response.errormessage = ex.Message;
        response.data = null;
      }

      return response; 
    }

    public EntityBaseResponse Insert(EntityApartment apartment)
    {
      var response = new EntityBaseResponse();

      try
      {
        using (var db = GetSqlConnection())
        {
          const string sql = "usp_InsertarDepartamento";
          var p = new DynamicParameters();

          p.Add(name: "@CodDepartamento", value: apartment.CodDepartamento, dbType: DbType.String, direction: ParameterDirection.Input);
          p.Add(name: "@NumDepartamento", value: apartment.NumDepartamento, dbType: DbType.String, direction: ParameterDirection.Input);
          p.Add(name: "@AreaDepartamento", value: apartment.AreaDepartamento, dbType: DbType.VarNumeric, direction: ParameterDirection.Input);
          p.Add(name: "@CodCondominio", value: apartment.CodCondominio, dbType: DbType.String, direction: ParameterDirection.Input);

          p.Add(name: "@NumDocPropietario", value: apartment.CodDepartamento, dbType: DbType.String, direction: ParameterDirection.Input);
          p.Add(name: "@NumDocHabitante", value: apartment.NumDepartamento, dbType: DbType.String, direction: ParameterDirection.Input);
          p.Add(name: "@@CodSector", value: apartment.AreaDepartamento, dbType: DbType.VarNumeric, direction: ParameterDirection.Input);
          p.Add(name: "@DescTipoDepart", value: apartment.CodCondominio, dbType: DbType.String, direction: ParameterDirection.Input);

          p.Add(name: "@NroPiso", value: apartment.NumDepartamento, dbType: DbType.Int32, direction: ParameterDirection.Input);
          p.Add(name: "@NroHabitaciones", value: apartment.AreaDepartamento, dbType: DbType.Int32, direction: ParameterDirection.Input);
          p.Add(name: "@NroBaños", value: apartment.CodCondominio, dbType: DbType.Int32, direction: ParameterDirection.Input);


          db.Query<EntityApartment>(
              sql: sql,
              param: p,
              commandType:CommandType.StoredProcedure
            ).FirstOrDefault();

          var idapartment = p.Get<string>("@CodDepartamento");



        }

      }

      catch (Exception ex)
      {

      }
      return response;
    }

  }
}
