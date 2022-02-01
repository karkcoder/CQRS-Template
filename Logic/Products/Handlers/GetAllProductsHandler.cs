using Infrastructure.Persistence;
using Logic.Products.Mapper;
using Logic.Products.Queries;
using Logic.Products.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Results;

namespace Logic.Products.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IDataResult<List<ProductResponse>>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetAllProductsHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IDataResult<List<ProductResponse>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.Products.ToListAsync(cancellationToken: cancellationToken);
            var responses = entities.Select(x => x.ToResponse()).ToList();
            return new SuccessResult<List<ProductResponse>>(responses);
        }
    }
}