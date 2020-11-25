using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticCode
{
    internal class GeneticCode
    {
        private readonly Random _rnd = new Random();

        public IList<double> XValues { get; set; }
        public IList<double> YValues { get; set; }

        public List<int> FindIndexTenBestParents(IEnumerable<GeneticStruct> parents)
        {
            var functionValuesOfParents = parents.Select(x =>
                XValues.Select((r, j) => Math.Pow(YValues[j] - (x.A * r * r + x.B * r + x.C), 2)).Sum()).ToList();
            
            var indexes = functionValuesOfParents
                .Select((value, index) => new {value, index})
                .OrderBy(x => x.value)
                .Take(10)
                .Select(x => x.index)
                .ToList();

            return indexes;
        }

        public List<GeneticStruct> RemoveBestTenParents(List<GeneticStruct> parents, ICollection<int> indexes)
        {
            for (var i = 0; i < parents.Count; i++)
            {
                if (indexes.Contains(i))
                {
                    parents.RemoveAt(i);
                }
            }

            return parents;
        }

        public byte GetRandomByte()
        {
            return (byte) _rnd.Next(0, 255);
        }

        public List<GeneticStruct> GenerateChildren(IReadOnlyList<GeneticStruct> parents)
        {
            var result = new List<GeneticStruct>();
            foreach (var _ in parents)
            {
                var male = parents[_rnd.Next(0, 45)];
                var female = parents[_rnd.Next(46, 90)];
                result.Add(HybridizationAndMutation(male, female));
            }

            return result;
        }

        public GeneticStruct HybridizationAndMutation(GeneticStruct male, GeneticStruct female)
        {
            var result = new GeneticStruct
            {
                A = (byte) (~male.A & female.A),
                B = (byte) (male.B & ~female.B),
                C = (byte) (male.C & female.C)
            };

            return result;
        }

        public List<GeneticStruct> GenerateParentPersons()
        {
            var parents = new List<GeneticStruct>();

            for (var i = 0; i < 100; i++)
            {
                var parent = new GeneticStruct
                {
                    A = GetRandomByte(),
                    B = GetRandomByte(),
                    C = GetRandomByte()
                };

                parents.Add(parent);
            }

            return parents;
        }

        public struct GeneticStruct
        {
            public byte A, B, C;
        }
    }
}
