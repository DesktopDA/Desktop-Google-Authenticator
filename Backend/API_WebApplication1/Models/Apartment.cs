using System.ComponentModel.DataAnnotations;

namespace API_WebApplication1.Models
{
  public class Apartment
  {
    [Key]
    public int CodDepartamento { get; set; }
    public string NumDepartamento { get; set; }

    public double AreaDepartamento { get; set; }

    public string CodCondominio{ get; set; }
    public string NumDocPropietario { get; set; }
    public string NumDocHabitante { get; set; }
    public string CodSector { get; set; }
    public string DescTipoDepart { get; set; }
    public int NroPiso { get; set; }
    public int NroBaños { get; set; }

    public int NroHabitaciones { get; set; }

  }
}
