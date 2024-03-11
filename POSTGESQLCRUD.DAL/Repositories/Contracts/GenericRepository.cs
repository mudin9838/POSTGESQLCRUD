﻿using POSTGESQLCRUD.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace POSTGESQLCRUD.DAL.Repositories.Contracts;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
    _context = context;
    _dbSet = _context.Set<T>();
    }

    public async Task<T> AddAsync(T entity)
    {
    await _dbSet.AddAsync(entity);
    await _context.SaveChangesAsync();
    return entity;

    }

    public async Task DeleteAsync(T entity)
    {
    _dbSet.Remove(entity);
    await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
    return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(string id)
    {
    return await _dbSet.FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
    _dbSet.Attach(entity);
    _context.Entry(entity).State = EntityState.Modified;
    await _context.SaveChangesAsync();
    }
}