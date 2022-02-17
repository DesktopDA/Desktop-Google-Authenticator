using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IImageRepository
    {
        EntityBaseResponse GetImages(int id, string tipo);
    }
}