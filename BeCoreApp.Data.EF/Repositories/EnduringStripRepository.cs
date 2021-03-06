using BeCoreApp.Data.Entities;
using BeCoreApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeCoreApp.Data.EF.Repositories
{
    public class EnduringStripRepository : EFRepository<EnduringStrip, int>, IEnduringStripRepository
    {
        public EnduringStripRepository(AppDbContext context) : base(context)
        {
        }
    }
}
