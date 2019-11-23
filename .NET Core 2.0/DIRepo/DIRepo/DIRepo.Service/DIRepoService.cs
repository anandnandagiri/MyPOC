using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIRepo
{
    public class DIRepoService : IDIRepoService
    {

        private readonly IDIRepoRepository _repo;

        public DIRepoService(IDIRepoRepository repo)
        {
            _repo = repo;

            //Note: This will add default values to IN Memory
            _repo.DefaultValues();
        }
        
        public DIRepoEntities GetValues()
        {
           return _repo.GetValues();
        }
    }
}
