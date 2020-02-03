using System;
using System.Collections.Generic;
using CS321_W3D2_BookAPI.Models;
using CS321_W3D2_BookAPI.Services;

namespace CS321_W3D2_BookAPI.Services
{
    public interface IPublisherService
    {
        Publisher Add(Publisher todo);

        Publisher Get(int id);

        Publisher Update(Publisher todo);

        void Remove(Publisher todo);

        IEnumerable<Publisher> GetAll();

    }
}
