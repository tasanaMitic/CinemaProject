using CinemaApp.Common.Dtos;
using System;
using System.Collections.Generic;
namespace CinemaApp.Common.Interfaces
{
    public interface IProjectionService
    {
        Guid AddProjection(ProjectionDto projection);
        IEnumerable<ProjectionDtoId> GetProjections(string date);
        bool DeleteProjection(Guid id);
        void UpdateProjection(Guid id, ProjectionDto projection);
    }
}
