using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Shared;

namespace Services
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> GetEventsAsync();
        Task<Event> GetEventAsync(long id);
        Task<Event> AddEventsAsync(string name, string description, string organizer, string location, DateTime startDateTime, DateTime endDateTime, TargetAudienceType targetAudience, string eventLink, Admin createdBy, Admin lastModifiedBy);
        Task<Event> EditEventAsync(Event eventToUpdate);        
    }
}
