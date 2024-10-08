﻿using Galaxy.GestionPedidos.Entidades;
using System.Linq.Expressions;

namespace Galaxy.GestionPedidos.Repositorios.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : EntityBase
{
    Task<ICollection<TEntity>> ListAsync();

    Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicado);

    Task<ICollection<TInfo>> ListAsync<TInfo>
        (Expression<Func<TEntity, bool>> predicado, 
        Expression<Func<TEntity, TInfo>> selector);

    Task<(ICollection<TInfo> Collection, int Total)> ListAsync<TInfo, TKey>
        (Expression<Func<TEntity, bool>> predicado, 
        Expression<Func<TEntity, TInfo>> selector, 
        Expression<Func<TEntity, TKey>> orderBy, 
        int pagina = 1, 
        int filas = 5);

    Task<TEntity?> FindAsync(int id);

    Task<TEntity> AddAsync(TEntity entity);

    Task UpdateAsync();

    Task DeleteAsync(int id);
}