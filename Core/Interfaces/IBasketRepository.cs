using Core.Entities;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {        
        Task<CustomerBasket> GetBasketAsync(string basketId);
        Task<CustomerBasket> UpdateBasketAsyn(CustomerBasket basket);
        Task<bool> DeleteBasketAsyn(string basketId);
    }
}
