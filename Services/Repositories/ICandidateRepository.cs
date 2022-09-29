using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICandidateRepository
    {
        Task<IEnumerable<Candidate>> ReadCandidatesAsync();
        Task<Candidate> CreateCandidateAsync(Candidate candidate);
        Task<Candidate> ReadCandidateAsync(long id);
        Task<Candidate> UpdateCandidateAsync(Candidate candidate);
    }
}
