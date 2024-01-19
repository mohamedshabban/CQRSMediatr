using CQRSMediatr.Models;
using CQRSMediatr.Queries;
using MediatR;

namespace CQRSMediatr.Handler
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, IEnumerable<Product>>//take query of product and return list of products
    {
        private readonly FakeDataStore _fakeDataStore;
        public GetProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<IEnumerable<Product>> Handle(GetProductQuery queryRequest, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetProducts();
        }
    }
}
