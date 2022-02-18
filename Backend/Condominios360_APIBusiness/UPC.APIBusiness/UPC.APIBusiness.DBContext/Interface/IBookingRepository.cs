using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
  public interface IBookingRepository
  {
    EntityBaseResponse GetBooking();
    EntityBaseResponse GetBooking(String id);
    EntityBaseResponse Insert(EntityBooking booking);
  }
}
