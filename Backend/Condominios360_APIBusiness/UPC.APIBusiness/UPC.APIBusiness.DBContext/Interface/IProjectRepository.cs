using System;
using System.Collections.Generic;
using System.Text;
using DBEntity;

namespace DBContext
{
    public interface IProjectRepository
    {
        EntityBaseResponse GetProjects();
        EntityBaseResponse GetProject(int id);
        EntityBaseResponse Insert(EntityProject project);
    }
}