using Core.Repositories;

namespace Core.UseCase
{
    public class HeadlinesUseCase
    {
        private readonly NewsRepository _repository;

        public HeadlinesUseCase(NewsRepository repository)
        {
            _repository = repository;
        }

        public HeadlinesResponse GetLatestNews()
        {
            var news = _repository.FindLastesNewsChronologically();
            
            return new HeadlinesResponse()
            {
                News = news
            };
        }
    }
}