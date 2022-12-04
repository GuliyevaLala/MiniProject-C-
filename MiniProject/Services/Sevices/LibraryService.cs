using Domain.Entities;
using RepositoryLayer.Repositories;
using ServiceLayer.Sevices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Sevices
{
    public class LibraryService : ILibraryService
    {
        private readonly LibraryRepository _repo;
        private int _count;
        public LibraryService()
        {
            _repo= new LibraryRepository();
        }

        public Library Create(Library library)
        {
            library.Id = _count;
            _repo.Add(library);
            _count++;
            return library; 
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Library GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Library Update(int id, Library library)
        {
            throw new NotImplementedException();
        }
    }
}
