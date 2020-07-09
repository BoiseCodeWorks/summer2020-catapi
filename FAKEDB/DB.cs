using System.Collections.Generic;
using catapi.Models;

namespace catapi.FAKEDB
{
    public static class FakeDb
    {
        public static List<Cat> Cats { get; set; } = new List<Cat>(){
            new Cat("Mr. Snibbley", 102, 3),
            new Cat("Wiskers", 2, 9),
            new Cat("Lucky", 1, 1)
        };
    }
}