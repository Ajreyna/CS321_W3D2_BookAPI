using System.Collections.Generic;
using System.Linq;
using CS321_W3D2_BookAPI.Data;
using CS321_W3D2_BookAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace CS321_W3D2_BookAPI.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly BookContext _bookContext;

        public PublisherService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public Publisher Add(Publisher publisher)
        {
            _bookContext.Publishers.Add(publisher);
            _bookContext.SaveChanges();
            return publisher;
        }

        public Publisher Get(int id)
        {
            return _bookContext.Publishers
                .Include(a => a.publishers)
                .SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _bookContext.Publishers
               .Include(a => a.publishers)
               .ToList();
        }

        public void Remove(Publisher publisher)
        {
            _bookContext.Publishers.Remove(publisher);
            _bookContext.SaveChanges();
        }

        public Publisher Update(Publisher updatedPublisher)
        {
            // get the ToDo object in the current list with this id 
            var currentPublisher = _bookContext.Publishers.Find(updatedPublisher.Id);

            // return null if todo to update isn't found
            if (currentPublisher == null) return null;

            // NOTE: This method is already completed for you, but note
            // how the property values are copied below.

            // copy the property values from the changed todo into the
            // one in the db. NOTE that this is much simpler than individually
            // copying each property.
            _bookContext.Entry(currentPublisher)
                .CurrentValues
                .SetValues(updatedPublisher);

            // update the todo and save
            _bookContext.Publishers.Update(currentPublisher);
            _bookContext.SaveChanges();
            return currentPublisher;
        }
    }
   
}
