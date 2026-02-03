using System;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Abstractions.Persistence;

public interface IProjectRepository
{
    Task AddAsync(Project project);
}
