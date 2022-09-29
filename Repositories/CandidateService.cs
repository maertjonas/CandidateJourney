using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Domain.Shared;

namespace Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public Task<Candidate> AddCandidateAsync(string firstName, string lastName, string email, string phone, string specialization, DateTime dateOfGraduation, CandidateType candidateType, string pictureLink)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> EditCandidateAsync(Candidate candidate)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> GetCandidateAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidate>> GetCandidatesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
