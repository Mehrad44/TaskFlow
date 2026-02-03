using System;
using MediatR;

namespace TaskFlow.Application.Features.Projects.CreateProject;

public record CreateProjectCommand(string Name) : IRequest<Guid>;
