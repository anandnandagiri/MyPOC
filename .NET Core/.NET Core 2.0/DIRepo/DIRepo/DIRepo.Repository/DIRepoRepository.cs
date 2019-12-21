using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIRepo
{
    public class DIRepoRepository : IDIRepoRepository
    {
        private DIRepoDBContext _context;

        public DIRepoRepository(DIRepoDBContext context)
        {
            _context = context;
        }

        public DIRepoEntities GetValues()
        {
            return _context.DIRepoEntities.FirstOrDefault();
        }

        private void AddValues()
        {
            if (_context.DIRepoEntities.Count() == 0)
            {
                for (int i = 0; i <= 10; i++)
                {
                    _context.DIRepoEntities.Add(new DIRepoEntities { Name = "In Memory DI Repo " + i.ToString() });
                }
                _context.SaveChanges();
            }
        }

        public void DefaultValues()
        {
            AddValues();
        }
    }
}
