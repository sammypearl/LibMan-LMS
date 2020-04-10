using System.Collections.Generic;
using LibManApp.Data.Models;

namespace LibManApp.Data
{
    public interface ILibraryCardService
    {
        IEnumerable<LibraryCard> GetAll();
        LibraryCard Get(int id);
        void Add(LibraryCard newCard);
    }
}