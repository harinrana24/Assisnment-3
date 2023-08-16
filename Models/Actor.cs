

namespace MovieMVC.Models
{

       
        public class Actor
        {

            public Actor()
            {
                Name = "Unknown";
                // Assign other default values here
            }
       
            public int Id { get; set; }
            public string Name { get; set; }

            public int Age { get; set; }
        }
    }



