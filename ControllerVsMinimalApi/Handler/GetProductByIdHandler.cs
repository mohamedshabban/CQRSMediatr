using CQRSMediatr.Models;
using CQRSMediatr.Queries;
using MediatR;

namespace CQRSMediatr.Handler
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductByIdHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(await _fakeDataStore.GetProductById(request.Id));
        }
    }
}
