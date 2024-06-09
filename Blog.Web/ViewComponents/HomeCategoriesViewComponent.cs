using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.ViewComponents
{
    public class HomeCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryServices categoryServices;

        public HomeCategoriesViewComponent(ICategoryServices categoryServices)
        {
            this.categoryServices = categoryServices;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await categoryServices.GetAllCategoriesNonDeletedTake24();
            return View(categories);
        }
    }
}
