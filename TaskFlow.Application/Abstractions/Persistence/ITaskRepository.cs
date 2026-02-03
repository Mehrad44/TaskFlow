using System;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Application.Abstractions.Persistence;

public interface ITaskRepository
{
    Task AddAsync(TaskItem task);
}