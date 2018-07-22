using System;
using System.Collections.Generic;
using System.Net.Security;
using ProjectManagementTool.Core.Contracts;
using ProjectManagementTool.Core.Contracts.System;
using ProjectManagementTool.Core.Dtos.Project;
using ProjectManagementTool.Core.Entities;

namespace ProjectManagementTool.Core.Interactors
{
    public class CreateProjectInteractor : IRequestHandler<CreateProjectRequest, CreateProjectResponse>
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectInteractor(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public CreateProjectResponse Handle(CreateProjectRequest message)
        {
            List<string> errors = new List<string>();
            
            Project project = new Project()
            {
                Name = message.Name,
                CreatedDate = DateTimeOffset.Now
            };
            bool success = _projectRepository.CreateProject(project);
            
            if(!success) errors.Add($"Error creating project");

            return new CreateProjectResponse(success, errors);
        }
    }
}