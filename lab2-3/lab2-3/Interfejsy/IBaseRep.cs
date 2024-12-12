﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.Interfejsy
{
    public interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T Get(TEntity id);
        void Delete(TEntity id);
    }


}
