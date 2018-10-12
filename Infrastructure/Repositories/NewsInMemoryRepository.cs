using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Core.Repositories;

namespace Infrastructure.Repositories
{
    public class NewsInMemoryRepository : NewsRepository
    {
        private readonly IEnumerable<News> _news = new List<News>()
        {
            new News
            {
                Id = 1,
                Title = "Browns owners lead group to buy Columbus Crew",
                Description =
                    "The Haslam Family -- owners of the Cleveland Browns -- are in negotiations with MLS to " +
                    "buy the Columbus Crew and keep the team in Ohio's capital.",
                UrlImage = "http://a2.espncdn.com/combiner/i?img=%2Fphoto%2F2018%2F0305%2Fr336874_1296x729_16%2D9.jpg",
                Content =
                    "The bid to keep the Columbus Crew in Ohio's capital has taken a significant step forward, as " +
                    "an investor group that includes the Haslam Family -- owners of the NFL's Cleveland Browns -- " +
                    "and the Columbus-based Edwards Family has entered into negotiations with … ",
                PublishedAt = new DateTime(2018, 01, 21),
                Author = new Author
                {
                    FullName = "Jeff Carlisle",
                    Position = "U.S. soccer correspondent"
                }
            },
            new News
            {
                Id = 2,
                Title = "49ers issue apology for Kaepernick omission",
                Description =
                    "The 49ers have apologized for initially leaving Colin Kaepernick out of a photo gallery " +
                    "celebrating the team's history against the Packers.",
                UrlImage =
                    "http://a3.espncdn.com/combiner/i?img=%2Fphoto%2F2014%2F0711%2Fnfl_g_kaepernick_kh_1296x729.jpg",
                Content =
                    "SANTA CLARA, Calif. -- The San Francisco 49ers have apologized for initially leaving Colin " +
                    "Kaepernick out of a photo gallery celebrating the team's history against the Green Bay Packers. " +
                    "Colin Kaepernick has filed for the trademark to an image of his iconic h…",
                PublishedAt = new DateTime(2018, 03, 12),
                Author = new Author
                {
                    FullName = "Jeff Carlisle",
                    Position = "U.S. soccer correspondent"
                }
            },
            new News
            {
                Id = 3,
                Title = "Gordon: 'Natural type of relationship' with Brady",
                Description =
                    "Patriots receiver Josh Gordon says he winds up talking football " +
                    "for most of the day with Tom Brady, and that the two have a real natural type of relationship.",
                UrlImage =
                     "http://a3.espncdn.com/combiner/i?img=%2Fphoto%2F2018%2F1008%2Fr444158_1296x729_16%2D9.jpg",
                Content =
                    "FOXBOROUGH, Mass. -- New England Patriots receiver Josh Gordon described his growing bond with " +
                    "quarterback Tom Brady as a \"real natural type of relationship,\" while adding Friday that he's " +
                    "settling in nicely in the move from Cleveland to the suburbs of Boston…",
                PublishedAt = new DateTime(1992, 10, 17),
                Author = new Author
                {
                    FullName = "Mike ReissESPN Staff Writer",
                    Position = "U.S. soccer correspondent"
                }
            }
        };

        public IEnumerable<News> FindLastesNewsChronologically()
        {
            return _news.OrderByDescending(n => n.PublishedAt);
        }
    }
}