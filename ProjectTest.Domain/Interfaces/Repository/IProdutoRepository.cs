﻿using ProjectTest.Domain.Entities;
using ProjectTest.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest.Domain.Interfaces.Repository
{
    public interface IProdutoRepository : IGenericAsyncRepository<Produto>
    {
        Task<Produto?> ObterProdutoPorNomeAsync(string nomeProduto);
    }
}
