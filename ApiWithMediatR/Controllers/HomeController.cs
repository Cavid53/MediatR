using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWithMediatR.Controllers
{
    [ApiController]
    [Route("cars")]
    public class HomeController : Controller
    {
        private readonly IMediator _mediatr;
        public HomeController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public Task<IEnumerable<Car>> Index()
        {
            return _mediatr.Send(new GetAllCarsQuery());
        }
    }
}
