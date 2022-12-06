using MediatR;

namespace MediatRDemo.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
