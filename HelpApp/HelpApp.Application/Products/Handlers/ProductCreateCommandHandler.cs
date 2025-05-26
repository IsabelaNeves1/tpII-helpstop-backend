using HelpApp.Application.Products.Commands;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using MediatR;

namespace HelpApp.Application.Products.Handlers;

public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Product>
{
    private readonly IProductRepository productRepository;
    public ProductCreateCommandHandler(IProductRepository _productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> Handle(ProductCreateCommand request,
        CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Description, request.Price,
            request.Stock, request.Image);

        if (product == null)
        {
            throw new ApplicationException($"Error create entity");
        }
        else
        {
            product.CategoryId= request.CategoryId;
            return await _productRepository.Create(product);
        }
    }
}
