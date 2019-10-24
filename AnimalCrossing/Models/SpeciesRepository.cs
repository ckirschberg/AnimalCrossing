using System;
using System.Collections.Generic;
using AnimalCrossing.Data;
using Microsoft.EntityFrameworkCore;

namespace AnimalCrossing.Models
{
    public class SpeciesRepository : ISpeciesRepository
    {
        AnimalCrossingContext context =
            new AnimalCrossingContext(new DbContextOptions<AnimalCrossingContext>());

        public SpeciesRepository()
        {
        }

        public void Delete(int speciesId)
        {
            throw new NotImplementedException();
        }

        public List<Species> Get()
        {
            throw new NotImplementedException();
        }

        public Species Get(int speciesId)
        {
            throw new NotImplementedException();
        }

        public void Save(Species s)
        {
            throw new NotImplementedException();
        }
    }
}
