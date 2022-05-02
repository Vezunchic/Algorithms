using BenchmarkDotNet.Attributes;
using System.Collections.Generic;


namespace DistanceCalculation
{
    [JsonExporterAttribute.Full]
    public class BechmarkClass
    {

        private readonly List<PointStruct> pointArrayStruct;
        private readonly List<PointClass> pointArray;


        public BechmarkClass()
        {
            pointArrayStruct = new List<PointStruct>();
            pointArray = new List<PointClass>();
            int quantity = 1000;

            for (int i = 0; i < quantity; i++)
            {
                pointArray.Add(new PointClass { _x = i, _y = i });
                pointArrayStruct.Add(new PointStruct { _x = i, _y = i });
            }
        }


        [Benchmark]
        public void DistanceCalculationClassFloat()
        {
            for (int i = 0; i < pointArray.Count - 1; i++)
            {
                var result = PointClass.PointDistance(pointArray[i], pointArray[i + 1]);
            }

        }
        [Benchmark]
        public void DistanceCalculationStructFloat()
        {
            for (int i = 0; i < pointArrayStruct.Count - 1; i++)
            {
                var result = PointStruct.PointDistance(pointArrayStruct[i], pointArrayStruct[i + 1]);
            }

        }
        [Benchmark]
        public void DistanceCalculationStructDouble()
        {
            for (int i = 0; i < pointArrayStruct.Count - 1; i++)
            {
                var result = PointStruct.PointDistanceDouble(pointArrayStruct[i], pointArrayStruct[i + 1]);
            }
        }
        [Benchmark]
        public void DistanceCalculationStructShort()
        {
            for (int i = 0; i < pointArrayStruct.Count - 1; i++)
            {
                var result = PointStruct.PointDistanceShort(pointArrayStruct[i], pointArrayStruct[i + 1]);
            }
        }

    }
}
