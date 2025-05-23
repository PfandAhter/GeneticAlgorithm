﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Mutation
{
    
    public interface IMutation
    {
        Individual mutate(Individual individual, double mutationRate);
    }
}