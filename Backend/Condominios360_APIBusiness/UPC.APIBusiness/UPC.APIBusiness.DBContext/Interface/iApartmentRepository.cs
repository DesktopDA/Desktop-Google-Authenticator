using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
   public interface iApartmentRepository
  {
    List<EntityApartment> GetApartments();
    EntityApartment GetApartment(String id);
  }
}
