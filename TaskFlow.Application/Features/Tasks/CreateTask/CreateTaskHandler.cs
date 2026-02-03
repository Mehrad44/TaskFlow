using System;
using MediatR;
using TaskFlow.Application.Abstractions.Persistence;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Features.Tasks.CreateTask;


public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, Guid>
{
    private readonly ITaskRepository _repository;

    public CreateTaskHandler(ITaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = new TaskItem(
            request.Title,
            request.Description,
            request.ProjectId
        );

        await _repository.AddAsync(task);

        return task.Id;
    }
}
