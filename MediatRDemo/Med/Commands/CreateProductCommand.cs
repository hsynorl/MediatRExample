using MediatR;

namespace MediatRDemo.Med.Commands
{
    public class CreateProductCommand:IRequest<Guid>
    {
        public string Name { get; set; }
        public int Quentity { get; set; }

        public decimal Value { get; set; }
    }
}
