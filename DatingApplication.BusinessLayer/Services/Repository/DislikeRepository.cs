using DatingApplication.DataLayer;
using DatingApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.BusinessLayer.Services.Repository
{
    public class DislikeRepository : IDislikeRepository
    {
        private readonly DatingAppDbContext _datingAppDbContext;
        public DislikeRepository(DatingAppDbContext datingAppDbContext)
        {
            _datingAppDbContext =datingAppDbContext;
        }

        public async Task<Dislike> FindDislikeById(long userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dislike>> ListAllDislikesByUserId(long userId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Dislike> Register(Dislike dislike)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
