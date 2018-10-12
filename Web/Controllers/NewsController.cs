using Core.UseCase;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            var repository = new InMemoryNewsRepository();
            var useCase = new HeadlinesUseCase(repository);
            var presenter = new HeadlinePresenter();

            var response = useCase.GetLatestNews();
            var viewModel = presenter.PresentHeadlines(response);

            return View(viewModel);
        }
    }
}