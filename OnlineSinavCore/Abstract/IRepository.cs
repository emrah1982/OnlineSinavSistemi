using OnlineSinavCore.Messages;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineSinavCore.Abstract
{

    public interface IRepository<T> where T : class, IData, new()
    {

       
        ResultMessage<T> Add(T data);
        ResultMessage<T> AddRange(T data);
        ResultMessage<T> UpdateRange(T data);
        ResultMessage<T> RemoveRange(T data);
        ResultMessage<T> Remove(T data);
        ResultMessage<T> Update(T data);
       // Expression<T> Update(Expression body, IEnumerable<ParameterExpression> parameters);
        ResultMessage<ICollection<T>> GetAll(Expression<Func<T, bool>> filter = null);
        ResultMessage<T> Get(Expression<Func<T, bool>> filter);

        
    }


}
