using System.Collections.Generic;

namespace animalcontrol_webapi.Models
{
    public class Owner
    {
        public Owner()
        {
            
        }

        public Owner(int id, string name, string address, string schedule)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Schedule = schedule;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Schedule { get; set; }
        public IEnumerable<LearningTopic> LearningTopic {get; set;}
    }
}