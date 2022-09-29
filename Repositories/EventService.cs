using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Shared;
using Repositories;

namespace Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public Task<Event> AddEventsAsync(string name, string description, string organizer, string location, DateTime startDateTime, DateTime endDateTime, TargetAudienceType targetAudience, string eventLink, Admin createdBy, Admin lastModifiedBy)
        {
            throw new NotImplementedException();
        }

        public Task<Event> EditEventAsync(Event eventToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetEventAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Event>> GetEventsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
