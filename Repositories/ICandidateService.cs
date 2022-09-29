using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Shared;

namespace Services
{
    public interface ICandidateService
    {
        Task<IEnumerable<Candidate>> GetCandidatesAsync();
        Task<Candidate> AddCandidateAsync(string firstName, string lastName, string email, string phone, string specialization, DateTime dateOfGraduation, CandidateType candidateType, string pictureLink);
        Task<Candidate> GetCandidateAsync(long id);
        Task<Candidate> EditCandidateAsync(Candidate candidate);
    }
}
