using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace CinemaApp.Services.Services
{
    public class ProjectionService : IProjectionService
    {
        public Guid AddProjection(ProjectionDto projection)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProjection(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectionDtoId> GetProjections(string date)
        {
            throw new NotImplementedException();
        }

        public void UpdateProjection(Guid id, ProjectionDto projection)
        {
            throw new NotImplementedException();
        }
    }
}
