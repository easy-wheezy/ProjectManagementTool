using System.Xml;
using ProjectManagementTool.Core.Contracts.System;

namespace ProjectManagementTool.Core.Dtos.Project
{
    public class CreateProjectRequest : IRequest<CreateProjectResponse>
    {
        public string Name { get; private set; }
        public CreateProjectRequest(string name)
        {
            Name = name;
        }
    }
}