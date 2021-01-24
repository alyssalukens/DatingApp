
using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Game
    {
        public int Id {get; set;}

        public string Title {get; set;}

        public string Description {get; set;}

        public string TeamPictureUrl {get; set;}

        public string GameFileUrl {get; set;}

        public DateTime DateUploaded {get; set;}

        public virtual ICollection<GameUser> TeamMembers {get; set;}

        public virtual ICollection<GameImage> GameImages {get; set;}
        
        public virtual ICollection<GameTag> Tags {get; set;}
        
    }
}