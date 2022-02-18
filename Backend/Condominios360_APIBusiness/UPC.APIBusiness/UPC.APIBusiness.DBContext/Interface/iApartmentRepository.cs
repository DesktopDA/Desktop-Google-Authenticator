using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
   public interface iApartmentRepository
  {
    EntityBaseResponse GetApartments();
    EntityBaseResponse GetApartment(String id);
    EntityBaseResponse Insert(EntityApartment apartment);
  }
}
