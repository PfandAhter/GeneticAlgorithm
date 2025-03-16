using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm.Tests.Crossover
{
    [TestClass]
    public class BasicCrossoverTest
    {
        [TestMethod]
        public void Individual_DefaultConstructor_ShouldInitializeGenes()
        {
            // Arrange & Act
            Individual individual = new Individual();

            // Assert
            Assert.IsNotNull(individual.genes);
            Assert.IsNotNull(individual.x1Gens);
            Assert.IsNotNull(individual.x2Gens);
            Assert.IsTrue(individual.genes.Length > 0);
            Assert.IsTrue(individual.x1Gens.Length > 0);
            Assert.IsTrue(individual.x2Gens.Length > 0);
        }

        [TestMethod]
        public void Individual_GenesConstructor_ShouldCopyGenes()
        {
            // Arrange
            bool[] genes = { true, false, true, false, true };

            // Act
            Individual individual = new Individual(genes);

            // Assert
            Assert.AreEqual(genes.Length, individual.genes.Length);
            for (int i = 0; i < genes.Length; i++)
            {
                Assert.AreEqual(genes[i], individual.genes[i]);
            }
        }

        /*[TestMethod]
        public void Individual_SetX1AndX2Gens_ShouldSeparateGenesCorrectly()
        {
            // Arrange
            bool[] genes = { true, false, true, false, true, false, true, false };
            Individual individual = new Individual(genes);

            // Act
            individual.setX1AndX2Gens();

            // Assert
            Assert.IsNotNull(individual.x1Gens);
            Assert.IsNotNull(individual.x2Gens);
            Assert.IsTrue(individual.x1Gens.Length > 0);
            Assert.IsTrue(individual.x2Gens.Length > 0);
        }*/

        [TestMethod]
        public void Individual_CompareTo_ShouldReturnCorrectComparison()
        {
            // Arrange
            bool[] genes1 = { true, false, true, false, true };
            bool[] genes2 = { false, true, false, true, false };
            Individual individual1 = new Individual(genes1);
            Individual individual2 = new Individual(genes2);

            // Act
            int comparisonResult = individual1.CompareTo(individual2);

            // Assert
            Assert.AreEqual(individual1.fitnessValue.CompareTo(individual2.fitnessValue), comparisonResult);
        }
    }
}