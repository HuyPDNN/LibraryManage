using Abp.Domain.Repositories;
using LabraryManage.AppService.Authors.Dto;
using LabraryManage.Entities.Authors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabraryManage.AppService.Authors
{
    public class AuthorAppService : LabraryManageAppServiceBase
    {
        private readonly IRepository<Author, Guid> _authorRepository;
        public AuthorAppService(IRepository<Author, Guid> authorRepository)
        {
            _authorRepository = authorRepository;
        }
        //Get ALL
        [HttpGet]
        public async Task<List<GetAuthorDto>> GetAllAthor()
        {
            var item = await _authorRepository
                .GetAll()
                .Select(x => new GetAuthorDto
                {
                    Name = x.Name,
                    Phone = x.Phone,
                    YearOfBirth = x.YearOfBirth,
                    Address = x.Address
                })
                .ToListAsync();
            return item;

        }
        [HttpGet]
        //Get Id
        public async Task<Author> GetAuthorById(Guid Id)
        {
            return await _authorRepository.GetAsync(Id);
        }
        //Insert 
        [HttpPost]
        public async Task AddAuthor(AddAuthorDto input)
        {
            var item = new Author
            {
                Name = input.Name,
                Phone = input.Phone,
                YearOfBirth = input.YearOfBirth,
                Address = input.Address

            };
            await _authorRepository.InsertAsync(item);           
        }

        //Update
        [HttpPut]
        public async Task UpdateAuthor(AddAuthorDto input)
        {
            var item = await GetAuthorById(input.Id);
            item.Name = input.Name;
            item.Phone = input.Name;
            item.YearOfBirth = input.YearOfBirth;
            item.Address = input.Address;

            await _authorRepository.UpdateAsync(item);
        }

        //Delete
        [HttpDelete]
        public async Task DeleteAuthor(DeleteAuthorDto input)
        {
            var item = await GetAuthorById(input.Id);
            await _authorRepository.DeleteAsync(item);
        }
    }
}
