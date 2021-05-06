using DAL.EFCore.Repositories;

using System;

public interface IUnitOfWork : IDisposable
{
    IDepartmentRepository Departments { get; }
    IDesignationRepository Designations { get; }
    int Complete();
}