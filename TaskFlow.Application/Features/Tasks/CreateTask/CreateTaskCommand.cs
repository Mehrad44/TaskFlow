using System;
using MediatR;

namespace TaskFlow.Application.Features.Tasks.CreateTask;


public record CreateTaskCommand(
    string Title,
    string Description,
    Guid ProjectId
) : IRequest<Guid>;