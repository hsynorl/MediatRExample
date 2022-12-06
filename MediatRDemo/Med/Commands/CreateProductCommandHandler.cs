﻿using MediatR;

namespace MediatRDemo.Med.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid()); 
            //repository araclığı ile veritabanına gönderlir..

        }
    }
}
