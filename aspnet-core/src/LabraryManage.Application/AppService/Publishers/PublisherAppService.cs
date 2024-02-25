using Abp.Domain.Repositories;
using LabraryManage.AppService.Publishers.Dto;
using LabraryManage.Entities.Publishers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabraryManage.AppService.Publishers
{
    public class PublisherAppService : LabraryManageAppServiceBase
    {
        private readonly IRepository<Publisher, Guid> _publisherRepository;
        public PublisherAppService(IRepository<Publisher, Guid> publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        //Get All
        [HttpGet]
        public async Task<List<GetPublisherDto>> GetAllPublisher()
        {
            var item = await _publisherRepository
                .GetAll()
                .Select(x => new GetPublisherDto
                {
                    Name = x.Name,
                    Phone = x.Phone,
                    Email = x.Email,
                    Address = x.Address
                })
                .ToListAsync();
            return item;
        }
        //Get Id
        [HttpGet]
        public async Task<Publisher> GetPublisherById(Guid Id)
        {
            return await _publisherRepository.GetAsync(Id);
        }
        //Insert 
        [HttpPost]
        public async Task AddPublisher(AddPublisherDto input)
        {
            var item = new Publisher
            {
                Name = input.Name,
                Phone = input.Phone,
                Email = input.Email,
                Address = input.Address
            };
            await _publisherRepository.InsertAsync(item);
            
        }

        //Update
        [HttpPut]
        public async Task UpdatePublisher(AddPublisherDto input)
        {
            var item = await GetPublisherById(input.Id);
            item.Name = input.Name;
            item.Phone = input.Phone;
            item.Email = input.Email;
            item.Address = input.Address;
            await _publisherRepository.UpdateAsync(item);
        }

        //Delete
        [HttpDelete]
        public async Task DeletePublisher(AddPublisherDto input)
        {
            var item = await GetPublisherById(input.Id);
            await _publisherRepository.DeleteAsync(item);
        }

    }
}
