using System.Collections.Generic;
using LibManApp.Data.Models;

namespace LibManApp.Data
{
    public interface IHoldService
    {
        IEnumerable<AssetType> GetAll();
        AssetType Get(int id);
        void Add(AssetType newType);
    }
}