using Bulky.Models;
using Bulky.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IInvoiceRepository : IRepository<InvoiceVM>
    {
        void Update(PartyDetail partyDetails,Bill bills);
    }
}
