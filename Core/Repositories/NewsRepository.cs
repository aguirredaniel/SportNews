using System.Collections.Generic;
using Core.Entities;

namespace Core.Repositories
{
    public interface NewsRepository
    {
        IEnumerable<News> FindLastesNewsChronologically();
    }
}