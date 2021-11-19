using CoreDemo.BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public WriterMessageNotification(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
