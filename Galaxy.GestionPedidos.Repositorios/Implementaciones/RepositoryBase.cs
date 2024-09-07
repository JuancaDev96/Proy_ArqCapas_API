using System.Linq.Expressions;
using Galaxy.GestionPedidos.AccesoDatos.Contexto;
using Galaxy.GestionPedidos.Entidades;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.GestionPedidos.Repositorios.Implementaciones;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
{
    protected readonly BdPedidosContext Context;

    public RepositoryBase(BdPedidosContext context)
    {
        Context = context;
    }

    public async Task<ICollection<TEntity>> ListAsync()
    {
        return await Context.Set<TEntity>()
            .Where(p => p.Estado)
            .AsNoTracking() // Esto permite que no me traiga el ChangeTracker
            .ToListAsync();
    }

    public async Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicado)
    {
        return await Context.Set<TEntity>()
            .Where(predicado)
            .AsNoTracking()
            .ToListAsync();
    }

    public virtual async Task<ICollection<TInfo>> ListAsync<TInfo>(
        Expression<Func<TEntity, bool>> predicado,
        Expression<Func<TEntity, TInfo>> selector)
    {
        return await Context.Set<TEntity>()
            .Where(predicado)
            .AsNoTracking()
            .Select(selector)
            .ToListAsync();
    }

    public virtual async Task<(ICollection<TInfo> Collection, int Total)> ListAsync<TInfo, TKey>(
        Expression<Func<TEntity, bool>> predicado,
        Expression<Func<TEntity, TInfo>> selector,
        Expression<Func<TEntity, TKey>> orderBy,
        int pagina = 1, int filas = 5)
    {
        var query = await Context.Set<TEntity>()
            .Where(predicado)
            .OrderBy(orderBy)
            .Skip((pagina - 1) * filas)
            .Take(filas)
            .Select(selector)
            .ToListAsync();

        var total = await Context.Set<TEntity>()
            .Where(predicado)
            .CountAsync();

        return (query, total);
    }

    public async Task<TEntity?> FindAsync(int id)
    {
        return await Context.Set<TEntity>().FindAsync(id);
    }

    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        var resultado = await Context.Set<TEntity>().AddAsync(entity);
        await Context.SaveChangesAsync();
        return resultado.Entity;
    }

    public async Task UpdateAsync()
    {
        await Context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var registro = await FindAsync(id);
        if (registro is not null)
        {
            registro.Estado = false;
            await UpdateAsync();
        }
    }
}