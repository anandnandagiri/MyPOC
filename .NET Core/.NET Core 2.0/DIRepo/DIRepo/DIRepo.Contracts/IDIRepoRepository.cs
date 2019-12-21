using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIRepo
{
    public interface IDIRepoRepository
    {
        void DefaultValues();
        DIRepoEntities GetValues();
    }
}
