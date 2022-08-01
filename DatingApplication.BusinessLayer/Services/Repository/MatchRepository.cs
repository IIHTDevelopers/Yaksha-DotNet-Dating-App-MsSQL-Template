using DatingApplication.DataLayer;
using DatingApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.Services.Repository
{
    public class MatchRepository : IMatchRepository
    {

        private readonly DatingAppDbContext _datingAppDbContext;
        public MatchRepository(DatingAppDbContext datingAppDbContext)
        {
            _datingAppDbContext = datingAppDbContext;
        }

        public async Task<IEnumerable<Match>> ListAllMatchesByFilter(long userId, User user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Match>> ListAllMatchesByUserId(long userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Match> Register(Match match)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
