using System;
using MediatR;
using TaskFlow.Application.Abstractions.Persistence;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Features.Projects.CreateProject;

public class CreateProjectHandler : IRequestHandler<CreateProjectCommand, Guid>
{
    private readonly IProjectRepository _repository;

    public CreateProjectHandler(IProjectRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        var project = new Project(request.Name);

        await _repository.AddAsync(project);

        return project.Id;
    }
}