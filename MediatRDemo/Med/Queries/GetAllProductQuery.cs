using MediatR;

namespace MediatRDemo.Med.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductViewModel>>
    {
        
    }
}
