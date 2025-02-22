using AutoMapper;
using EcommerceApiSrc.Application.Interfaces.UnitOfWorks;
using EcommerceApiSrc.Domain.Entities;
using MediatR;

namespace EcommerceApiSrc.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map =  _mapper.Map<UpdateProductCommandRequest, Product>(request);
           
            var productCategories = await _unitOfWork.GetReadRepository<CategoryProduct>().GetAllAsync(x => x.ProductId == product.Id);

            await _unitOfWork.GetWriteRepository<CategoryProduct>().HardDeleteRangeAsync(productCategories);
            foreach (var categoryId in request.CategoriesId) 
                await _unitOfWork.GetWriteRepository<CategoryProduct>().AddAsync(new() { CategoryId = categoryId,ProductId=product.Id });

            await _unitOfWork.GetWriteRepository<Product>().UpdateAsync(map);
            await _unitOfWork.SaveAsync();

        }
    }
}
