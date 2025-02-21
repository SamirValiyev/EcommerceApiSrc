using EcommerceApiSrc.Application.Interfaces.UnitOfWorks;
using EcommerceApiSrc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiSrc.Application.Features.Products.Command.CreateProduct
{
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.Title,request.Description,request.Price,request.Discount,request.BrandId);
            await _unitOfWork.GetWriteRepository<Product>().AddAsync(product);  

            if(await _unitOfWork.SaveAsync() > 0)
            {
                    foreach(var categoryId in request.CategoriesId)
                    {
                        await _unitOfWork.GetWriteRepository<CategoryProduct>().AddAsync(new()
                        {
                            ProductId = product.Id,
                            CategoryId = categoryId
                        });
                    }

                await _unitOfWork.SaveAsync();
            }  
        }
    }
}
