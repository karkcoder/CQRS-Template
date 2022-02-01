using Logic.Products.Responses;
using MediatR;

namespace Logic.Products.Commands
{
    public class CreateProductCommand : IRequest<ProductResponse>
    {
        public string Name { get; }
        public string Description { get; }

        public CreateProductCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
