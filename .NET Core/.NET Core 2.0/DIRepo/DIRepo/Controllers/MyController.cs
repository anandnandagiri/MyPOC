using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIRepo.Controllers
{
    [Route("api/[controller]")]
    public class MyController
    {

        //Step 1: Direct DB call with dependency Injection
        //private readonly DIRepoDBContext _context;      

        //public MyController(DIRepoDBContext context)
        //{
        //    _context = context;
        //    if (_context.DIRepoEntities.Count() == 0)
        //    {
        //        for (int i = 0; i <= 10; i++)
        //        {
        //            _context.DIRepoEntities.Add(new DIRepoEntities { Name = "In Memory DI Repo " + i.ToString() });
        //        }
        //        _context.SaveChanges();
        //    }
        //}

        //Step 2: Repository call with dependency Injection
        //private readonly IDIRepoRepository _repo;

        //public MyController(IDIRepoRepository repo)
        //{
        //    _repo = repo;
        //    _repo.DefaultValues();
        //}

        //Step 3: Service call with dependeny Injection
        private readonly IDIRepoService _service;

        public MyController(IDIRepoService service)
        {
            _service = service;
        }


        public DIRepoEntities Get()
        {
            //return _context.DIRepoEntities.FirstOrDefault();
            //return _repo.GetValues();
            return _service.GetValues();
        }
    }
}
