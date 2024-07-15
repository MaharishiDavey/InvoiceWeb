using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class InvoicesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public IActionResult Index()
        {
            InvoiceVM invoiceVM = new()
            {
                PartyDetails = new PartyDetail(),
                Bills = new Bill()
            };
            return View(invoiceVM);
        }



        #region Api Call
        [HttpGet]
        public IActionResult GetAll()
        {
            List<InvoiceVM> objInvoiceList = _unitOfWork.Invoice.GetAll(includeProperties: "PartyDetail").ToList();
            return Json(new { data = objInvoiceList });
        }

        [HttpDelete]
        public IActionResult Delete(string? BillNo)
        {
            var InvoiceToBeDeleted = _unitOfWork.Invoice.Get(u => u.Bills.BillNo == BillNo);

            _unitOfWork.Invoice.Remove(InvoiceToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Deleted Successfully" });
        }

        #endregion

    }


}
