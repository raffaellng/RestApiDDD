﻿using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entitys;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<ProdutoEntity>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
    }
}