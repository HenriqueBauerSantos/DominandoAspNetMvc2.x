﻿using AppMvcBasica.Models;
using DevIO.Business.Interfaces;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores
                .AsNoTracking()
                .Include(x => x.Endereco)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores
                .AsNoTracking()
                .Include(x => x.Produtos)
                .Include(x => x.Endereco)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
