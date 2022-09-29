using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> ReadEventsAsync();
        Task<Event> ReadEventAsync(long id);
        Task<Event> CreateEventsAsync(Event eventToCreate);
        Task<Event> UpdateEventAsync(Event eventToUpdate);
    }
}
