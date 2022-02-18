using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using DBEntity;
using Dapper;

namespace DBContext
{
  public class BookingRepository : BaseRepository, IBookingRepository
  {
    public EntityBaseResponse GetBooking(int id)
    {
      var response = new EntityBaseResponse();

      try
      {
        using (var db = GetSqlConnection())
        {
          var booking = new EntityBooking();
          const string sql = "usp_ObtenerDepartamento";

          var p = new DynamicParameters();
          p.Add(name: "@CodDepartamento", value: id, dbType: DbType.String, direction: ParameterDirection.Input);

          booking = db.Query<EntityBooking>(
            sql: sql,
            param: p,
            commandType: CommandType.StoredProcedure
          ).FirstOrDefault();

          if (booking != null)
          {
            response.issuccess = true;
            response.errorcode = "0000";
            response.errormessage = string.Empty;
            response.data = booking;
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

    public EntityBaseResponse GetBooking()
    {
      throw new NotImplementedException();
    }

    public EntityBaseResponse GetBooking(string id)
    {
      throw new NotImplementedException();
    }

    public EntityBaseResponse GetBookings()
    {
      var response = new EntityBaseResponse();

      try
      {
        using (var db = GetSqlConnection())
        {
          var bookings = new List<EntityBooking>();
          const string sql = "usp_ListarDepartamentos";

          bookings = db.Query<EntityBooking>(
                  sql: sql,
                  commandType: CommandType.StoredProcedure
            ).ToList();

          if (bookings.Count > 0)
          {
            response.issuccess = true;
            response.errorcode = "0000";
            response.errormessage = string.Empty;
            response.data = bookings;
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

    public EntityBaseResponse Insert(EntityBooking booking)
    {
      throw new NotImplementedException();
    }
  }
}
