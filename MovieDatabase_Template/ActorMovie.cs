using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase_Template
{
    internal class ActorMovie
    {
        public int MovieId { get; }
        public int ActorId { get; }

        public ActorMovie(int movieId, int actorId)
        {
            MovieId = movieId;
            ActorId = actorId;
        }
    }
}
