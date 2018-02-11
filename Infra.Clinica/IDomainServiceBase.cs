using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinica
{
    public interface IDomainServiceBase<TEntity>
 where TEntity : class
    {


        List<TEntity> ListarTodos();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Atualizar(TEntity obj);
        void SalvarTodos();
        void Adicionar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);
     
    }
}