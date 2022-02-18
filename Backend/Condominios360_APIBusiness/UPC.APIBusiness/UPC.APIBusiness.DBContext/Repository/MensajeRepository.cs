using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using DBEntity;
using Dapper;

namespace DBContext
{
  public class MensajeRepository : BaseRepository, IMensajeRepository
  {
    public EntityBaseResponse GetMensaje(string id)
    {
      var response = new EntityBaseResponse();

      try
      {
        using (var db = GetSqlConnection())
        {
          var apartment = new EntityMensaje();
          const string sql = "usp_ObtenerMensaje";

          var p = new DynamicParameters();
          p.Add(name: "@CodMensaje", value: id, dbType: DbType.String, direction: ParameterDirection.Input);

          apartment = db.Query<EntityMensaje>(
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

    public EntityBaseResponse GetMensajes()
    {
      var response = new EntityBaseResponse();

      try
      {
        using (var db = GetSqlConnection())
        {
          var mensajes = new List<EntityMensaje>();
          const string sql = "usp_ListarMensajes";

          mensajes = db.Query<EntityMensaje>(
                  sql: sql,
                  commandType: CommandType.StoredProcedure
            ).ToList();

          if (mensajes.Count > 0)
          {
            response.issuccess = true;
            response.errorcode = "0000";
            response.errormessage = string.Empty;
            response.data = mensajes;
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

    public EntityBaseResponse Insert(EntityMensaje mensaje)
    {
      throw new NotImplementedException();
    }
  }
}
