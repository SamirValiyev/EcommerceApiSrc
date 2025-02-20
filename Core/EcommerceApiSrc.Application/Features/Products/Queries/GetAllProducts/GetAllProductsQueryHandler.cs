using EcommerceApiSrc.Application.Interfaces.UnitOfWorks;
using EcommerceApiSrc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllProductsResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

            List<GetAllProductsResponse> response = new();
            foreach (var product in products)
                response.Add(
                    new GetAllProductsResponse
                    {
                        Title = product.Title,
                        Description = product.Description,
                        Discount = product.Discount,
                        Price=product.Price - (product.Price*product.Discount/100)
                    }
                );
            return response;
            
        }
    }
}
