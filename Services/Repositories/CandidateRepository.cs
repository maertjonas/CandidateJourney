using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Repositories.Data;

namespace Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly ApplicationContext _applicationContext;
        public CandidateRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public Task<Candidate> CreateCandidateAsync(Candidate candidate)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> ReadCandidateAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidate>> ReadCandidatesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> UpdateCandidateAsync(Candidate candidate)
        {
            throw new NotImplementedException();
        }
    }
}
