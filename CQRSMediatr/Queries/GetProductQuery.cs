using CQRSMediatr.Models;
using MediatR;

namespace CQRSMediatr.Queries
{
    public record GetProductQuery() : IRequest<IEnumerable<Product>>
    {

    }
}
