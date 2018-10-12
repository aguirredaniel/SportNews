using System.Collections.Generic;
using System.Linq;

namespace Core.UseCase
{
    public class HeadlinePresenter
    {
        public IEnumerable<NewsViewModel> PresentHeadlines(HeadlinesResponse response)
        {
            var viewModels = response.News.ToList().Select(n => new NewsViewModel
            {
                author = n.Author.FullName,
                publishedAt = n.PublishedAt.ToString("D"),
                title = n.Title,
                description = n.Description,
                urlImage = n.UrlImage,
            });

            return viewModels;
        }
    }
}