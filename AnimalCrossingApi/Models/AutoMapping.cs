using System;
using AnimalCrossing.Models.ViewModels;
using AutoMapper;

namespace AnimalCrossingApi.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Cat, CatVM>();    
        }
    }
}
