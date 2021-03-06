﻿using Emprise.Domain.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Emprise.Infra.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmpriseDbContext _context;

        public UnitOfWork(EmpriseDbContext context)
        {
            _context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        /*
        public void Dispose()
        {
            _context.Dispose();
        }*/
    }
}
