using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        //aqui e implementado a regra de negocio
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(TEntity obj)
        {
            _repositoryBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            ValidId(obj);
            _repositoryBase.Remove(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            var entity = _repositoryBase.GetById(id);
            return entity is null ? throw new Exception("ID não encontrado.") : entity;
        }

        public void Update(TEntity obj)
        {
            ValidId(obj);
            _repositoryBase.Update(obj);
        }

        private void ValidId(TEntity obj)
        {
            var prop = typeof(TEntity).GetProperty("Id");

            if (prop is null)
                throw new Exception("O objeto não possui um ID válido.");

            var id = prop.GetValue(obj);

            if (id is null)
                throw new Exception("ID não encontrado.");

            var entity = _repositoryBase.GetById((int)id);

            if (entity is null)
                throw new Exception("ID não encontrado.");
        }
    }
}