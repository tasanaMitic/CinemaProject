using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Interfaces
{
    public interface IProjectionRepository
    {
        void AddProjection(Projection projection);
        IEnumerable<Projection> GetProjections(string date);
        bool DeleteProjection(Guid id);
        void UpdateProjection(Guid id, Projection projection);
        Projection GetProjection(Guid id);
    }
}
