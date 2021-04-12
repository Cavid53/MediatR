using Common;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Queries
{
    public class GetAllCarsQuery : IRequest<IEnumerable<Car>> {}

    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        private readonly IAppDbContext _dbContext;

        public GetAllCarsQueryHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.GetDbSet<Car>().ToListAsync();
        }
    }

}
