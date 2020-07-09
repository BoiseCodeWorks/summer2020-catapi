using System;
using System.Collections.Generic;
using catapi.FAKEDB;
using catapi.Models;

namespace catapi.Services
{
    public class CatService
    {
        internal IEnumerable<Cat> Get()
        {
            return FakeDb.Cats;
        }

        internal Cat GetById(string id)
        {
            var found = FakeDb.Cats.Find(cat => cat.Id == id);
            if (found == null) { throw new Exception("Bad Id Muchacho"); }
            return found;
        }
        internal Cat Create(Cat newCat)
        {
            FakeDb.Cats.Add(newCat);
            return newCat;
        }
        internal Cat Edit(Cat editCat, string id)
        {
            var original = FakeDb.Cats.Find(cat => cat.Id == id);
            if (original == null) { throw new Exception("Bad Id Muchacho"); }
            editCat.Id = original.Id;
            editCat.Name = editCat.Name != null ? editCat.Name : original.Name;
            FakeDb.Cats.Remove(original);
            FakeDb.Cats.Add(editCat);
            return editCat;
        }

        internal Cat Delete(string catId)
        {
            var found = FakeDb.Cats.Find(cat => cat.Id == catId);
            if (found == null) { throw new Exception("Bad Id Muchacho"); }
            FakeDb.Cats.Remove(found);
            return found;
        }


    }
}