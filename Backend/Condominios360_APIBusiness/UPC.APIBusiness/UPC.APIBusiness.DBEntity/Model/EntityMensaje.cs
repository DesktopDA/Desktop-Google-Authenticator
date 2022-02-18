using System;
using System.Collections.Generic;
using System.Text;

namespace DBEntity
{
  public class EntityMensaje : EntityBase
  {
    public string CodMensaje { get; set; }
    public string CodTipoMensaje { get; set; }
    public string TxAsuntoMensaje { get; set; }
    public string CodImportancia { get; set; }
    public DateTime FechaLimite { get; set; }
    public string TxBodyMensaje { get; set; }

  }
}
