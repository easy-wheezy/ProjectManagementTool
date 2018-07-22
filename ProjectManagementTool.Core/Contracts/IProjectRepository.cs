using ProjectManagementTool.Core.Entities;

namespace ProjectManagementTool.Core.Contracts
{
    public interface IProjectRepository
    {
        bool CreateProject(Project project);
    }
}