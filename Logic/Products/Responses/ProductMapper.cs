using Domain.Entities;
using Logic.Products.Responses;

namespace Logic.Products.Mapper
{
    public static class ProductMapper
    {
        public static ProductResponse ToResponse(this Product product)
        {
            var result = new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description
            };

            return result;
        }
    }
}
