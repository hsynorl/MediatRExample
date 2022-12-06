using MediatR;

namespace MediatRDemo.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            //get product from repository
            var viewModel = new GetProductViewModel() {
                Id = Guid.NewGuid(),
                Name = "Book" 
            };
            return Task.FromResult(viewModel);
        }
    }
}
