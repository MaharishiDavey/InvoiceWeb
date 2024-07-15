using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class InvoiceRepository : Repository<InvoiceVM>, IInvoiceRepository
    {
        private readonly ApplicationDBContext _db;
        public InvoiceVM invoiceVM;
        public InvoiceRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
            invoiceVM = new()
            {
                PartyDetails = new PartyDetail(),
                Bills = new Bill()
            };
        }

        public void Update(PartyDetail partyDetails, Bill bills)
        {
            _db.PartyDetails.Update(partyDetails);
            _db.PartyDetails.Update(bills);
        }
    }
}
