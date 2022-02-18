using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
  public interface IMensajeRepository
  {
    EntityBaseResponse GetMensajes();
    EntityBaseResponse GetMensaje(String id);
    EntityBaseResponse Insert(EntityMensaje mensaje);


  }
}
