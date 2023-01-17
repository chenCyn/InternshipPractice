using System.Threading.Tasks;

namespace AndreyevInterview.Services
{
    public class InvoiceServices:IInvoiceServices
    {
        #region Constractor
        private readonly AIDbContext _context;

        public InvoiceServices(AIDbContext context)
        {
            _context = context;
        }
        #endregion#region Repositories
        public async Task<bool> UpdateLineItem(LineItem lineItem)
        {
            bool done = false;

            await Task.Run(() =>
            {
                LineItem dblineItem = _context.LineItems.Find(lineItem.Id);

                if (dblineItem != null)
                {
                    LineItem lt = dblineItem;
                    lt.isBillable = lineItem.isBillable;
                    _context.Entry(dblineItem).CurrentValues.SetValues(lt);

                    if (_context.SaveChanges() == 1)
                    {
                        done = true;
                    }
                }
            });

            return done;
        }

        public async Task<bool> AddLineItem(LineItem lineItem)
        {
            bool done = false;
            await Task.Run(() =>
            {
                _context.LineItems.Add(lineItem);

                if (_context.SaveChanges() == 1)
                {
                    done = true;
                }
            });
            return done;
        }
    }
}
