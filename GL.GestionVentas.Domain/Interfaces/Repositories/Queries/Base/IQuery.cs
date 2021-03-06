﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GL.GestionVentas.Domain.Interfaces.Repositories.Queries.Base
{
    public interface IQuery<E> where E : class
    {
        IQueryable<E> GetAll();
        IQueryable<E> FindBy(Expression<Func<E, bool>> predicate, string[] includeProperties = null);
        E FindById(int id);
        void Detach(E entity);
    }
}
