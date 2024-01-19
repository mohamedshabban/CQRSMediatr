using CQRSMediatr.Models;
using MediatR;

namespace CQRSMediatr.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
