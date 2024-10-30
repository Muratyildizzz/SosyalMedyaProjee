﻿using Core.Utulities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface IServiceRepository<T>
    {
        IDataResult<List<T>> GetAll();
        //IDataResult<T> Get(Expression<Func<T, bool>> filter);
        IDataResult<T> GetById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}