using System.Collections.Generic;
using Core.Entities;

namespace Core.UseCase
{
    public class HeadlinesResponse
    {
        public IEnumerable<News> News { get; set; }
    }
}