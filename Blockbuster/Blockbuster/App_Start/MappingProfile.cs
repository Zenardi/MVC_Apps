using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Blockbuster.Dtos;
using Blockbuster.Models;

namespace Blockbuster.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Maps based on their variables names
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

        }
    }
}