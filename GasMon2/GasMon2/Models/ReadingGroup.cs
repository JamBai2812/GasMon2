using System;
using System.Collections.Generic;

namespace GasMon.Models
{
    public class ReadingGroup
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime => StartTime.AddMinutes(1);
        public List<ReadingFromSensor> Readings { get; set; }
        public double AverageReading { get; set; }
        
        
        
        
        
        public double GetAverage()
        {
            var avg = 0;

            return avg;
        }


        public void Add(ReadingFromSensor reading)
        {
            Readings.Add(reading);    
        }
        
    }
}