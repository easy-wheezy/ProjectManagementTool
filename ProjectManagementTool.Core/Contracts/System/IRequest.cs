namespace ProjectManagementTool.Core.Contracts.System
{
    public interface IRequest{}
    public interface IRequest<out TResponse> { }
}