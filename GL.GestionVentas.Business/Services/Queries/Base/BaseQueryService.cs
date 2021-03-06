﻿using AutoMapper;
using GL.GestionVentas.Domain.Interfaces.Repositories.Queries.Base;
using GL.GestionVentas.Domain.Interfaces.Services.Queries.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GL.GestionVentas.Business.Services.Queries.Base
{
    public abstract class BaseQueryService<E> : IQueryService<E> where E : class
    {
        protected readonly IQuery<E> Query;
        protected readonly IMapper Mapper;

        public BaseQueryService(IQuery<E> query, IMapper mapper)
        {
            Query = query;
            Mapper = mapper;
        }

        public virtual void Detach(E entity)
        {
            Query.Detach(entity);
        }

        public virtual IQueryable<E> FindBy(Expression<Func<E, bool>> predicate, string[] includeProperties = null)
        {
            return Query.FindBy(predicate, includeProperties);
        }

        public virtual E FindById(int id)
        {
            return Query.FindById(id);
        }

        public virtual IQueryable<E> GetAll()
        {
            return Query.GetAll();
        }
    }
}
