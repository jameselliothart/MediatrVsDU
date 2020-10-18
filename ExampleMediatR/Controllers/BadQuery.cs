using MediatR;

namespace ExampleMediatR.Controllers
{
    public class BadQuery : IRequest<string>
    {
        public string Day { get; set; }
        public string Bad { get; set; }
    }
}