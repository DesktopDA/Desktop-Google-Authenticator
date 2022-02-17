using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using DBEntity;
using Dapper;

namespace DBContext
{
    public class ImageRepository : BaseRepository, IImageRepository
    {
        public EntityBaseResponse GetImages(int id, string tipo)
        {
            var response = new EntityBaseResponse();

            try
            {
                using (var db = GetSqlConnection())
                {
                    var images = new List<EntityImage>();
                    var sql = tipo == "P" ? "usp_Listar_Images_X_Proyecto" : "usp_Listar_Images_X_Departamento";

                    var p = new DynamicParameters();
                    if (tipo == "P")
                        p.Add(name: "@IDPROYECTO", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    else
                        p.Add(name: "@IDDEPARTAMENTO", value: id, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    images = db.Query<EntityImage>(
                            sql: sql,
                            param: p,
                            commandType: CommandType.StoredProcedure
                        ).ToList();
                    
                    if(images.Count > 0)
                    {
                        response.issuccess = true;
                        response.errorcode = "0000";
                        response.errormessage = string.Empty;
                        response.data = images;
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
            catch(Exception ex)
            {
                response.issuccess = false;
                response.errorcode = "0001";
                response.errormessage = ex.Message;
                response.data = null;
            }

            return response;
        }
    }
}
