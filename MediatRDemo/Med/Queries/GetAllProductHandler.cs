using MediatR;

namespace MediatRDemo.Med.Queries
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var model = new GetProductViewModel() { Id = Guid.NewGuid(), Name = "Laptop" };
            var model1= new GetProductViewModel() { Id = Guid.NewGuid(), Name = "Mouse" };

            return Task.FromResult(new List<GetProductViewModel> { model, model1 });
        }
    }
}
