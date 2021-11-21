using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        public String JokeQuestion { get; set; }
        public int JokeAnswer { get; set; }

        public Jokes()
        {

        }
    }
}
