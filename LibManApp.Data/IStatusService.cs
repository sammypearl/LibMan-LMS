using System.Collections.Generic;
using LibManApp.Data.Models;

namespace LibManApp.Data
{
    public interface IStatusService
    {
        IEnumerable<Status> GetAll();
        Status Get(int id);
        void Add(Status newStatus);
    }
}