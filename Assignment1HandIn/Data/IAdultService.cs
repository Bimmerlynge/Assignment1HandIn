using System.Collections.Generic;
using Models;

namespace Assignment1HandIn.Data
{
    public interface IAdultService
    {
        public IList<Adult> GetAdults();
        public void AddAdult(Adult adult);
        public void Remove(Adult adult);
    }
}