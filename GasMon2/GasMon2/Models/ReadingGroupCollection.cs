using System.Collections;
using System.Collections.Generic;

namespace GasMon.Models
{
    public class ReadingGroupCollection
    {
        public Queue<ReadingGroup> Groups { get; set; }


        public ReadingGroupCollection()
        {
            
        }

        public void AddGroup(ReadingGroup group)
        {
            Groups.Enqueue(group);          
        }


        public void DeleteGroupAtStartOfQueue(ReadingGroup group)
        {
            Groups.Dequeue();
        }


    }
}