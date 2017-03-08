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
            //Domain Dto
            //Maps based on their variables names
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            //Dto do domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}