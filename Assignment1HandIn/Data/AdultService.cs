using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;
using Models;

namespace Assignment1HandIn.Data
{
    public class AdultService : IAdultService
    {
        private IFileContext context;
        private IList<Adult> adults;

        public AdultService()
        {
            context = new FileContext();
            //Opgaven nævnte godt nok intefaces, men var det også
            //ment at FileContext skal have et interface, eller
            //måtte den forblive "ikke løs" koblet?
            adults = ((FileContext)context).Adults;
        }


        public IList<Adult> GetAdults()
        {
            var tmp = new List<Adult>(adults);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
            int max = adults.Max(a => a.Id);
            adult.Id = ++max;
            adults.Add(adult);
            context.SaveChanges();
        }

        public void Remove(Adult adult)
        {
            adults.Remove(adult);
            context.SaveChanges();
        }
    }
}