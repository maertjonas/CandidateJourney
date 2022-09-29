using Domain;
using Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationContext _applicationContext;

        public EventRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }


        public async Task<Event> CreateEventsAsync(Event eventToCreate)
        {
            throw new NotImplementedException();

        }

        public async Task<Event> ReadEventAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> ReadEventsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Event> UpdateEventAsync(Event eventToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
