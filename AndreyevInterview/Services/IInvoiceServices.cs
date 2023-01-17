using System.Threading.Tasks;


namespace AndreyevInterview.Services
{
    public interface IInvoiceServices
    {
        Task<bool> UpdateLineItem(LineItem lineItem);
        Task<bool> AddLineItem(LineItem lineItem);
    }
}
