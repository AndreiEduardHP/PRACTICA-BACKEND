using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HONEV
{
    public class Enums
    {
        public enum UserSortType
        {
            FirstNameAscendent,     //0
            FirstNameDescendent,    //1
            LastNameAscendent,      //2
            LastNameDescendent,     //3
        }

        public enum ProductSortType
        {
            PriceAscendent,
            PriceDescendent,
            NameAscendent,
            NameDescendent,
        }
    }
}
