using System.Collections.Generic;
using ProjectManagementTool.Core.Contracts.System;

namespace ProjectManagementTool.Core.Dtos.Project
{
    public class CreateProjectResponse : ResponseMessage
    {
        public List<string> Errors { get; private set; }
        public CreateProjectResponse(bool success, List<string> errors, string message = null):base(success, message)
        {
            Errors = errors;
        }
    }
}