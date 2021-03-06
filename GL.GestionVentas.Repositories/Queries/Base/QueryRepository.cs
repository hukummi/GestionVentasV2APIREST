﻿using GL.GestionVentas.Domain.Interfaces.Repositories.Queries.Base;
using GL.GestionVentas.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GL.GestionVentas.Repositories.Queries.Base
{
    public class QueryRepository<E> : IQuery<E> where E : class
    {
        protected readonly GestionVentasContext Context;

        public QueryRepository(GestionVentasContext context)
        {
            Context = context;
        }

        public virtual void Detach(E entity)
        {
            Context.Entry(entity).State = EntityState.Detached;
        }

        public virtual IQueryable<E> FindBy(Expression<Func<E, bool>> predicate, string[] includeProperties = null)
        {
            IQueryable<E> query = Context.Set<E>();

            if (includeProperties != null)
                foreach (string includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }

            return query.Where(predicate);
        }

        public virtual E FindById(int id)
        {
            return Context.Set<E>().Find(id);
        }

        public virtual IQueryable<E> GetAll()
        {
            IQueryable<E> query = Context.Set<E>();
            return query;
        }
    }
}
