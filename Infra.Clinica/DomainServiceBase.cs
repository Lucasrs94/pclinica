
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Clinica
{
    public  class DomainServiceBase<TEntity>
 : IDomainServiceBase<TEntity>
 where TEntity : class
    {
        ////interface de abstração do repositorio de dados..
        //private readonly IRepositoryBase<TEntity> repository;
        ////construtor para injeção de dependencia..
         BancoDb ctx= new BancoDb(); //acesso ao banco de dados..

        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }

        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
            ctx.SaveChanges();

        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public void Dispose()
        {
            ctx.Dispose();
        }

        public List<TEntity> ListarTodos()
        {







            try
            {


                return ctx.Set<TEntity>().ToList();

            }
            catch (Exception e)
            {



                throw new Exception(e.Message);
            }


      
        }
    }
}
